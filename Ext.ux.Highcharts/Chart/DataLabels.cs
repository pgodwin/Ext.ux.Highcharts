
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
        /// 
        /// </summary>
        public partial class DataLabels : Observable
        {

    
            /// <summary>
            /// The alignment of the data label compared to the point.  If right, the right side of the label should be touching the point. For points with an extent, like columns, the alignments also dictates how to align it inside the box, as given with the inside option. Can be one of ""left"", ""center"" or ""right"".
            /// </summary>
            [ConfigOption("align", null)]
            [DefaultValue(@"center")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The alignment of the data label compared to the point.  If right, the right side of the label should be touching the point. For points with an extent, like columns, the alignments also dictates how to align it inside the box, as given with the inside option. Can be one of ""left"", ""center"" or ""right"".")]
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
            /// Whether to allow data labels to overlap. To make the labels less sensitive for overlapping, the dataLabels.padding can be set to 0.
            /// </summary>
            [ConfigOption("allowOverlap", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to allow data labels to overlap. To make the labels less sensitive for overlapping, the dataLabels.padding can be set to 0.")]
            public bool? AllowOverlap
            {
                get
                {
                    return this.State.Get<bool?>("AllowOverlap", false);
                }
                set
                {
                    this.State.Set("AllowOverlap", value);
                }
            }

            /// <summary>
            /// The background color or gradient for the data label. Defaults to undefined.
            /// </summary>
            [ConfigOption("backgroundColor", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The background color or gradient for the data label. Defaults to undefined.")]
            public string BackgroundColor
            {
                get
                {
                    return this.State.Get<string>("BackgroundColor", "");
                }
                set
                {
                    this.State.Set("BackgroundColor", value);
                }
            }

            /// <summary>
            /// The border color for the data label. Defaults to undefined.
            /// </summary>
            [ConfigOption("borderColor", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The border color for the data label. Defaults to undefined.")]
            public string BorderColor
            {
                get
                {
                    return this.State.Get<string>("BorderColor", "");
                }
                set
                {
                    this.State.Set("BorderColor", value);
                }
            }

            /// <summary>
            /// The border radius in pixels for the data label.
            /// </summary>
            [ConfigOption("borderRadius", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The border radius in pixels for the data label.")]
            public double? BorderRadius
            {
                get
                {
                    return this.State.Get<double?>("BorderRadius", 0);
                }
                set
                {
                    this.State.Set("BorderRadius", value);
                }
            }

            /// <summary>
            /// The border width in pixels for the data label.
            /// </summary>
            [ConfigOption("borderWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The border width in pixels for the data label.")]
            public double? BorderWidth
            {
                get
                {
                    return this.State.Get<double?>("BorderWidth", 0);
                }
                set
                {
                    this.State.Set("BorderWidth", value);
                }
            }

            /// <summary>
            /// The text color for the data labels. Defaults to null.
            /// </summary>
            [ConfigOption("color", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The text color for the data labels. Defaults to null.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", "");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// Whether to hide data labels that are outside the plot area. By default, the data label is moved inside the plot area according to the overflow option.
            /// </summary>
            [ConfigOption("crop", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to hide data labels that are outside the plot area. By default, the data label is moved inside the plot area according to the overflow option.")]
            public bool? Crop
            {
                get
                {
                    return this.State.Get<bool?>("Crop", true);
                }
                set
                {
                    this.State.Set("Crop", value);
                }
            }

            /// <summary>
            /// Whether to defer displaying the data labels until the initial series animation has finished.
            /// </summary>
            [ConfigOption("defer", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to defer displaying the data labels until the initial series animation has finished.")]
            public bool? Defer
            {
                get
                {
                    return this.State.Get<bool?>("Defer", true);
                }
                set
                {
                    this.State.Set("Defer", value);
                }
            }

            /// <summary>
            /// Enable or disable the data labels.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the data labels.")]
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
            [DefaultValue(@"{y}")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A format string for the data label. Available variables are the same as for formatter.")]
            public string Format
            {
                get
                {
                    return this.State.Get<string>("Format", @"{y}");
                }
                set
                {
                    this.State.Set("Format", value);
                }
            }

            /// <summary>
            /// Callback JavaScript function to format the data label. Note that if a format is defined, the format takes precedence and the formatter is ignored. Available data are:  this.percentage  Stacked series and pies only. The point's percentage of the total.  this.point  The point object. The point name, if defined, is available through this.point.name.  this.series:  The series object. The series name is available through this.series.name.  this.total  Stacked series only. The total value at this point's x value.				  this.x:  The x value.  this.y:  The y value.
            /// </summary>
            [ConfigOption("formatter", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Callback JavaScript function to format the data label. Note that if a format is defined, the format takes precedence and the formatter is ignored. Available data are:  this.percentage  Stacked series and pies only. The point's percentage of the total.  this.point  The point object. The point name, if defined, is available through this.point.name.  this.series:  The series object. The series name is available through this.series.name.  this.total  Stacked series only. The total value at this point's x value.				  this.x:  The x value.  this.y:  The y value.")]
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
            /// For points with an extent, like columns, whether to align the data label inside the box or to the actual value point. Defaults to false in most cases, true in stacked columns.
            /// </summary>
            [ConfigOption("inside", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"For points with an extent, like columns, whether to align the data label inside the box or to the actual value point. Defaults to false in most cases, true in stacked columns.")]
            public bool? Inside
            {
                get
                {
                    return this.State.Get<bool?>("Inside", null);
                }
                set
                {
                    this.State.Set("Inside", value);
                }
            }

            /// <summary>
            /// How to handle data labels that flow outside the plot area. The default is justify, which aligns them inside the plot area. For columns and bars, this means it will be moved inside the bar. To display data labels outside the plot area, set crop to false and overflow to ""none"".
            /// </summary>
            [ConfigOption("overflow", null)]
            [DefaultValue(@"justify")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"How to handle data labels that flow outside the plot area. The default is justify, which aligns them inside the plot area. For columns and bars, this means it will be moved inside the bar. To display data labels outside the plot area, set crop to false and overflow to ""none"".")]
            public string Overflow
            {
                get
                {
                    return this.State.Get<string>("Overflow", @"justify");
                }
                set
                {
                    this.State.Set("Overflow", value);
                }
            }

            /// <summary>
            /// When either the borderWidth or the backgroundColor is set, this		is the padding within the box.
            /// </summary>
            [ConfigOption("padding", null)]
            [DefaultValue(5)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When either the borderWidth or the backgroundColor is set, this		is the padding within the box.")]
            public double? Padding
            {
                get
                {
                    return this.State.Get<double?>("Padding", 5);
                }
                set
                {
                    this.State.Set("Padding", value);
                }
            }

            /// <summary>
            /// Text rotation in degrees. Note that due to a more complex structure, backgrounds, borders and padding will be lost on a rotated data label.
            /// </summary>
            [ConfigOption("rotation", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Text rotation in degrees. Note that due to a more complex structure, backgrounds, borders and padding will be lost on a rotated data label.")]
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
            /// The shadow of the box. Works best with borderWidth or backgroundColor. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.
            /// </summary>
            [ConfigOption("shadow", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The shadow of the box. Works best with borderWidth or backgroundColor. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.")]
            public object Shadow
            {
                get
                {
                    return this.State.Get<object>("Shadow", null);
                }
                set
                {
                    this.State.Set("Shadow", value);
                }
            }

            /// <summary>
            /// The name of a symbol to use for the border around the label. Symbols are predefined functions on the Renderer object.
            /// </summary>
            [ConfigOption("shape", null)]
            [DefaultValue(@"square")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The name of a symbol to use for the border around the label. Symbols are predefined functions on the Renderer object.")]
            public string Shape
            {
                get
                {
                    return this.State.Get<string>("Shape", @"square");
                }
                set
                {
                    this.State.Set("Shape", value);
                }
            }

            /// <summary>
            /// Styles for the label.
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue(@"{""color"": ""contrast"", ""fontSize"": ""11px"", ""fontWeight"": ""bold"", ""textShadow"": ""0 0 6px contrast, 0 0 3px contrast"" }")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Styles for the label.")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", @"{""color"": ""contrast"", ""fontSize"": ""11px"", ""fontWeight"": ""bold"", ""textShadow"": ""0 0 6px contrast, 0 0 3px contrast"" }");
                }
                set
                {
                    this.State.Set("Style", value);
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
            /// The vertical alignment of a data label. Can be one of top, middle or bottom. The default value depends on the data, for instance in a column chart, the label is above positive values and below negative values.
            /// </summary>
            [ConfigOption("verticalAlign", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The vertical alignment of a data label. Can be one of top, middle or bottom. The default value depends on the data, for instance in a column chart, the label is above positive values and below negative values.")]
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
            /// The x position offset of the label relative to the point. 
            /// </summary>
            [ConfigOption("x", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The x position offset of the label relative to the point. ")]
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
            /// The y position offset of the label relative to the point. 
            /// </summary>
            [ConfigOption("y", null)]
            [DefaultValue(-6)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The y position offset of the label relative to the point. ")]
            public double? y
            {
                get
                {
                    return this.State.Get<double?>("y", -6);
                }
                set
                {
                    this.State.Set("y", value);
                }
            }

            /// <summary>
            /// The Z index of the data labels. The default Z index puts it above the series. Use a Z index of 2 to display it behind the series.
            /// </summary>
            [ConfigOption("zIndex", null)]
            [DefaultValue(6)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The Z index of the data labels. The default Z index puts it above the series. Use a Z index of 2 to display it behind the series.")]
            public double? ZIndex
            {
                get
                {
                    return this.State.Get<double?>("ZIndex", 6);
                }
                set
                {
                    this.State.Set("ZIndex", value);
                }
            }

            /// <summary>
            /// X offset of the higher data labels relative to the point value.
            /// </summary>
            [ConfigOption("xHigh", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"X offset of the higher data labels relative to the point value.")]
            public double? XHigh
            {
                get
                {
                    return this.State.Get<double?>("XHigh", 0);
                }
                set
                {
                    this.State.Set("XHigh", value);
                }
            }

            /// <summary>
            /// X offset of the lower data labels relative to the point value.
            /// </summary>
            [ConfigOption("xLow", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"X offset of the lower data labels relative to the point value.")]
            public double? XLow
            {
                get
                {
                    return this.State.Get<double?>("XLow", 0);
                }
                set
                {
                    this.State.Set("XLow", value);
                }
            }

            /// <summary>
            /// Y offset of the higher data labels relative to the point value.
            /// </summary>
            [ConfigOption("yHigh", null)]
            [DefaultValue(-6)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Y offset of the higher data labels relative to the point value.")]
            public double? YHigh
            {
                get
                {
                    return this.State.Get<double?>("YHigh", -6);
                }
                set
                {
                    this.State.Set("YHigh", value);
                }
            }

            /// <summary>
            /// Y offset of the lower data labels relative to the point value.
            /// </summary>
            [ConfigOption("yLow", null)]
            [DefaultValue(16)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Y offset of the lower data labels relative to the point value.")]
            public double? YLow
            {
                get
                {
                    return this.State.Get<double?>("YLow", 16);
                }
                set
                {
                    this.State.Set("YLow", value);
                }
            }

            /// <summary>
            /// The color of the line connecting the data label to the pie slice. The default color is the same as the point's color.
            /// </summary>
            [ConfigOption("connectorColor", null)]
            [DefaultValue(@"{point.color}")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the line connecting the data label to the pie slice. The default color is the same as the point's color.")]
            public string ConnectorColor
            {
                get
                {
                    return this.State.Get<string>("ConnectorColor", @"{point.color}");
                }
                set
                {
                    this.State.Set("ConnectorColor", value);
                }
            }

            /// <summary>
            /// The distance from the data label to the connector.
            /// </summary>
            [ConfigOption("connectorPadding", null)]
            [DefaultValue(5)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The distance from the data label to the connector.")]
            public double? ConnectorPadding
            {
                get
                {
                    return this.State.Get<double?>("ConnectorPadding", 5);
                }
                set
                {
                    this.State.Set("ConnectorPadding", value);
                }
            }

            /// <summary>
            /// The width of the line connecting the data label to the pie slice.
            /// </summary>
            [ConfigOption("connectorWidth", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the line connecting the data label to the pie slice.")]
            public double? ConnectorWidth
            {
                get
                {
                    return this.State.Get<double?>("ConnectorWidth", 1);
                }
                set
                {
                    this.State.Set("ConnectorWidth", value);
                }
            }

            /// <summary>
            /// The distance of the data label from the pie's edge. Negative numbers put the data label on top of the pie slices. Connectors are only shown for data labels outside the pie.
            /// </summary>
            [ConfigOption("distance", null)]
            [DefaultValue(30)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The distance of the data label from the pie's edge. Negative numbers put the data label on top of the pie slices. Connectors are only shown for data labels outside the pie.")]
            public double? Distance
            {
                get
                {
                    return this.State.Get<double?>("Distance", 30);
                }
                set
                {
                    this.State.Set("Distance", value);
                }
            }

            /// <summary>
            /// Whether to render the connector as a soft arc or a line with sharp break.
            /// </summary>
            [ConfigOption("softConnector", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to render the connector as a soft arc or a line with sharp break.")]
            public bool? SoftConnector
            {
                get
                {
                    return this.State.Get<bool?>("SoftConnector", true);
                }
                set
                {
                    this.State.Set("SoftConnector", value);
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

                list.Add("allowOverlap", new ConfigOption("allowOverlap", null, false, this.AllowOverlap));

                list.Add("backgroundColor", new ConfigOption("backgroundColor", null, "", this.BackgroundColor));

                list.Add("borderColor", new ConfigOption("borderColor", null, "", this.BorderColor));

                list.Add("borderRadius", new ConfigOption("borderRadius", null, 0, this.BorderRadius));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 0, this.BorderWidth));

                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("crop", new ConfigOption("crop", null, true, this.Crop));

                list.Add("defer", new ConfigOption("defer", null, true, this.Defer));

                list.Add("enabled", new ConfigOption("enabled", null, false, this.Enabled));

                list.Add("format", new ConfigOption("format", null, @"{y}", this.Format));

                list.Add("formatter", new ConfigOption("formatter", null, "", this.Formatter));

                list.Add("inside", new ConfigOption("inside", null, null, this.Inside));

                list.Add("overflow", new ConfigOption("overflow", null, @"justify", this.Overflow));

                list.Add("padding", new ConfigOption("padding", null, 5, this.Padding));

                list.Add("rotation", new ConfigOption("rotation", null, 0, this.Rotation));

                list.Add("shadow", new ConfigOption("shadow", null, null, this.Shadow));

                list.Add("shape", new ConfigOption("shape", null, @"square", this.Shape));

                list.Add("style", new ConfigOption("style", null, @"{""color"": ""contrast"", ""fontSize"": ""11px"", ""fontWeight"": ""bold"", ""textShadow"": ""0 0 6px contrast, 0 0 3px contrast"" }", this.Style));

                list.Add("useHTML", new ConfigOption("useHTML", null, false, this.UseHTML));

                list.Add("verticalAlign", new ConfigOption("verticalAlign", null, "", this.VerticalAlign));

                list.Add("x", new ConfigOption("x", null, 0, this.x));

                list.Add("y", new ConfigOption("y", null, -6, this.y));

                list.Add("zIndex", new ConfigOption("zIndex", null, 6, this.ZIndex));

                list.Add("xHigh", new ConfigOption("xHigh", null, 0, this.XHigh));

                list.Add("xLow", new ConfigOption("xLow", null, 0, this.XLow));

                list.Add("yHigh", new ConfigOption("yHigh", null, -6, this.YHigh));

                list.Add("yLow", new ConfigOption("yLow", null, 16, this.YLow));

                list.Add("connectorColor", new ConfigOption("connectorColor", null, @"{point.color}", this.ConnectorColor));

                list.Add("connectorPadding", new ConfigOption("connectorPadding", null, 5, this.ConnectorPadding));

                list.Add("connectorWidth", new ConfigOption("connectorWidth", null, 1, this.ConnectorWidth));

                list.Add("distance", new ConfigOption("distance", null, 30, this.Distance));

                list.Add("softConnector", new ConfigOption("softConnector", null, true, this.SoftConnector));

                return list;
            }
        }


    
	        private DataLabelsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public DataLabelsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new DataLabelsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class DataLabelsEvents : ComponentListeners
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
            