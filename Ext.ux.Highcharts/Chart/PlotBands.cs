
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
        /// An array of colored bands stretching across the plot area marking an interval on the axis.In a gauge, a plot band on the Y axis (value axis) will stretch along the perimeter of the gauge.
        /// </summary>
        public partial class PlotBands : Observable
        {

    
            /// <summary>
            /// Border color for the plot band. Also requires borderWidth to be set.
            /// </summary>
            [ConfigOption("borderColor", null)]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Border color for the plot band. Also requires borderWidth to be set.")]
            public string BorderColor
            {
                get
                {
                    return this.State.Get<string>("BorderColor", @"null");
                }
                set
                {
                    this.State.Set("BorderColor", value);
                }
            }

            /// <summary>
            /// Border width for the plot band.  Also requires borderColor to be set.
            /// </summary>
            [ConfigOption("borderWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Border width for the plot band.  Also requires borderColor to be set.")]
            public double? BorderWidth
            {
                get
                {
                    return this.State.Get<double?>("BorderWidth", 0);
                }
                set
                {
                    this.State.Set("BorderWidth", value);
                }
            }

            /// <summary>
            /// The color of the plot band.
            /// </summary>
            [ConfigOption("color", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the plot band.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", "");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// An object defining mouse events for the plot band. Supported properties are click, mouseover, mouseout, mousemove.
            /// </summary>
            [ConfigOption("events", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An object defining mouse events for the plot band. Supported properties are click, mouseover, mouseout, mousemove.")]
            public object Events
            {
                get
                {
                    return this.State.Get<object>("Events", null);
                }
                set
                {
                    this.State.Set("Events", value);
                }
            }

            /// <summary>
            /// The start position of the plot band in axis units.
            /// </summary>
            [ConfigOption("from", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The start position of the plot band in axis units.")]
            public double? From
            {
                get
                {
                    return this.State.Get<double?>("From", null);
                }
                set
                {
                    this.State.Set("From", value);
                }
            }

            /// <summary>
            /// An id used for identifying the plot band in Axis.removePlotBand.
            /// </summary>
            [ConfigOption("id", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An id used for identifying the plot band in Axis.removePlotBand.")]
            public string Id
            {
                get
                {
                    return this.State.Get<string>("Id", "");
                }
                set
                {
                    this.State.Set("Id", value);
                }
            }

            /// <summary>
            /// The end position of the plot band in axis units.
            /// </summary>
            [ConfigOption("to", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The end position of the plot band in axis units.")]
            public double? To
            {
                get
                {
                    return this.State.Get<double?>("To", null);
                }
                set
                {
                    this.State.Set("To", value);
                }
            }

            /// <summary>
            /// The z index of the plot band within the chart, relative to other elements. Using the same z index as another element may give unpredictable results, as the last rendered element will be on top. Values from 0 to 20 make sense.
            /// </summary>
            [ConfigOption("zIndex", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The z index of the plot band within the chart, relative to other elements. Using the same z index as another element may give unpredictable results, as the last rendered element will be on top. Values from 0 to 20 make sense.")]
            public double? ZIndex
            {
                get
                {
                    return this.State.Get<double?>("ZIndex", null);
                }
                set
                {
                    this.State.Set("ZIndex", value);
                }
            }

        private Label _Label;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("label", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Text labels for the plot bands")]
        public virtual Label Label
        {
            get
            {
                return this._Label;
            }
            set
            {
                if (this._Label != null)
                {
                    this.Controls.Remove(this._Label);
                    this.LazyItems.Remove(this._Label);
                }

                this._Label = value;

                if (this._Label != null)
                {
                    this.LazyItems.Add(this._Label);
                    this.Controls.Add(this._Label);
                }
            }
        }
            /// <summary>
            /// In a gauge chart, this option determines the inner radius of the plot band that stretches along the perimeter. It can be given as a percentage string, like ""100%"", or as a pixel number, like 100. By default, the inner radius is controlled by the thickness option.
            /// </summary>
            [ConfigOption("innerRadius", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"In a gauge chart, this option determines the inner radius of the plot band that stretches along the perimeter. It can be given as a percentage string, like ""100%"", or as a pixel number, like 100. By default, the inner radius is controlled by the thickness option.")]
            public object InnerRadius
            {
                get
                {
                    return this.State.Get<object>("InnerRadius", null);
                }
                set
                {
                    this.State.Set("InnerRadius", value);
                }
            }

            /// <summary>
            /// In a gauge chart, this option determines the outer radius of the plot band that stretches along the perimeter. It can be given as a percentage string, like ""100%"", or as a pixel number, like 100.
            /// </summary>
            [ConfigOption("outerRadius", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"In a gauge chart, this option determines the outer radius of the plot band that stretches along the perimeter. It can be given as a percentage string, like ""100%"", or as a pixel number, like 100.")]
            public object OuterRadius
            {
                get
                {
                    return this.State.Get<object>("OuterRadius", null);
                }
                set
                {
                    this.State.Set("OuterRadius", value);
                }
            }

            /// <summary>
            /// In a gauge chart, this option sets the width of the plot band stretching along the perimeter. It can be given as a percentage string, like ""10%"", or as a pixel number, like 10. The default value 10 is the same as the default tickLength, thus making the plot band act as a background for the tick markers. 
            /// </summary>
            [ConfigOption("thickness", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"In a gauge chart, this option sets the width of the plot band stretching along the perimeter. It can be given as a percentage string, like ""10%"", or as a pixel number, like 10. The default value 10 is the same as the default tickLength, thus making the plot band act as a background for the tick markers. ")]
            public object Thickness
            {
                get
                {
                    return this.State.Get<object>("Thickness", null);
                }
                set
                {
                    this.State.Set("Thickness", value);
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


                list.Add("borderColor", new ConfigOption("borderColor", null, @"null", this.BorderColor));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 0, this.BorderWidth));

                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("events", new ConfigOption("events", null, null, this.Events));

                list.Add("from", new ConfigOption("from", null, null, this.From));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("to", new ConfigOption("to", null, null, this.To));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                list.Add("label", new ConfigOption("label", new SerializationOptions("label", typeof(LazyControlJsonConverter)), null, this.Label));


                list.Add("innerRadius", new ConfigOption("innerRadius", null, null, this.InnerRadius));

                list.Add("outerRadius", new ConfigOption("outerRadius", null, null, this.OuterRadius));

                list.Add("thickness", new ConfigOption("thickness", null, null, this.Thickness));

                return list;
            }
        }


    
	        private PlotBandsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public PlotBandsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new PlotBandsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class PlotBandsEvents : ComponentListeners
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
            