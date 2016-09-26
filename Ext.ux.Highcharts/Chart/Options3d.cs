
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
        /// Options to render charts in 3 dimensions. This feature requires highcharts-3d.js, found in the download package or online at code.highcharts.com/highcharts-3d.js.
        /// </summary>
        public partial class Options3d : Observable
        {

    
            /// <summary>
            /// One of the two rotation angles for the chart.
            /// </summary>
            [ConfigOption("alpha", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"One of the two rotation angles for the chart.")]
            public double? Alpha
            {
                get
                {
                    return this.State.Get<double?>("Alpha", 0);
                }
                set
                {
                    this.State.Set("Alpha", value);
                }
            }

            /// <summary>
            /// One of the two rotation angles for the chart.
            /// </summary>
            [ConfigOption("beta", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"One of the two rotation angles for the chart.")]
            public double? Beta
            {
                get
                {
                    return this.State.Get<double?>("Beta", 0);
                }
                set
                {
                    this.State.Set("Beta", value);
                }
            }

            /// <summary>
            /// The total depth of the chart.
            /// </summary>
            [ConfigOption("depth", null)]
            [DefaultValue(100)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The total depth of the chart.")]
            public double? Depth
            {
                get
                {
                    return this.State.Get<double?>("Depth", 100);
                }
                set
                {
                    this.State.Set("Depth", value);
                }
            }

            /// <summary>
            /// Wether to render the chart using the 3D functionality.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Wether to render the chart using the 3D functionality.")]
            public bool? Enabled
            {
                get
                {
                    return this.State.Get<bool?>("Enabled", false);
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// Defines the distance the viewer is standing in front of the chart, this setting is important to calculate the perspective effect in column and scatter charts.It is not used for 3D pie charts.
            /// </summary>
            [ConfigOption("viewDistance", null)]
            [DefaultValue(100)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Defines the distance the viewer is standing in front of the chart, this setting is important to calculate the perspective effect in column and scatter charts.It is not used for 3D pie charts.")]
            public double? ViewDistance
            {
                get
                {
                    return this.State.Get<double?>("ViewDistance", 100);
                }
                set
                {
                    this.State.Set("ViewDistance", value);
                }
            }

        private Frame _Frame;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("frame", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Provides the option to draw a frame around the charts by defining a bottom, front and back panel. ")]
        public virtual Frame Frame
        {
            get
            {
                return this._Frame;
            }
            set
            {
                if (this._Frame != null)
                {
                    this.Controls.Remove(this._Frame);
                    this.LazyItems.Remove(this._Frame);
                }

                this._Frame = value;

                if (this._Frame != null)
                {
                    this.LazyItems.Add(this._Frame);
                    this.Controls.Add(this._Frame);
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


                list.Add("alpha", new ConfigOption("alpha", null, 0, this.Alpha));

                list.Add("beta", new ConfigOption("beta", null, 0, this.Beta));

                list.Add("depth", new ConfigOption("depth", null, 100, this.Depth));

                list.Add("enabled", new ConfigOption("enabled", null, false, this.Enabled));

                list.Add("viewDistance", new ConfigOption("viewDistance", null, 100, this.ViewDistance));

                list.Add("frame", new ConfigOption("frame", new SerializationOptions("frame", typeof(LazyControlJsonConverter)), null, this.Frame));

                return list;
            }
        }


    
	        private Options3dEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public Options3dEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new Options3dEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class Options3dEvents : ComponentListeners
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
            