
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
        /// Text labels for the plot bands
        /// </summary>
        public partial class Label : Observable
        {

    
            /// <summary>
            /// Horizontal alignment of the label. Can be one of ""left"", ""center"" or ""right"".
            /// </summary>
            [ConfigOption("align", null)]
            [DefaultValue(@"center")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Horizontal alignment of the label. Can be one of ""left"", ""center"" or ""right"".")]
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
            /// Rotation of the text label in degrees .
            /// </summary>
            [ConfigOption("rotation", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Rotation of the text label in degrees .")]
            public double? Rotation
            {
                get
                {
                    return this.State.Get<double?>("Rotation", 0);
                }
                set
                {
                    this.State.Set("Rotation", value);
                }
            }

            /// <summary>
            /// CSS styles for the text label.
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the text label.")]
            public object Style
            {
                get
                {
                    return this.State.Get<object>("Style", null);
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// The string text itself. A subset of HTML is supported.
            /// </summary>
            [ConfigOption("text", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The string text itself. A subset of HTML is supported.")]
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
            /// The text alignment for the label. While align determines where the texts anchor point is placed within the plot band, textAlign determines how the text is aligned against its anchor point. Possible values are ""left"", ""center"" and ""right"". Defaults to the same as the align option.
            /// </summary>
            [ConfigOption("textAlign", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The text alignment for the label. While align determines where the texts anchor point is placed within the plot band, textAlign determines how the text is aligned against its anchor point. Possible values are ""left"", ""center"" and ""right"". Defaults to the same as the align option.")]
            public string TextAlign
            {
                get
                {
                    return this.State.Get<string>("TextAlign", "");
                }
                set
                {
                    this.State.Set("TextAlign", value);
                }
            }

            /// <summary>
            /// Whether to use HTML to render the labels.
            /// </summary>
            [ConfigOption("useHTML", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to use HTML to render the labels.")]
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
            /// Vertical alignment of the label relative to the plot band. Can be one of ""top"", ""middle"" or ""bottom"".
            /// </summary>
            [ConfigOption("verticalAlign", null)]
            [DefaultValue(@"top")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Vertical alignment of the label relative to the plot band. Can be one of ""top"", ""middle"" or ""bottom"".")]
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
            /// Horizontal position relative the alignment. Default varies by orientation.
            /// </summary>
            [ConfigOption("x", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Horizontal position relative the alignment. Default varies by orientation.")]
            public double? x
            {
                get
                {
                    return this.State.Get<double?>("x", null);
                }
                set
                {
                    this.State.Set("x", value);
                }
            }

            /// <summary>
            /// Vertical position of the text baseline relative to the alignment. Default varies by orientation.
            /// </summary>
            [ConfigOption("y", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Vertical position of the text baseline relative to the alignment. Default varies by orientation.")]
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

                list.Add("rotation", new ConfigOption("rotation", null, 0, this.Rotation));

                list.Add("style", new ConfigOption("style", null, null, this.Style));

                list.Add("text", new ConfigOption("text", null, "", this.Text));

                list.Add("textAlign", new ConfigOption("textAlign", null, "", this.TextAlign));

                list.Add("useHTML", new ConfigOption("useHTML", null, false, this.UseHTML));

                list.Add("verticalAlign", new ConfigOption("verticalAlign", null, @"top", this.VerticalAlign));

                list.Add("x", new ConfigOption("x", null, null, this.x));

                list.Add("y", new ConfigOption("y", null, null, this.y));

                return list;
            }
        }


    
	        private LabelEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public LabelEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new LabelEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class LabelEvents : ComponentListeners
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
            