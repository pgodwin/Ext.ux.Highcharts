
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
        /// The chart's main title.
        /// </summary>
        public partial class Title : Observable
        {

    
            /// <summary>
            /// The horizontal alignment of the title. Can be one of ""left"", ""center"" and ""right"".
            /// </summary>
            [ConfigOption("align", null)]
            [DefaultValue(@"center")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The horizontal alignment of the title. Can be one of ""left"", ""center"" and ""right"".")]
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
            /// When the title is floating, the plot area will not move to make space for it.
            /// </summary>
            [ConfigOption("floating", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When the title is floating, the plot area will not move to make space for it.")]
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
            /// The margin between the title and the plot area, or if a subtitle is present, the margin between the subtitle and the plot area.
            /// </summary>
            [ConfigOption("margin", null)]
            [DefaultValue(15)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The margin between the title and the plot area, or if a subtitle is present, the margin between the subtitle and the plot area.")]
            public double? Margin
            {
                get
                {
                    return this.State.Get<double?>("Margin", 15);
                }
                set
                {
                    this.State.Set("Margin", value);
                }
            }

            /// <summary>
            /// CSS styles for the title. Use this for font styling, but use align, x and y for text alignment.
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue(@"{ ""color"": ""#333333"", ""fontSize"": ""18px"" }")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the title. Use this for font styling, but use align, x and y for text alignment.")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", @"{ ""color"": ""#333333"", ""fontSize"": ""18px"" }");
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// The title of the chart. To disable the title, set the text to null.
            /// </summary>
            [ConfigOption("text", null)]
            [DefaultValue(@"Chart title")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The title of the chart. To disable the title, set the text to null.")]
            public string Text
            {
                get
                {
                    return this.State.Get<string>("Text", @"Chart title");
                }
                set
                {
                    this.State.Set("Text", value);
                }
            }

            /// <summary>
            /// Whether to use HTML to render the text.
            /// </summary>
            [ConfigOption("useHTML", null)]
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
            [ConfigOption("verticalAlign", null)]
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
            /// The x position of the title relative to the alignment within chart.spacingLeft and chart.spacingRight.
            /// </summary>
            [ConfigOption("x", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The x position of the title relative to the alignment within chart.spacingLeft and chart.spacingRight.")]
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
            /// The y position of the title relative to the alignment within chart.spacingTop and chart.spacingBottom. By default it depends on the font size.
            /// </summary>
            [ConfigOption("y", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The y position of the title relative to the alignment within chart.spacingTop and chart.spacingBottom. By default it depends on the font size.")]
            public double? y
            {
                get
                {
                    return this.State.Get<double?>("y", null);
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

                list.Add("margin", new ConfigOption("margin", null, 15, this.Margin));

                list.Add("style", new ConfigOption("style", null, @"{ ""color"": ""#333333"", ""fontSize"": ""18px"" }", this.Style));

                list.Add("text", new ConfigOption("text", null, @"Chart title", this.Text));

                list.Add("useHTML", new ConfigOption("useHTML", null, false, this.UseHTML));

                list.Add("verticalAlign", new ConfigOption("verticalAlign", null, @" ", this.VerticalAlign));

                list.Add("x", new ConfigOption("x", null, 0, this.x));

                list.Add("y", new ConfigOption("y", null, null, this.y));

                return list;
            }
        }


    
	        private TitleEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public TitleEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new TitleEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class TitleEvents : ComponentListeners
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
            