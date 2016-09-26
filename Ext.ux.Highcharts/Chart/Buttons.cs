
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
        /// Options for the export related buttons, print and export. In addition to the default buttons listed here, custom buttons can be added. See navigation.buttonOptions for general options.
        /// </summary>
        public partial class Buttons : Observable
        {

    
        private ContextButton _ContextButton;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("contextButton", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Options for the export button.")]
        public virtual ContextButton ContextButton
        {
            get
            {
                return this._ContextButton;
            }
            set
            {
                if (this._ContextButton != null)
                {
                    this.Controls.Remove(this._ContextButton);
                    this.LazyItems.Remove(this._ContextButton);
                }

                this._ContextButton = value;

                if (this._ContextButton != null)
                {
                    this.LazyItems.Add(this._ContextButton);
                    this.Controls.Add(this._ContextButton);
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


                list.Add("contextButton", new ConfigOption("contextButton", new SerializationOptions("contextButton", typeof(LazyControlJsonConverter)), null, this.ContextButton));


                return list;
            }
        }


    
	        private ButtonsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ButtonsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new ButtonsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class ButtonsEvents : ComponentListeners
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
            