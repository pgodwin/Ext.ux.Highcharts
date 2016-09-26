
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
        /// 
        /// </summary>
        public partial class Hover : Observable
        {

    
            /// <summary>
            /// Enable or disable the point marker.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the point marker.")]
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
            /// The fill color of the marker in hover state.
            /// </summary>
            [ConfigOption("fillColor", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The fill color of the marker in hover state.")]
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
            /// The additional line width for a hovered point.
            /// </summary>
            [ConfigOption("lineWidthPlus", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The additional line width for a hovered point.")]
            public double? LineWidthPlus
            {
                get
                {
                    return this.State.Get<double?>("LineWidthPlus", 1);
                }
                set
                {
                    this.State.Set("LineWidthPlus", value);
                }
            }

            /// <summary>
            /// The radius of the point marker. In hover state, it defaults to the normal state's radius + 2 as per the radiusPlus option.
            /// </summary>
            [ConfigOption("radius", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The radius of the point marker. In hover state, it defaults to the normal state's radius + 2 as per the radiusPlus option.")]
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

            /// <summary>
            /// The number of pixels to increase the radius of the hovered point.
            /// </summary>
            [ConfigOption("radiusPlus", null)]
            [DefaultValue(2)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The number of pixels to increase the radius of the hovered point.")]
            public double? RadiusPlus
            {
                get
                {
                    return this.State.Get<double?>("RadiusPlus", 2);
                }
                set
                {
                    this.State.Set("RadiusPlus", value);
                }
            }

        private Halo _Halo;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("halo", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts. By default the halo is filled by the current point or series color with an opacity of 0.25. The halo can be disabled by setting the halo option to false.")]
        public virtual Halo Halo
        {
            get
            {
                return this._Halo;
            }
            set
            {
                if (this._Halo != null)
                {
                    this.Controls.Remove(this._Halo);
                    this.LazyItems.Remove(this._Halo);
                }

                this._Halo = value;

                if (this._Halo != null)
                {
                    this.LazyItems.Add(this._Halo);
                    this.Controls.Add(this._Halo);
                }
            }
        }
        private Marker _Marker;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("marker", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual Marker Marker
        {
            get
            {
                return this._Marker;
            }
            set
            {
                if (this._Marker != null)
                {
                    this.Controls.Remove(this._Marker);
                    this.LazyItems.Remove(this._Marker);
                }

                this._Marker = value;

                if (this._Marker != null)
                {
                    this.LazyItems.Add(this._Marker);
                    this.Controls.Add(this._Marker);
                }
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

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#FFFFFF", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("lineWidthPlus", new ConfigOption("lineWidthPlus", null, 1, this.LineWidthPlus));

                list.Add("radius", new ConfigOption("radius", null, null, this.Radius));

                list.Add("radiusPlus", new ConfigOption("radiusPlus", null, 2, this.RadiusPlus));

                list.Add("halo", new ConfigOption("halo", new SerializationOptions("halo", typeof(LazyControlJsonConverter)), null, this.Halo));

                list.Add("marker", new ConfigOption("marker", new SerializationOptions("marker", typeof(LazyControlJsonConverter)), null, this.Marker));

                return list;
            }
        }


    
	        private HoverEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public HoverEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new HoverEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class HoverEvents : ComponentListeners
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
            