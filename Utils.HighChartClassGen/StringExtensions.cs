using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.HighChartClassGen
{
    public static class StringExtensions
    {

        public static string ToDotNetType(this string value)
        {
            
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

        public static string ToCamelCase(this string value)
        {
            if (value == null || value.Length < 2)
                return value;

            return value.Substring(0, 1).ToUpperInvariant() + value.Substring(1);
        }


        public static string FormatValue(this string value, string dotNetType)
        {
            if (dotNetType == "string" && string.IsNullOrEmpty(value))
                return "\"\"";
            
            if (string.IsNullOrEmpty(value))
                return "null";

            if (value == "undefined")
                return "null";

            if (value.StartsWith("["))
                // Array
                return "new " + dotNetType + " { " + value.Replace("[", "").Replace("]", "") + "}";

            if (dotNetType == "object")
                return "null";
            
            if (dotNetType == "string")
                //{"fontFamily":"\"Lucida Grande\", \"Lucida Sans Unicode\", Verdana, Arial, Helvetica, sans-serif","fontSize":"12px"}
                return "@\"" + value.Replace(@"\""", "'").Replace("\"", @"""""") + "\"";
          
            
            
            return value;
        }
    }
}
