
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
        /// A bar series. If the .type">type option is not specified, it is inherited from chart.type.For options that apply to multiple series, it is recommended to add them to the pointOptions.series options structure. To apply to all series of this specific type, apply it to plotOptions.bar.
        /// </summary>
        public partial class Bar : Observable
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
            /// The color of the border surrounding each column or bar.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#FFFFFF")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the border surrounding each column or bar.")]
            public string BorderColor
            {
                get
                {
                    return this.State.Get<string>("BorderColor", @"#FFFFFF");
                }
                set
                {
                    this.State.Set("BorderColor", value);
                }
            }

            /// <summary>
            /// The corner radius of the border surrounding each column or bar.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The corner radius of the border surrounding each column or bar.")]
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
            /// The width of the border surrounding each column or bar.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the border surrounding each column or bar.")]
            public double? BorderWidth
            {
                get
                {
                    return this.State.Get<double?>("BorderWidth", 1);
                }
                set
                {
                    this.State.Set("BorderWidth", value);
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
            /// When the series contains less points than the crop threshold, all points are drawn,  event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.  .
            /// </summary>
            [ConfigOption]
            [DefaultValue(50)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When the series contains less points than the crop threshold, all points are drawn,  event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.  .")]
            public double? CropThreshold
            {
                get
                {
                    return this.State.Get<double?>("CropThreshold", 50);
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
            /// Padding between each value groups, in x axis units.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0.2)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Padding between each value groups, in x axis units.")]
            public double? GroupPadding
            {
                get
                {
                    return this.State.Get<double?>("GroupPadding", 0.2);
                }
                set
                {
                    this.State.Set("GroupPadding", value);
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
            /// Whether to group non-stacked columns or to let them render independent of each other. Non-grouped columns will be laid out individually and overlap each other.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to group non-stacked columns or to let them render independent of each other. Non-grouped columns will be laid out individually and overlap each other.")]
            public bool? Grouping
            {
                get
                {
                    return this.State.Get<bool?>("Grouping", true);
                }
                set
                {
                    this.State.Set("Grouping", value);
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
            /// The minimal height for a column or width for a bar. By default, 0 values are not shown. To visualize a 0 (or close to zero) point, set the minimal point length to a  pixel value like 3. In stacked column charts, minPointLength might not be respected for tightly packed values.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The minimal height for a column or width for a bar. By default, 0 values are not shown. To visualize a 0 (or close to zero) point, set the minimal point length to a  pixel value like 3. In stacked column charts, minPointLength might not be respected for tightly packed values.")]
            public double? MinPointLength
            {
                get
                {
                    return this.State.Get<double?>("MinPointLength", 0);
                }
                set
                {
                    this.State.Set("MinPointLength", value);
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
            /// The Y axis value to serve as the base for the columns, for distinguishing between values above and below a threshold. If null, the columns extend from the padding Y axis minimum.
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The Y axis value to serve as the base for the columns, for distinguishing between values above and below a threshold. If null, the columns extend from the padding Y axis minimum.")]
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

                list.Add("borderColor", new ConfigOption("borderColor", null, @"#FFFFFF", this.BorderColor));

                list.Add("borderRadius", new ConfigOption("borderRadius", null, 0, this.BorderRadius));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 1, this.BorderWidth));

                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("colorByPoint", new ConfigOption("colorByPoint", null, false, this.ColorByPoint));

                list.Add("colors", new ConfigOption("colors", null, null, this.Colors));

                list.Add("cropThreshold", new ConfigOption("cropThreshold", null, 50, this.CropThreshold));

                list.Add("cursor", new ConfigOption("cursor", null, "", this.Cursor));

                list.Add("depth", new ConfigOption("depth", null, 25, this.Depth));

                list.Add("edgeColor", new ConfigOption("edgeColor", null, "", this.EdgeColor));

                list.Add("edgeWidth", new ConfigOption("edgeWidth", null, 1, this.EdgeWidth));

                list.Add("enableMouseTracking", new ConfigOption("enableMouseTracking", null, true, this.EnableMouseTracking));

                list.Add("getExtremesFromAll", new ConfigOption("getExtremesFromAll", null, false, this.GetExtremesFromAll));

                list.Add("groupPadding", new ConfigOption("groupPadding", null, 0.2, this.GroupPadding));

                list.Add("groupZPadding", new ConfigOption("groupZPadding", null, 1, this.GroupZPadding));

                list.Add("grouping", new ConfigOption("grouping", null, true, this.Grouping));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("index", new ConfigOption("index", null, null, this.Index));

                list.Add("keys", new ConfigOption("keys", null, null, this.Keys));

                list.Add("legendIndex", new ConfigOption("legendIndex", null, null, this.LegendIndex));

                list.Add("linkedTo", new ConfigOption("linkedTo", null, "", this.LinkedTo));

                list.Add("maxPointWidth", new ConfigOption("maxPointWidth", null, null, this.MaxPointWidth));

                list.Add("minPointLength", new ConfigOption("minPointLength", null, 0, this.MinPointLength));

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

                list.Add("shadow", new ConfigOption("shadow", null, null, this.Shadow));

                list.Add("showCheckbox", new ConfigOption("showCheckbox", null, false, this.ShowCheckbox));

                list.Add("showInLegend", new ConfigOption("showInLegend", null, true, this.ShowInLegend));

                list.Add("stack", new ConfigOption("stack", null, "", this.Stack));

                list.Add("stacking", new ConfigOption("stacking", null, "", this.Stacking));

                list.Add("stickyTracking", new ConfigOption("stickyTracking", null, true, this.StickyTracking));

                list.Add("threshold", new ConfigOption("threshold", null, 0, this.Threshold));

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
        /// An array of data points for the series. For the bar series type, points can be given in the following ways:  	An array of numerical values. In this case, the numerical values will  	be interpreted as y options. The x values will be automatically calculated, 	either starting at 0 and incremented by 1, or from pointStart  	and pointInterval given in the series options. If the axis 	has categories, these will be used.  Example:data: [0, 5, 3, 5] 	 	An array of arrays with 2 values. In this case, the values correspond to x,y. If the first value is a string, it is 	applied as the name of the point, and the x value is inferred. data: [    [0, 5],     [1, 10],     [2, 3]]An array of objects with named values. The objects are 	point configuration objects as seen below. If the total number of data points exceeds the series' .turboThreshold'>turboThreshold, this option is not available.data: [{    x: 1,    y: 1,    name: "Point2",    color: "#00FF00"}, {    x: 1,    y: 10,    name: "Point1",    color: "#FF00FF"}] 
        /// </summary>
        public partial class Data : Observable
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


        /// <summary>
        /// 
        /// </summary>
        public partial class DataLabels : Observable
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


        /// <summary>
        /// 
        /// </summary>
        public partial class Events : Observable
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


    

        }


        /// <summary>
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip, but only the following properties can be defined on a series level.
        /// </summary>
        public partial class Tooltip : Observable
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


        /// <summary>
        /// An array defining zones within a series. Zones can be applied to the X axis, Y axis or Z axis for bubbles, according to the zoneAxis option.
        /// </summary>
        public partial class Zones : Observable
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
            