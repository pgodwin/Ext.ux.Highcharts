
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
        /// A errorbar series. If the .type">type option is not specified, it is inherited from chart.type.For options that apply to multiple series, it is recommended to add them to the pointOptions.series options structure. To apply to all series of this specific type, apply it to plotOptions.errorbar.
        /// </summary>
        public partial class Errorbar : Observable
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
            /// The main color of the bars. This can be overridden by stemColor and whiskerColor individually. 
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#000000")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The main color of the bars. This can be overridden by stemColor and whiskerColor individually. ")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", @"#000000");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// When using automatic point colors pulled from the options.colors collection, this option determines whether the chart should receive  one color per series or one color per point.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When using automatic point colors pulled from the options.colors collection, this option determines whether the chart should receive  one color per series or one color per point.")]
            public bool? ColorByPoint
            {
                get
                {
                    return this.State.Get<bool?>("ColorByPoint", false);
                }
                set
                {
                    this.State.Set("ColorByPoint", value);
                }
            }

            /// <summary>
            /// A series specific or series type specific color set to apply instead of the global colors when colorByPoint is true.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A series specific or series type specific color set to apply instead of the global colors when colorByPoint is true.")]
            public string[] Colors
            {
                get
                {
                    return this.State.Get<string[]>("Colors", null);
                }
                set
                {
                    this.State.Set("Colors", value);
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
            /// Depth of the columns in a 3D column chart. Requires highcharts-3d.js.
            /// </summary>
            [ConfigOption]
            [DefaultValue(25)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Depth of the columns in a 3D column chart. Requires highcharts-3d.js.")]
            public double? Depth
            {
                get
                {
                    return this.State.Get<double?>("Depth", 25);
                }
                set
                {
                    this.State.Set("Depth", value);
                }
            }

            /// <summary>
            /// 3D columns only. The color of the edges. Similar to borderColor, except it defaults to the same color as the column.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"3D columns only. The color of the edges. Similar to borderColor, except it defaults to the same color as the column.")]
            public string EdgeColor
            {
                get
                {
                    return this.State.Get<string>("EdgeColor", "");
                }
                set
                {
                    this.State.Set("EdgeColor", value);
                }
            }

            /// <summary>
            /// 3D columns only. The width of the colored edges.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"3D columns only. The width of the colored edges.")]
            public double? EdgeWidth
            {
                get
                {
                    return this.State.Get<double?>("EdgeWidth", 1);
                }
                set
                {
                    this.State.Set("EdgeWidth", value);
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
            /// The spacing between columns on the Z Axis in a 3D chart. Requires highcharts-3d.js.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The spacing between columns on the Z Axis in a 3D chart. Requires highcharts-3d.js.")]
            public double? GroupZPadding
            {
                get
                {
                    return this.State.Get<double?>("GroupZPadding", 1);
                }
                set
                {
                    this.State.Set("GroupZPadding", value);
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
            /// The width of the line surrounding the box. If any of stemWidth, medianWidth or whiskerWidth are null, the lineWidth also applies to these lines.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the line surrounding the box. If any of stemWidth, medianWidth or whiskerWidth are null, the lineWidth also applies to these lines.")]
            public double? LineWidth
            {
                get
                {
                    return this.State.Get<double?>("LineWidth", 1);
                }
                set
                {
                    this.State.Set("LineWidth", value);
                }
            }

            /// <summary>
            /// The parent series of the error bar. The default value links it to the previous series. Otherwise, use the id of the parent series.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@":previous")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The parent series of the error bar. The default value links it to the previous series. Otherwise, use the id of the parent series.")]
            public string LinkedTo
            {
                get
                {
                    return this.State.Get<string>("LinkedTo", @":previous");
                }
                set
                {
                    this.State.Set("LinkedTo", value);
                }
            }

            /// <summary>
            /// The maximum allowed pixel width for a column, translated to the height of a bar in a bar chart. This prevents the columns from becoming too wide when there is a small number of points in the chart.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The maximum allowed pixel width for a column, translated to the height of a bar in a bar chart. This prevents the columns from becoming too wide when there is a small number of points in the chart.")]
            public double? MaxPointWidth
            {
                get
                {
                    return this.State.Get<double?>("MaxPointWidth", null);
                }
                set
                {
                    this.State.Set("MaxPointWidth", value);
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
            /// Padding between each column or bar, in x axis units.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0.1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Padding between each column or bar, in x axis units.")]
            public double? PointPadding
            {
                get
                {
                    return this.State.Get<double?>("PointPadding", 0.1);
                }
                set
                {
                    this.State.Set("PointPadding", value);
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
            /// The X axis range that each point is valid for. This determines the width of the column. On a categorized axis, the range will be 1 by default (one category unit). On linear and datetime axes, the range will be computed as the distance between the two closest data points.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The X axis range that each point is valid for. This determines the width of the column. On a categorized axis, the range will be 1 by default (one category unit). On linear and datetime axes, the range will be computed as the distance between the two closest data points.")]
            public double? PointRange
            {
                get
                {
                    return this.State.Get<double?>("PointRange", null);
                }
                set
                {
                    this.State.Set("PointRange", value);
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
            /// A pixel value specifying a fixed width for each column or bar. When null, the width is calculated from the pointPadding and groupPadding.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A pixel value specifying a fixed width for each column or bar. When null, the width is calculated from the pointPadding and groupPadding.")]
            public double? PointWidth
            {
                get
                {
                    return this.State.Get<double?>("PointWidth", null);
                }
                set
                {
                    this.State.Set("PointWidth", value);
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
            /// The color of the stem, the vertical line extending from the box to the whiskers. If null, the series color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the stem, the vertical line extending from the box to the whiskers. If null, the series color is used.")]
            public string StemColor
            {
                get
                {
                    return this.State.Get<string>("StemColor", @"null");
                }
                set
                {
                    this.State.Set("StemColor", value);
                }
            }

            /// <summary>
            /// The dash style of the stem, the vertical line extending from the box to the whiskers.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"Solid")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The dash style of the stem, the vertical line extending from the box to the whiskers.")]
            public string StemDashStyle
            {
                get
                {
                    return this.State.Get<string>("StemDashStyle", @"Solid");
                }
                set
                {
                    this.State.Set("StemDashStyle", value);
                }
            }

            /// <summary>
            /// The width of the stem, the vertical line extending from the box to the whiskers. If null, the width is inherited from the lineWidth option.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the stem, the vertical line extending from the box to the whiskers. If null, the width is inherited from the lineWidth option.")]
            public double? StemWidth
            {
                get
                {
                    return this.State.Get<double?>("StemWidth", null);
                }
                set
                {
                    this.State.Set("StemWidth", value);
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
            /// The color of the whiskers, the horizontal lines marking low and high values. When null, the general series color is used.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the whiskers, the horizontal lines marking low and high values. When null, the general series color is used.")]
            public string WhiskerColor
            {
                get
                {
                    return this.State.Get<string>("WhiskerColor", @"null");
                }
                set
                {
                    this.State.Set("WhiskerColor", value);
                }
            }

            /// <summary>
            /// The length of the whiskers, the horizontal lines marking low and high values. It can be a numerical pixel value, or a percentage value of the box width. Set 0 to disable whiskers.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The length of the whiskers, the horizontal lines marking low and high values. It can be a numerical pixel value, or a percentage value of the box width. Set 0 to disable whiskers.")]
            public object WhiskerLength
            {
                get
                {
                    return this.State.Get<object>("WhiskerLength", null);
                }
                set
                {
                    this.State.Set("WhiskerLength", value);
                }
            }

            /// <summary>
            /// The line width of the whiskers, the horizontal lines marking low and high values. When null, the general lineWidth applies.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The line width of the whiskers, the horizontal lines marking low and high values. When null, the general lineWidth applies.")]
            public double? WhiskerWidth
            {
                get
                {
                    return this.State.Get<double?>("WhiskerWidth", null);
                }
                set
                {
                    this.State.Set("WhiskerWidth", value);
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

                list.Add("color", new ConfigOption("color", null, @"#000000", this.Color));

                list.Add("colorByPoint", new ConfigOption("colorByPoint", null, false, this.ColorByPoint));

                list.Add("colors", new ConfigOption("colors", null, null, this.Colors));

                list.Add("cursor", new ConfigOption("cursor", null, "", this.Cursor));

                list.Add("depth", new ConfigOption("depth", null, 25, this.Depth));

                list.Add("edgeColor", new ConfigOption("edgeColor", null, "", this.EdgeColor));

                list.Add("edgeWidth", new ConfigOption("edgeWidth", null, 1, this.EdgeWidth));

                list.Add("enableMouseTracking", new ConfigOption("enableMouseTracking", null, true, this.EnableMouseTracking));

                list.Add("getExtremesFromAll", new ConfigOption("getExtremesFromAll", null, false, this.GetExtremesFromAll));

                list.Add("groupZPadding", new ConfigOption("groupZPadding", null, 1, this.GroupZPadding));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("index", new ConfigOption("index", null, null, this.Index));

                list.Add("keys", new ConfigOption("keys", null, null, this.Keys));

                list.Add("legendIndex", new ConfigOption("legendIndex", null, null, this.LegendIndex));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 1, this.LineWidth));

                list.Add("linkedTo", new ConfigOption("linkedTo", null, @":previous", this.LinkedTo));

                list.Add("maxPointWidth", new ConfigOption("maxPointWidth", null, null, this.MaxPointWidth));

                list.Add("name", new ConfigOption("name", null, "", this.Name));

                list.Add("negativeColor", new ConfigOption("negativeColor", null, @"null", this.NegativeColor));

                list.Add("pointInterval", new ConfigOption("pointInterval", null, 1, this.PointInterval));

                list.Add("pointIntervalUnit", new ConfigOption("pointIntervalUnit", null, "", this.PointIntervalUnit));

                list.Add("pointPadding", new ConfigOption("pointPadding", null, 0.1, this.PointPadding));

                list.Add("pointPlacement", new ConfigOption("pointPlacement", null, null, this.PointPlacement));

                list.Add("pointRange", new ConfigOption("pointRange", null, null, this.PointRange));

                list.Add("pointStart", new ConfigOption("pointStart", null, 0, this.PointStart));

                list.Add("pointWidth", new ConfigOption("pointWidth", null, null, this.PointWidth));

                list.Add("selected", new ConfigOption("selected", null, false, this.Selected));

                list.Add("stemColor", new ConfigOption("stemColor", null, @"null", this.StemColor));

                list.Add("stemDashStyle", new ConfigOption("stemDashStyle", null, @"Solid", this.StemDashStyle));

                list.Add("stemWidth", new ConfigOption("stemWidth", null, null, this.StemWidth));

                list.Add("stickyTracking", new ConfigOption("stickyTracking", null, true, this.StickyTracking));

                list.Add("turboThreshold", new ConfigOption("turboThreshold", null, 1000, this.TurboThreshold));

                list.Add("type", new ConfigOption("type", null, "", this.Type));

                list.Add("visible", new ConfigOption("visible", null, true, this.Visible));

                list.Add("whiskerColor", new ConfigOption("whiskerColor", null, @"null", this.WhiskerColor));

                list.Add("whiskerLength", new ConfigOption("whiskerLength", null, null, this.WhiskerLength));

                list.Add("whiskerWidth", new ConfigOption("whiskerWidth", null, null, this.WhiskerWidth));

                list.Add("xAxis", new ConfigOption("xAxis", null, null, this.XAxis));

                list.Add("yAxis", new ConfigOption("yAxis", null, null, this.YAxis));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                list.Add("zoneAxis", new ConfigOption("zoneAxis", null, @"y", this.ZoneAxis));

                return list;
            }
        }


    

        /// <summary>
        /// An array of data points for the series. For the errorbar series type, points can be given in the following ways:  	An array of arrays with 3 or 2 values. In this case, the values correspond to x,low,high. If the first value is a string, it is 	applied as the name of the point, and the x value is inferred. The x value can also be omitted, in which case the inner arrays should be of length 2. Then the x value is automatically calculated, either starting at 0 and incremented by 1, or from pointStart  	and pointInterval given in the series options.data: [    [0, 10, 2],     [1, 1, 8],     [2, 4, 5]]An array of objects with named values. The objects are 	point configuration objects as seen below. If the total number of data points exceeds the series' .turboThreshold'>turboThreshold, this option is not available.data: [{    x: 1,    low: 0,    high: 0,    name: "Point2",    color: "#00FF00"}, {    x: 1,    low: 5,    high: 5,    name: "Point1",    color: "#FF00FF"}] 
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
            /// The high or maximum value for each data point.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The high or maximum value for each data point.")]
            public double? High
            {
                get
                {
                    return this.State.Get<double?>("High", null);
                }
                set
                {
                    this.State.Set("High", value);
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
            /// The low or minimum value for each data point.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The low or minimum value for each data point.")]
            public double? Low
            {
                get
                {
                    return this.State.Get<double?>("Low", null);
                }
                set
                {
                    this.State.Set("Low", value);
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

                list.Add("high", new ConfigOption("high", null, null, this.High));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("low", new ConfigOption("low", null, null, this.Low));

                list.Add("name", new ConfigOption("name", null, "", this.Name));

                list.Add("selected", new ConfigOption("selected", null, false, this.Selected));

                list.Add("x", new ConfigOption("x", null, null, this.x));

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
            