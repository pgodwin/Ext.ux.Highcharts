
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
        /// 
        /// </summary>
        public partial class Marker : Observable
        {

    
            /// <summary>
            /// Enable or disable the point marker. If null, the markers are hidden when the data is dense, and shown for more widespread data points.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Enable or disable the point marker. If null, the markers are hidden when the data is dense, and shown for more widespread data points.")]
            public bool? Enabled
            {
                get
                {
                    return this.State.Get<bool?>("Enabled", null);
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// The fill color of the point marker. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption("fillColor", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The fill color of the point marker. When null, the series' or point's color is used.")]
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
            /// Image markers only. Set the image width explicitly. When using this option, a width must also be set.
            /// </summary>
            [ConfigOption("height", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Image markers only. Set the image width explicitly. When using this option, a width must also be set.")]
            public double? Height
            {
                get
                {
                    return this.State.Get<double?>("Height", null);
                }
                set
                {
                    this.State.Set("Height", value);
                }
            }

            /// <summary>
            /// The color of the point marker's outline. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption("lineColor", null)]
            [DefaultValue(@"#FFFFFF")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The color of the point marker's outline. When null, the series' or point's color is used.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#FFFFFF");
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
            /// The radius of the point marker.
            /// </summary>
            [ConfigOption("radius", null)]
            [DefaultValue(4)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The radius of the point marker.")]
            public double? Radius
            {
                get
                {
                    return this.State.Get<double?>("Radius", 4);
                }
                set
                {
                    this.State.Set("Radius", value);
                }
            }

            /// <summary>
            /// 
            /// </summary>
            [ConfigOption("states", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"")]
            public string States
            {
                get
                {
                    return this.State.Get<string>("States", "");
                }
                set
                {
                    this.State.Set("States", value);
                }
            }

            /// <summary>
            /// A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are ""circle"", ""square"", ""diamond"", ""triangle"" and ""triangle-down"".Additionally, the URL to a graphic can be given on this form:  ""url(graphic.png)"". Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to Highcharts.SVGRenderer.prototype.symbols. The callback is then used by its method name, as shown in the demo.
            /// </summary>
            [ConfigOption("symbol", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are ""circle"", ""square"", ""diamond"", ""triangle"" and ""triangle-down"".Additionally, the URL to a graphic can be given on this form:  ""url(graphic.png)"". Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to Highcharts.SVGRenderer.prototype.symbols. The callback is then used by its method name, as shown in the demo.")]
            public string Symbol
            {
                get
                {
                    return this.State.Get<string>("Symbol", "");
                }
                set
                {
                    this.State.Set("Symbol", value);
                }
            }

            /// <summary>
            /// Image markers only. Set the image width explicitly. When using this option, a height must also be set.
            /// </summary>
            [ConfigOption("width", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Image markers only. Set the image width explicitly. When using this option, a height must also be set.")]
            public double? Width
            {
                get
                {
                    return this.State.Get<double?>("Width", null);
                }
                set
                {
                    this.State.Set("Width", value);
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


                list.Add("enabled", new ConfigOption("enabled", null, null, this.Enabled));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("height", new ConfigOption("height", null, null, this.Height));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#FFFFFF", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("radius", new ConfigOption("radius", null, 4, this.Radius));

                list.Add("states", new ConfigOption("states", null, "", this.States));

                list.Add("symbol", new ConfigOption("symbol", null, "", this.Symbol));

                list.Add("width", new ConfigOption("width", null, null, this.Width));

                return list;
            }
        }


    
	        private MarkerEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public MarkerEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new MarkerEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class MarkerEvents : ComponentListeners
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
            