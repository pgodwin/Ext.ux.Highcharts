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

namespace Ext.ux.Highcharts.Chart#SUBNAMESPACE#
{
        
#CLASSBODY#
        
}
            ";
        public const string ClassTemplate = @"

        /// <summary>
        /// #DESCRIPTION#
        /// </summary>
        public partial class #NAME# : #SUBTYPE#
        {

    #PROPERTIES#

    #CONFIGOPTIONS#

    #LISTENERCONFIG#

    #CLASSES#

    #LISTENERCLASS#

        }
";

        public const string PropertyTemplate = @"
            /// <summary>
            /// #DESCRIPTION#
            /// </summary>
            [ConfigOption(""#JSNAME#"", #SERIALISER#)]
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



        public const string ControlPropertyTemplate = @"
        private #TYPE# _#NAME#;
        [Meta]
        [DefaultValue(null)]
        [Category(""HighCharts"")]
        [ConfigOption(""#JSNAME#"", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@""#DESCRIPTION#"")]
        public virtual #TYPE# #NAME#
        {
            get
            {
                return this._#NAME#;
            }
            set
            {
                if (this._#NAME# != null)
                {
                    this.Controls.Remove(this._#NAME#);
                    this.LazyItems.Remove(this._#NAME#);
                }

                this._#NAME# = value;

                if (this._#NAME# != null)
                {
                    this.LazyItems.Add(this._#NAME#);
                    this.Controls.Add(this._#NAME#);
                }
            }
        }";


        public const string ConfigOptionTemplate = @"
                list.Add(""#JSNAME#"", new ConfigOption(""#JSNAME#"", #SERIALISER#, #DEFAULTVALUE#, this.#NAME#));
";


        public const string ControlConfigOptionTemplate = @"
                list.Add(""#JSNAME#"", new ConfigOption(""#JSNAME#"", new SerializationOptions(""#JSNAME#"", typeof(LazyControlJsonConverter)), null, this.#NAME#));
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



        public const string ListenerPropertyTemplate = @"
	        private #NAME#Events events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption(""events"", JsonMode.Object)]
            [Category(""2. Observable"")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public #NAME#Events Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new #NAME#Events();
					}
			
					return this.events;
				}
			}
";

        public const string ListenerClassTemplate = @"

        /// <summary>
        /// #DESCRIPTION#
        /// </summary>
        public partial class #NAME#Events : ComponentListeners
        {

#LISTENERS#


            /// <summary>
            /// 
            /// </summary>
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
                    #LISTENERCONFIGS#
                    return list;
                }
            }

        }
";

        public const string ListenerItem = @"
        private JFunction #JAVASCRIPTNAME#;

        /// <summary>
        /// #DESCRIPTION#
        /// </summary>
        #ARGS#
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption(""#JAVASCRIPTNAME#"", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@""#DESCRIPTION#"")]
        public virtual JFunction #NAME#
        {
            get
            {
                return this.#JAVASCRIPTNAME# ?? (this.#JAVASCRIPTNAME# = new JFunction(){
                    Args = new string[] {""event""}
                });
            }
        }
";

        public const string ListenerConfigItem = @"list.Add(""#JSNAME#"", new ConfigOption(""#JSNAME#"", new SerializationOptions(""#JSNAME#"", typeof(JFunctionJsonConverter)), null, this.#NAME#));";


    }
}
