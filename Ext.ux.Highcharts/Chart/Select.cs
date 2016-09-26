
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
        /// The appearance of the point marker when selected. In order to allow a point to be 		selected, set the series.allowPointSelect option to true.
        /// </summary>
        public partial class Select : Observable
        {

    
            /// <summary>
            /// Enable or disable visible feedback for selection.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Enable or disable visible feedback for selection.")]
            public bool? Enabled
            {
                get
                {
                    return this.State.Get<bool?>("Enabled", true);
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// The fill color of the point marker.
            /// </summary>
            [ConfigOption("fillColor", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The fill color of the point marker.")]
            public string FillColor
            {
                get
                {
                    return this.State.Get<string>("FillColor", "");
                }
                set
                {
                    this.State.Set("FillColor", value);
                }
            }

            /// <summary>
            /// The color of the point marker's outline. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption("lineColor", null)]
            [DefaultValue(@"#000000")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The color of the point marker's outline. When null, the series' or point's color is used.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#000000");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// The width of the point marker's outline.
            /// </summary>
            [ConfigOption("lineWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The width of the point marker's outline.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 0);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The radius of the point marker. In hover state, it defaults		to the normal state's radius + 2.
            /// </summary>
            [ConfigOption("radius", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The radius of the point marker. In hover state, it defaults		to the normal state's radius + 2.")]
            public double? Radius
            {
                get
                {
                    return this.State.Get<double?>("Radius", null);
                }
                set
                {
                    this.State.Set("Radius", value);
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


                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#000000", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("radius", new ConfigOption("radius", null, null, this.Radius));

                return list;
            }
        }


    
	        private SelectEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public SelectEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new SelectEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class SelectEvents : ComponentListeners
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
            