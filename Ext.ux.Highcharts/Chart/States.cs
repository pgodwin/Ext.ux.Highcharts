
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
        /// 
        /// </summary>
        public partial class States : Observable
        {

    
        private Hover _Hover;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("hover", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual Hover Hover
        {
            get
            {
                return this._Hover;
            }
            set
            {
                if (this._Hover != null)
                {
                    this.Controls.Remove(this._Hover);
                    this.LazyItems.Remove(this._Hover);
                }

                this._Hover = value;

                if (this._Hover != null)
                {
                    this.LazyItems.Add(this._Hover);
                    this.Controls.Add(this._Hover);
                }
            }
        }
        private Select _Select;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("select", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"The appearance of the point marker when selected. In order to allow a point to be 		selected, set the series.allowPointSelect option to true.")]
        public virtual Select Select
        {
            get
            {
                return this._Select;
            }
            set
            {
                if (this._Select != null)
                {
                    this.Controls.Remove(this._Select);
                    this.LazyItems.Remove(this._Select);
                }

                this._Select = value;

                if (this._Select != null)
                {
                    this.LazyItems.Add(this._Select);
                    this.Controls.Add(this._Select);
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


                list.Add("hover", new ConfigOption("hover", new SerializationOptions("hover", typeof(LazyControlJsonConverter)), null, this.Hover));


                list.Add("select", new ConfigOption("select", new SerializationOptions("select", typeof(LazyControlJsonConverter)), null, this.Select));


                return list;
            }
        }


    
	        private StatesEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public StatesEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new StatesEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class StatesEvents : ComponentListeners
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
            