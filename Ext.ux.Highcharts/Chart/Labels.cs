
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
        /// HTML labels that can be positioned anywhere in the chart area.
        /// </summary>
        public partial class Labels : Observable
        {

    
            /// <summary>
            /// Shared CSS styles for all labels. Defaults to:style: {	color: '#3E576F'}
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Shared CSS styles for all labels. Defaults to:style: {	color: '#3E576F'}")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", "");
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }


        private ItemsCollection<Items> _items;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("items", typeof(ItemCollectionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"A HTML label that can be positioned anywhere in the chart area.")]
        public virtual ItemsCollection<Items> Items
        {
            get
            {
                if (this._items == null)
                {
                    this._items = new ItemsCollection<Items>();
                    this._items.AfterItemAdd += this.AfterItemAdd;
                    this._items.AfterItemRemove += this.AfterItemRemove;

                }
                return this._items;
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


                list.Add("style", new ConfigOption("style", null, "", this.Style));

                list.Add("items", new ConfigOption("items", new SerializationOptions("items", typeof(ItemCollectionJsonConverter)), null, this.Items));


                return list;
            }
        }


    
	        private LabelsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public LabelsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new LabelsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class LabelsEvents : ComponentListeners
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
            