
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
        /// A HTML label that can be positioned anywhere in the chart area.
        /// </summary>
        public partial class Items : Observable
        {

    
            /// <summary>
            /// Inner HTML or text for the label.
            /// </summary>
            [ConfigOption("html", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Inner HTML or text for the label.")]
            public string Html
            {
                get
                {
                    return this.State.Get<string>("Html", "");
                }
                set
                {
                    this.State.Set("Html", value);
                }
            }

            /// <summary>
            /// CSS styles for each label. To position the label, use left and top like this:style: {	left: '100px',	top: '100px'}
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for each label. To position the label, use left and top like this:style: {	left: '100px',	top: '100px'}")]
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


                list.Add("html", new ConfigOption("html", null, "", this.Html));

                list.Add("style", new ConfigOption("style", null, "", this.Style));

                return list;
            }
        }


    
	        private ItemsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ItemsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new ItemsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class ItemsEvents : ComponentListeners
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
            