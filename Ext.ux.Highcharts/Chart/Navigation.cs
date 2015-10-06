
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

    
            /// <summary>
            /// Alignment for the buttons.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"right")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Alignment for the buttons.")]
            public string Align
            {
                get
                {
                    return this.State.Get<string>("Align", @"right");
                }
                set
                {
                    this.State.Set("Align", value);
                }
            }

            /// <summary>
            /// Whether to enable buttons.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to enable buttons.")]
            public bool? Enabled
            {
                get
                {
                    return this.State.Get<bool?>("Enabled", true);
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// Pixel height of the buttons.
            /// </summary>
            [ConfigOption]
            [DefaultValue(20)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Pixel height of the buttons.")]
            public double? Height
            {
                get
                {
                    return this.State.Get<double?>("Height", 20);
                }
                set
                {
                    this.State.Set("Height", value);
                }
            }

            /// <summary>
            /// Fill color for the symbol within the button.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#E0E0E0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fill color for the symbol within the button.")]
            public string SymbolFill
            {
                get
                {
                    return this.State.Get<string>("SymbolFill", @"#E0E0E0");
                }
                set
                {
                    this.State.Set("SymbolFill", value);
                }
            }

            /// <summary>
            /// The pixel size of the symbol on the button.
            /// </summary>
            [ConfigOption]
            [DefaultValue(14)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel size of the symbol on the button.")]
            public double? SymbolSize
            {
                get
                {
                    return this.State.Get<double?>("SymbolSize", 14);
                }
                set
                {
                    this.State.Set("SymbolSize", value);
                }
            }

            /// <summary>
            /// The color of the symbol's stroke or line.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#666")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the symbol's stroke or line.")]
            public string SymbolStroke
            {
                get
                {
                    return this.State.Get<string>("SymbolStroke", @"#666");
                }
                set
                {
                    this.State.Set("SymbolStroke", value);
                }
            }

            /// <summary>
            /// The pixel stroke width of the symbol on the button.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel stroke width of the symbol on the button.")]
            public double? SymbolStrokeWidth
            {
                get
                {
                    return this.State.Get<double?>("SymbolStrokeWidth", 1);
                }
                set
                {
                    this.State.Set("SymbolStrokeWidth", value);
                }
            }

            /// <summary>
            /// The x position of the center of the symbol inside the button.
            /// </summary>
            [ConfigOption]
            [DefaultValue(12.5)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The x position of the center of the symbol inside the button.")]
            public double? SymbolX
            {
                get
                {
                    return this.State.Get<double?>("SymbolX", 12.5);
                }
                set
                {
                    this.State.Set("SymbolX", value);
                }
            }

            /// <summary>
            /// The y position of the center of the symbol inside the button.
            /// </summary>
            [ConfigOption]
            [DefaultValue(10.5)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The y position of the center of the symbol inside the button.")]
            public double? SymbolY
            {
                get
                {
                    return this.State.Get<double?>("SymbolY", 10.5);
                }
                set
                {
                    this.State.Set("SymbolY", value);
                }
            }

            /// <summary>
            /// A text string to add to the individual button. 
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A text string to add to the individual button. ")]
            public string Text
            {
                get
                {
                    return this.State.Get<string>("Text", @"null");
                }
                set
                {
                    this.State.Set("Text", value);
                }
            }

            /// <summary>
            /// A configuration object for the button theme. The object accepts SVG properties like stroke-width, stroke and fill. Tri-state button styles are supported by the states.hover and states.select objects.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A configuration object for the button theme. The object accepts SVG properties like stroke-width, stroke and fill. Tri-state button styles are supported by the states.hover and states.select objects.")]
            public object Theme
            {
                get
                {
                    return this.State.Get<object>("Theme", null);
                }
                set
                {
                    this.State.Set("Theme", value);
                }
            }

            /// <summary>
            /// The vertical alignment of the buttons. Can be one of ""top"", ""middle"" or ""bottom"".
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"top")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The vertical alignment of the buttons. Can be one of ""top"", ""middle"" or ""bottom"".")]
            public string VerticalAlign
            {
                get
                {
                    return this.State.Get<string>("VerticalAlign", @"top");
                }
                set
                {
                    this.State.Set("VerticalAlign", value);
                }
            }

            /// <summary>
            /// The pixel width of the button.
            /// </summary>
            [ConfigOption]
            [DefaultValue(24)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel width of the button.")]
            public double? Width
            {
                get
                {
                    return this.State.Get<double?>("Width", 24);
                }
                set
                {
                    this.State.Set("Width", value);
                }
            }

            /// <summary>
            /// The vertical offset of the button's position relative to its verticalAlign.			 .
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The vertical offset of the button's position relative to its verticalAlign.			 .")]
            public double? y
            {
                get
                {
                    return this.State.Get<double?>("y", 0);
                }
                set
                {
                    this.State.Set("y", value);
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


                list.Add("align", new ConfigOption("align", null, @"right", this.Align));

                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("height", new ConfigOption("height", null, 20, this.Height));

                list.Add("symbolFill", new ConfigOption("symbolFill", null, @"#E0E0E0", this.SymbolFill));

                list.Add("symbolSize", new ConfigOption("symbolSize", null, 14, this.SymbolSize));

                list.Add("symbolStroke", new ConfigOption("symbolStroke", null, @"#666", this.SymbolStroke));

                list.Add("symbolStrokeWidth", new ConfigOption("symbolStrokeWidth", null, 1, this.SymbolStrokeWidth));

                list.Add("symbolX", new ConfigOption("symbolX", null, 12.5, this.SymbolX));

                list.Add("symbolY", new ConfigOption("symbolY", null, 10.5, this.SymbolY));

                list.Add("text", new ConfigOption("text", null, @"null", this.Text));

                list.Add("theme", new ConfigOption("theme", null, null, this.Theme));

                list.Add("verticalAlign", new ConfigOption("verticalAlign", null, @"top", this.VerticalAlign));

                list.Add("width", new ConfigOption("width", null, 24, this.Width));

                list.Add("y", new ConfigOption("y", null, 0, this.y));

                return list;
            }
        }


    

        }


        }

        
}
            