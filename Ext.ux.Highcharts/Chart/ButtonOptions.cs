
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
        /// A collection of options for buttons appearing in the exporting module.
        /// </summary>
        public partial class ButtonOptions : Observable
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
            /// Fill color for the symbol within the button.
            /// </summary>
            [ConfigOption("symbolFill", null)]
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


    
	        private ButtonOptionsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ButtonOptionsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new ButtonOptionsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class ButtonOptionsEvents : ComponentListeners
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
            