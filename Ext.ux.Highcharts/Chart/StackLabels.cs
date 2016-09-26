
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
        /// The stack labels show the total value for each bar in a stacked column or bar chart. The label will be placed on top of	positive columns and below negative columns. In case of an inverted column chart or a bar chart the label is placed to 	the right of positive bars and to the left of negative bars.
        /// </summary>
        public partial class StackLabels : Observable
        {

    
            /// <summary>
            /// Defines the horizontal alignment of the stack total label.  Can be one of ""left"", ""center"" or ""right"". The default value is calculated at runtime and depends on orientation and whether  the stack is positive or negative.
            /// </summary>
            [ConfigOption("align", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Defines the horizontal alignment of the stack total label.  Can be one of ""left"", ""center"" or ""right"". The default value is calculated at runtime and depends on orientation and whether  the stack is positive or negative.")]
            public string Align
            {
                get
                {
                    return this.State.Get<string>("Align", "");
                }
                set
                {
                    this.State.Set("Align", value);
                }
            }

            /// <summary>
            /// Enable or disable the stack total labels.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Enable or disable the stack total labels.")]
            public bool? Enabled
            {
                get
                {
                    return this.State.Get<bool?>("Enabled", false);
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// A format string for the data label. Available variables are the same as for formatter.
            /// </summary>
            [ConfigOption("format", null)]
            [DefaultValue(@"{total}")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"A format string for the data label. Available variables are the same as for formatter.")]
            public string Format
            {
                get
                {
                    return this.State.Get<string>("Format", @"{total}");
                }
                set
                {
                    this.State.Set("Format", value);
                }
            }

            /// <summary>
            /// Callback JavaScript function to format the label. The value is  given by this.total. Defaults to: function() {	return this.total;}
            /// </summary>
            [ConfigOption("formatter", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Callback JavaScript function to format the label. The value is  given by this.total. Defaults to: function() {	return this.total;}")]
            public string Formatter
            {
                get
                {
                    return this.State.Get<string>("Formatter", "");
                }
                set
                {
                    this.State.Set("Formatter", value);
                }
            }

            /// <summary>
            /// Rotation of the labels in degrees.
            /// </summary>
            [ConfigOption("rotation", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Rotation of the labels in degrees.")]
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
            /// CSS styles for the label.
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue(@"{ ""color"": ""#000000"", ""fontSize"": ""11px"", ""fontWeight"": ""bold"", ""textShadow"": ""0 0 6px contrast, 00 3px contrast"" }")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"CSS styles for the label.")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", @"{ ""color"": ""#000000"", ""fontSize"": ""11px"", ""fontWeight"": ""bold"", ""textShadow"": ""0 0 6px contrast, 00 3px contrast"" }");
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// The text alignment for the label. While align determines where the texts anchor point is placed with regards to the stack, textAlign determines how the text is aligned against its anchor point. Possible values are ""left"", ""center"" and ""right"". The default value is calculated at runtime and depends on orientation and whether the stack is positive or negative.
            /// </summary>
            [ConfigOption("textAlign", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The text alignment for the label. While align determines where the texts anchor point is placed with regards to the stack, textAlign determines how the text is aligned against its anchor point. Possible values are ""left"", ""center"" and ""right"". The default value is calculated at runtime and depends on orientation and whether the stack is positive or negative.")]
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
            /// Defines the vertical alignment of the stack total label. Can be one of ""top"", ""middle"" or ""bottom"". The default value is calculated at runtime and depends on orientation and whether  the stack is positive or negative.
            /// </summary>
            [ConfigOption("verticalAlign", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Defines the vertical alignment of the stack total label. Can be one of ""top"", ""middle"" or ""bottom"". The default value is calculated at runtime and depends on orientation and whether  the stack is positive or negative.")]
            public string VerticalAlign
            {
                get
                {
                    return this.State.Get<string>("VerticalAlign", "");
                }
                set
                {
                    this.State.Set("VerticalAlign", value);
                }
            }

            /// <summary>
            /// The x position offset of the label relative to the left of the stacked bar. The default value is calculated at runtime and depends on orientation and whether the stack is positive or negative.
            /// </summary>
            [ConfigOption("x", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The x position offset of the label relative to the left of the stacked bar. The default value is calculated at runtime and depends on orientation and whether the stack is positive or negative.")]
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
            /// The y position offset of the label relative to the tick position on the axis. The default value is calculated at runtime and depends on orientation and whether  the stack is positive or negative.
            /// </summary>
            [ConfigOption("y", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The y position offset of the label relative to the tick position on the axis. The default value is calculated at runtime and depends on orientation and whether  the stack is positive or negative.")]
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


                list.Add("align", new ConfigOption("align", null, "", this.Align));

                list.Add("enabled", new ConfigOption("enabled", null, false, this.Enabled));

                list.Add("format", new ConfigOption("format", null, @"{total}", this.Format));

                list.Add("formatter", new ConfigOption("formatter", null, "", this.Formatter));

                list.Add("rotation", new ConfigOption("rotation", null, 0, this.Rotation));

                list.Add("style", new ConfigOption("style", null, @"{ ""color"": ""#000000"", ""fontSize"": ""11px"", ""fontWeight"": ""bold"", ""textShadow"": ""0 0 6px contrast, 00 3px contrast"" }", this.Style));

                list.Add("textAlign", new ConfigOption("textAlign", null, "", this.TextAlign));

                list.Add("useHTML", new ConfigOption("useHTML", null, false, this.UseHTML));

                list.Add("verticalAlign", new ConfigOption("verticalAlign", null, "", this.VerticalAlign));

                list.Add("x", new ConfigOption("x", null, null, this.x));

                list.Add("y", new ConfigOption("y", null, null, this.y));

                return list;
            }
        }


    
	        private StackLabelsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public StackLabelsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new StackLabelsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class StackLabelsEvents : ComponentListeners
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
            