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

                foreach (var cls in outClasses)
                {
                    File.WriteAllText(@".\Output\" + cls.Name + ".cs", cls.GetOutput());
                }

                Console.WriteLine();
            }
            

            

        }

        static List<MockClass> GetClasses(List<HighChartDocItem> items)
        {
            List<MockClass> classes = new List<MockClass>();
            foreach (var cls in items.Where(i=>i.IsTopMostClass))
            {
                var mockClass = new MockClass(cls);

                // Find Properties
                mockClass.Properties = items.Where(i => i.parent == cls.name && i.isParent == false)
                    .Select(i => new MockProperty(i))
                    .ToList();

                // Find Sub Classes
                mockClass.SubClasses = items.Where(i => i.isParent == true && i.parent == cls.name)
                    .Select(i => new MockClass(i))
                    .ToList();

                classes.Add(mockClass);
            }
            return classes;
        }
    }


    public class MockClass
    {

        public MockClass(HighChartDocItem item)
        {

            if (item.title.Contains("series<"))
            {
                item.title = item.title.Replace("series<", "").Replace(">", "");
            }

            this.Name = item.title.ToCamelCase();
            this.JavascriptName = item.name;
            this.Description = string.IsNullOrEmpty(item.description) ? "" : Regex.Replace(item.description, @"<(.|n)*?>", string.Empty).Replace("&nbsp", "");

            this.IsTopMost = item.IsTopMostClass;

            this.Properties = new List<MockProperty>();
            this.SubClasses = new List<MockClass>();

            
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
            var subClasses = string.Join("\r", this.SubClasses.Select(p => p.GetOutput()));

            var configProperty = Templates.ConfigPropertyTemplate.Replace("#CONFIGS#", configOptions);

            var output = Templates.ClassTemplate
                .Replace("#DESCRIPTION#", Regex.Replace(this.Description, @"\r\n?|\n", ""))
                .Replace("#NAME#", this.Name)
                .Replace("#PROPERTIES#", properties)
                .Replace("#CLASSES#", subClasses)
                .Replace("#CONFIGOPTIONS#", configProperty);

            if (this.IsTopMost)
                output = Templates.NameSpaceTemplate.Replace("#CLASSBODY#", output);
            
            return output;
        }

    }

    public class MockProperty
    {

        public MockProperty(HighChartDocItem item)
        {
            this.Name = item.title.ToCamelCase();
            this.JavascriptName = item.title;
            this.Type = item.returnType.ToDotNetType();
            this.Description = Regex.Replace(item.description, @"<(.|n)*?>", string.Empty).Replace("&nbsp", "");

            this.DefaultValue = item.defaults.FormatValue(this.Type);
        }

        public string Name { get; set; }
        public string JavascriptName { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public string DefaultValue { get; set; }

        public string GetOutput()
        {
            return Templates.PropertyTemplate
                .Replace("#DESCRIPTION#", Regex.Replace(this.Description, @"\r\n?|\n", "").Replace("\"", @""""""))
                .Replace("#DEFAULTVALUE#", this.DefaultValue)
                .Replace("#TYPE#", this.Type)
                .Replace("#NAME#", this.Name);
        }

        public string GetConfigItem()
        {
            return Templates.ConfigOptionTemplate
                .Replace("#JSNAME#", this.JavascriptName)
                .Replace("#NAME#", this.Name)
                .Replace("#DEFAULTVALUE#", this.DefaultValue);

        }
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

    }
}
