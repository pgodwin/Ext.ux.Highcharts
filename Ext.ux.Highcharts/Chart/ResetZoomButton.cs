
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
        /// The button that appears after a selection zoom, allowing the user to reset zoom.
        /// </summary>
        public partial class ResetZoomButton : Observable
        {

    
            /// <summary>
            /// The position of the button. This is an object that can hold the properties align, verticalAlign, x and y.
            /// </summary>
            [ConfigOption("position", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The position of the button. This is an object that can hold the properties align, verticalAlign, x and y.")]
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
            /// What frame the button should be placed related to. Can be either ""plot"" or ""chart"".
            /// </summary>
            [ConfigOption("relativeTo", null)]
            [DefaultValue(@"plot")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"What frame the button should be placed related to. Can be either ""plot"" or ""chart"".")]
            public string RelativeTo
            {
                get
                {
                    return this.State.Get<string>("RelativeTo", @"plot");
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

                list.Add("relativeTo", new ConfigOption("relativeTo", null, @"plot", this.RelativeTo));

                list.Add("theme", new ConfigOption("theme", null, null, this.Theme));

                return list;
            }
        }


    
	        private ResetZoomButtonEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ResetZoomButtonEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new ResetZoomButtonEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class ResetZoomButtonEvents : ComponentListeners
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
            