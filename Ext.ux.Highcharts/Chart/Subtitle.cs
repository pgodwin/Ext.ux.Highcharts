
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
        /// The chart's subtitle
        /// </summary>
        public partial class Subtitle : Observable
        {

    
            /// <summary>
            /// The horizontal alignment of the subtitle. Can be one of ""left"", ""center"" and ""right"".
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"center")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The horizontal alignment of the subtitle. Can be one of ""left"", ""center"" and ""right"".")]
            public string Align
            {
                get
                {
                    return this.State.Get<string>("Align", @"center");
                }
                set
                {
                    this.State.Set("Align", value);
                }
            }

            /// <summary>
            /// When the subtitle is floating, the plot area will not move to make space for it.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When the subtitle is floating, the plot area will not move to make space for it.")]
            public bool? Floating
            {
                get
                {
                    return this.State.Get<bool?>("Floating", false);
                }
                set
                {
                    this.State.Set("Floating", value);
                }
            }

            /// <summary>
            /// CSS styles for the title. Exact positioning of the title can be achieved by changing the margin property, or by adding position: ""absolute"" and  left and top properties.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"{ ""color"": ""#555555"" }")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the title. Exact positioning of the title can be achieved by changing the margin property, or by adding position: ""absolute"" and  left and top properties.")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", @"{ ""color"": ""#555555"" }");
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// The subtitle of the chart.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The subtitle of the chart.")]
            public string Text
            {
                get
                {
                    return this.State.Get<string>("Text", "");
                }
                set
                {
                    this.State.Set("Text", value);
                }
            }

            /// <summary>
            /// Whether to use HTML to render the text.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to use HTML to render the text.")]
            public bool? UseHTML
            {
                get
                {
                    return this.State.Get<bool?>("UseHTML", false);
                }
                set
                {
                    this.State.Set("UseHTML", value);
                }
            }

            /// <summary>
            /// The vertical alignment of the title. Can be one of ""top"", ""middle"" and ""bottom"". When a value is given, the title behaves as floating.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@" ")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The vertical alignment of the title. Can be one of ""top"", ""middle"" and ""bottom"". When a value is given, the title behaves as floating.")]
            public string VerticalAlign
            {
                get
                {
                    return this.State.Get<string>("VerticalAlign", @" ");
                }
                set
                {
                    this.State.Set("VerticalAlign", value);
                }
            }

            /// <summary>
            /// The x position of the subtitle relative to the alignment within chart.spacingLeft and chart.spacingRight.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The x position of the subtitle relative to the alignment within chart.spacingLeft and chart.spacingRight.")]
            public double? x
            {
                get
                {
                    return this.State.Get<double?>("x", 0);
                }
                set
                {
                    this.State.Set("x", value);
                }
            }

            /// <summary>
            /// The y position of the subtitle relative to the alignment within chart.spacingTop and chart.spacingBottom. By default the subtitle is laid out below the title unless the title is floating.
            /// </summary>
            [ConfigOption]
            [DefaultValue( null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The y position of the subtitle relative to the alignment within chart.spacingTop and chart.spacingBottom. By default the subtitle is laid out below the title unless the title is floating.")]
            public double? y
            {
                get
                {
                    return this.State.Get<double?>("y",  null);
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


                list.Add("align", new ConfigOption("align", null, @"center", this.Align));

                list.Add("floating", new ConfigOption("floating", null, false, this.Floating));

                list.Add("style", new ConfigOption("style", null, @"{ ""color"": ""#555555"" }", this.Style));

                list.Add("text", new ConfigOption("text", null, "", this.Text));

                list.Add("useHTML", new ConfigOption("useHTML", null, false, this.UseHTML));

                list.Add("verticalAlign", new ConfigOption("verticalAlign", null, @" ", this.VerticalAlign));

                list.Add("x", new ConfigOption("x", null, 0, this.x));

                list.Add("y", new ConfigOption("y", null,  null, this.y));

                return list;
            }
        }


    

        }

        
}
            