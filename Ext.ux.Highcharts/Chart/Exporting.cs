
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
        /// Options for the exporting module. For an overview on the matter, see the docs.
        /// </summary>
        public partial class Exporting : Observable
        {

    
            /// <summary>
            /// Experimental setting to allow HTML inside the chart (added through the useHTML options), directly in the exported image. This allows you to preserve complicated HTML structures like tables or bi-directional text in exported charts.Disclaimer: The HTML is rendered in a foreignObject tag in the generated SVG. The official export server is based on PhantomJS, which supports this, but other SVG clients, like Batik, does not support it. This also applies to downloaded SVG that you want to open in a desktop client.
            /// </summary>
            [ConfigOption("allowHTML", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Experimental setting to allow HTML inside the chart (added through the useHTML options), directly in the exported image. This allows you to preserve complicated HTML structures like tables or bi-directional text in exported charts.Disclaimer: The HTML is rendered in a foreignObject tag in the generated SVG. The official export server is based on PhantomJS, which supports this, but other SVG clients, like Batik, does not support it. This also applies to downloaded SVG that you want to open in a desktop client.")]
            public bool? AllowHTML
            {
                get
                {
                    return this.State.Get<bool?>("AllowHTML", false);
                }
                set
                {
                    this.State.Set("AllowHTML", value);
                }
            }

            /// <summary>
            /// Additional chart options to be merged into an exported chart. For example, the exported chart can be given a specific width and height, or a printer-friendly color scheme.
            /// </summary>
            [ConfigOption("chartOptions", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Additional chart options to be merged into an exported chart. For example, the exported chart can be given a specific width and height, or a printer-friendly color scheme.")]
            public object ChartOptions
            {
                get
                {
                    return this.State.Get<object>("ChartOptions", null);
                }
                set
                {
                    this.State.Set("ChartOptions", value);
                }
            }

            /// <summary>
            /// Whether to enable the exporting module. Disabling the module will hide the context button, but API methods will still be available.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to enable the exporting module. Disabling the module will hide the context button, but API methods will still be available.")]
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
            /// Whether or not to fall back to the export server if the offline-exporting module is unable to export the chart on the client side.
            /// </summary>
            [ConfigOption("fallbackToExportServer", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether or not to fall back to the export server if the offline-exporting module is unable to export the chart on the client side.")]
            public bool? FallbackToExportServer
            {
                get
                {
                    return this.State.Get<bool?>("FallbackToExportServer", true);
                }
                set
                {
                    this.State.Set("FallbackToExportServer", value);
                }
            }

            /// <summary>
            /// The filename, without extension, to use for the exported chart.
            /// </summary>
            [ConfigOption("filename", null)]
            [DefaultValue(@"chart")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The filename, without extension, to use for the exported chart.")]
            public string Filename
            {
                get
                {
                    return this.State.Get<string>("Filename", @"chart");
                }
                set
                {
                    this.State.Set("Filename", value);
                }
            }

            /// <summary>
            /// An object containing additional attributes for the POST form that sends the SVG to the export server. For example, a target can be set to make sure the generated image is received in another frame, or a custom enctype or encoding can be set.
            /// </summary>
            [ConfigOption("formAttributes", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An object containing additional attributes for the POST form that sends the SVG to the export server. For example, a target can be set to make sure the generated image is received in another frame, or a custom enctype or encoding can be set.")]
            public object FormAttributes
            {
                get
                {
                    return this.State.Get<object>("FormAttributes", null);
                }
                set
                {
                    this.State.Set("FormAttributes", value);
                }
            }

            /// <summary>
            /// Defines the scale or zoom factor for the exported image compared to the on-screen display. While for instance a 600px wide chart may look good on a website, it will look bad in print. The default scale of 2 makes this chart export to a 1200px PNG or JPG. 
            /// </summary>
            [ConfigOption("scale", null)]
            [DefaultValue(2)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Defines the scale or zoom factor for the exported image compared to the on-screen display. While for instance a 600px wide chart may look good on a website, it will look bad in print. The default scale of 2 makes this chart export to a 1200px PNG or JPG. ")]
            public double? Scale
            {
                get
                {
                    return this.State.Get<double?>("Scale", 2);
                }
                set
                {
                    this.State.Set("Scale", value);
                }
            }

            /// <summary>
            /// Analogous to sourceWidth
            /// </summary>
            [ConfigOption("sourceHeight", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Analogous to sourceWidth")]
            public double? SourceHeight
            {
                get
                {
                    return this.State.Get<double?>("SourceHeight", null);
                }
                set
                {
                    this.State.Set("SourceHeight", value);
                }
            }

            /// <summary>
            /// The width of the original chart when exported, unless an explicit chart.width is set. The width exported raster image is then multiplied by scale.
            /// </summary>
            [ConfigOption("sourceWidth", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the original chart when exported, unless an explicit chart.width is set. The width exported raster image is then multiplied by scale.")]
            public double? SourceWidth
            {
                get
                {
                    return this.State.Get<double?>("SourceWidth", null);
                }
                set
                {
                    this.State.Set("SourceWidth", value);
                }
            }

            /// <summary>
            /// Default MIME type for exporting if chart.exportChart() is called without specifying a type option. Possible values are image/png, image/jpeg, application/pdf and image/svg+xml.
            /// </summary>
            [ConfigOption("type", null)]
            [DefaultValue(@"image/png")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Default MIME type for exporting if chart.exportChart() is called without specifying a type option. Possible values are image/png, image/jpeg, application/pdf and image/svg+xml.")]
            public string Type
            {
                get
                {
                    return this.State.Get<string>("Type", @"image/png");
                }
                set
                {
                    this.State.Set("Type", value);
                }
            }

            /// <summary>
            /// The URL for the server module converting the SVG string to an image format. By default this points to Highslide Software's free web service.
            /// </summary>
            [ConfigOption("url", null)]
            [DefaultValue(@"http://export.highcharts.com")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The URL for the server module converting the SVG string to an image format. By default this points to Highslide Software's free web service.")]
            public string Url
            {
                get
                {
                    return this.State.Get<string>("Url", @"http://export.highcharts.com");
                }
                set
                {
                    this.State.Set("Url", value);
                }
            }

            /// <summary>
            /// The pixel width of charts exported to PNG or JPG. As of Highcharts 3.0, the default pixel width is a function of the chart.width or exporting.sourceWidth and the exporting.scale.
            /// </summary>
            [ConfigOption("width", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel width of charts exported to PNG or JPG. As of Highcharts 3.0, the default pixel width is a function of the chart.width or exporting.sourceWidth and the exporting.scale.")]
            public double? Width
            {
                get
                {
                    return this.State.Get<double?>("Width", null);
                }
                set
                {
                    this.State.Set("Width", value);
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


                list.Add("allowHTML", new ConfigOption("allowHTML", null, false, this.AllowHTML));

                list.Add("chartOptions", new ConfigOption("chartOptions", null, null, this.ChartOptions));

                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("fallbackToExportServer", new ConfigOption("fallbackToExportServer", null, true, this.FallbackToExportServer));

                list.Add("filename", new ConfigOption("filename", null, @"chart", this.Filename));

                list.Add("formAttributes", new ConfigOption("formAttributes", null, null, this.FormAttributes));

                list.Add("scale", new ConfigOption("scale", null, 2, this.Scale));

                list.Add("sourceHeight", new ConfigOption("sourceHeight", null, null, this.SourceHeight));

                list.Add("sourceWidth", new ConfigOption("sourceWidth", null, null, this.SourceWidth));

                list.Add("type", new ConfigOption("type", null, @"image/png", this.Type));

                list.Add("url", new ConfigOption("url", null, @"http://export.highcharts.com", this.Url));

                list.Add("width", new ConfigOption("width", null, null, this.Width));

                return list;
            }
        }


    
	        private ExportingEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ExportingEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new ExportingEvents();
					}
			
					return this.events;
				}
			}


    

        /// <summary>
        /// Options for the export related buttons, print and export. In addition to the default buttons listed here, custom buttons can be added. See navigation.buttonOptions for general options.
        /// </summary>
        public partial class Buttons : Observable
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
        /// Options for the export button.
        /// </summary>
        public partial class ContextButton : Observable
        {

    
            /// <summary>
            /// Alignment for the buttons.
            /// </summary>
            [ConfigOption("align", null)]
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
            [ConfigOption("enabled", null)]
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
            [ConfigOption("height", null)]
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
            /// A collection of config options for the menu items. Each options object consists of a text option which is a string to show in the menu item, as well as an onclick parameter which is a callback function to run on click. By default, there is the ""Print"" menu item plus one menu item for each of the available export types. Menu items can be customized by defining a new array of items and assigning  null to unwanted positions (see override example below).
            /// </summary>
            [ConfigOption("menuItems", JsonMode.AlwaysArray)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A collection of config options for the menu items. Each options object consists of a text option which is a string to show in the menu item, as well as an onclick parameter which is a callback function to run on click. By default, there is the ""Print"" menu item plus one menu item for each of the available export types. Menu items can be customized by defining a new array of items and assigning  null to unwanted positions (see override example below).")]
            public object[] MenuItems
            {
                get
                {
                    return this.State.Get<object[]>("MenuItems", null);
                }
                set
                {
                    this.State.Set("MenuItems", value);
                }
            }

            /// <summary>
            /// A click handler callback to use on the button directly instead of the popup menu.
            /// </summary>
            [ConfigOption("onclick", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A click handler callback to use on the button directly instead of the popup menu.")]
            public string Onclick
            {
                get
                {
                    return this.State.Get<string>("Onclick", "");
                }
                set
                {
                    this.State.Set("Onclick", value);
                }
            }

            /// <summary>
            /// The symbol for the button. Points to a definition function in the  Highcharts.Renderer.symbols collection. The default exportIcon function is part of the exporting module.
            /// </summary>
            [ConfigOption("symbol", null)]
            [DefaultValue(@"menu")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The symbol for the button. Points to a definition function in the  Highcharts.Renderer.symbols collection. The default exportIcon function is part of the exporting module.")]
            public string Symbol
            {
                get
                {
                    return this.State.Get<string>("Symbol", @"menu");
                }
                set
                {
                    this.State.Set("Symbol", value);
                }
            }

            /// <summary>
            /// See navigation.buttonOptions =&gt; symbolFill.
            /// </summary>
            [ConfigOption("symbolFill", null)]
            [DefaultValue(@"#A8BF77")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"See navigation.buttonOptions =&gt; symbolFill.")]
            public string SymbolFill
            {
                get
                {
                    return this.State.Get<string>("SymbolFill", @"#A8BF77");
                }
                set
                {
                    this.State.Set("SymbolFill", value);
                }
            }

            /// <summary>
            /// The pixel size of the symbol on the button.
            /// </summary>
            [ConfigOption("symbolSize", null)]
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
            [ConfigOption("symbolStroke", null)]
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
            [ConfigOption("symbolStrokeWidth", null)]
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
            [ConfigOption("symbolX", null)]
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
            [ConfigOption("symbolY", null)]
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
            [ConfigOption("text", null)]
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
            [ConfigOption("theme", null)]
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
            [ConfigOption("verticalAlign", null)]
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
            [ConfigOption("width", null)]
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
            /// The horizontal position of the button relative to the align option.
            /// </summary>
            [ConfigOption("x", null)]
            [DefaultValue(-10)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The horizontal position of the button relative to the align option.")]
            public double? x
            {
                get
                {
                    return this.State.Get<double?>("x", -10);
                }
                set
                {
                    this.State.Set("x", value);
                }
            }

            /// <summary>
            /// The vertical offset of the button's position relative to its verticalAlign.			 .
            /// </summary>
            [ConfigOption("y", null)]
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

                list.Add("menuItems", new ConfigOption("menuItems", new SerializationOptions("menuItems", JsonMode.AlwaysArray), null, this.MenuItems));

                list.Add("onclick", new ConfigOption("onclick", null, "", this.Onclick));

                list.Add("symbol", new ConfigOption("symbol", null, @"menu", this.Symbol));

                list.Add("symbolFill", new ConfigOption("symbolFill", null, @"#A8BF77", this.SymbolFill));

                list.Add("symbolSize", new ConfigOption("symbolSize", null, 14, this.SymbolSize));

                list.Add("symbolStroke", new ConfigOption("symbolStroke", null, @"#666", this.SymbolStroke));

                list.Add("symbolStrokeWidth", new ConfigOption("symbolStrokeWidth", null, 1, this.SymbolStrokeWidth));

                list.Add("symbolX", new ConfigOption("symbolX", null, 12.5, this.SymbolX));

                list.Add("symbolY", new ConfigOption("symbolY", null, 10.5, this.SymbolY));

                list.Add("text", new ConfigOption("text", null, @"null", this.Text));

                list.Add("theme", new ConfigOption("theme", null, null, this.Theme));

                list.Add("verticalAlign", new ConfigOption("verticalAlign", null, @"top", this.VerticalAlign));

                list.Add("width", new ConfigOption("width", null, 24, this.Width));

                list.Add("x", new ConfigOption("x", null, -10, this.x));

                list.Add("y", new ConfigOption("y", null, 0, this.y));

                return list;
            }
        }


    
	        private ContextButtonEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ContextButtonEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new ContextButtonEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class ContextButtonEvents : ComponentListeners
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


    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class ExportingEvents : ComponentListeners
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
            