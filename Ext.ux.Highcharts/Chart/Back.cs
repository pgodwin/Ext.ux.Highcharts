
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
        /// Defines the back panel of the frame around 3D charts.
        /// </summary>
        public partial class Back : Observable
        {

    
            /// <summary>
            /// The color of the panel.
            /// </summary>
            [ConfigOption("color", null)]
            [DefaultValue(@"transparent")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The color of the panel.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", @"transparent");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// Thickness of the panel.
            /// </summary>
            [ConfigOption("size", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Thickness of the panel.")]
            public double? Size
            {
                get
                {
                    return this.State.Get<double?>("Size", 1);
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


                list.Add("color", new ConfigOption("color", null, @"transparent", this.Color));

                list.Add("size", new ConfigOption("size", null, 1, this.Size));

                return list;
            }
        }


    
	        private BackEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public BackEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new BackEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class BackEvents : ComponentListeners
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
            