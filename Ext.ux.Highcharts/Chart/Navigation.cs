
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
        /// A collection of options for buttons and menus appearing in the exporting module.
        /// </summary>
        public partial class Navigation : Observable
        {

    
            /// <summary>
            /// CSS styles for the hover state of the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML. Defaults to menuItemHoverStyle: {	background: '#4572A5',	color: '#FFFFFF'}
            /// </summary>
            [ConfigOption("menuItemHoverStyle", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the hover state of the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML. Defaults to menuItemHoverStyle: {	background: '#4572A5',	color: '#FFFFFF'}")]
            public string MenuItemHoverStyle
            {
                get
                {
                    return this.State.Get<string>("MenuItemHoverStyle", "");
                }
                set
                {
                    this.State.Set("MenuItemHoverStyle", value);
                }
            }

            /// <summary>
            /// CSS styles for the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML. Defaults to menuItemStyle: {	padding: '0 5px',	background: NONE,	color: '#303030'}
            /// </summary>
            [ConfigOption("menuItemStyle", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML. Defaults to menuItemStyle: {	padding: '0 5px',	background: NONE,	color: '#303030'}")]
            public string MenuItemStyle
            {
                get
                {
                    return this.State.Get<string>("MenuItemStyle", "");
                }
                set
                {
                    this.State.Set("MenuItemStyle", value);
                }
            }

            /// <summary>
            /// CSS styles for the popup menu appearing by default when the export icon is clicked. This menu is rendered in HTML. Defaults to menuStyle: {	border: '1px solid #A0A0A0',	background: '#FFFFFF'}
            /// </summary>
            [ConfigOption("menuStyle", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the popup menu appearing by default when the export icon is clicked. This menu is rendered in HTML. Defaults to menuStyle: {	border: '1px solid #A0A0A0',	background: '#FFFFFF'}")]
            public string MenuStyle
            {
                get
                {
                    return this.State.Get<string>("MenuStyle", "");
                }
                set
                {
                    this.State.Set("MenuStyle", value);
                }
            }

        private ButtonOptions _ButtonOptions;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("buttonOptions", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"A collection of options for buttons appearing in the exporting module.")]
        public virtual ButtonOptions ButtonOptions
        {
            get
            {
                return this._ButtonOptions;
            }
            set
            {
                if (this._ButtonOptions != null)
                {
                    this.Controls.Remove(this._ButtonOptions);
                    this.LazyItems.Remove(this._ButtonOptions);
                }

                this._ButtonOptions = value;

                if (this._ButtonOptions != null)
                {
                    this.LazyItems.Add(this._ButtonOptions);
                    this.Controls.Add(this._ButtonOptions);
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


                list.Add("menuItemHoverStyle", new ConfigOption("menuItemHoverStyle", null, "", this.MenuItemHoverStyle));

                list.Add("menuItemStyle", new ConfigOption("menuItemStyle", null, "", this.MenuItemStyle));

                list.Add("menuStyle", new ConfigOption("menuStyle", null, "", this.MenuStyle));

                list.Add("buttonOptions", new ConfigOption("buttonOptions", new SerializationOptions("buttonOptions", typeof(LazyControlJsonConverter)), null, this.ButtonOptions));


                return list;
            }
        }


    
	        private NavigationEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public NavigationEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new NavigationEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class NavigationEvents : ComponentListeners
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
            