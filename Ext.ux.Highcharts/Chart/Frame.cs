
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
        /// Provides the option to draw a frame around the charts by defining a bottom, front and back panel. 
        /// </summary>
        public partial class Frame : Observable
        {

    
        private Back _Back;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("back", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Defines the back panel of the frame around 3D charts.")]
        public virtual Back Back
        {
            get
            {
                return this._Back;
            }
            set
            {
                if (this._Back != null)
                {
                    this.Controls.Remove(this._Back);
                    this.LazyItems.Remove(this._Back);
                }

                this._Back = value;

                if (this._Back != null)
                {
                    this.LazyItems.Add(this._Back);
                    this.Controls.Add(this._Back);
                }
            }
        }
        private Bottom _Bottom;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("bottom", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"The bottom of the frame around a 3D chart.")]
        public virtual Bottom Bottom
        {
            get
            {
                return this._Bottom;
            }
            set
            {
                if (this._Bottom != null)
                {
                    this.Controls.Remove(this._Bottom);
                    this.LazyItems.Remove(this._Bottom);
                }

                this._Bottom = value;

                if (this._Bottom != null)
                {
                    this.LazyItems.Add(this._Bottom);
                    this.Controls.Add(this._Bottom);
                }
            }
        }
        private Side _Side;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("side", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"The side for the frame around a 3D chart.")]
        public virtual Side Side
        {
            get
            {
                return this._Side;
            }
            set
            {
                if (this._Side != null)
                {
                    this.Controls.Remove(this._Side);
                    this.LazyItems.Remove(this._Side);
                }

                this._Side = value;

                if (this._Side != null)
                {
                    this.LazyItems.Add(this._Side);
                    this.Controls.Add(this._Side);
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


                list.Add("back", new ConfigOption("back", new SerializationOptions("back", typeof(LazyControlJsonConverter)), null, this.Back));

                list.Add("bottom", new ConfigOption("bottom", new SerializationOptions("bottom", typeof(LazyControlJsonConverter)), null, this.Bottom));

                list.Add("side", new ConfigOption("side", new SerializationOptions("side", typeof(LazyControlJsonConverter)), null, this.Side));

                return list;
            }
        }


    
	        private FrameEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public FrameEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new FrameEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class FrameEvents : ComponentListeners
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
            