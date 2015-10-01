
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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


    

        }


        }

        
}
            