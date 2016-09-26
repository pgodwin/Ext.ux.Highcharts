
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
        /// Options for the pivot or the center point of the gauge.
        /// </summary>
        public partial class Pivot : Observable
        {

    
            /// <summary>
            /// The background color or fill of the pivot.
            /// </summary>
            [ConfigOption("backgroundColor", null)]
            [DefaultValue(@"black")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The background color or fill of the pivot.")]
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
            /// The border or stroke color of the pivot. In able to change this, the borderWidth must also be set to something other than the default 0.
            /// </summary>
            [ConfigOption("borderColor", null)]
            [DefaultValue(@"silver")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The border or stroke color of the pivot. In able to change this, the borderWidth must also be set to something other than the default 0.")]
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
            /// The border or stroke width of the pivot.
            /// </summary>
            [ConfigOption("borderWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The border or stroke width of the pivot.")]
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
            /// The pixel radius of the pivot.
            /// </summary>
            [ConfigOption("radius", null)]
            [DefaultValue(5)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The pixel radius of the pivot.")]
            public double? Radius
            {
                get
                {
                    return this.State.Get<double?>("Radius", 5);
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


                list.Add("backgroundColor", new ConfigOption("backgroundColor", null, @"black", this.BackgroundColor));

                list.Add("borderColor", new ConfigOption("borderColor", null, @"silver", this.BorderColor));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 0, this.BorderWidth));

                list.Add("radius", new ConfigOption("radius", null, 5, this.Radius));

                return list;
            }
        }


    
	        private PivotEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public PivotEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new PivotEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class PivotEvents : ComponentListeners
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
            