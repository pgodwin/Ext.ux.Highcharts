
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
        /// A collection of options for buttons and menus appearing in the exporting module.
        /// </summary>
        public partial class Navigation : Observable
        {

    
            /// <summary>
            /// CSS styles for the hover state of the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML. Defaults to menuItemHoverStyle: {	background: '#4572A5',	color: '#FFFFFF'}
            /// </summary>
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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

                return list;
            }
        }


    

        /// <summary>
        /// A collection of options for buttons appearing in the exporting module.
        /// </summary>
        public partial class ButtonOptions : Observable
        {

    

    
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
            