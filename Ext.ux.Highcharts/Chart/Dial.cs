
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
        /// Options for the dial or arrow pointer of the gauge.
        /// </summary>
        public partial class Dial : Observable
        {

    
            /// <summary>
            /// The background or fill color of the gauge's dial. 
            /// </summary>
            [ConfigOption("backgroundColor", null)]
            [DefaultValue(@"black")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The background or fill color of the gauge's dial. ")]
            public string BackgroundColor
            {
                get
                {
                    return this.State.Get<string>("BackgroundColor", @"black");
                }
                set
                {
                    this.State.Set("BackgroundColor", value);
                }
            }

            /// <summary>
            /// The length of the dial's base part, relative to the total radius or length of the dial. 
            /// </summary>
            [ConfigOption("baseLength", null)]
            [DefaultValue(@"70%")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The length of the dial's base part, relative to the total radius or length of the dial. ")]
            public string BaseLength
            {
                get
                {
                    return this.State.Get<string>("BaseLength", @"70%");
                }
                set
                {
                    this.State.Set("BaseLength", value);
                }
            }

            /// <summary>
            /// The pixel width of the base of the gauge dial. The base is the part closest to the pivot, defined by baseLength. 
            /// </summary>
            [ConfigOption("baseWidth", null)]
            [DefaultValue(3)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The pixel width of the base of the gauge dial. The base is the part closest to the pivot, defined by baseLength. ")]
            public double? BaseWidth
            {
                get
                {
                    return this.State.Get<double?>("BaseWidth", 3);
                }
                set
                {
                    this.State.Set("BaseWidth", value);
                }
            }

            /// <summary>
            /// The border color or stroke of the gauge's dial. By default, the borderWidth is 0, so this must be set in addition to a custom border color.
            /// </summary>
            [ConfigOption("borderColor", null)]
            [DefaultValue(@"silver")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The border color or stroke of the gauge's dial. By default, the borderWidth is 0, so this must be set in addition to a custom border color.")]
            public string BorderColor
            {
                get
                {
                    return this.State.Get<string>("BorderColor", @"silver");
                }
                set
                {
                    this.State.Set("BorderColor", value);
                }
            }

            /// <summary>
            /// The width of the gauge dial border in pixels.
            /// </summary>
            [ConfigOption("borderWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The width of the gauge dial border in pixels.")]
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
            /// The radius or length of the dial, in percentages relative to the radius of the gauge itself.
            /// </summary>
            [ConfigOption("radius", null)]
            [DefaultValue(@"80%")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The radius or length of the dial, in percentages relative to the radius of the gauge itself.")]
            public string Radius
            {
                get
                {
                    return this.State.Get<string>("Radius", @"80%");
                }
                set
                {
                    this.State.Set("Radius", value);
                }
            }

            /// <summary>
            /// The length of the dial's rear end, the part that extends out on the other side of the pivot. Relative to the dial's length. 
            /// </summary>
            [ConfigOption("rearLength", null)]
            [DefaultValue(@"10%")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The length of the dial's rear end, the part that extends out on the other side of the pivot. Relative to the dial's length. ")]
            public string RearLength
            {
                get
                {
                    return this.State.Get<string>("RearLength", @"10%");
                }
                set
                {
                    this.State.Set("RearLength", value);
                }
            }

            /// <summary>
            /// The width of the top of the dial, closest to the perimeter. The pivot narrows in from the base to the top.
            /// </summary>
            [ConfigOption("topWidth", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The width of the top of the dial, closest to the perimeter. The pivot narrows in from the base to the top.")]
            public double? TopWidth
            {
                get
                {
                    return this.State.Get<double?>("TopWidth", 1);
                }
                set
                {
                    this.State.Set("TopWidth", value);
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


                list.Add("backgroundColor", new ConfigOption("backgroundColor", null, @"black", this.BackgroundColor));

                list.Add("baseLength", new ConfigOption("baseLength", null, @"70%", this.BaseLength));

                list.Add("baseWidth", new ConfigOption("baseWidth", null, 3, this.BaseWidth));

                list.Add("borderColor", new ConfigOption("borderColor", null, @"silver", this.BorderColor));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 0, this.BorderWidth));

                list.Add("radius", new ConfigOption("radius", null, @"80%", this.Radius));

                list.Add("rearLength", new ConfigOption("rearLength", null, @"10%", this.RearLength));

                list.Add("topWidth", new ConfigOption("topWidth", null, 1, this.TopWidth));

                return list;
            }
        }


    
	        private DialEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public DialEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new DialEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class DialEvents : ComponentListeners
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
            