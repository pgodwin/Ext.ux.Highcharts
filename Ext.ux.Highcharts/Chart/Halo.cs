
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
        /// Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts. By default the halo is filled by the current point or series color with an opacity of 0.25. The halo can be disabled by setting the halo option to false.
        /// </summary>
        public partial class Halo : Observable
        {

    
            /// <summary>
            /// A collection of SVG attributes to override the appearance of the halo, for example fill, stroke and stroke-width.
            /// </summary>
            [ConfigOption("attributes", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A collection of SVG attributes to override the appearance of the halo, for example fill, stroke and stroke-width.")]
            public object Attributes
            {
                get
                {
                    return this.State.Get<object>("Attributes", null);
                }
                set
                {
                    this.State.Set("Attributes", value);
                }
            }

            /// <summary>
            /// Opacity for the halo unless a specific fill is overridden using the attributes setting. Note that Highcharts is only able to apply opacity to colors of hex or rgb(a) formats.
            /// </summary>
            [ConfigOption("opacity", null)]
            [DefaultValue(0.25)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Opacity for the halo unless a specific fill is overridden using the attributes setting. Note that Highcharts is only able to apply opacity to colors of hex or rgb(a) formats.")]
            public double? Opacity
            {
                get
                {
                    return this.State.Get<double?>("Opacity", 0.25);
                }
                set
                {
                    this.State.Set("Opacity", value);
                }
            }

            /// <summary>
            /// The pixel size of the halo. For point markers this is the radius of the halo. For pie slices it is the width of the halo outside the slice. For bubbles it defaults to 5 and is the width of the halo outside the bubble.
            /// </summary>
            [ConfigOption("size", null)]
            [DefaultValue(10)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel size of the halo. For point markers this is the radius of the halo. For pie slices it is the width of the halo outside the slice. For bubbles it defaults to 5 and is the width of the halo outside the bubble.")]
            public double? Size
            {
                get
                {
                    return this.State.Get<double?>("Size", 10);
                }
                set
                {
                    this.State.Set("Size", value);
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


                list.Add("attributes", new ConfigOption("attributes", null, null, this.Attributes));

                list.Add("opacity", new ConfigOption("opacity", null, 0.25, this.Opacity));

                list.Add("size", new ConfigOption("size", null, 10, this.Size));

                return list;
            }
        }


    
	        private HaloEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public HaloEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new HaloEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class HaloEvents : ComponentListeners
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
            