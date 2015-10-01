using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.HighChartClassGen
{
    public class Templates
    {
        public const string NameSpaceTemplate = @"
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Serialization;
using Ext.Net;
using Ext.Net.Utilities;
using Newtonsoft.Json;

namespace Ext.ux.Highcharts.Chart
{
        
#CLASSBODY#
        
}
            ";
        public const string ClassTemplate = @"

        /// <summary>
        /// #DESCRIPTION#
        /// </summary>
        public partial class #NAME# : Observable
        {

    #PROPERTIES#

    #CONFIGOPTIONS#

    #CLASSES#

        }
";

        public const string PropertyTemplate = @"
            /// <summary>
            /// #DESCRIPTION#
            /// </summary>
            [ConfigOption]
            [DefaultValue(#DEFAULTVALUE#)]
            [NotifyParentProperty(true)]
            [Category(""HighChart"")]
            [Description(@""#DESCRIPTION#"")]
            public #TYPE# #NAME#
            {
                get
                {
                    return this.State.Get<#TYPE#>(""#NAME#"", #DEFAULTVALUE#);
                }
                set
                {
                    this.State.Set(""#NAME#"", value);
                }
            }
";

        public const string ConfigOptionTemplate = @"
                list.Add(""#JSNAME#"", new ConfigOption(""#JSNAME#"", null, #DEFAULTVALUE#, this.#NAME#));
";

        public const string ConfigPropertyTemplate = @"
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;

#CONFIGS#
                return list;
            }
        }
";

    }
}
