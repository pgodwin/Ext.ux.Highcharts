
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
        /// An array defining zones within a series. Zones can be applied to the X axis, Y axis or Z axis for bubbles, according to the zoneAxis option.
        /// </summary>
        public partial class Zones : Observable
        {

    
            /// <summary>
            /// Defines the color of the series.
            /// </summary>
            [ConfigOption("color", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Defines the color of the series.")]
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
            /// A name for the dash style to use for the graph.
            /// </summary>
            [ConfigOption("dashStyle", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"A name for the dash style to use for the graph.")]
            public string DashStyle
            {
                get
                {
                    return this.State.Get<string>("DashStyle", "");
                }
                set
                {
                    this.State.Set("DashStyle", value);
                }
            }

            /// <summary>
            /// Defines the fill color for the series (in area type series)
            /// </summary>
            [ConfigOption("fillColor", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Defines the fill color for the series (in area type series)")]
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
            /// The value up to where the zone extends, if undefined the zones stretches to the last value in the series.
            /// </summary>
            [ConfigOption("value", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The value up to where the zone extends, if undefined the zones stretches to the last value in the series.")]
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

                list.Add("dashStyle", new ConfigOption("dashStyle", null, "", this.DashStyle));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("value", new ConfigOption("value", null, null, this.Value));

                return list;
            }
        }


    
	        private ZonesEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ZonesEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new ZonesEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class ZonesEvents : ComponentListeners
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
            