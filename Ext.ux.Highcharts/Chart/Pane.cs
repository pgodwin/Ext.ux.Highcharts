
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
        /// Applies only to polar charts and angular gauges. This configuration object holds general options for the combined X and Y axes set. Each xAxis or yAxis can reference the pane by index.
        /// </summary>
        public partial class Pane : Observable
        {

    
            /// <summary>
            /// An object, or array of objects, for backgrounds. Sub options include backgroundColor (can be solid or gradient), shape (""solid"" or ""arc""), innerWidth, outerWidth, borderWidth, borderColor.
            /// </summary>
            [ConfigOption("background", JsonMode.AlwaysArray)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"An object, or array of objects, for backgrounds. Sub options include backgroundColor (can be solid or gradient), shape (""solid"" or ""arc""), innerWidth, outerWidth, borderWidth, borderColor.")]
            public object[] Background
            {
                get
                {
                    return this.State.Get<object[]>("Background", null);
                }
                set
                {
                    this.State.Set("Background", value);
                }
            }

            /// <summary>
            /// The center of a polar chart or angular gauge, given as an array of [x, y] positions. Positions can be given as integers that transform to pixels, or as percentages of the plot area size.
            /// </summary>
            [ConfigOption("center", JsonMode.AlwaysArray)]
            [DefaultValue(new object[] { "50%", "50%"})]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The center of a polar chart or angular gauge, given as an array of [x, y] positions. Positions can be given as integers that transform to pixels, or as percentages of the plot area size.")]
            public object[] Center
            {
                get
                {
                    return this.State.Get<object[]>("Center", new object[] { "50%", "50%"});
                }
                set
                {
                    this.State.Set("Center", value);
                }
            }

            /// <summary>
            /// The end angle of the polar X axis or gauge value axis, given in degrees where 0 is north. Defaults to startAngle + 360.
            /// </summary>
            [ConfigOption("endAngle", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The end angle of the polar X axis or gauge value axis, given in degrees where 0 is north. Defaults to startAngle + 360.")]
            public double? EndAngle
            {
                get
                {
                    return this.State.Get<double?>("EndAngle", null);
                }
                set
                {
                    this.State.Set("EndAngle", value);
                }
            }

            /// <summary>
            /// The size of the pane, either as a number defining pixels, or a percentage defining a percentage of the plot are.
            /// </summary>
            [ConfigOption("size", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The size of the pane, either as a number defining pixels, or a percentage defining a percentage of the plot are.")]
            public object Size
            {
                get
                {
                    return this.State.Get<object>("Size", null);
                }
                set
                {
                    this.State.Set("Size", value);
                }
            }

            /// <summary>
            /// The start angle of the polar X axis or gauge axis, given in degrees where 0 is north. Defaults to 0.
            /// </summary>
            [ConfigOption("startAngle", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The start angle of the polar X axis or gauge axis, given in degrees where 0 is north. Defaults to 0.")]
            public double? StartAngle
            {
                get
                {
                    return this.State.Get<double?>("StartAngle", null);
                }
                set
                {
                    this.State.Set("StartAngle", value);
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


                list.Add("background", new ConfigOption("background", new SerializationOptions("background", JsonMode.AlwaysArray), null, this.Background));

                list.Add("center", new ConfigOption("center", new SerializationOptions("center", JsonMode.AlwaysArray), new object[] { "50%", "50%"}, this.Center));

                list.Add("endAngle", new ConfigOption("endAngle", null, null, this.EndAngle));

                list.Add("size", new ConfigOption("size", null, null, this.Size));

                list.Add("startAngle", new ConfigOption("startAngle", null, null, this.StartAngle));

                return list;
            }
        }


    
	        private PaneEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public PaneEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new PaneEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class PaneEvents : ComponentListeners
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
            