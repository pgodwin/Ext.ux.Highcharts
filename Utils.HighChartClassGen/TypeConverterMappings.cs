using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Utils.HighChartClassGen
{
    public static class TypeConverterMappings
    {
        //#TYPECONVERTER#

        public static Dictionary<string, string> TypeConverters = new Dictionary<string, string>()
        {
            { "string[]", "StringArrayConverter"}
        };

        public static string GetTypeConverter(string typeName)
        {
            
            if (TypeConverters.ContainsKey(typeName))
            {
                var converterName = TypeConverters[typeName];
                return string.Format("[TypeConverter(typeof({0}))]", converterName);
            }
            return string.Empty;

        }


    }
}
