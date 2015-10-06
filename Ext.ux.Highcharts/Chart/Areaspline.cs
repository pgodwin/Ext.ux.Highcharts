
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
        /// A areaspline series. If the .type">type option is not specified, it is inherited from chart.type.For options that apply to multiple series, it is recommended to add them to the pointOptions.series options structure. To apply to all series of this specific type, apply it to plotOptions.areaspline.
        /// </summary>
        public partial class Areaspline : Observable
        {

    
            /// <summary>
            /// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Allow this series' points to be selected by clicking on the markers, bars or pie slices.")]
            public bool? AllowPointSelect
            {
                get
                {
                    return this.State.Get<bool?>("AllowPointSelect", false);
                }
                set
                {
                    this.State.Set("AllowPointSelect", value);
                }
            }

            /// <summary>
            /// Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see chart.animation and the animation parameter under the API methods.		The following properties are supported:  duration  The duration of the animation in milliseconds.easingWhen using jQuery as the general framework, the easing can be set to linear or	swing. More easing functions are available with the use of jQuery plug-ins, most notably				the jQuery UI suite. See the jQuery docs. When using MooTools as the general framework, use the property name transition instead of easing.Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the initial animation when a series is displayed. The animation can also be set as a configuration object. Please note that this option only applies to the initial animation of the series itself. For other animations, see chart.animation and the animation parameter under the API methods.		The following properties are supported:  duration  The duration of the animation in milliseconds.easingWhen using jQuery as the general framework, the easing can be set to linear or	swing. More easing functions are available with the use of jQuery plug-ins, most notably				the jQuery UI suite. See the jQuery docs. When using MooTools as the general framework, use the property name transition instead of easing.Due to poor performance, animation is disabled in old IE browsers for column charts and polar charts.")]
            public bool? Animation
            {
                get
                {
                    return this.State.Get<bool?>("Animation", true);
                }
                set
                {
                    this.State.Set("Animation", value);
                }
            }

            /// <summary>
            /// The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified. In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the  options.colors array.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The main color or the series. In line type series it applies to the line and the point markers unless otherwise specified. In bar type series it applies to the bars unless a color is specified per point. The default value is pulled from the  options.colors array.")]
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
            /// Polar charts only. Whether to connect the ends of a line series plot across the extremes.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Polar charts only. Whether to connect the ends of a line series plot across the extremes.")]
            public bool? ConnectEnds
            {
                get
                {
                    return this.State.Get<bool?>("ConnectEnds", true);
                }
                set
                {
                    this.State.Set("ConnectEnds", value);
                }
            }

            /// <summary>
            /// Whether to connect a graph line across null points.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to connect a graph line across null points.")]
            public bool? ConnectNulls
            {
                get
                {
                    return this.State.Get<bool?>("ConnectNulls", false);
                }
                set
                {
                    this.State.Set("ConnectNulls", value);
                }
            }

            /// <summary>
            /// When the series contains less points than the crop threshold, all points are drawn,  event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.  .
            /// </summary>
            [ConfigOption]
            [DefaultValue(300)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When the series contains less points than the crop threshold, all points are drawn,  event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.  .")]
            public double? CropThreshold
            {
                get
                {
                    return this.State.Get<double?>("CropThreshold", 300);
                }
                set
                {
                    this.State.Set("CropThreshold", value);
                }
            }

            /// <summary>
            /// You can set the cursor to ""pointer"" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"You can set the cursor to ""pointer"" if you have click events attached to  the series, to signal to the user that the points and lines can be clicked.")]
            public string Cursor
            {
                get
                {
                    return this.State.Get<string>("Cursor", "");
                }
                set
                {
                    this.State.Set("Cursor", value);
                }
            }

            /// <summary>
            /// A name for the dash style to use for the graph. Applies only to series type having a graph, like line, spline, area and scatter in  case it has a lineWidth. The value for the dashStyle include:		    		    	Solid		    	ShortDash		    	ShortDot		    	ShortDashDot		    	ShortDashDotDot		    	Dot		    	Dash		    	LongDash		    	DashDot		    	LongDashDot		    	LongDashDotDot		    
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"Solid")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A name for the dash style to use for the graph. Applies only to series type having a graph, like line, spline, area and scatter in  case it has a lineWidth. The value for the dashStyle include:		    		    	Solid		    	ShortDash		    	ShortDot		    	ShortDashDot		    	ShortDashDotDot		    	Dot		    	Dash		    	LongDash		    	DashDot		    	LongDashDot		    	LongDashDotDot		    ")]
            public string DashStyle
            {
                get
                {
                    return this.State.Get<string>("DashStyle", @"Solid");
                }
                set
                {
                    this.State.Set("DashStyle", value);
                }
            }

            /// <summary>
            /// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.")]
            public bool? EnableMouseTracking
            {
                get
                {
                    return this.State.Get<bool?>("EnableMouseTracking", true);
                }
                set
                {
                    this.State.Set("EnableMouseTracking", value);
                }
            }

            /// <summary>
            /// Fill color or gradient for the area. When null, the series' color  is  used with the series' fillOpacity.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fill color or gradient for the area. When null, the series' color  is  used with the series' fillOpacity.")]
            public string FillColor
            {
                get
                {
                    return this.State.Get<string>("FillColor", "");
                }
                set
                {
                    this.State.Set("FillColor", value);
                }
            }

            /// <summary>
            /// Fill opacity for the area. Note that when you set an explicit fillColor, the fillOpacity is not applied. Instead, you should define the opacity in the fillColor with an rgba color definition.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0.75)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fill opacity for the area. Note that when you set an explicit fillColor, the fillOpacity is not applied. Instead, you should define the opacity in the fillColor with an rgba color definition.")]
            public double? FillOpacity
            {
                get
                {
                    return this.State.Get<double?>("FillOpacity", 0.75);
                }
                set
                {
                    this.State.Set("FillOpacity", value);
                }
            }

            /// <summary>
            /// Whether to use the Y extremes of the total chart width or only the zoomed area when zooming in on parts of the X axis. By default, the Y axis adjusts to the min and max of the visible data. Cartesian series only.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to use the Y extremes of the total chart width or only the zoomed area when zooming in on parts of the X axis. By default, the Y axis adjusts to the min and max of the visible data. Cartesian series only.")]
            public bool? GetExtremesFromAll
            {
                get
                {
                    return this.State.Get<bool?>("GetExtremesFromAll", false);
                }
                set
                {
                    this.State.Set("GetExtremesFromAll", value);
                }
            }

            /// <summary>
            /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get().
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An id for the series. This can be used after render time to get a pointer to the series object through chart.get().")]
            public string Id
            {
                get
                {
                    return this.State.Get<string>("Id", "");
                }
                set
                {
                    this.State.Set("Id", value);
                }
            }

            /// <summary>
            /// The index of the series in the chart, affecting the internal index in the chart.series array, the visible Z index as well as the order in the legend.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The index of the series in the chart, affecting the internal index in the chart.series array, the visible Z index as well as the order in the legend.")]
            public double? Index
            {
                get
                {
                    return this.State.Get<double?>("Index", null);
                }
                set
                {
                    this.State.Set("Index", value);
                }
            }

            /// <summary>
            /// An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.")]
            public string[] Keys
            {
                get
                {
                    return this.State.Get<string[]>("Keys", null);
                }
                set
                {
                    this.State.Set("Keys", value);
                }
            }

            /// <summary>
            /// The sequential index of the series in the legend.  Try it:  	Legend in opposite order .
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The sequential index of the series in the legend.  Try it:  	Legend in opposite order .")]
            public double? LegendIndex
            {
                get
                {
                    return this.State.Get<double?>("LegendIndex", null);
                }
                set
                {
                    this.State.Set("LegendIndex", value);
                }
            }

            /// <summary>
            /// A separate color for the graph line. By default the line takes the color of the series, but the lineColor setting allows setting a separate color for the line without altering the fillColor.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A separate color for the graph line. By default the line takes the color of the series, but the lineColor setting allows setting a separate color for the line without altering the fillColor.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", "");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// Pixel with of the graph line.
            /// </summary>
            [ConfigOption]
            [DefaultValue(2)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Pixel with of the graph line.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 2);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The id of another series to link to. Additionally, the value can be "":previous"" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The id of another series to link to. Additionally, the value can be "":previous"" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.")]
            public string LinkedTo
            {
                get
                {
                    return this.State.Get<string>("LinkedTo", "");
                }
                set
                {
                    this.State.Set("LinkedTo", value);
                }
            }

            /// <summary>
            /// The name of the series as shown in the legend, tooltip etc.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The name of the series as shown in the legend, tooltip etc.")]
            public string Name
            {
                get
                {
                    return this.State.Get<string>("Name", "");
                }
                set
                {
                    this.State.Set("Name", value);
                }
            }

            /// <summary>
            /// The color for the parts of the graph or points that are below the threshold.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color for the parts of the graph or points that are below the threshold.")]
            public string NegativeColor
            {
                get
                {
                    return this.State.Get<string>("NegativeColor", @"null");
                }
                set
                {
                    this.State.Set("NegativeColor", value);
                }
            }

            /// <summary>
            /// A separate color for the negative part of the area.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A separate color for the negative part of the area.")]
            public string NegativeFillColor
            {
                get
                {
                    return this.State.Get<string>("NegativeFillColor", "");
                }
                set
                {
                    this.State.Set("NegativeFillColor", value);
                }
            }

            /// <summary>
            /// If no x values are given for the points in a series, pointInterval defines the interval of the x values. For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.Since Highcharts 4.1, it can be combined with pointIntervalUnit to draw irregular intervals.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If no x values are given for the points in a series, pointInterval defines the interval of the x values. For example, if a series contains one value every decade starting from year 0, set pointInterval to 10.Since Highcharts 4.1, it can be combined with pointIntervalUnit to draw irregular intervals.")]
            public double? PointInterval
            {
                get
                {
                    return this.State.Get<double?>("PointInterval", 1);
                }
                set
                {
                    this.State.Set("PointInterval", value);
                }
            }

            /// <summary>
            /// On datetime series, this allows for setting the pointInterval to the two irregular time units, month and year. Combine it with pointInterval to draw quarters, 6 months, 10 years etc.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"On datetime series, this allows for setting the pointInterval to the two irregular time units, month and year. Combine it with pointInterval to draw quarters, 6 months, 10 years etc.")]
            public string PointIntervalUnit
            {
                get
                {
                    return this.State.Get<string>("PointIntervalUnit", "");
                }
                set
                {
                    this.State.Set("PointIntervalUnit", value);
                }
            }

            /// <summary>
            /// Possible values: null, ""on"", ""between"".In a column chart, when pointPlacement is ""on"", the point will not create any padding of the X axis. In a polar column chart this means that the first column points directly north. If the pointPlacement is ""between"", the columns will be laid out between ticks. This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.Since Highcharts 3.0.2, the point placement can also be numeric, where 0 is on the axis value, -0.5 is between this value and the previous, and 0.5 is between this value and the next. Unlike the textual options, numeric point placement options won't affect axis padding.Note that pointPlacement needs a pointRange to work. For column series this is computed, but for line-type series it needs to be set.Defaults to null in cartesian charts, ""between"" in polar charts.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Possible values: null, ""on"", ""between"".In a column chart, when pointPlacement is ""on"", the point will not create any padding of the X axis. In a polar column chart this means that the first column points directly north. If the pointPlacement is ""between"", the columns will be laid out between ticks. This is useful for example for visualising an amount between two points in time or in a certain sector of a polar chart.Since Highcharts 3.0.2, the point placement can also be numeric, where 0 is on the axis value, -0.5 is between this value and the previous, and 0.5 is between this value and the next. Unlike the textual options, numeric point placement options won't affect axis padding.Note that pointPlacement needs a pointRange to work. For column series this is computed, but for line-type series it needs to be set.Defaults to null in cartesian charts, ""between"" in polar charts.")]
            public object PointPlacement
            {
                get
                {
                    return this.State.Get<object>("PointPlacement", null);
                }
                set
                {
                    this.State.Set("PointPlacement", value);
                }
            }

            /// <summary>
            /// If no x values are given for the points in a series, pointStart defines on what value to start. For example, if a series contains one yearly value starting from 1945, set pointStart to 1945.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If no x values are given for the points in a series, pointStart defines on what value to start. For example, if a series contains one yearly value starting from 1945, set pointStart to 1945.")]
            public double? PointStart
            {
                get
                {
                    return this.State.Get<double?>("PointStart", 0);
                }
                set
                {
                    this.State.Set("PointStart", value);
                }
            }

            /// <summary>
            /// Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to select the series initially. If showCheckbox is true, the checkbox next to the series name will be checked for a selected series.")]
            public bool? Selected
            {
                get
                {
                    return this.State.Get<bool?>("Selected", false);
                }
                set
                {
                    this.State.Set("Selected", value);
                }
            }

            /// <summary>
            /// Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to apply a drop shadow to the graph line. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.")]
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
            /// If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the selected option.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If true, a checkbox is displayed next to the legend item to allow selecting the series. The state of the checkbox is determined by the selected option.")]
            public bool? ShowCheckbox
            {
                get
                {
                    return this.State.Get<bool?>("ShowCheckbox", false);
                }
                set
                {
                    this.State.Set("ShowCheckbox", value);
                }
            }

            /// <summary>
            /// Whether to display this particular series or series type in the legend. The default value is true for standalone series, false for linked series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to display this particular series or series type in the legend. The default value is true for standalone series, false for linked series.")]
            public bool? ShowInLegend
            {
                get
                {
                    return this.State.Get<bool?>("ShowInLegend", true);
                }
                set
                {
                    this.State.Set("ShowInLegend", value);
                }
            }

            /// <summary>
            /// This option allows grouping series in a stacked chart. The stack option can be a string  or a number or anything else, as long as the grouped series' stack options match each other.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"This option allows grouping series in a stacked chart. The stack option can be a string  or a number or anything else, as long as the grouped series' stack options match each other.")]
            public string Stack
            {
                get
                {
                    return this.State.Get<string>("Stack", "");
                }
                set
                {
                    this.State.Set("Stack", value);
                }
            }

            /// <summary>
            /// Whether to stack the values of each series on top of each other. Possible values are null to disable, ""normal"" to stack by value or ""percent"".
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to stack the values of each series on top of each other. Possible values are null to disable, ""normal"" to stack by value or ""percent"".")]
            public string Stacking
            {
                get
                {
                    return this.State.Get<string>("Stacking", "");
                }
                set
                {
                    this.State.Set("Stacking", value);
                }
            }

            /// <summary>
            /// Whether to apply steps to the line. Possible values are left, center and right. Prior to 2.3.5, only left was supported.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"false")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to apply steps to the line. Possible values are left, center and right. Prior to 2.3.5, only left was supported.")]
            public string Step
            {
                get
                {
                    return this.State.Get<string>("Step", @"false");
                }
                set
                {
                    this.State.Set("Step", value);
                }
            }

            /// <summary>
            /// Sticky tracking of mouse events. When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When stickyTracking is false and tooltip.shared is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Sticky tracking of mouse events. When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When stickyTracking is false and tooltip.shared is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.")]
            public bool? StickyTracking
            {
                get
                {
                    return this.State.Get<bool?>("StickyTracking", true);
                }
                set
                {
                    this.State.Set("StickyTracking", value);
                }
            }

            /// <summary>
            /// The Y axis value to serve as the base for the area, for distinguishing between values above and below a threshold. If null, the area behaves like a line series with fill between the graph and the Y axis minimum.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The Y axis value to serve as the base for the area, for distinguishing between values above and below a threshold. If null, the area behaves like a line series with fill between the graph and the Y axis minimum.")]
            public double? Threshold
            {
                get
                {
                    return this.State.Get<double?>("Threshold", 0);
                }
                set
                {
                    this.State.Set("Threshold", value);
                }
            }

            /// <summary>
            /// Whether the whole area or just the line should respond to mouseover tooltips and other mouse or touch events.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether the whole area or just the line should respond to mouseover tooltips and other mouse or touch events.")]
            public bool? TrackByArea
            {
                get
                {
                    return this.State.Get<bool?>("TrackByArea", false);
                }
                set
                {
                    this.State.Set("TrackByArea", value);
                }
            }

            /// <summary>
            /// When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to 0 disable.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1000)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When a series contains a data array that is longer than this, only one dimensional arrays of numbers, or two dimensional arrays with x and y values are allowed. Also, only the first point is tested, and the rest are assumed to be the same format. This saves expensive data checking and indexing in long series. Set it to 0 disable.")]
            public double? TurboThreshold
            {
                get
                {
                    return this.State.Get<double?>("TurboThreshold", 1000);
                }
                set
                {
                    this.State.Set("TurboThreshold", value);
                }
            }

            /// <summary>
            /// The type of series. Can be one of area, areaspline, bar, column, line, pie, scatter or spline. From version 2.3, arearange, areasplinerange and columnrange are supported with the highcharts-more.js component.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The type of series. Can be one of area, areaspline, bar, column, line, pie, scatter or spline. From version 2.3, arearange, areasplinerange and columnrange are supported with the highcharts-more.js component.")]
            public string Type
            {
                get
                {
                    return this.State.Get<string>("Type", "");
                }
                set
                {
                    this.State.Set("Type", value);
                }
            }

            /// <summary>
            /// Set the initial visibility of the series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Set the initial visibility of the series.")]
            public bool? Visible
            {
                get
                {
                    return this.State.Get<bool?>("Visible", true);
                }
                set
                {
                    this.State.Set("Visible", value);
                }
            }

            /// <summary>
            /// When using dual or multiple x axes, this number defines which xAxis the particular series is connected to. It refers to either the axis id or the index of the axis in the xAxis array, with 0 being the first.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When using dual or multiple x axes, this number defines which xAxis the particular series is connected to. It refers to either the axis id or the index of the axis in the xAxis array, with 0 being the first.")]
            public object XAxis
            {
                get
                {
                    return this.State.Get<object>("XAxis", null);
                }
                set
                {
                    this.State.Set("XAxis", value);
                }
            }

            /// <summary>
            /// When using dual or multiple y axes, this number defines which yAxis the particular series is connected to. It refers to either the axis id or the index of the axis in the yAxis array, with 0 being the first.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When using dual or multiple y axes, this number defines which yAxis the particular series is connected to. It refers to either the axis id or the index of the axis in the yAxis array, with 0 being the first.")]
            public object YAxis
            {
                get
                {
                    return this.State.Get<object>("YAxis", null);
                }
                set
                {
                    this.State.Set("YAxis", value);
                }
            }

            /// <summary>
            /// Define the visual z index of the series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Define the visual z index of the series.")]
            public double? ZIndex
            {
                get
                {
                    return this.State.Get<double?>("ZIndex", null);
                }
                set
                {
                    this.State.Set("ZIndex", value);
                }
            }

            /// <summary>
            /// Defines the Axis on which the zones are applied.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"y")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Defines the Axis on which the zones are applied.")]
            public string ZoneAxis
            {
                get
                {
                    return this.State.Get<string>("ZoneAxis", @"y");
                }
                set
                {
                    this.State.Set("ZoneAxis", value);
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


                list.Add("allowPointSelect", new ConfigOption("allowPointSelect", null, false, this.AllowPointSelect));

                list.Add("animation", new ConfigOption("animation", null, true, this.Animation));

                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("connectEnds", new ConfigOption("connectEnds", null, true, this.ConnectEnds));

                list.Add("connectNulls", new ConfigOption("connectNulls", null, false, this.ConnectNulls));

                list.Add("cropThreshold", new ConfigOption("cropThreshold", null, 300, this.CropThreshold));

                list.Add("cursor", new ConfigOption("cursor", null, "", this.Cursor));

                list.Add("dashStyle", new ConfigOption("dashStyle", null, @"Solid", this.DashStyle));

                list.Add("enableMouseTracking", new ConfigOption("enableMouseTracking", null, true, this.EnableMouseTracking));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("fillOpacity", new ConfigOption("fillOpacity", null, 0.75, this.FillOpacity));

                list.Add("getExtremesFromAll", new ConfigOption("getExtremesFromAll", null, false, this.GetExtremesFromAll));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("index", new ConfigOption("index", null, null, this.Index));

                list.Add("keys", new ConfigOption("keys", null, null, this.Keys));

                list.Add("legendIndex", new ConfigOption("legendIndex", null, null, this.LegendIndex));

                list.Add("lineColor", new ConfigOption("lineColor", null, "", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 2, this.LineWidth));

                list.Add("linkedTo", new ConfigOption("linkedTo", null, "", this.LinkedTo));

                list.Add("name", new ConfigOption("name", null, "", this.Name));

                list.Add("negativeColor", new ConfigOption("negativeColor", null, @"null", this.NegativeColor));

                list.Add("negativeFillColor", new ConfigOption("negativeFillColor", null, "", this.NegativeFillColor));

                list.Add("pointInterval", new ConfigOption("pointInterval", null, 1, this.PointInterval));

                list.Add("pointIntervalUnit", new ConfigOption("pointIntervalUnit", null, "", this.PointIntervalUnit));

                list.Add("pointPlacement", new ConfigOption("pointPlacement", null, null, this.PointPlacement));

                list.Add("pointStart", new ConfigOption("pointStart", null, 0, this.PointStart));

                list.Add("selected", new ConfigOption("selected", null, false, this.Selected));

                list.Add("shadow", new ConfigOption("shadow", null, null, this.Shadow));

                list.Add("showCheckbox", new ConfigOption("showCheckbox", null, false, this.ShowCheckbox));

                list.Add("showInLegend", new ConfigOption("showInLegend", null, true, this.ShowInLegend));

                list.Add("stack", new ConfigOption("stack", null, "", this.Stack));

                list.Add("stacking", new ConfigOption("stacking", null, "", this.Stacking));

                list.Add("step", new ConfigOption("step", null, @"false", this.Step));

                list.Add("stickyTracking", new ConfigOption("stickyTracking", null, true, this.StickyTracking));

                list.Add("threshold", new ConfigOption("threshold", null, 0, this.Threshold));

                list.Add("trackByArea", new ConfigOption("trackByArea", null, false, this.TrackByArea));

                list.Add("turboThreshold", new ConfigOption("turboThreshold", null, 1000, this.TurboThreshold));

                list.Add("type", new ConfigOption("type", null, "", this.Type));

                list.Add("visible", new ConfigOption("visible", null, true, this.Visible));

                list.Add("xAxis", new ConfigOption("xAxis", null, null, this.XAxis));

                list.Add("yAxis", new ConfigOption("yAxis", null, null, this.YAxis));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                list.Add("zoneAxis", new ConfigOption("zoneAxis", null, @"y", this.ZoneAxis));

                return list;
            }
        }


    

        /// <summary>
        /// An array of data points for the series. For the areaspline series type, points can be given in the following ways:  	An array of numerical values. In this case, the numerical values will  	be interpreted as y options. The x values will be automatically calculated, 	either starting at 0 and incremented by 1, or from pointStart  	and pointInterval given in the series options. If the axis 	has categories, these will be used.  Example:data: [0, 5, 3, 5] 	 	An array of arrays with 2 values. In this case, the values correspond to x,y. If the first value is a string, it is 	applied as the name of the point, and the x value is inferred. data: [    [0, 10],     [1, 9],     [2, 3]]An array of objects with named values. The objects are 	point configuration objects as seen below. If the total number of data points exceeds the series' .turboThreshold'>turboThreshold, this option is not available.data: [{    x: 1,    y: 4,    name: "Point2",    color: "#00FF00"}, {    x: 1,    y: 4,    name: "Point1",    color: "#FF00FF"}] 
        /// </summary>
        public partial class Data : Observable
        {

    
            /// <summary>
            /// Individual color for the point. By default the color is pulled from the global colors array.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Individual color for the point. By default the color is pulled from the global colors array.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", null);
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// Individual data label for each point. The options are the same as the ones for  plotOptions.series.dataLabels
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Individual data label for each point. The options are the same as the ones for  plotOptions.series.dataLabels")]
            public object DataLabels
            {
                get
                {
                    return this.State.Get<object>("DataLabels", null);
                }
                set
                {
                    this.State.Set("DataLabels", value);
                }
            }

            /// <summary>
            /// The id of a series in the drilldown.series array to use for a drilldown for this point.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The id of a series in the drilldown.series array to use for a drilldown for this point.")]
            public string Drilldown
            {
                get
                {
                    return this.State.Get<string>("Drilldown", "");
                }
                set
                {
                    this.State.Set("Drilldown", value);
                }
            }

            /// <summary>
            /// An id for the point. This can be used after render time to get a pointer to the point object through chart.get().
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An id for the point. This can be used after render time to get a pointer to the point object through chart.get().")]
            public string Id
            {
                get
                {
                    return this.State.Get<string>("Id", "");
                }
                set
                {
                    this.State.Set("Id", value);
                }
            }

            /// <summary>
            /// The name of the point as shown in the legend, tooltip, dataLabel etc.If the xAxis.type is set to category, and no categories option exists, the category will be pulled from the point.name of the last series defined. For multiple series, best practice however is to define xAxis.categories.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The name of the point as shown in the legend, tooltip, dataLabel etc.If the xAxis.type is set to category, and no categories option exists, the category will be pulled from the point.name of the last series defined. For multiple series, best practice however is to define xAxis.categories.")]
            public string Name
            {
                get
                {
                    return this.State.Get<string>("Name", "");
                }
                set
                {
                    this.State.Set("Name", value);
                }
            }

            /// <summary>
            /// Whether the data point is selected initially.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether the data point is selected initially.")]
            public bool? Selected
            {
                get
                {
                    return this.State.Get<bool?>("Selected", false);
                }
                set
                {
                    this.State.Set("Selected", value);
                }
            }

            /// <summary>
            /// The x value of the point. For datetime axes, the X value is the timestamp in milliseconds since 1970.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The x value of the point. For datetime axes, the X value is the timestamp in milliseconds since 1970.")]
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
            /// The y value of the point.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The y value of the point.")]
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


                list.Add("color", new ConfigOption("color", null, null, this.Color));

                list.Add("dataLabels", new ConfigOption("dataLabels", null, null, this.DataLabels));

                list.Add("drilldown", new ConfigOption("drilldown", null, "", this.Drilldown));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("name", new ConfigOption("name", null, "", this.Name));

                list.Add("selected", new ConfigOption("selected", null, false, this.Selected));

                list.Add("x", new ConfigOption("x", null, null, this.x));

                list.Add("y", new ConfigOption("y", null, null, this.y));

                return list;
            }
        }


    

        /// <summary>
        /// Individual point events
        /// </summary>
        public partial class Events : Observable
        {

    
            /// <summary>
            /// Fires when a point is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state. Returning false cancels this action.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when a point is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state. Returning false cancels this action.")]
            public string Click
            {
                get
                {
                    return this.State.Get<string>("Click", "");
                }
                set
                {
                    this.State.Set("Click", value);
                }
            }

            /// <summary>
            /// Fires when the mouse leaves the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the mouse leaves the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
            public string MouseOut
            {
                get
                {
                    return this.State.Get<string>("MouseOut", "");
                }
                set
                {
                    this.State.Set("MouseOut", value);
                }
            }

            /// <summary>
            /// Fires when the mouse enters the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the mouse enters the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
            public string MouseOver
            {
                get
                {
                    return this.State.Get<string>("MouseOver", "");
                }
                set
                {
                    this.State.Set("MouseOver", value);
                }
            }

            /// <summary>
            /// Fires when the point is removed using the .remove() method. One parameter, event, is passed to the function. Returning false cancels the operation.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the point is removed using the .remove() method. One parameter, event, is passed to the function. Returning false cancels the operation.")]
            public string Remove
            {
                get
                {
                    return this.State.Get<string>("Remove", "");
                }
                set
                {
                    this.State.Set("Remove", value);
                }
            }

            /// <summary>
            /// Fires when the point is selected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the point is selected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.")]
            public string Select
            {
                get
                {
                    return this.State.Get<string>("Select", "");
                }
                set
                {
                    this.State.Set("Select", value);
                }
            }

            /// <summary>
            /// Fires when the point is unselected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the point is unselected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.")]
            public string Unselect
            {
                get
                {
                    return this.State.Get<string>("Unselect", "");
                }
                set
                {
                    this.State.Set("Unselect", value);
                }
            }

            /// <summary>
            /// Fires when the point is updated programmatically through the .update() method. One parameter, event, is passed to the function. The  new point options can be accessed through event.options. Returning false cancels the operation.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the point is updated programmatically through the .update() method. One parameter, event, is passed to the function. The  new point options can be accessed through event.options. Returning false cancels the operation.")]
            public string Update
            {
                get
                {
                    return this.State.Get<string>("Update", "");
                }
                set
                {
                    this.State.Set("Update", value);
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


                list.Add("click", new ConfigOption("click", null, "", this.Click));

                list.Add("mouseOut", new ConfigOption("mouseOut", null, "", this.MouseOut));

                list.Add("mouseOver", new ConfigOption("mouseOver", null, "", this.MouseOver));

                list.Add("remove", new ConfigOption("remove", null, "", this.Remove));

                list.Add("select", new ConfigOption("select", null, "", this.Select));

                list.Add("unselect", new ConfigOption("unselect", null, "", this.Unselect));

                list.Add("update", new ConfigOption("update", null, "", this.Update));

                return list;
            }
        }


    

        }


        /// <summary>
        /// 
        /// </summary>
        public partial class Marker : Observable
        {

    
            /// <summary>
            /// Enable or disable the point marker. If null, the markers are hidden when the data is dense, and shown for more widespread data points.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the point marker. If null, the markers are hidden when the data is dense, and shown for more widespread data points.")]
            public bool? Enabled
            {
                get
                {
                    return this.State.Get<bool?>("Enabled", null);
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// The fill color of the point marker. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The fill color of the point marker. When null, the series' or point's color is used.")]
            public string FillColor
            {
                get
                {
                    return this.State.Get<string>("FillColor", "");
                }
                set
                {
                    this.State.Set("FillColor", value);
                }
            }

            /// <summary>
            /// Image markers only. Set the image width explicitly. When using this option, a width must also be set.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Image markers only. Set the image width explicitly. When using this option, a width must also be set.")]
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
            /// The color of the point marker's outline. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#FFFFFF")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the point marker's outline. When null, the series' or point's color is used.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#FFFFFF");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// The width of the point marker's outline.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the point marker's outline.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 0);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The radius of the point marker.
            /// </summary>
            [ConfigOption]
            [DefaultValue(4)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The radius of the point marker.")]
            public double? Radius
            {
                get
                {
                    return this.State.Get<double?>("Radius", 4);
                }
                set
                {
                    this.State.Set("Radius", value);
                }
            }

            /// <summary>
            /// A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are ""circle"", ""square"", ""diamond"", ""triangle"" and ""triangle-down"".Additionally, the URL to a graphic can be given on this form:  ""url(graphic.png)"". Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to Highcharts.SVGRenderer.prototype.symbols. The callback is then used by its method name, as shown in the demo.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are ""circle"", ""square"", ""diamond"", ""triangle"" and ""triangle-down"".Additionally, the URL to a graphic can be given on this form:  ""url(graphic.png)"". Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to Highcharts.SVGRenderer.prototype.symbols. The callback is then used by its method name, as shown in the demo.")]
            public string Symbol
            {
                get
                {
                    return this.State.Get<string>("Symbol", "");
                }
                set
                {
                    this.State.Set("Symbol", value);
                }
            }

            /// <summary>
            /// Image markers only. Set the image width explicitly. When using this option, a height must also be set.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Image markers only. Set the image width explicitly. When using this option, a height must also be set.")]
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


                list.Add("enabled", new ConfigOption("enabled", null, null, this.Enabled));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("height", new ConfigOption("height", null, null, this.Height));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#FFFFFF", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("radius", new ConfigOption("radius", null, 4, this.Radius));

                list.Add("symbol", new ConfigOption("symbol", null, "", this.Symbol));

                list.Add("width", new ConfigOption("width", null, null, this.Width));

                return list;
            }
        }


    

        /// <summary>
        /// 
        /// </summary>
        public partial class States : Observable
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


    

        /// <summary>
        /// 
        /// </summary>
        public partial class Hover : Observable
        {

    
            /// <summary>
            /// Enable or disable the point marker.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the point marker.")]
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
            /// The fill color of the marker in hover state.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The fill color of the marker in hover state.")]
            public string FillColor
            {
                get
                {
                    return this.State.Get<string>("FillColor", "");
                }
                set
                {
                    this.State.Set("FillColor", value);
                }
            }

            /// <summary>
            /// The color of the point marker's outline. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#FFFFFF")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the point marker's outline. When null, the series' or point's color is used.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#FFFFFF");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// The width of the point marker's outline.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the point marker's outline.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 0);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The additional line width for a hovered point.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The additional line width for a hovered point.")]
            public double? LineWidthPlus
            {
                get
                {
                    return this.State.Get<double?>("LineWidthPlus", 1);
                }
                set
                {
                    this.State.Set("LineWidthPlus", value);
                }
            }

            /// <summary>
            /// The radius of the point marker. In hover state, it defaults to the normal state's radius + 2 as per the radiusPlus option.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The radius of the point marker. In hover state, it defaults to the normal state's radius + 2 as per the radiusPlus option.")]
            public double? Radius
            {
                get
                {
                    return this.State.Get<double?>("Radius", null);
                }
                set
                {
                    this.State.Set("Radius", value);
                }
            }

            /// <summary>
            /// The number of pixels to increase the radius of the hovered point.
            /// </summary>
            [ConfigOption]
            [DefaultValue(2)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The number of pixels to increase the radius of the hovered point.")]
            public double? RadiusPlus
            {
                get
                {
                    return this.State.Get<double?>("RadiusPlus", 2);
                }
                set
                {
                    this.State.Set("RadiusPlus", value);
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


                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#FFFFFF", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("lineWidthPlus", new ConfigOption("lineWidthPlus", null, 1, this.LineWidthPlus));

                list.Add("radius", new ConfigOption("radius", null, null, this.Radius));

                list.Add("radiusPlus", new ConfigOption("radiusPlus", null, 2, this.RadiusPlus));

                return list;
            }
        }


    

        }


        /// <summary>
        /// The appearance of the point marker when selected. In order to allow a point to be 		selected, set the series.allowPointSelect option to true.
        /// </summary>
        public partial class Select : Observable
        {

    
            /// <summary>
            /// Enable or disable visible feedback for selection.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable visible feedback for selection.")]
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
            /// The fill color of the point marker.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The fill color of the point marker.")]
            public string FillColor
            {
                get
                {
                    return this.State.Get<string>("FillColor", "");
                }
                set
                {
                    this.State.Set("FillColor", value);
                }
            }

            /// <summary>
            /// The color of the point marker's outline. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#000000")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the point marker's outline. When null, the series' or point's color is used.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#000000");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// The width of the point marker's outline.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the point marker's outline.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 0);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The radius of the point marker. In hover state, it defaults		to the normal state's radius + 2.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The radius of the point marker. In hover state, it defaults		to the normal state's radius + 2.")]
            public double? Radius
            {
                get
                {
                    return this.State.Get<double?>("Radius", null);
                }
                set
                {
                    this.State.Set("Radius", value);
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


                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#000000", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("radius", new ConfigOption("radius", null, null, this.Radius));

                return list;
            }
        }


    

        }


        }


        }


        }


        /// <summary>
        /// 
        /// </summary>
        public partial class DataLabels : Observable
        {

    
            /// <summary>
            /// The alignment of the data label compared to the point.  If right, the right side of the label should be touching the point. For points with an extent, like columns, the alignments also dictates how to align it inside the box, as given with the inside option. Can be one of ""left"", ""center"" or ""right"".
            /// </summary>
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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

                return list;
            }
        }


    

        }


        /// <summary>
        /// 
        /// </summary>
        public partial class Events : Observable
        {

    
            /// <summary>
            /// Fires after the series has finished its initial animation, or in case animation is disabled, immediately as the series is displayed.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires after the series has finished its initial animation, or in case animation is disabled, immediately as the series is displayed.")]
            public string AfterAnimate
            {
                get
                {
                    return this.State.Get<string>("AfterAnimate", "");
                }
                set
                {
                    this.State.Set("AfterAnimate", value);
                }
            }

            /// <summary>
            /// Fires when the checkbox next to the series' name in the legend is clicked. One parameter, event, is passed to the function. The state of the checkbox is found by event.checked. The checked item is found by event.item. Return false to prevent the default action which is to toggle the select state of the series.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the checkbox next to the series' name in the legend is clicked. One parameter, event, is passed to the function. The state of the checkbox is found by event.checked. The checked item is found by event.item. Return false to prevent the default action which is to toggle the select state of the series.")]
            public string CheckboxClick
            {
                get
                {
                    return this.State.Get<string>("CheckboxClick", "");
                }
                set
                {
                    this.State.Set("CheckboxClick", value);
                }
            }

            /// <summary>
            /// Fires when the series is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Additionally, event.point holds a pointer to the nearest point on the graph.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the series is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Additionally, event.point holds a pointer to the nearest point on the graph.")]
            public string Click
            {
                get
                {
                    return this.State.Get<string>("Click", "");
                }
                set
                {
                    this.State.Set("Click", value);
                }
            }

            /// <summary>
            /// Fires when the series is hidden after chart generation time, either by clicking the legend item or by calling .hide().
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the series is hidden after chart generation time, either by clicking the legend item or by calling .hide().")]
            public string Hide
            {
                get
                {
                    return this.State.Get<string>("Hide", "");
                }
                set
                {
                    this.State.Set("Hide", value);
                }
            }

            /// <summary>
            /// Fires when the legend item belonging to the series is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. The default action is to toggle the visibility of the series. This can be prevented by returning false or calling event.preventDefault().
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the legend item belonging to the series is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. The default action is to toggle the visibility of the series. This can be prevented by returning false or calling event.preventDefault().")]
            public string LegendItemClick
            {
                get
                {
                    return this.State.Get<string>("LegendItemClick", "");
                }
                set
                {
                    this.State.Set("LegendItemClick", value);
                }
            }

            /// <summary>
            /// Fires when the mouse leaves the graph. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the  stickyTracking option is true, mouseOut doesn't happen before the mouse enters another graph or leaves the plot area.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the mouse leaves the graph. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the  stickyTracking option is true, mouseOut doesn't happen before the mouse enters another graph or leaves the plot area.")]
            public string MouseOut
            {
                get
                {
                    return this.State.Get<string>("MouseOut", "");
                }
                set
                {
                    this.State.Set("MouseOut", value);
                }
            }

            /// <summary>
            /// Fires when the mouse enters the graph. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the mouse enters the graph. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
            public string MouseOver
            {
                get
                {
                    return this.State.Get<string>("MouseOver", "");
                }
                set
                {
                    this.State.Set("MouseOver", value);
                }
            }

            /// <summary>
            /// Fires when the series is shown after chart generation time, either by clicking the legend item or by calling .show().
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the series is shown after chart generation time, either by clicking the legend item or by calling .show().")]
            public string Show
            {
                get
                {
                    return this.State.Get<string>("Show", "");
                }
                set
                {
                    this.State.Set("Show", value);
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


                list.Add("afterAnimate", new ConfigOption("afterAnimate", null, "", this.AfterAnimate));

                list.Add("checkboxClick", new ConfigOption("checkboxClick", null, "", this.CheckboxClick));

                list.Add("click", new ConfigOption("click", null, "", this.Click));

                list.Add("hide", new ConfigOption("hide", null, "", this.Hide));

                list.Add("legendItemClick", new ConfigOption("legendItemClick", null, "", this.LegendItemClick));

                list.Add("mouseOut", new ConfigOption("mouseOut", null, "", this.MouseOut));

                list.Add("mouseOver", new ConfigOption("mouseOver", null, "", this.MouseOver));

                list.Add("show", new ConfigOption("show", null, "", this.Show));

                return list;
            }
        }


    

        }


        /// <summary>
        /// 
        /// </summary>
        public partial class Marker : Observable
        {

    
            /// <summary>
            /// Enable or disable the point marker. If null, the markers are hidden when the data is dense, and shown for more widespread data points.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the point marker. If null, the markers are hidden when the data is dense, and shown for more widespread data points.")]
            public bool? Enabled
            {
                get
                {
                    return this.State.Get<bool?>("Enabled", null);
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// The fill color of the point marker. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The fill color of the point marker. When null, the series' or point's color is used.")]
            public string FillColor
            {
                get
                {
                    return this.State.Get<string>("FillColor", "");
                }
                set
                {
                    this.State.Set("FillColor", value);
                }
            }

            /// <summary>
            /// Image markers only. Set the image width explicitly. When using this option, a width must also be set.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Image markers only. Set the image width explicitly. When using this option, a width must also be set.")]
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
            /// The color of the point marker's outline. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#FFFFFF")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the point marker's outline. When null, the series' or point's color is used.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#FFFFFF");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// The width of the point marker's outline.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the point marker's outline.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 0);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The radius of the point marker.
            /// </summary>
            [ConfigOption]
            [DefaultValue(4)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The radius of the point marker.")]
            public double? Radius
            {
                get
                {
                    return this.State.Get<double?>("Radius", 4);
                }
                set
                {
                    this.State.Set("Radius", value);
                }
            }

            /// <summary>
            /// A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are ""circle"", ""square"", ""diamond"", ""triangle"" and ""triangle-down"".Additionally, the URL to a graphic can be given on this form:  ""url(graphic.png)"". Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to Highcharts.SVGRenderer.prototype.symbols. The callback is then used by its method name, as shown in the demo.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are ""circle"", ""square"", ""diamond"", ""triangle"" and ""triangle-down"".Additionally, the URL to a graphic can be given on this form:  ""url(graphic.png)"". Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to Highcharts.SVGRenderer.prototype.symbols. The callback is then used by its method name, as shown in the demo.")]
            public string Symbol
            {
                get
                {
                    return this.State.Get<string>("Symbol", "");
                }
                set
                {
                    this.State.Set("Symbol", value);
                }
            }

            /// <summary>
            /// Image markers only. Set the image width explicitly. When using this option, a height must also be set.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Image markers only. Set the image width explicitly. When using this option, a height must also be set.")]
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


                list.Add("enabled", new ConfigOption("enabled", null, null, this.Enabled));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("height", new ConfigOption("height", null, null, this.Height));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#FFFFFF", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("radius", new ConfigOption("radius", null, 4, this.Radius));

                list.Add("symbol", new ConfigOption("symbol", null, "", this.Symbol));

                list.Add("width", new ConfigOption("width", null, null, this.Width));

                return list;
            }
        }


    

        /// <summary>
        /// 
        /// </summary>
        public partial class States : Observable
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


    

        /// <summary>
        /// 
        /// </summary>
        public partial class Hover : Observable
        {

    
            /// <summary>
            /// Enable or disable the point marker.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the point marker.")]
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
            /// The fill color of the marker in hover state.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The fill color of the marker in hover state.")]
            public string FillColor
            {
                get
                {
                    return this.State.Get<string>("FillColor", "");
                }
                set
                {
                    this.State.Set("FillColor", value);
                }
            }

            /// <summary>
            /// The color of the point marker's outline. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#FFFFFF")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the point marker's outline. When null, the series' or point's color is used.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#FFFFFF");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// The width of the point marker's outline.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the point marker's outline.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 0);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The additional line width for a hovered point.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The additional line width for a hovered point.")]
            public double? LineWidthPlus
            {
                get
                {
                    return this.State.Get<double?>("LineWidthPlus", 1);
                }
                set
                {
                    this.State.Set("LineWidthPlus", value);
                }
            }

            /// <summary>
            /// The radius of the point marker. In hover state, it defaults to the normal state's radius + 2 as per the radiusPlus option.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The radius of the point marker. In hover state, it defaults to the normal state's radius + 2 as per the radiusPlus option.")]
            public double? Radius
            {
                get
                {
                    return this.State.Get<double?>("Radius", null);
                }
                set
                {
                    this.State.Set("Radius", value);
                }
            }

            /// <summary>
            /// The number of pixels to increase the radius of the hovered point.
            /// </summary>
            [ConfigOption]
            [DefaultValue(2)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The number of pixels to increase the radius of the hovered point.")]
            public double? RadiusPlus
            {
                get
                {
                    return this.State.Get<double?>("RadiusPlus", 2);
                }
                set
                {
                    this.State.Set("RadiusPlus", value);
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


                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#FFFFFF", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("lineWidthPlus", new ConfigOption("lineWidthPlus", null, 1, this.LineWidthPlus));

                list.Add("radius", new ConfigOption("radius", null, null, this.Radius));

                list.Add("radiusPlus", new ConfigOption("radiusPlus", null, 2, this.RadiusPlus));

                return list;
            }
        }


    

        }


        /// <summary>
        /// The appearance of the point marker when selected. In order to allow a point to be 		selected, set the series.allowPointSelect option to true.
        /// </summary>
        public partial class Select : Observable
        {

    
            /// <summary>
            /// Enable or disable visible feedback for selection.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable visible feedback for selection.")]
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
            /// The fill color of the point marker.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The fill color of the point marker.")]
            public string FillColor
            {
                get
                {
                    return this.State.Get<string>("FillColor", "");
                }
                set
                {
                    this.State.Set("FillColor", value);
                }
            }

            /// <summary>
            /// The color of the point marker's outline. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#000000")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the point marker's outline. When null, the series' or point's color is used.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#000000");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// The width of the point marker's outline.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the point marker's outline.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 0);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The radius of the point marker. In hover state, it defaults		to the normal state's radius + 2.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The radius of the point marker. In hover state, it defaults		to the normal state's radius + 2.")]
            public double? Radius
            {
                get
                {
                    return this.State.Get<double?>("Radius", null);
                }
                set
                {
                    this.State.Set("Radius", value);
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


                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#000000", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("radius", new ConfigOption("radius", null, null, this.Radius));

                return list;
            }
        }


    

        }


        }


        }


        /// <summary>
        /// Properties for each single point
        /// </summary>
        public partial class Point : Observable
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


    

        /// <summary>
        /// Events for each single point
        /// </summary>
        public partial class Events : Observable
        {

    
            /// <summary>
            /// Fires when a point is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state. Returning false cancels this action.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when a point is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state. Returning false cancels this action.")]
            public string Click
            {
                get
                {
                    return this.State.Get<string>("Click", "");
                }
                set
                {
                    this.State.Set("Click", value);
                }
            }

            /// <summary>
            /// Fires when the mouse leaves the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the mouse leaves the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
            public string MouseOut
            {
                get
                {
                    return this.State.Get<string>("MouseOut", "");
                }
                set
                {
                    this.State.Set("MouseOut", value);
                }
            }

            /// <summary>
            /// Fires when the mouse enters the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the mouse enters the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
            public string MouseOver
            {
                get
                {
                    return this.State.Get<string>("MouseOver", "");
                }
                set
                {
                    this.State.Set("MouseOver", value);
                }
            }

            /// <summary>
            /// Fires when the point is removed using the .remove() method. One parameter, event, is passed to the function. Returning false cancels the operation.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the point is removed using the .remove() method. One parameter, event, is passed to the function. Returning false cancels the operation.")]
            public string Remove
            {
                get
                {
                    return this.State.Get<string>("Remove", "");
                }
                set
                {
                    this.State.Set("Remove", value);
                }
            }

            /// <summary>
            /// Fires when the point is selected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the point is selected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.")]
            public string Select
            {
                get
                {
                    return this.State.Get<string>("Select", "");
                }
                set
                {
                    this.State.Set("Select", value);
                }
            }

            /// <summary>
            /// Fires when the point is unselected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the point is unselected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.")]
            public string Unselect
            {
                get
                {
                    return this.State.Get<string>("Unselect", "");
                }
                set
                {
                    this.State.Set("Unselect", value);
                }
            }

            /// <summary>
            /// Fires when the point is updated programmatically through the .update() method. One parameter, event, is passed to the function. The  new point options can be accessed through event.options. Returning false cancels the operation.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the point is updated programmatically through the .update() method. One parameter, event, is passed to the function. The  new point options can be accessed through event.options. Returning false cancels the operation.")]
            public string Update
            {
                get
                {
                    return this.State.Get<string>("Update", "");
                }
                set
                {
                    this.State.Set("Update", value);
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


                list.Add("click", new ConfigOption("click", null, "", this.Click));

                list.Add("mouseOut", new ConfigOption("mouseOut", null, "", this.MouseOut));

                list.Add("mouseOver", new ConfigOption("mouseOver", null, "", this.MouseOver));

                list.Add("remove", new ConfigOption("remove", null, "", this.Remove));

                list.Add("select", new ConfigOption("select", null, "", this.Select));

                list.Add("unselect", new ConfigOption("unselect", null, "", this.Unselect));

                list.Add("update", new ConfigOption("update", null, "", this.Update));

                return list;
            }
        }


    

        }


        }


        /// <summary>
        /// A wrapper object for all the series options in specific states.
        /// </summary>
        public partial class States : Observable
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


    

        /// <summary>
        /// Options for the hovered series
        /// </summary>
        public partial class Hover : Observable
        {

    
            /// <summary>
            /// Enable separate styles for the hovered series to visualize that the user hovers either the series itself or the legend.			.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable separate styles for the hovered series to visualize that the user hovers either the series itself or the legend.			.")]
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
            /// Pixel with of the graph line.
            /// </summary>
            [ConfigOption]
            [DefaultValue(2)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Pixel with of the graph line.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 2);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The additional line width for the graph of a hovered series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The additional line width for the graph of a hovered series.")]
            public double? LineWidthPlus
            {
                get
                {
                    return this.State.Get<double?>("LineWidthPlus", 1);
                }
                set
                {
                    this.State.Set("LineWidthPlus", value);
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


                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 2, this.LineWidth));

                list.Add("lineWidthPlus", new ConfigOption("lineWidthPlus", null, 1, this.LineWidthPlus));

                return list;
            }
        }


    

        /// <summary>
        /// Options for the halo appearing around the hovered point in line-type series as well as outside the hovered slice in pie charts. By default the halo is filled by the current point or series color with an opacity of 0.25. The halo can be disabled by setting the halo option to false.
        /// </summary>
        public partial class Halo : Observable
        {

    
            /// <summary>
            /// A collection of SVG attributes to override the appearance of the halo, for example fill, stroke and stroke-width.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A collection of SVG attributes to override the appearance of the halo, for example fill, stroke and stroke-width.")]
            public object Attributes
            {
                get
                {
                    return this.State.Get<object>("Attributes", null);
                }
                set
                {
                    this.State.Set("Attributes", value);
                }
            }

            /// <summary>
            /// Opacity for the halo unless a specific fill is overridden using the attributes setting. Note that Highcharts is only able to apply opacity to colors of hex or rgb(a) formats.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0.25)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Opacity for the halo unless a specific fill is overridden using the attributes setting. Note that Highcharts is only able to apply opacity to colors of hex or rgb(a) formats.")]
            public double? Opacity
            {
                get
                {
                    return this.State.Get<double?>("Opacity", 0.25);
                }
                set
                {
                    this.State.Set("Opacity", value);
                }
            }

            /// <summary>
            /// The pixel size of the halo. For point markers this is the radius of the halo. For pie slices it is the width of the halo outside the slice. For bubbles it defaults to 5 and is the width of the halo outside the bubble.
            /// </summary>
            [ConfigOption]
            [DefaultValue(10)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel size of the halo. For point markers this is the radius of the halo. For pie slices it is the width of the halo outside the slice. For bubbles it defaults to 5 and is the width of the halo outside the bubble.")]
            public double? Size
            {
                get
                {
                    return this.State.Get<double?>("Size", 10);
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


                list.Add("attributes", new ConfigOption("attributes", null, null, this.Attributes));

                list.Add("opacity", new ConfigOption("opacity", null, 0.25, this.Opacity));

                list.Add("size", new ConfigOption("size", null, 10, this.Size));

                return list;
            }
        }


    

        }


        /// <summary>
        /// 
        /// </summary>
        public partial class Marker : Observable
        {

    
            /// <summary>
            /// Enable or disable the point marker. If null, the markers are hidden when the data is dense, and shown for more widespread data points.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the point marker. If null, the markers are hidden when the data is dense, and shown for more widespread data points.")]
            public bool? Enabled
            {
                get
                {
                    return this.State.Get<bool?>("Enabled", null);
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// The fill color of the point marker. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The fill color of the point marker. When null, the series' or point's color is used.")]
            public string FillColor
            {
                get
                {
                    return this.State.Get<string>("FillColor", "");
                }
                set
                {
                    this.State.Set("FillColor", value);
                }
            }

            /// <summary>
            /// Image markers only. Set the image width explicitly. When using this option, a width must also be set.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Image markers only. Set the image width explicitly. When using this option, a width must also be set.")]
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
            /// The color of the point marker's outline. When null, the series' or point's color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#FFFFFF")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the point marker's outline. When null, the series' or point's color is used.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#FFFFFF");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// The width of the point marker's outline.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the point marker's outline.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 0);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The radius of the point marker.
            /// </summary>
            [ConfigOption]
            [DefaultValue(4)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The radius of the point marker.")]
            public double? Radius
            {
                get
                {
                    return this.State.Get<double?>("Radius", 4);
                }
                set
                {
                    this.State.Set("Radius", value);
                }
            }

            /// <summary>
            /// 
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"")]
            public string States
            {
                get
                {
                    return this.State.Get<string>("States", "");
                }
                set
                {
                    this.State.Set("States", value);
                }
            }

            /// <summary>
            /// A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are ""circle"", ""square"", ""diamond"", ""triangle"" and ""triangle-down"".Additionally, the URL to a graphic can be given on this form:  ""url(graphic.png)"". Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to Highcharts.SVGRenderer.prototype.symbols. The callback is then used by its method name, as shown in the demo.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A predefined shape or symbol for the marker. When null, the symbol is pulled from options.symbols. Other possible values are ""circle"", ""square"", ""diamond"", ""triangle"" and ""triangle-down"".Additionally, the URL to a graphic can be given on this form:  ""url(graphic.png)"". Note that for the image to be applied to exported charts, its URL needs to be accessible by the export server.Custom callbacks for symbol path generation can also be added to Highcharts.SVGRenderer.prototype.symbols. The callback is then used by its method name, as shown in the demo.")]
            public string Symbol
            {
                get
                {
                    return this.State.Get<string>("Symbol", "");
                }
                set
                {
                    this.State.Set("Symbol", value);
                }
            }

            /// <summary>
            /// Image markers only. Set the image width explicitly. When using this option, a height must also be set.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Image markers only. Set the image width explicitly. When using this option, a height must also be set.")]
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


                list.Add("enabled", new ConfigOption("enabled", null, null, this.Enabled));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("height", new ConfigOption("height", null, null, this.Height));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#FFFFFF", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("radius", new ConfigOption("radius", null, 4, this.Radius));

                list.Add("states", new ConfigOption("states", null, "", this.States));

                list.Add("symbol", new ConfigOption("symbol", null, "", this.Symbol));

                list.Add("width", new ConfigOption("width", null, null, this.Width));

                return list;
            }
        }


    

        }


        }


        }


        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip, but only the following properties can be defined on a series level.
        /// </summary>
        public partial class Tooltip : Observable
        {

    
            /// <summary>
            /// For series on a datetime axes, the date format in the tooltip's header will by default be guessed based on the closest data points. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat.Defaults to:{    millisecond:""%A, %b %e, %H:%M:%S.%L"",    second:""%A, %b %e, %H:%M:%S"",    minute:""%A, %b %e, %H:%M"",    hour:""%A, %b %e, %H:%M"",    day:""%A, %b %e, %Y"",    week:""Week from %A, %b %e, %Y"",    month:""%B %Y"",    year:""%Y""}
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"For series on a datetime axes, the date format in the tooltip's header will by default be guessed based on the closest data points. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat.Defaults to:{    millisecond:""%A, %b %e, %H:%M:%S.%L"",    second:""%A, %b %e, %H:%M:%S"",    minute:""%A, %b %e, %H:%M"",    hour:""%A, %b %e, %H:%M"",    day:""%A, %b %e, %Y"",    week:""Week from %A, %b %e, %Y"",    month:""%B %Y"",    year:""%Y""}")]
            public object DateTimeLabelFormats
            {
                get
                {
                    return this.State.Get<object>("DateTimeLabelFormats", null);
                }
                set
                {
                    this.State.Set("DateTimeLabelFormats", value);
                }
            }

            /// <summary>
            /// Whether the tooltip should follow the mouse as it moves across columns, pie slices and other point types with an extent. By default it behaves this way for scatter, bubble and pie series by override in the plotOptions for those series types. For touch moves to behave the same way, followTouchMove must be true also.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether the tooltip should follow the mouse as it moves across columns, pie slices and other point types with an extent. By default it behaves this way for scatter, bubble and pie series by override in the plotOptions for those series types. For touch moves to behave the same way, followTouchMove must be true also.")]
            public bool? FollowPointer
            {
                get
                {
                    return this.State.Get<bool?>("FollowPointer", false);
                }
                set
                {
                    this.State.Set("FollowPointer", value);
                }
            }

            /// <summary>
            /// Whether the tooltip should follow the finger as it moves on a touch device. If chart.zoomType is set, it will override followTouchMove.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether the tooltip should follow the finger as it moves on a touch device. If chart.zoomType is set, it will override followTouchMove.")]
            public bool? FollowTouchMove
            {
                get
                {
                    return this.State.Get<bool?>("FollowTouchMove", true);
                }
                set
                {
                    this.State.Set("FollowTouchMove", value);
                }
            }

            /// <summary>
            /// A string to append to the tooltip format.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"false")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A string to append to the tooltip format.")]
            public string FooterFormat
            {
                get
                {
                    return this.State.Get<string>("FooterFormat", @"false");
                }
                set
                {
                    this.State.Set("FooterFormat", value);
                }
            }

            /// <summary>
            /// The HTML of the tooltip header line. Variables are enclosed by curly brackets. Available variables			are point.key, series.name, series.color and other members from the point and series objects. The point.key variable contains the category name, x value or datetime string depending on the type of axis. For datetime axes, the point.key date format can be set using tooltip.xDateFormat. Defaults to &lt;span style=""font-size: 10px""&gt;{point.key}&lt;/span&gt;&lt;br/&gt;
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The HTML of the tooltip header line. Variables are enclosed by curly brackets. Available variables			are point.key, series.name, series.color and other members from the point and series objects. The point.key variable contains the category name, x value or datetime string depending on the type of axis. For datetime axes, the point.key date format can be set using tooltip.xDateFormat. Defaults to &lt;span style=""font-size: 10px""&gt;{point.key}&lt;/span&gt;&lt;br/&gt;")]
            public string HeaderFormat
            {
                get
                {
                    return this.State.Get<string>("HeaderFormat", "");
                }
                set
                {
                    this.State.Set("HeaderFormat", value);
                }
            }

            /// <summary>
            /// The number of milliseconds to wait until the tooltip is hidden when mouse out from a point or chart. 
            /// </summary>
            [ConfigOption]
            [DefaultValue(500)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The number of milliseconds to wait until the tooltip is hidden when mouse out from a point or chart. ")]
            public double? HideDelay
            {
                get
                {
                    return this.State.Get<double?>("HideDelay", 500);
                }
                set
                {
                    this.State.Set("HideDelay", value);
                }
            }

            /// <summary>
            /// The HTML of the point's line in the tooltip. Variables are enclosed by curly brackets. Available variables are point.x, point.y, series.name and series.color and other properties on the same form. Furthermore,  point.y can be extended by the tooltip.valuePrefix and tooltip.valueSuffix variables. This can also be overridden for each series, which makes it a good hook for displaying units.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"<span style=""color:{point.color}"">\u25CF</span> {series.name}: <b>{point.y}</b><br/>")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The HTML of the point's line in the tooltip. Variables are enclosed by curly brackets. Available variables are point.x, point.y, series.name and series.color and other properties on the same form. Furthermore,  point.y can be extended by the tooltip.valuePrefix and tooltip.valueSuffix variables. This can also be overridden for each series, which makes it a good hook for displaying units.")]
            public string PointFormat
            {
                get
                {
                    return this.State.Get<string>("PointFormat", @"<span style=""color:{point.color}"">\u25CF</span> {series.name}: <b>{point.y}</b><br/>");
                }
                set
                {
                    this.State.Set("PointFormat", value);
                }
            }

            /// <summary>
            /// A callback function for formatting the HTML output for a single point in the tooltip. Like the pointFormat string, but with more flexibility.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A callback function for formatting the HTML output for a single point in the tooltip. Like the pointFormat string, but with more flexibility.")]
            public string PointFormatter
            {
                get
                {
                    return this.State.Get<string>("PointFormatter", "");
                }
                set
                {
                    this.State.Set("PointFormatter", value);
                }
            }

            /// <summary>
            /// How many decimals to show in each series' y value. This is overridable in each series' tooltip options object. The default is to preserve all decimals.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"How many decimals to show in each series' y value. This is overridable in each series' tooltip options object. The default is to preserve all decimals.")]
            public double? ValueDecimals
            {
                get
                {
                    return this.State.Get<double?>("ValueDecimals", null);
                }
                set
                {
                    this.State.Set("ValueDecimals", value);
                }
            }

            /// <summary>
            /// A string to prepend to each series' y value. Overridable in each series' tooltip options object.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A string to prepend to each series' y value. Overridable in each series' tooltip options object.")]
            public string ValuePrefix
            {
                get
                {
                    return this.State.Get<string>("ValuePrefix", "");
                }
                set
                {
                    this.State.Set("ValuePrefix", value);
                }
            }

            /// <summary>
            /// A string to append to each series' y value. Overridable in each series' tooltip options object.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A string to append to each series' y value. Overridable in each series' tooltip options object.")]
            public string ValueSuffix
            {
                get
                {
                    return this.State.Get<string>("ValueSuffix", "");
                }
                set
                {
                    this.State.Set("ValueSuffix", value);
                }
            }

            /// <summary>
            /// The format for the date in the tooltip header if the X axis is a datetime axis. The default is a best guess based on the smallest distance between points in the chart.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The format for the date in the tooltip header if the X axis is a datetime axis. The default is a best guess based on the smallest distance between points in the chart.")]
            public string XDateFormat
            {
                get
                {
                    return this.State.Get<string>("XDateFormat", "");
                }
                set
                {
                    this.State.Set("XDateFormat", value);
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


                list.Add("dateTimeLabelFormats", new ConfigOption("dateTimeLabelFormats", null, null, this.DateTimeLabelFormats));

                list.Add("followPointer", new ConfigOption("followPointer", null, false, this.FollowPointer));

                list.Add("followTouchMove", new ConfigOption("followTouchMove", null, true, this.FollowTouchMove));

                list.Add("footerFormat", new ConfigOption("footerFormat", null, @"false", this.FooterFormat));

                list.Add("headerFormat", new ConfigOption("headerFormat", null, "", this.HeaderFormat));

                list.Add("hideDelay", new ConfigOption("hideDelay", null, 500, this.HideDelay));

                list.Add("pointFormat", new ConfigOption("pointFormat", null, @"<span style=""color:{point.color}"">\u25CF</span> {series.name}: <b>{point.y}</b><br/>", this.PointFormat));

                list.Add("pointFormatter", new ConfigOption("pointFormatter", null, "", this.PointFormatter));

                list.Add("valueDecimals", new ConfigOption("valueDecimals", null, null, this.ValueDecimals));

                list.Add("valuePrefix", new ConfigOption("valuePrefix", null, "", this.ValuePrefix));

                list.Add("valueSuffix", new ConfigOption("valueSuffix", null, "", this.ValueSuffix));

                list.Add("xDateFormat", new ConfigOption("xDateFormat", null, "", this.XDateFormat));

                return list;
            }
        }


    

        }


        /// <summary>
        /// An array defining zones within a series. Zones can be applied to the X axis, Y axis or Z axis for bubbles, according to the zoneAxis option.
        /// </summary>
        public partial class Zones : Observable
        {

    
            /// <summary>
            /// Defines the color of the series.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Defines the color of the series.")]
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
            /// A name for the dash style to use for the graph.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A name for the dash style to use for the graph.")]
            public string DashStyle
            {
                get
                {
                    return this.State.Get<string>("DashStyle", "");
                }
                set
                {
                    this.State.Set("DashStyle", value);
                }
            }

            /// <summary>
            /// Defines the fill color for the series (in area type series)
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Defines the fill color for the series (in area type series)")]
            public string FillColor
            {
                get
                {
                    return this.State.Get<string>("FillColor", "");
                }
                set
                {
                    this.State.Set("FillColor", value);
                }
            }

            /// <summary>
            /// The value up to where the zone extends, if undefined the zones stretches to the last value in the series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The value up to where the zone extends, if undefined the zones stretches to the last value in the series.")]
            public double? Value
            {
                get
                {
                    return this.State.Get<double?>("Value", null);
                }
                set
                {
                    this.State.Set("Value", value);
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


                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("dashStyle", new ConfigOption("dashStyle", null, "", this.DashStyle));

                list.Add("fillColor", new ConfigOption("fillColor", null, "", this.FillColor));

                list.Add("value", new ConfigOption("value", null, null, this.Value));

                return list;
            }
        }


    

        }


        }

        
}
            