
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
        /// Options regarding the chart area and plot area as well as general chart options.
        /// </summary>
        public partial class Chart : Observable
        {

    
            /// <summary>
            /// When using multiple axis, the ticks of two or more opposite axes will  automatically be aligned by adding ticks to the axis or axes with the least ticks. This can be prevented by setting alignTicks to false. If the grid lines look messy, it's a good idea to hide them for the secondary axis by setting gridLineWidth to 0.
            /// </summary>
            [ConfigOption("alignTicks", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When using multiple axis, the ticks of two or more opposite axes will  automatically be aligned by adding ticks to the axis or axes with the least ticks. This can be prevented by setting alignTicks to false. If the grid lines look messy, it's a good idea to hide them for the secondary axis by setting gridLineWidth to 0.")]
            public bool? AlignTicks
            {
                get
                {
                    return this.State.Get<bool?>("AlignTicks", true);
                }
                set
                {
                    this.State.Set("AlignTicks", value);
                }
            }

            /// <summary>
            /// Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the  initial series animation, see plotOptions.series.animation.  The animation can either be set as a boolean or a configuration object. If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:   	duration 	The duration of the animation in milliseconds. 	 	easing 	When using jQuery as the general framework, the easing can be set to linear or 	swing. More easing functions are available with the use of jQuery plug-ins, most notably 	the jQuery UI suite. See the jQuery docs. When using  	MooTools as the general framework, use the property name transition instead  	of easing. 
            /// </summary>
            [ConfigOption("animation", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Set the overall animation for all chart updating. Animation can be disabled throughout the chart by setting it to false here. It can be overridden for each individual API method as a function parameter. The only animation not affected by this option is the  initial series animation, see plotOptions.series.animation.  The animation can either be set as a boolean or a configuration object. If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:   	duration 	The duration of the animation in milliseconds. 	 	easing 	When using jQuery as the general framework, the easing can be set to linear or 	swing. More easing functions are available with the use of jQuery plug-ins, most notably 	the jQuery UI suite. See the jQuery docs. When using  	MooTools as the general framework, use the property name transition instead  	of easing. ")]
            public object Animation
            {
                get
                {
                    return this.State.Get<object>("Animation", null);
                }
                set
                {
                    this.State.Set("Animation", value);
                }
            }

            /// <summary>
            /// The background color or gradient for the outer chart area.
            /// </summary>
            [ConfigOption("backgroundColor", null)]
            [DefaultValue(@"#FFFFFF")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The background color or gradient for the outer chart area.")]
            public string BackgroundColor
            {
                get
                {
                    return this.State.Get<string>("BackgroundColor", @"#FFFFFF");
                }
                set
                {
                    this.State.Set("BackgroundColor", value);
                }
            }

            /// <summary>
            /// The color of the outer chart border.
            /// </summary>
            [ConfigOption("borderColor", null)]
            [DefaultValue(@"#4572A7")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the outer chart border.")]
            public string BorderColor
            {
                get
                {
                    return this.State.Get<string>("BorderColor", @"#4572A7");
                }
                set
                {
                    this.State.Set("BorderColor", value);
                }
            }

            /// <summary>
            /// The corner radius of the outer chart border.
            /// </summary>
            [ConfigOption("borderRadius", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The corner radius of the outer chart border.")]
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
            /// The pixel width of the outer chart border.
            /// </summary>
            [ConfigOption("borderWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel width of the outer chart border.")]
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
            /// A CSS class name to apply to the charts container div, allowing unique CSS styling for each chart.
            /// </summary>
            [ConfigOption("className", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A CSS class name to apply to the charts container div, allowing unique CSS styling for each chart.")]
            public string ClassName
            {
                get
                {
                    return this.State.Get<string>("ClassName", "");
                }
                set
                {
                    this.State.Set("ClassName", value);
                }
            }

            /// <summary>
            /// Alias of type.
            /// </summary>
            [ConfigOption("defaultSeriesType", null)]
            [DefaultValue(@"line")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Alias of type.")]
            public string DefaultSeriesType
            {
                get
                {
                    return this.State.Get<string>("DefaultSeriesType", @"line");
                }
                set
                {
                    this.State.Set("DefaultSeriesType", value);
                }
            }

            /// <summary>
            /// An explicit height for the chart. By default the height is calculated from the offset height of the containing element, or 400 pixels if the containing element's height is 0.
            /// </summary>
            [ConfigOption("height", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An explicit height for the chart. By default the height is calculated from the offset height of the containing element, or 400 pixels if the containing element's height is 0.")]
            public double? Height
            {
                get
                {
                    return this.State.Get<double?>("Height", null);
                }
                set
                {
                    this.State.Set("Height", value);
                }
            }

            /// <summary>
            /// If true, the axes will scale to the remaining visible series once one series is hidden. If false, hiding and showing a series will not affect the axes or the other series. For stacks, once one series within the stack is hidden, the rest of the stack will close in around it even if the axis is not affected.
            /// </summary>
            [ConfigOption("ignoreHiddenSeries", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If true, the axes will scale to the remaining visible series once one series is hidden. If false, hiding and showing a series will not affect the axes or the other series. For stacks, once one series within the stack is hidden, the rest of the stack will close in around it even if the axis is not affected.")]
            public bool? IgnoreHiddenSeries
            {
                get
                {
                    return this.State.Get<bool?>("IgnoreHiddenSeries", true);
                }
                set
                {
                    this.State.Set("IgnoreHiddenSeries", value);
                }
            }

            /// <summary>
            /// Whether to invert the axes so that the x axis is vertical and y axis is horizontal. When true, the x axis is reversed by default. If a bar series is present in the chart, it will be inverted automatically.
            /// </summary>
            [ConfigOption("inverted", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to invert the axes so that the x axis is vertical and y axis is horizontal. When true, the x axis is reversed by default. If a bar series is present in the chart, it will be inverted automatically.")]
            public bool? Inverted
            {
                get
                {
                    return this.State.Get<bool?>("Inverted", false);
                }
                set
                {
                    this.State.Set("Inverted", value);
                }
            }

            /// <summary>
            /// The margin between the outer edge of the chart and the plot area. The numbers in the array designate top, right, bottom and left respectively. Use the options marginTop, marginRight, marginBottom and marginLeft for shorthand setting of one option. Since version 2.1, the margin is 0 by default. The actual space is dynamically calculated  from the offset of axis labels, axis title, title, subtitle and legend in addition to the spacingTop, spacingRight, spacingBottom and spacingLeft options.		 Defaults to [null].
            /// </summary>
            [ConfigOption("margin", JsonMode.AlwaysArray)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The margin between the outer edge of the chart and the plot area. The numbers in the array designate top, right, bottom and left respectively. Use the options marginTop, marginRight, marginBottom and marginLeft for shorthand setting of one option. Since version 2.1, the margin is 0 by default. The actual space is dynamically calculated  from the offset of axis labels, axis title, title, subtitle and legend in addition to the spacingTop, spacingRight, spacingBottom and spacingLeft options.		 Defaults to [null].")]
            public string Margin
            {
                get
                {
                    return this.State.Get<string>("Margin", "");
                }
                set
                {
                    this.State.Set("Margin", value);
                }
            }

            /// <summary>
            /// The margin between the bottom outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingBottom.
            /// </summary>
            [ConfigOption("marginBottom", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The margin between the bottom outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingBottom.")]
            public double? MarginBottom
            {
                get
                {
                    return this.State.Get<double?>("MarginBottom", null);
                }
                set
                {
                    this.State.Set("MarginBottom", value);
                }
            }

            /// <summary>
            /// The margin between the left outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingLeft.
            /// </summary>
            [ConfigOption("marginLeft", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The margin between the left outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingLeft.")]
            public double? MarginLeft
            {
                get
                {
                    return this.State.Get<double?>("MarginLeft", null);
                }
                set
                {
                    this.State.Set("MarginLeft", value);
                }
            }

            /// <summary>
            /// The margin between the right outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingRight.
            /// </summary>
            [ConfigOption("marginRight", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The margin between the right outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingRight.")]
            public double? MarginRight
            {
                get
                {
                    return this.State.Get<double?>("MarginRight", null);
                }
                set
                {
                    this.State.Set("MarginRight", value);
                }
            }

            /// <summary>
            /// The margin between the top outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingTop.
            /// </summary>
            [ConfigOption("marginTop", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The margin between the top outer edge of the chart and the plot area. Use this to set a fixed pixel value for the margin as opposed to the default dynamic margin. See also spacingTop.")]
            public double? MarginTop
            {
                get
                {
                    return this.State.Get<double?>("MarginTop", null);
                }
                set
                {
                    this.State.Set("MarginTop", value);
                }
            }

            /// <summary>
            /// Allows setting a key to switch between zooming and panning. 
            /// </summary>
            [ConfigOption("panKey", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Allows setting a key to switch between zooming and panning. ")]
            public string PanKey
            {
                get
                {
                    return this.State.Get<string>("PanKey", "");
                }
                set
                {
                    this.State.Set("PanKey", value);
                }
            }

            /// <summary>
            /// Allow panning in a chart. Best used with panKey to combine zooming and panning.
            /// </summary>
            [ConfigOption("panning", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Allow panning in a chart. Best used with panKey to combine zooming and panning.")]
            public bool? Panning
            {
                get
                {
                    return this.State.Get<bool?>("Panning", false);
                }
                set
                {
                    this.State.Set("Panning", value);
                }
            }

            /// <summary>
            /// Equivalent to zoomType, but for multitouch gestures only. By default, the pinchType is the same as the zoomType setting. However, pinching can be enabled separately in some cases, for example in stock charts where a mouse drag pans the chart, while pinching is enabled.
            /// </summary>
            [ConfigOption("pinchType", null)]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Equivalent to zoomType, but for multitouch gestures only. By default, the pinchType is the same as the zoomType setting. However, pinching can be enabled separately in some cases, for example in stock charts where a mouse drag pans the chart, while pinching is enabled.")]
            public string PinchType
            {
                get
                {
                    return this.State.Get<string>("PinchType", @"null");
                }
                set
                {
                    this.State.Set("PinchType", value);
                }
            }

            /// <summary>
            /// The background color or gradient for the plot area.
            /// </summary>
            [ConfigOption("plotBackgroundColor", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The background color or gradient for the plot area.")]
            public string PlotBackgroundColor
            {
                get
                {
                    return this.State.Get<string>("PlotBackgroundColor", "");
                }
                set
                {
                    this.State.Set("PlotBackgroundColor", value);
                }
            }

            /// <summary>
            /// The URL for an image to use as the plot background. To set an image as the background for the entire chart, set a CSS background image to the container element. Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.
            /// </summary>
            [ConfigOption("plotBackgroundImage", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The URL for an image to use as the plot background. To set an image as the background for the entire chart, set a CSS background image to the container element. Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.")]
            public string PlotBackgroundImage
            {
                get
                {
                    return this.State.Get<string>("PlotBackgroundImage", "");
                }
                set
                {
                    this.State.Set("PlotBackgroundImage", value);
                }
            }

            /// <summary>
            /// The color of the inner chart or plot area border.
            /// </summary>
            [ConfigOption("plotBorderColor", null)]
            [DefaultValue(@"#C0C0C0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the inner chart or plot area border.")]
            public string PlotBorderColor
            {
                get
                {
                    return this.State.Get<string>("PlotBorderColor", @"#C0C0C0");
                }
                set
                {
                    this.State.Set("PlotBorderColor", value);
                }
            }

            /// <summary>
            /// The pixel width of the plot area border.
            /// </summary>
            [ConfigOption("plotBorderWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel width of the plot area border.")]
            public double? PlotBorderWidth
            {
                get
                {
                    return this.State.Get<double?>("PlotBorderWidth", 0);
                }
                set
                {
                    this.State.Set("PlotBorderWidth", value);
                }
            }

            /// <summary>
            /// Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.
            /// </summary>
            [ConfigOption("plotShadow", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to apply a drop shadow to the plot area. Requires that plotBackgroundColor be set. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.")]
            public object PlotShadow
            {
                get
                {
                    return this.State.Get<object>("PlotShadow", null);
                }
                set
                {
                    this.State.Set("PlotShadow", value);
                }
            }

            /// <summary>
            /// When true, cartesian charts like line, spline, area and column are transformed into the polar coordinate system. Requires highcharts-more.js.
            /// </summary>
            [ConfigOption("polar", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When true, cartesian charts like line, spline, area and column are transformed into the polar coordinate system. Requires highcharts-more.js.")]
            public bool? Polar
            {
                get
                {
                    return this.State.Get<bool?>("Polar", false);
                }
                set
                {
                    this.State.Set("Polar", value);
                }
            }

            /// <summary>
            /// Whether to reflow the chart to fit the width of the container div on resizing the window.
            /// </summary>
            [ConfigOption("reflow", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to reflow the chart to fit the width of the container div on resizing the window.")]
            public bool? Reflow
            {
                get
                {
                    return this.State.Get<bool?>("Reflow", true);
                }
                set
                {
                    this.State.Set("Reflow", value);
                }
            }

            /// <summary>
            /// The HTML element where the chart will be rendered. If it is a string, the element by that id is used. The HTML element can also be passed by direct reference.
            /// </summary>
            [ConfigOption("renderTo", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The HTML element where the chart will be rendered. If it is a string, the element by that id is used. The HTML element can also be passed by direct reference.")]
            public object RenderTo
            {
                get
                {
                    return this.State.Get<object>("RenderTo", null);
                }
                set
                {
                    this.State.Set("RenderTo", value);
                }
            }

            /// <summary>
            /// The background color of the marker square when selecting (zooming in on) an area of the chart.
            /// </summary>
            [ConfigOption("selectionMarkerFill", null)]
            [DefaultValue(@"rgba(69,114,167,0.25)")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The background color of the marker square when selecting (zooming in on) an area of the chart.")]
            public string SelectionMarkerFill
            {
                get
                {
                    return this.State.Get<string>("SelectionMarkerFill", @"rgba(69,114,167,0.25)");
                }
                set
                {
                    this.State.Set("SelectionMarkerFill", value);
                }
            }

            /// <summary>
            /// Whether to apply a drop shadow to the outer chart area. Requires that  backgroundColor be set. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.
            /// </summary>
            [ConfigOption("shadow", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to apply a drop shadow to the outer chart area. Requires that  backgroundColor be set. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.")]
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
            /// Whether to show the axes initially. This only applies to empty charts where series are added dynamically, as axes are automatically added to cartesian series.
            /// </summary>
            [ConfigOption("showAxes", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to show the axes initially. This only applies to empty charts where series are added dynamically, as axes are automatically added to cartesian series.")]
            public bool? ShowAxes
            {
                get
                {
                    return this.State.Get<bool?>("ShowAxes", false);
                }
                set
                {
                    this.State.Set("ShowAxes", value);
                }
            }

            /// <summary>
            /// The distance between the outer edge of the chart and the content, like title, legend, axis title or labels. The numbers in the array designate top, right, bottom and left respectively. Use the options spacingTop, spacingRight, spacingBottom and spacingLeft options for shorthand setting of one option.
            /// </summary>
            [ConfigOption("spacing", JsonMode.AlwaysArray)]
            [DefaultValue(new double[] { 10, 10, 15, 10})]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The distance between the outer edge of the chart and the content, like title, legend, axis title or labels. The numbers in the array designate top, right, bottom and left respectively. Use the options spacingTop, spacingRight, spacingBottom and spacingLeft options for shorthand setting of one option.")]
            public double[] Spacing
            {
                get
                {
                    return this.State.Get<double[]>("Spacing", new double[] { 10, 10, 15, 10});
                }
                set
                {
                    this.State.Set("Spacing", value);
                }
            }

            /// <summary>
            /// The space between the bottom edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).
            /// </summary>
            [ConfigOption("spacingBottom", null)]
            [DefaultValue(15)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The space between the bottom edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).")]
            public double? SpacingBottom
            {
                get
                {
                    return this.State.Get<double?>("SpacingBottom", 15);
                }
                set
                {
                    this.State.Set("SpacingBottom", value);
                }
            }

            /// <summary>
            /// The space between the left edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).
            /// </summary>
            [ConfigOption("spacingLeft", null)]
            [DefaultValue(10)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The space between the left edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).")]
            public double? SpacingLeft
            {
                get
                {
                    return this.State.Get<double?>("SpacingLeft", 10);
                }
                set
                {
                    this.State.Set("SpacingLeft", value);
                }
            }

            /// <summary>
            /// The space between the right edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).
            /// </summary>
            [ConfigOption("spacingRight", null)]
            [DefaultValue(10)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The space between the right edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).")]
            public double? SpacingRight
            {
                get
                {
                    return this.State.Get<double?>("SpacingRight", 10);
                }
                set
                {
                    this.State.Set("SpacingRight", value);
                }
            }

            /// <summary>
            /// The space between the top edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).
            /// </summary>
            [ConfigOption("spacingTop", null)]
            [DefaultValue(10)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The space between the top edge of the chart and the content (plot area, axis title and labels, title, subtitle or  legend in top position).")]
            public double? SpacingTop
            {
                get
                {
                    return this.State.Get<double?>("SpacingTop", 10);
                }
                set
                {
                    this.State.Set("SpacingTop", value);
                }
            }

            /// <summary>
            /// Additional CSS styles to apply inline to the container div. Note that since the default font styles are applied in the renderer, it is ignorant of the individual chart  options and must be set globally. Defaults to:style: {	fontFamily: '""Lucida Grande"", ""Lucida Sans Unicode"", Verdana, Arial, Helvetica, sans-serif', // default font	fontSize: '12px'}
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue(@"{""fontFamily"":""'Lucida Grande', 'Lucida Sans Unicode', Verdana, Arial, Helvetica, sans-serif"",""fontSize"":""12px""}")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Additional CSS styles to apply inline to the container div. Note that since the default font styles are applied in the renderer, it is ignorant of the individual chart  options and must be set globally. Defaults to:style: {	fontFamily: '""Lucida Grande"", ""Lucida Sans Unicode"", Verdana, Arial, Helvetica, sans-serif', // default font	fontSize: '12px'}")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", @"{""fontFamily"":""'Lucida Grande', 'Lucida Sans Unicode', Verdana, Arial, Helvetica, sans-serif"",""fontSize"":""12px""}");
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// The default series type for the chart. Can be any of the chart types listed under plotOptions.
            /// </summary>
            [ConfigOption("type", null)]
            [DefaultValue(@"line")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The default series type for the chart. Can be any of the chart types listed under plotOptions.")]
            public string Type
            {
                get
                {
                    return this.State.Get<string>("Type", @"line");
                }
                set
                {
                    this.State.Set("Type", value);
                }
            }

            /// <summary>
            /// An explicit width for the chart. By default the width is calculated from the offset width of the containing element.
            /// </summary>
            [ConfigOption("width", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An explicit width for the chart. By default the width is calculated from the offset width of the containing element.")]
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

            /// <summary>
            /// Decides in what dimensions the user can zoom by dragging the mouse. Can be one of x, y or xy.
            /// </summary>
            [ConfigOption("zoomType", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Decides in what dimensions the user can zoom by dragging the mouse. Can be one of x, y or xy.")]
            public string ZoomType
            {
                get
                {
                    return this.State.Get<string>("ZoomType", "");
                }
                set
                {
                    this.State.Set("ZoomType", value);
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


                list.Add("alignTicks", new ConfigOption("alignTicks", null, true, this.AlignTicks));

                list.Add("animation", new ConfigOption("animation", null, null, this.Animation));

                list.Add("backgroundColor", new ConfigOption("backgroundColor", null, @"#FFFFFF", this.BackgroundColor));

                list.Add("borderColor", new ConfigOption("borderColor", null, @"#4572A7", this.BorderColor));

                list.Add("borderRadius", new ConfigOption("borderRadius", null, 0, this.BorderRadius));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 0, this.BorderWidth));

                list.Add("className", new ConfigOption("className", null, "", this.ClassName));

                list.Add("defaultSeriesType", new ConfigOption("defaultSeriesType", null, @"line", this.DefaultSeriesType));

                list.Add("height", new ConfigOption("height", null, null, this.Height));

                list.Add("ignoreHiddenSeries", new ConfigOption("ignoreHiddenSeries", null, true, this.IgnoreHiddenSeries));

                list.Add("inverted", new ConfigOption("inverted", null, false, this.Inverted));

                list.Add("margin", new ConfigOption("margin", new SerializationOptions("margin", JsonMode.AlwaysArray), "", this.Margin));

                list.Add("marginBottom", new ConfigOption("marginBottom", null, null, this.MarginBottom));

                list.Add("marginLeft", new ConfigOption("marginLeft", null, null, this.MarginLeft));

                list.Add("marginRight", new ConfigOption("marginRight", null, null, this.MarginRight));

                list.Add("marginTop", new ConfigOption("marginTop", null, null, this.MarginTop));

                list.Add("panKey", new ConfigOption("panKey", null, "", this.PanKey));

                list.Add("panning", new ConfigOption("panning", null, false, this.Panning));

                list.Add("pinchType", new ConfigOption("pinchType", null, @"null", this.PinchType));

                list.Add("plotBackgroundColor", new ConfigOption("plotBackgroundColor", null, "", this.PlotBackgroundColor));

                list.Add("plotBackgroundImage", new ConfigOption("plotBackgroundImage", null, "", this.PlotBackgroundImage));

                list.Add("plotBorderColor", new ConfigOption("plotBorderColor", null, @"#C0C0C0", this.PlotBorderColor));

                list.Add("plotBorderWidth", new ConfigOption("plotBorderWidth", null, 0, this.PlotBorderWidth));

                list.Add("plotShadow", new ConfigOption("plotShadow", null, null, this.PlotShadow));

                list.Add("polar", new ConfigOption("polar", null, false, this.Polar));

                list.Add("reflow", new ConfigOption("reflow", null, true, this.Reflow));

                list.Add("renderTo", new ConfigOption("renderTo", null, null, this.RenderTo));

                list.Add("selectionMarkerFill", new ConfigOption("selectionMarkerFill", null, @"rgba(69,114,167,0.25)", this.SelectionMarkerFill));

                list.Add("shadow", new ConfigOption("shadow", null, null, this.Shadow));

                list.Add("showAxes", new ConfigOption("showAxes", null, false, this.ShowAxes));

                list.Add("spacing", new ConfigOption("spacing", new SerializationOptions("spacing", JsonMode.AlwaysArray), new double[] { 10, 10, 15, 10}, this.Spacing));

                list.Add("spacingBottom", new ConfigOption("spacingBottom", null, 15, this.SpacingBottom));

                list.Add("spacingLeft", new ConfigOption("spacingLeft", null, 10, this.SpacingLeft));

                list.Add("spacingRight", new ConfigOption("spacingRight", null, 10, this.SpacingRight));

                list.Add("spacingTop", new ConfigOption("spacingTop", null, 10, this.SpacingTop));

                list.Add("style", new ConfigOption("style", null, @"{""fontFamily"":""'Lucida Grande', 'Lucida Sans Unicode', Verdana, Arial, Helvetica, sans-serif"",""fontSize"":""12px""}", this.Style));

                list.Add("type", new ConfigOption("type", null, @"line", this.Type));

                list.Add("width", new ConfigOption("width", null, null, this.Width));

                list.Add("zoomType", new ConfigOption("zoomType", null, "", this.ZoomType));
list.Add("events", new ConfigOption("events", new SerializationOptions("events", JsonMode.Object), null, this.Listeners));
                return list;
            }
        }


    
	        private ChartEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ChartEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new ChartEvents();
					}
			
					return this.events;
				}
			}


    

        /// <summary>
        /// Options to render charts in 3 dimensions. This feature requires highcharts-3d.js, found in the download package or online at code.highcharts.com/highcharts-3d.js.
        /// </summary>
        public partial class Options3d : Observable
        {

    
            /// <summary>
            /// One of the two rotation angles for the chart.
            /// </summary>
            [ConfigOption("alpha", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"One of the two rotation angles for the chart.")]
            public double? Alpha
            {
                get
                {
                    return this.State.Get<double?>("Alpha", 0);
                }
                set
                {
                    this.State.Set("Alpha", value);
                }
            }

            /// <summary>
            /// One of the two rotation angles for the chart.
            /// </summary>
            [ConfigOption("beta", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"One of the two rotation angles for the chart.")]
            public double? Beta
            {
                get
                {
                    return this.State.Get<double?>("Beta", 0);
                }
                set
                {
                    this.State.Set("Beta", value);
                }
            }

            /// <summary>
            /// The total depth of the chart.
            /// </summary>
            [ConfigOption("depth", null)]
            [DefaultValue(100)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The total depth of the chart.")]
            public double? Depth
            {
                get
                {
                    return this.State.Get<double?>("Depth", 100);
                }
                set
                {
                    this.State.Set("Depth", value);
                }
            }

            /// <summary>
            /// Wether to render the chart using the 3D functionality.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Wether to render the chart using the 3D functionality.")]
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
            /// Defines the distance the viewer is standing in front of the chart, this setting is important to calculate the perspective effect in column and scatter charts.It is not used for 3D pie charts.
            /// </summary>
            [ConfigOption("viewDistance", null)]
            [DefaultValue(100)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Defines the distance the viewer is standing in front of the chart, this setting is important to calculate the perspective effect in column and scatter charts.It is not used for 3D pie charts.")]
            public double? ViewDistance
            {
                get
                {
                    return this.State.Get<double?>("ViewDistance", 100);
                }
                set
                {
                    this.State.Set("ViewDistance", value);
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


                list.Add("alpha", new ConfigOption("alpha", null, 0, this.Alpha));

                list.Add("beta", new ConfigOption("beta", null, 0, this.Beta));

                list.Add("depth", new ConfigOption("depth", null, 100, this.Depth));

                list.Add("enabled", new ConfigOption("enabled", null, false, this.Enabled));

                list.Add("viewDistance", new ConfigOption("viewDistance", null, 100, this.ViewDistance));

                return list;
            }
        }


    
	        private Options3dEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public Options3dEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new Options3dEvents();
					}
			
					return this.events;
				}
			}


    

        /// <summary>
        /// Provides the option to draw a frame around the charts by defining a bottom, front and back panel. 
        /// </summary>
        public partial class Frame : Observable
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


    
	        private FrameEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public FrameEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new FrameEvents();
					}
			
					return this.events;
				}
			}


    

        /// <summary>
        /// Defines the back panel of the frame around 3D charts.
        /// </summary>
        public partial class Back : Observable
        {

    
            /// <summary>
            /// The color of the panel.
            /// </summary>
            [ConfigOption("color", null)]
            [DefaultValue(@"transparent")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the panel.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", @"transparent");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// Thickness of the panel.
            /// </summary>
            [ConfigOption("size", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Thickness of the panel.")]
            public double? Size
            {
                get
                {
                    return this.State.Get<double?>("Size", 1);
                }
                set
                {
                    this.State.Set("Size", value);
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


                list.Add("color", new ConfigOption("color", null, @"transparent", this.Color));

                list.Add("size", new ConfigOption("size", null, 1, this.Size));

                return list;
            }
        }


    
	        private BackEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public BackEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new BackEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class BackEvents : ComponentListeners
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
        /// The bottom of the frame around a 3D chart.
        /// </summary>
        public partial class Bottom : Observable
        {

    
            /// <summary>
            /// The color of the panel.
            /// </summary>
            [ConfigOption("color", null)]
            [DefaultValue(@"transparent")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the panel.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", @"transparent");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// The thickness of the panel.
            /// </summary>
            [ConfigOption("size", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The thickness of the panel.")]
            public double? Size
            {
                get
                {
                    return this.State.Get<double?>("Size", 1);
                }
                set
                {
                    this.State.Set("Size", value);
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


                list.Add("color", new ConfigOption("color", null, @"transparent", this.Color));

                list.Add("size", new ConfigOption("size", null, 1, this.Size));

                return list;
            }
        }


    
	        private BottomEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public BottomEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new BottomEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class BottomEvents : ComponentListeners
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
        /// The side for the frame around a 3D chart.
        /// </summary>
        public partial class Side : Observable
        {

    
            /// <summary>
            /// The color of the panel.
            /// </summary>
            [ConfigOption("color", null)]
            [DefaultValue(@"transparent")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the panel.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", @"transparent");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// The thickness of the panel.
            /// </summary>
            [ConfigOption("size", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The thickness of the panel.")]
            public double? Size
            {
                get
                {
                    return this.State.Get<double?>("Size", 1);
                }
                set
                {
                    this.State.Set("Size", value);
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


                list.Add("color", new ConfigOption("color", null, @"transparent", this.Color));

                list.Add("size", new ConfigOption("size", null, 1, this.Size));

                return list;
            }
        }


    
	        private SideEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public SideEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new SideEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class SideEvents : ComponentListeners
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
        public partial class FrameEvents : ComponentListeners
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
        public partial class Options3dEvents : ComponentListeners
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
        /// The button that appears after a selection zoom, allowing the user to reset zoom.
        /// </summary>
        public partial class ResetZoomButton : Observable
        {

    
            /// <summary>
            /// The position of the button. This is an object that can hold the properties align, verticalAlign, x and y.
            /// </summary>
            [ConfigOption("position", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The position of the button. This is an object that can hold the properties align, verticalAlign, x and y.")]
            public object Position
            {
                get
                {
                    return this.State.Get<object>("Position", null);
                }
                set
                {
                    this.State.Set("Position", value);
                }
            }

            /// <summary>
            /// What frame the button should be placed related to. Can be either ""plot"" or ""chart"".
            /// </summary>
            [ConfigOption("relativeTo", null)]
            [DefaultValue(@"plot")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"What frame the button should be placed related to. Can be either ""plot"" or ""chart"".")]
            public string RelativeTo
            {
                get
                {
                    return this.State.Get<string>("RelativeTo", @"plot");
                }
                set
                {
                    this.State.Set("RelativeTo", value);
                }
            }

            /// <summary>
            /// A collection of attributes for the button. The object takes SVG attributes like  fill, stroke, stroke-width or r, the border radius. The theme also supports style, a collection of CSS properties for the text. Equivalent attributes for the hover state are given in theme.states.hover.
            /// </summary>
            [ConfigOption("theme", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A collection of attributes for the button. The object takes SVG attributes like  fill, stroke, stroke-width or r, the border radius. The theme also supports style, a collection of CSS properties for the text. Equivalent attributes for the hover state are given in theme.states.hover.")]
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


                list.Add("position", new ConfigOption("position", null, null, this.Position));

                list.Add("relativeTo", new ConfigOption("relativeTo", null, @"plot", this.RelativeTo));

                list.Add("theme", new ConfigOption("theme", null, null, this.Theme));

                return list;
            }
        }


    
	        private ResetZoomButtonEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ResetZoomButtonEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new ResetZoomButtonEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class ResetZoomButtonEvents : ComponentListeners
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
        public partial class ChartEvents : ComponentListeners
        {


        private JFunction addSeries;

        /// <summary>
        /// Fires when a series is added to the chart after load time, using the addSeries method. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Through event.options you can access the series options that was passed to the addSeries  method. Returning false prevents the series from being added.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("addSeries", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when a series is added to the chart after load time, using the addSeries method. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Through event.options you can access the series options that was passed to the addSeries  method. Returning false prevents the series from being added.")]
        public virtual JFunction AddSeries
        {
            get
            {
                return this.addSeries ?? (this.addSeries = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction afterPrint;

        /// <summary>
        /// Fires after a chart is printed through the context menu item or the Chart.print method. Requires the exporting module.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("afterPrint", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires after a chart is printed through the context menu item or the Chart.print method. Requires the exporting module.")]
        public virtual JFunction AfterPrint
        {
            get
            {
                return this.afterPrint ?? (this.afterPrint = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction beforePrint;

        /// <summary>
        /// Fires before a chart is printed through the context menu item or the Chart.print method. Requires the exporting module.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("beforePrint", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires before a chart is printed through the context menu item or the Chart.print method. Requires the exporting module.")]
        public virtual JFunction BeforePrint
        {
            get
            {
                return this.beforePrint ?? (this.beforePrint = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction click;

        /// <summary>
        /// Fires when clicking on the plot background. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Information on the clicked spot can be found through event.xAxis and  event.yAxis, which are arrays containing the axes of each dimension and each axis' value at the clicked spot. The primary axes are event.xAxis[0] and event.yAxis[0]. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00.click: function(e) {	console.log(		Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', e.xAxis[0].value), 		e.yAxis[0].value	)}
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when clicking on the plot background. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Information on the clicked spot can be found through event.xAxis and  event.yAxis, which are arrays containing the axes of each dimension and each axis' value at the clicked spot. The primary axes are event.xAxis[0] and event.yAxis[0]. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00.click: function(e) {	console.log(		Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', e.xAxis[0].value), 		e.yAxis[0].value	)}")]
        public virtual JFunction Click
        {
            get
            {
                return this.click ?? (this.click = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction drilldown;

        /// <summary>
        /// Fires when a drilldown point is clicked, before the new series is added. Event arguments:  category  If a category label was clicked, which index.  point  The originating point.  points  If a category label was clicked, this array holds all points corresponing to the category.  seriesOptions  Options for the new seriesThis event is also utilized for async drilldown, where the seriesOptions are not added by option, but rather loaded async.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("drilldown", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when a drilldown point is clicked, before the new series is added. Event arguments:  category  If a category label was clicked, which index.  point  The originating point.  points  If a category label was clicked, this array holds all points corresponing to the category.  seriesOptions  Options for the new seriesThis event is also utilized for async drilldown, where the seriesOptions are not added by option, but rather loaded async.")]
        public virtual JFunction Drilldown
        {
            get
            {
                return this.drilldown ?? (this.drilldown = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction drillup;

        /// <summary>
        /// Fires when drilling up from a drilldown series.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("drillup", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when drilling up from a drilldown series.")]
        public virtual JFunction Drillup
        {
            get
            {
                return this.drillup ?? (this.drillup = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction load;

        /// <summary>
        /// Fires when the chart is finished loading. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.From version 2.0.4, there is also a second parameter to Highcharts.Chart where a callback function can be passed to be executed on chart.load.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("load", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the chart is finished loading. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.From version 2.0.4, there is also a second parameter to Highcharts.Chart where a callback function can be passed to be executed on chart.load.")]
        public virtual JFunction Load
        {
            get
            {
                return this.load ?? (this.load = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction redraw;

        /// <summary>
        /// Fires when the chart is redrawn, either after a call to chart.redraw() or after an axis, series or point is modified with the redraw option set to true. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("redraw", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the chart is redrawn, either after a call to chart.redraw() or after an axis, series or point is modified with the redraw option set to true. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
        public virtual JFunction Redraw
        {
            get
            {
                return this.redraw ?? (this.redraw = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction selection;

        /// <summary>
        /// Fires when an area of the chart has been selected. Selection is enabled by setting the chart's zoomType. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. The default action for the  selection event is to zoom the  chart to the selected area. It can be prevented by calling  event.preventDefault(). Information on the selected area can be found through event.xAxis and  event.yAxis, which are arrays containing the axes of each dimension and each axis' min and max values. The primary axes are event.xAxis[0] and event.yAxis[0]. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00. selection: function(event) {	// log the min and max of the primary, datetime x-axis	console.log(		Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].min),		Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].max)	);	// log the min and max of the y axis	console.log(event.yAxis[0].min, event.yAxis[0].max);}
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("selection", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when an area of the chart has been selected. Selection is enabled by setting the chart's zoomType. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. The default action for the  selection event is to zoom the  chart to the selected area. It can be prevented by calling  event.preventDefault(). Information on the selected area can be found through event.xAxis and  event.yAxis, which are arrays containing the axes of each dimension and each axis' min and max values. The primary axes are event.xAxis[0] and event.yAxis[0]. Remember the unit of a datetime axis is milliseconds since 1970-01-01 00:00:00. selection: function(event) {	// log the min and max of the primary, datetime x-axis	console.log(		Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].min),		Highcharts.dateFormat('%Y-%m-%d %H:%M:%S', event.xAxis[0].max)	);	// log the min and max of the y axis	console.log(event.yAxis[0].min, event.yAxis[0].max);}")]
        public virtual JFunction Selection
        {
            get
            {
                return this.selection ?? (this.selection = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }



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
                    list.Add("addSeries", new ConfigOption("addSeries", new SerializationOptions("addSeries", typeof(JFunctionJsonConverter)), null, this.AddSeries));list.Add("afterPrint", new ConfigOption("afterPrint", new SerializationOptions("afterPrint", typeof(JFunctionJsonConverter)), null, this.AfterPrint));list.Add("beforePrint", new ConfigOption("beforePrint", new SerializationOptions("beforePrint", typeof(JFunctionJsonConverter)), null, this.BeforePrint));list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(JFunctionJsonConverter)), null, this.Click));list.Add("drilldown", new ConfigOption("drilldown", new SerializationOptions("drilldown", typeof(JFunctionJsonConverter)), null, this.Drilldown));list.Add("drillup", new ConfigOption("drillup", new SerializationOptions("drillup", typeof(JFunctionJsonConverter)), null, this.Drillup));list.Add("load", new ConfigOption("load", new SerializationOptions("load", typeof(JFunctionJsonConverter)), null, this.Load));list.Add("redraw", new ConfigOption("redraw", new SerializationOptions("redraw", typeof(JFunctionJsonConverter)), null, this.Redraw));list.Add("selection", new ConfigOption("selection", new SerializationOptions("selection", typeof(JFunctionJsonConverter)), null, this.Selection));
                    return list;
                }
            }

        }


        }

        
}
            