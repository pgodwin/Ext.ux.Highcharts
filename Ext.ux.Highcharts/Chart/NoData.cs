
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
using Ext.ux.Highcharts.Chart;

namespace Ext.ux.Highcharts.Chart
{
        


        /// <summary>
        /// Options for displaying a message like "No data to display". This feature requires the file no-data-to-display.js to be loaded in the page. The actual text to display is set in the lang.noData option.
        /// </summary>
        public partial class NoData : Observable
        {

    
            /// <summary>
            /// An object of additional SVG attributes for the no-data label.
            /// </summary>
            [ConfigOption("attr", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An object of additional SVG attributes for the no-data label.")]
            public object Attr
            {
                get
                {
                    return this.State.Get<object>("Attr", null);
                }
                set
                {
                    this.State.Set("Attr", value);
                }
            }

            /// <summary>
            /// The position of the no-data label, relative to the plot area. 
            /// </summary>
            [ConfigOption("position", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The position of the no-data label, relative to the plot area. ")]
            public object Position
            {
                get
                {
                    return this.State.Get<object>("Position", null);
                }
                set
                {
                    this.State.Set("Position", value);
                }
            }

            /// <summary>
            /// CSS styles for the no-data label. 
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue(@"{ ""fontSize"": ""12px"", ""fontWeight"": ""bold"", ""color"": ""#60606a"" }")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the no-data label. ")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", @"{ ""fontSize"": ""12px"", ""fontWeight"": ""bold"", ""color"": ""#60606a"" }");
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }


    
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


                list.Add("attr", new ConfigOption("attr", null, null, this.Attr));

                list.Add("position", new ConfigOption("position", null, null, this.Position));

                list.Add("style", new ConfigOption("style", null, @"{ ""fontSize"": ""12px"", ""fontWeight"": ""bold"", ""color"": ""#60606a"" }", this.Style));

                return list;
            }
        }


    
	        private NoDataEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public NoDataEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new NoDataEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class NoDataEvents : ComponentListeners
        {




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
                    
                    return list;
                }
            }

        }


        }

        
}
            