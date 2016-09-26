
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
        /// An array of lines stretching across the plot area, marking a specific value on one of the axes.
        /// </summary>
        public partial class PlotLines : Observable
        {

    
            /// <summary>
            /// The color of the line.
            /// </summary>
            [ConfigOption("color", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The color of the line.")]
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
            /// The dashing or dot style for the plot line. For possible values see this overview.
            /// </summary>
            [ConfigOption("dashStyle", null)]
            [DefaultValue(@"Solid")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The dashing or dot style for the plot line. For possible values see this overview.")]
            public string DashStyle
            {
                get
                {
                    return this.State.Get<string>("DashStyle", @"Solid");
                }
                set
                {
                    this.State.Set("DashStyle", value);
                }
            }

            /// <summary>
            /// An object defining mouse events for the plot line. Supported properties are click, mouseover, mouseout, mousemove.
            /// </summary>
            [ConfigOption("events", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"An object defining mouse events for the plot line. Supported properties are click, mouseover, mouseout, mousemove.")]
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
            /// An id used for identifying the plot line in Axis.removePlotLine.
            /// </summary>
            [ConfigOption("id", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"An id used for identifying the plot line in Axis.removePlotLine.")]
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
            /// The position of the line in axis units.
            /// </summary>
            [ConfigOption("value", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The position of the line in axis units.")]
            public double? Value
            {
                get
                {
                    return this.State.Get<double?>("Value", null);
                }
                set
                {
                    this.State.Set("Value", value);
                }
            }

            /// <summary>
            /// The width or thickness of the plot line.
            /// </summary>
            [ConfigOption("width", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The width or thickness of the plot line.")]
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

            /// <summary>
            /// The z index of the plot line within the chart.
            /// </summary>
            [ConfigOption("zIndex", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The z index of the plot line within the chart.")]
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


                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("dashStyle", new ConfigOption("dashStyle", null, @"Solid", this.DashStyle));

                list.Add("events", new ConfigOption("events", null, null, this.Events));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("value", new ConfigOption("value", null, null, this.Value));

                list.Add("width", new ConfigOption("width", null, null, this.Width));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                list.Add("label", new ConfigOption("label", new SerializationOptions("label", typeof(LazyControlJsonConverter)), null, this.Label));


                return list;
            }
        }


    
	        private PlotLinesEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public PlotLinesEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new PlotLinesEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class PlotLinesEvents : ComponentListeners
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
            