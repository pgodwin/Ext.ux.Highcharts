using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Utils.HighChartClassGen
{

    public static class Shared
    {
        public static List<MockClass> SharedClasses = new List<MockClass>();
    }

    class Program
    {

       
        static void Main(string[] args)
        {

            string filename = "dump.json";
            using (StreamReader file = File.OpenText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                var items = serializer.Deserialize(file, typeof (List<HighChartDocItem>)) as List<HighChartDocItem>;



                var outClasses = GetClasses(items);

                // For each sub-class in our shared classes, create a new version with the distinct classes and and properties
                var distinctClasses = Shared.SharedClasses.ToLookup(c => c.Name);
                var sharedClasses = new List<MockClass>();
                foreach (var classesByName in distinctClasses)
                {
                    if (outClasses.Any(c => c.Name == classesByName.Key))
                        continue;
                    // Grab the properties, etc of each class and combine them into one...
                    var listeners = classesByName.SelectMany(c => c.Listeners).ToLookup(l => l.Name).Select(l => l.FirstOrDefault());
                    var properties = classesByName.SelectMany(c => c.Properties)
                            .ToLookup(l => l.Name)
                            .Select(l => l.FirstOrDefault());

                    var firstClass = classesByName.First();
                    firstClass.Properties = properties.ToList();
                    firstClass.Listeners = listeners.ToList();

                    sharedClasses.Add(firstClass);
                }

                outClasses.AddRange(sharedClasses);

                foreach (var cls in outClasses)
                {
                    string path = @".\Output\";
                    if (!string.IsNullOrEmpty(cls.NameSpace))
                    {
                        path = path + Path.DirectorySeparatorChar + cls.NameSpace;
                    }

                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    File.WriteAllText(path + Path.DirectorySeparatorChar + cls.Name + ".cs", cls.GetOutput());
                }


                

                Console.WriteLine();
            }
            

            

        }

        static List<MockClass> GetClasses(List<HighChartDocItem> items)
        {
            List<MockClass> classes = new List<MockClass>();
            foreach (var cls in items.Where(i=>i.IsTopMostClass))
            {
                var mockClass = new MockClass(cls, items);


                classes.Add(mockClass);
            }
            return classes;
        }

    }


    public class MockClass
    {
        public override string ToString()
        {
            return this.JavascriptName;
        }
        public MockClass(HighChartDocItem item, List<HighChartDocItem> items)
        {
            var parent = items.FirstOrDefault(i => i.name == item.parent);

            this.SubType = "Observable";
            bool isSeries = false;
            bool isPlotOptions = item.parent == "plotOptions";

            if (item.title.Contains("series<"))
            {
                isSeries = true;
                var title = item.title.Replace("series<", "").Replace(">", "");
                item.title = title;
                //this.SubType = "Series";
                this.SubType = SeriesBaseTypeMappings.GetMappingForSeries(title);
                this.NameSpace = "Series";
            }
            if (item.title == "series")
                this.NameSpace = "Series";

            // Remove plural 's' off the end of item names
            //if (parent != null && parent.returnType != null && parent.returnType.Contains("array") && parent.name.EndsWith("s"))
              //  item.title = item.title.TrimEnd(new[] {'s'});

            if (isSeries)
                this.Name  = item.title.ToCamelCase() + "Series";
            else if (isPlotOptions)
                this.Name = item.title.ToCamelCase() + "PlotOptions";
            else
                this.Name = item.title.ToCamelCase();
            this.JavascriptName = item.title;
            this.Description = string.IsNullOrEmpty(item.description) ? "" : Regex.Replace(item.description, @"<(.|n)*?>", string.Empty).Replace("&nbsp", "");

            this.IsTopMost = item.IsTopMostClass;

            // Find Properties
            this.Properties = items.Where(i => i.parent == item.name && i.isParent == false)
                .Select(i => new MockProperty(i))
                .ToList();

            // Find sub classes
            this.SubClasses = items.Where(i => i.isParent == true && i.parent == item.name && i.title != "events") 
                    .Select(i => new MockClass(i, items))
                    .ToList();

            Shared.SharedClasses.AddRange(this.SubClasses);

            var subClassProperties =
                items.Where(i => i.isParent == true && i.parent == item.name && i.title != "events")
                .Select(i => new MockPropertyForClass(i, this.Name == "PlotOptions" ? "PlotOptions" : ""))
                    .ToList();

            this.Properties.AddRange(subClassProperties);

            var eventsItem = items.FirstOrDefault(i => i.isParent == true && i.parent == item.name && i.title == "events");
            if (eventsItem != null)
                this.Listeners = items.Where(i => i.parent == eventsItem.name)
                        .Select(i => new MockEvent(i, items))
                        .ToList();
            else
                this.Listeners = new List<MockEvent>();

            //this.Properties = new List<MockProperty>();
            //this.SubClasses = new List<MockClass>();

            
        }

        public string Name { get; set; }

        public string JavascriptName { get; set; }

        
        public string Description { get; set; }

        public List<MockProperty> Properties { get; set; }

        //public List<MockMethod> Methods { get; set; }

        public bool IsTopMost { get; set; }

        public List<MockClass> SubClasses { get; set; }

        public string GetOutput()
        {
            var properties = string.Join("\r", this.Properties.Select(p => p.GetOutput()));
            var configOptions = string.Join("\r", this.Properties.Select(p => p.GetConfigItem()));

            if (this.Listeners.Count > 0)
                configOptions += "list.Add(\"events\", new ConfigOption(\"events\", new SerializationOptions(\"events\", JsonMode.Object), null, this.Listeners));";

            var subClasses = string.Join("\r", this.SubClasses.Select(p => p.GetOutput()));
            
            var configProperty = Templates.ConfigPropertyTemplate.Replace("#CONFIGS#", configOptions);

            var listenerProperty = Templates.ListenerPropertyTemplate
                                    .Replace("#NAME#", this.Name);


            var listeners = string.Join("\r", this.Listeners.Select(s=>s.GetOutput()));
            var listenerConfigs = string.Join("\r", this.Listeners.Select(s => s.GetConfigItem()));
            var listenerClass = Templates.ListenerClassTemplate
                                    .Replace("#DESCRIPTION", "Client Side Events")
                                    .Replace("#NAME#", this.Name)
                                    .Replace("#LISTENERCONFIGS#", listenerConfigs)
                                    .Replace("#LISTENERS#", listeners);

            

            

            var output = Templates.ClassTemplate
                .Replace("#DESCRIPTION#", Regex.Replace(this.Description, @"\r\n?|\n", ""))
                .Replace("#NAME#", this.Name)
                .Replace("#SUBTYPE#", this.SubType)
                .Replace("#PROPERTIES#", properties)
                //.Replace("#CLASSES#", subClasses)
                .Replace("#CLASSES#", "")
                .Replace("#LISTENERCONFIG#", listenerProperty)
                .Replace("#CONFIGOPTIONS#", configProperty)
                .Replace("#LISTENERCLASS#", listenerClass);

            //if (this.IsTopMost)
                output = Templates.NameSpaceTemplate
                    .Replace("#SUBNAMESPACE#", string.IsNullOrEmpty(this.NameSpace) ? "" : this.NameSpace)
                    .Replace("#CLASSBODY#", output);
            
            return output;
        }


        public string SubType { get; set; }

        public string NameSpace { get; set; }

        public List<MockEvent> Listeners { get; set; }
    }

    public class MockProperty
    {
        public MockProperty()
        {
            
        }

        public MockProperty(HighChartDocItem item)
        {
            this.OriginalItem = item;
            this.Name = item.title.ToCamelCase();
            this.JavascriptName = item.title;
            this.Type = item.returnType.ToDotNetType();
            if (item.description != null)
                this.Description = Regex.Replace(item.description, @"<(.|n)*?>", string.Empty).Replace("&nbsp", "");
            else
                this.Description = string.Empty;

            this.DefaultValue = item.defaults.FormatValue(this.Type);
        }

        public string Name { get; set; }
        public string JavascriptName { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public string DefaultValue { get; set; }

        public virtual string GetOutput()
        {
            return Templates.PropertyTemplate
                .Replace("#DESCRIPTION#", Regex.Replace(this.Description, @"\r\n?|\n", "").Replace("\"", @""""""))
                .Replace("#DEFAULTVALUE#", this.DefaultValue)
                .Replace("#SERIALISER#", this.OriginalItem.GetAttributeSerialisationOptions())
                .Replace("#JSNAME#", this.JavascriptName)
                .Replace("#TYPE#", this.Type)
                .Replace("#NAME#", this.Name);
        }

        public virtual string GetConfigItem()
        {
            return Templates.ConfigOptionTemplate
                .Replace("#JSNAME#", this.JavascriptName)
                .Replace("#NAME#", this.Name)
                .Replace("#SERIALISER#", this.OriginalItem.GetSerialisationOptions())
                .Replace("#DEFAULTVALUE#", this.DefaultValue);

        }

        public HighChartDocItem OriginalItem { get; set; }
    }


    public class MockPropertyForClass : MockProperty
    {

        public MockPropertyForClass(HighChartDocItem item, string nameToAppend) : base(item)
        {
            this.OriginalItem = item;
            this.Name = item.title.ToCamelCase();
            this.JavascriptName = item.title;


            if (item.returnType == "Array<Object>")
            {
                this.IsArray = true;
                this.Type = "ItemsCollection<" + item.title.ToCamelCase() + nameToAppend + ">";
            }
            else
            {
                this.IsArray = false;
                this.Type = item.title.ToCamelCase() + nameToAppend;
            }

            if (item.description != null)
                this.Description = Regex.Replace(item.description, @"<(.|n)*?>", string.Empty).Replace("&nbsp", "");

            //this.DefaultValue = "new " + item.title.ToCamelCase() + "();";
            this.DefaultValue = "null;";


            
            
        }

        public bool IsArray { get; set; }

        public override string GetOutput()
        {
            string template = this.IsArray ? Templates.ControlArrayPropertyTemplate : Templates.ControlPropertyTemplate;

            return template
              .Replace("#DESCRIPTION#", Regex.Replace(this.Description, @"\r\n?|\n", "").Replace("\"", @""""""))
              .Replace("#DEFAULTVALUE#", this.DefaultValue)
              .Replace("#JSNAME#", this.JavascriptName)
              .Replace("#TYPE#", this.Type)
              .Replace("#NAME#", this.Name);
        }

        public override string GetConfigItem()
        {
            string template = this.IsArray ? Templates.ControlArrayConfigOptionTemplate : Templates.ControlConfigOptionTemplate;

            return template
               .Replace("#JSNAME#", this.JavascriptName)
               .Replace("#NAME#", this.Name)
               .Replace("#DEFAULTVALUE#", this.DefaultValue);
        }

    }

    public class MockEvent     
    {
        public MockEvent(HighChartDocItem item, List<HighChartDocItem> items)
        {
            
            if (item.parent.StartsWith("series"))
                this.NameSpace = "Series";

            this.Name = item.title.ToCamelCase();
            this.JavascriptName = item.title;
            this.Description = string.IsNullOrEmpty(item.description) ? "" : Regex.Replace(item.description, @"<(.|n)*?>", string.Empty).Replace("&nbsp", "");

            this.Parent = items.FirstOrDefault(i=>i.parent == item.name);

            this.Arguments = new List<Argument>() {
                new Argument(0, "event") // almost all have a jquery event item
            };
        }

        public  string Description { get; set; }
        public  string JavascriptName { get; set; }
        public  string NameSpace { get; set; }
        public  string Name { get; set; }

        public List<Argument> Arguments { get; set; }

        public string GetOutput()
        {
            var arguments = string.Join("\r", this.Arguments.Select(a => a.GetOutput()));

            var output = Templates.ListenerItem
                            .Replace("#JAVASCRIPTNAME#", this.JavascriptName)
                            .Replace("#NAME#", this.Name)
                            .Replace("#DESCRIPTION#", Regex.Replace(this.Description, @"\r\n?|\n", "").Replace("\"", @""""""))
                            .Replace("#ARGS#", arguments);

            return output;
        }

        public string GetConfigItem()
        {
            return Templates.ListenerConfigItem
                .Replace("#JSNAME#", this.JavascriptName)
                .Replace("#NAME#", this.Name);

        }

        public class Argument
        {
            public Argument(int index, string name)
            {
                this.Index = index;
                this.Name = name;
            }
        
            public string Name { get; set; }
            public int Index { get; set; }

            public string GetOutput()
            {
                return "[ListenerArgument(" + this.Index + ", \"" + this.Name + "\")]";
            }
        }



        public HighChartDocItem Parent { get; set; }
    }



    public class HighChartDocItem
    {
        public string name { get; set; }

        public string fullname { get; set; }

        public string title { get; set; }

        public string parent { get; set; }

        public bool isParent { get; set; }

        public string returnType { get; set; }

        public string defaults { get; set; }

        public string description { get; set; }

        public bool depcreated { get; set; }


        public string context { get; set; }

        public string since { get; set; }

        public string values { get; set; }

        public string seeAlso { get; set; }

        public bool IsClass
        {
            get { return isParent; }
        }

        public bool IsTopMostClass
        {
            get { return isParent && string.IsNullOrEmpty(this.parent); }
        }


        /// <summary>
        /// Attemps to get the .NET type from the current item.
        /// </summary>
        /// <returns></returns>
        public string GetDotNetType()
        {
            var value = this.returnType;

            // Handle multiple return types
            if (value != null && value.Contains("|") && !value.StartsWith("Array"))
                return "object";
            switch (value)
            {
                case null:
                case "":
                case "null":
                case "Color":
                case "String":
                    return "string";

                case "Mixed":
                case "Object":
                    return "object";

                case "Number":
                    return "double?";

                case "Boolean":
                    return "bool?";
                case "Array<Object|Array>":
                case "Array<Object|Array|Number>":
                case "Array<Object|Number>":
                case "Array<String|Number>":
                case "Array<Object>":
                    return "object[]";

                case "Array<Color>":
                case "Array<String>":
                    return "string[]";

                case "Array<Number>":
                    return "double[]";

                case "Array<Array<Mixed>>":
                    return "object[,]";

                case "plotOptions.series.states":
                    return "PlotOptions.Series.States";
                default:
                    return "string";
            }
            
        }

        public string GetSerialisationOptions()
        {
            if (this.returnType.Contains("Array"))
            {
                return "new SerializationOptions(\"" + this.title + "\", JsonMode.AlwaysArray)";
            }

            return "null";
        }

        public string GetAttributeSerialisationOptions()
        {
             if (this.returnType.Contains("Array"))
            {
                return "JsonMode.AlwaysArray";
            }

            return "null";
        }

    }
}
