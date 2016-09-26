
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using Ext.Net;
using Ext.Net.Utilities;

using Newtonsoft.Json;
using Ext.ux.Highcharts.Chart;

namespace Ext.ux.Highcharts.Chart
{
        


        /// <summary>
        /// Options for the drill up button that appears when drilling down on a series. The text for the button is defined in lang.drillUpText.
        /// </summary>
        public partial class DrillUpButton : Observable
        {

    
            /// <summary>
            /// Positioning options for the button within the relativeTo box. Available properties are x, y, align and verticalAlign.
            /// </summary>
            [ConfigOption("position", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Positioning options for the button within the relativeTo box. Available properties are x, y, align and verticalAlign.")]
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
            /// What box to align the button to. Can be either ""plotBox"" or ""spacingBox"".
            /// </summary>
            [ConfigOption("relativeTo", null)]
            [DefaultValue(@"plotBox")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"What box to align the button to. Can be either ""plotBox"" or ""spacingBox"".")]
            public string RelativeTo
            {
                get
                {
                    return this.State.Get<string>("RelativeTo", @"plotBox");
                }
                set
                {
                    this.State.Set("RelativeTo", value);
                }
            }

            /// <summary>
            /// A collection of attributes for the button. The object takes SVG attributes like  fill, stroke, stroke-width or r, the border radius. The theme also supports style, a collection of CSS properties for the text. Equivalent attributes for the hover state are given in theme.states.hover.
            /// </summary>
            [ConfigOption("theme", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"A collection of attributes for the button. The object takes SVG attributes like  fill, stroke, stroke-width or r, the border radius. The theme also supports style, a collection of CSS properties for the text. Equivalent attributes for the hover state are given in theme.states.hover.")]
            public object Theme
            {
                get
                {
                    return this.State.Get<object>("Theme", null);
                }
                set
                {
                    this.State.Set("Theme", value);
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


                list.Add("position", new ConfigOption("position", null, null, this.Position));

                list.Add("relativeTo", new ConfigOption("relativeTo", null, @"plotBox", this.RelativeTo));

                list.Add("theme", new ConfigOption("theme", null, null, this.Theme));

                return list;
            }
        }


    
	        private DrillUpButtonEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public DrillUpButtonEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new DrillUpButtonEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class DrillUpButtonEvents : ComponentListeners
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
            