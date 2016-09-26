
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
        /// The X axis or category axis. Normally this is the horizontal axis, though if the 	chart is inverted this is the vertical axis. In case of multiple axes, the xAxis	node is an array of configuration objects.	See the Axis object for programmatic	access to the axis.
        /// </summary>
        public partial class XAxis : Observable
        {

    
            /// <summary>
            /// Whether to allow decimals in this axis' ticks. When counting integers, like persons or hits on a web page, decimals must be avoided in the axis tick labels.
            /// </summary>
            [ConfigOption("allowDecimals", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to allow decimals in this axis' ticks. When counting integers, like persons or hits on a web page, decimals must be avoided in the axis tick labels.")]
            public bool? AllowDecimals
            {
                get
                {
                    return this.State.Get<bool?>("AllowDecimals", true);
                }
                set
                {
                    this.State.Set("AllowDecimals", value);
                }
            }

            /// <summary>
            /// When using an alternate grid color, a band is painted across the plot area between every other grid line.
            /// </summary>
            [ConfigOption("alternateGridColor", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When using an alternate grid color, a band is painted across the plot area between every other grid line.")]
            public string AlternateGridColor
            {
                get
                {
                    return this.State.Get<string>("AlternateGridColor", "");
                }
                set
                {
                    this.State.Set("AlternateGridColor", value);
                }
            }

            /// <summary>
            /// If categories are present for the xAxis, names are used instead of numbers for that axis. Since Highcharts 3.0, categories can also be extracted by giving each point a name and setting axis type to category. However, if you have multiple series, best practice remains defining the categories array.Example:categories: ['Apples', 'Bananas', 'Oranges']		 Defaults to null
            /// </summary>
            [ConfigOption("categories", JsonMode.AlwaysArray)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If categories are present for the xAxis, names are used instead of numbers for that axis. Since Highcharts 3.0, categories can also be extracted by giving each point a name and setting axis type to category. However, if you have multiple series, best practice remains defining the categories array.Example:categories: ['Apples', 'Bananas', 'Oranges']		 Defaults to null")]
            public string[] Categories
            {
                get
                {
                    return this.State.Get<string[]>("Categories", null);
                }
                set
                {
                    this.State.Set("Categories", value);
                }
            }

            /// <summary>
            /// The highest allowed value for automatically computed axis extremes.
            /// </summary>
            [ConfigOption("ceiling", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The highest allowed value for automatically computed axis extremes.")]
            public double? Ceiling
            {
                get
                {
                    return this.State.Get<double?>("Ceiling", null);
                }
                set
                {
                    this.State.Set("Ceiling", value);
                }
            }

            /// <summary>
            /// For a datetime axis, the scale will automatically adjust to the appropriate unit. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat. Defaults to:{	millisecond: '%H:%M:%S.%L',	second: '%H:%M:%S',	minute: '%H:%M',	hour: '%H:%M',	day: '%e. %b',	week: '%e. %b',	month: '%b \'%y',	year: '%Y'}
            /// </summary>
            [ConfigOption("dateTimeLabelFormats", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"For a datetime axis, the scale will automatically adjust to the appropriate unit. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat. Defaults to:{	millisecond: '%H:%M:%S.%L',	second: '%H:%M:%S',	minute: '%H:%M',	hour: '%H:%M',	day: '%e. %b',	week: '%e. %b',	month: '%b \'%y',	year: '%Y'}")]
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
            /// Whether to force the axis to end on a tick. Use this option with the maxPadding option to control the axis end.
            /// </summary>
            [ConfigOption("endOnTick", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to force the axis to end on a tick. Use this option with the maxPadding option to control the axis end.")]
            public bool? EndOnTick
            {
                get
                {
                    return this.State.Get<bool?>("EndOnTick", false);
                }
                set
                {
                    this.State.Set("EndOnTick", value);
                }
            }

            /// <summary>
            /// The lowest allowed value for automatically computed axis extremes.
            /// </summary>
            [ConfigOption("floor", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The lowest allowed value for automatically computed axis extremes.")]
            public double? Floor
            {
                get
                {
                    return this.State.Get<double?>("Floor", null);
                }
                set
                {
                    this.State.Set("Floor", value);
                }
            }

            /// <summary>
            /// Color of the grid lines extending the ticks across the plot area.
            /// </summary>
            [ConfigOption("gridLineColor", null)]
            [DefaultValue(@"#D8D8D8")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Color of the grid lines extending the ticks across the plot area.")]
            public string GridLineColor
            {
                get
                {
                    return this.State.Get<string>("GridLineColor", @"#D8D8D8");
                }
                set
                {
                    this.State.Set("GridLineColor", value);
                }
            }

            /// <summary>
            /// The dash or dot style of the grid lines. For possible values, see this demonstration.
            /// </summary>
            [ConfigOption("gridLineDashStyle", null)]
            [DefaultValue(@"Solid")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The dash or dot style of the grid lines. For possible values, see this demonstration.")]
            public string GridLineDashStyle
            {
                get
                {
                    return this.State.Get<string>("GridLineDashStyle", @"Solid");
                }
                set
                {
                    this.State.Set("GridLineDashStyle", value);
                }
            }

            /// <summary>
            /// The width of the grid lines extending the ticks across the plot area.
            /// </summary>
            [ConfigOption("gridLineWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the grid lines extending the ticks across the plot area.")]
            public double? GridLineWidth
            {
                get
                {
                    return this.State.Get<double?>("GridLineWidth", 0);
                }
                set
                {
                    this.State.Set("GridLineWidth", value);
                }
            }

            /// <summary>
            /// The Z index of the grid lines.
            /// </summary>
            [ConfigOption("gridZIndex", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The Z index of the grid lines.")]
            public double? GridZIndex
            {
                get
                {
                    return this.State.Get<double?>("GridZIndex", 1);
                }
                set
                {
                    this.State.Set("GridZIndex", value);
                }
            }

            /// <summary>
            /// An id for the axis. This can be used after render time to get a pointer to the axis object through chart.get().
            /// </summary>
            [ConfigOption("id", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An id for the axis. This can be used after render time to get a pointer to the axis object through chart.get().")]
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
            /// The color of the line marking the axis itself.
            /// </summary>
            [ConfigOption("lineColor", null)]
            [DefaultValue(@"#C0D0E0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the line marking the axis itself.")]
            public string LineColor
            {
                get
                {
                    return this.State.Get<string>("LineColor", @"#C0D0E0");
                }
                set
                {
                    this.State.Set("LineColor", value);
                }
            }

            /// <summary>
            /// The width of the line marking the axis itself.
            /// </summary>
            [ConfigOption("lineWidth", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the line marking the axis itself.")]
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
            /// Index of another axis that this axis is linked to. When an axis is linked to a master axis, it will take the same extremes as the master, but as assigned by min or max or by setExtremes. It can be used to show additional info, or to ease reading the chart by duplicating the scales.
            /// </summary>
            [ConfigOption("linkedTo", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Index of another axis that this axis is linked to. When an axis is linked to a master axis, it will take the same extremes as the master, but as assigned by min or max or by setExtremes. It can be used to show additional info, or to ease reading the chart by duplicating the scales.")]
            public double? LinkedTo
            {
                get
                {
                    return this.State.Get<double?>("LinkedTo", null);
                }
                set
                {
                    this.State.Set("LinkedTo", value);
                }
            }

            /// <summary>
            /// The maximum value of the axis. If null, the max value is automatically calculated. If the endOnTick option is true, the max value might be rounded up. The actual maximum value is also influenced by  chart.alignTicks.
            /// </summary>
            [ConfigOption("max", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The maximum value of the axis. If null, the max value is automatically calculated. If the endOnTick option is true, the max value might be rounded up. The actual maximum value is also influenced by  chart.alignTicks.")]
            public double? Max
            {
                get
                {
                    return this.State.Get<double?>("Max", null);
                }
                set
                {
                    this.State.Set("Max", value);
                }
            }

            /// <summary>
            /// Padding of the max value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the highest data value to appear on the edge of the plot area. When the axis' max option is set or a max extreme is set using axis.setExtremes(), the maxPadding will be ignored.
            /// </summary>
            [ConfigOption("maxPadding", null)]
            [DefaultValue(0.01)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Padding of the max value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the highest data value to appear on the edge of the plot area. When the axis' max option is set or a max extreme is set using axis.setExtremes(), the maxPadding will be ignored.")]
            public double? MaxPadding
            {
                get
                {
                    return this.State.Get<double?>("MaxPadding", 0.01);
                }
                set
                {
                    this.State.Set("MaxPadding", value);
                }
            }

            /// <summary>
            /// Deprecated. Renamed to minRange as of Highcharts 2.2.
            /// </summary>
            [ConfigOption("maxZoom", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Deprecated. Renamed to minRange as of Highcharts 2.2.")]
            public double? MaxZoom
            {
                get
                {
                    return this.State.Get<double?>("MaxZoom", null);
                }
                set
                {
                    this.State.Set("MaxZoom", value);
                }
            }

            /// <summary>
            /// The minimum value of the axis. If null the min value is automatically calculated. If the startOnTick option is true, the min value might be rounded down.
            /// </summary>
            [ConfigOption("min", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The minimum value of the axis. If null the min value is automatically calculated. If the startOnTick option is true, the min value might be rounded down.")]
            public double? Min
            {
                get
                {
                    return this.State.Get<double?>("Min", null);
                }
                set
                {
                    this.State.Set("Min", value);
                }
            }

            /// <summary>
            /// Padding of the min value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the lowest data value to appear on the edge of the plot area. When the axis' min option is set or a min extreme is set using axis.setExtremes(), the minPadding will be ignored.
            /// </summary>
            [ConfigOption("minPadding", null)]
            [DefaultValue(0.01)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Padding of the min value relative to the length of the axis. A padding of 0.05 will make a 100px axis 5px longer. This is useful when you don't want the lowest data value to appear on the edge of the plot area. When the axis' min option is set or a min extreme is set using axis.setExtremes(), the minPadding will be ignored.")]
            public double? MinPadding
            {
                get
                {
                    return this.State.Get<double?>("MinPadding", 0.01);
                }
                set
                {
                    this.State.Set("MinPadding", value);
                }
            }

            /// <summary>
            /// The minimum range to display on this axis. The entire axis will not be allowed to span over a smaller interval than this. For example, for a datetime axis the main unit is milliseconds. If minRange is set to 3600000, you can't zoom in more than to one hour. The default minRange for the x axis is five times the smallest interval between any of the data points. On a logarithmic axis, the unit for the minimum range is the power. So a minRange of 	1 means that the axis can be zoomed to 10-100, 100-1000, 1000-10000 etc.Note that the minPadding, maxPadding, startOnTick and endOnTick settings also affect how the extremes of the axis are computed.
            /// </summary>
            [ConfigOption("minRange", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The minimum range to display on this axis. The entire axis will not be allowed to span over a smaller interval than this. For example, for a datetime axis the main unit is milliseconds. If minRange is set to 3600000, you can't zoom in more than to one hour. The default minRange for the x axis is five times the smallest interval between any of the data points. On a logarithmic axis, the unit for the minimum range is the power. So a minRange of 	1 means that the axis can be zoomed to 10-100, 100-1000, 1000-10000 etc.Note that the minPadding, maxPadding, startOnTick and endOnTick settings also affect how the extremes of the axis are computed.")]
            public double? MinRange
            {
                get
                {
                    return this.State.Get<double?>("MinRange", null);
                }
                set
                {
                    this.State.Set("MinRange", value);
                }
            }

            /// <summary>
            /// The minimum tick interval allowed in axis values. For example on zooming in on an axis with daily data, this can be used to prevent the axis from showing hours. Defaults to the closest distance between two points on the axis.
            /// </summary>
            [ConfigOption("minTickInterval", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The minimum tick interval allowed in axis values. For example on zooming in on an axis with daily data, this can be used to prevent the axis from showing hours. Defaults to the closest distance between two points on the axis.")]
            public double? MinTickInterval
            {
                get
                {
                    return this.State.Get<double?>("MinTickInterval", null);
                }
                set
                {
                    this.State.Set("MinTickInterval", value);
                }
            }

            /// <summary>
            /// Color of the minor, secondary grid lines.
            /// </summary>
            [ConfigOption("minorGridLineColor", null)]
            [DefaultValue(@"#E0E0E0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Color of the minor, secondary grid lines.")]
            public string MinorGridLineColor
            {
                get
                {
                    return this.State.Get<string>("MinorGridLineColor", @"#E0E0E0");
                }
                set
                {
                    this.State.Set("MinorGridLineColor", value);
                }
            }

            /// <summary>
            /// The dash or dot style of the minor grid lines. For possible values, see this demonstration.
            /// </summary>
            [ConfigOption("minorGridLineDashStyle", null)]
            [DefaultValue(@"Solid")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The dash or dot style of the minor grid lines. For possible values, see this demonstration.")]
            public string MinorGridLineDashStyle
            {
                get
                {
                    return this.State.Get<string>("MinorGridLineDashStyle", @"Solid");
                }
                set
                {
                    this.State.Set("MinorGridLineDashStyle", value);
                }
            }

            /// <summary>
            /// Width of the minor, secondary grid lines.
            /// </summary>
            [ConfigOption("minorGridLineWidth", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Width of the minor, secondary grid lines.")]
            public double? MinorGridLineWidth
            {
                get
                {
                    return this.State.Get<double?>("MinorGridLineWidth", 1);
                }
                set
                {
                    this.State.Set("MinorGridLineWidth", value);
                }
            }

            /// <summary>
            /// Color for the minor tick marks.
            /// </summary>
            [ConfigOption("minorTickColor", null)]
            [DefaultValue(@"#A0A0A0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Color for the minor tick marks.")]
            public string MinorTickColor
            {
                get
                {
                    return this.State.Get<string>("MinorTickColor", @"#A0A0A0");
                }
                set
                {
                    this.State.Set("MinorTickColor", value);
                }
            }

            /// <summary>
            /// Tick interval in scale units for the minor ticks. On a linear axis, if ""auto"",  the minor tick interval is calculated as a fifth of the tickInterval. If null, minor ticks are not shown. On logarithmic axes, the unit is the power of the value. For example, setting 	the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting 	the minorTickInterval to 0.1 produces 9 ticks between 1 and 10,  	10 and 100 etc. A minorTickInterval of ""auto"" on a log axis results in a best guess, 	attempting to enter approximately 5 minor ticks between each major tick.If user settings dictate minor ticks to become too dense, they don't make sense, and will be ignored to prevent performance problems.On axes using categories, minor ticks are not supported.
            /// </summary>
            [ConfigOption("minorTickInterval", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Tick interval in scale units for the minor ticks. On a linear axis, if ""auto"",  the minor tick interval is calculated as a fifth of the tickInterval. If null, minor ticks are not shown. On logarithmic axes, the unit is the power of the value. For example, setting 	the minorTickInterval to 1 puts one tick on each of 0.1, 1, 10, 100 etc. Setting 	the minorTickInterval to 0.1 produces 9 ticks between 1 and 10,  	10 and 100 etc. A minorTickInterval of ""auto"" on a log axis results in a best guess, 	attempting to enter approximately 5 minor ticks between each major tick.If user settings dictate minor ticks to become too dense, they don't make sense, and will be ignored to prevent performance problems.On axes using categories, minor ticks are not supported.")]
            public object MinorTickInterval
            {
                get
                {
                    return this.State.Get<object>("MinorTickInterval", null);
                }
                set
                {
                    this.State.Set("MinorTickInterval", value);
                }
            }

            /// <summary>
            /// The pixel length of the minor tick marks.
            /// </summary>
            [ConfigOption("minorTickLength", null)]
            [DefaultValue(2)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel length of the minor tick marks.")]
            public double? MinorTickLength
            {
                get
                {
                    return this.State.Get<double?>("MinorTickLength", 2);
                }
                set
                {
                    this.State.Set("MinorTickLength", value);
                }
            }

            /// <summary>
            /// The position of the minor tick marks relative to the axis line. Can be one of inside and outside.
            /// </summary>
            [ConfigOption("minorTickPosition", null)]
            [DefaultValue(@"outside")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The position of the minor tick marks relative to the axis line. Can be one of inside and outside.")]
            public string MinorTickPosition
            {
                get
                {
                    return this.State.Get<string>("MinorTickPosition", @"outside");
                }
                set
                {
                    this.State.Set("MinorTickPosition", value);
                }
            }

            /// <summary>
            /// The pixel width of the minor tick mark.
            /// </summary>
            [ConfigOption("minorTickWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel width of the minor tick mark.")]
            public double? MinorTickWidth
            {
                get
                {
                    return this.State.Get<double?>("MinorTickWidth", 0);
                }
                set
                {
                    this.State.Set("MinorTickWidth", value);
                }
            }

            /// <summary>
            /// The distance in pixels from the plot area to the axis line. A positive offset moves the axis with it's line, labels and ticks away from the plot area. This is typically used when two or more axes are displayed on the same side of the plot.
            /// </summary>
            [ConfigOption("offset", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The distance in pixels from the plot area to the axis line. A positive offset moves the axis with it's line, labels and ticks away from the plot area. This is typically used when two or more axes are displayed on the same side of the plot.")]
            public double? Offset
            {
                get
                {
                    return this.State.Get<double?>("Offset", 0);
                }
                set
                {
                    this.State.Set("Offset", value);
                }
            }

            /// <summary>
            /// Whether to display the axis on the opposite side of the normal. The normal is on the left side for vertical axes and bottom for horizontal, so the opposite sides will be right and top respectively. This is typically used with dual or multiple axes.
            /// </summary>
            [ConfigOption("opposite", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to display the axis on the opposite side of the normal. The normal is on the left side for vertical axes and bottom for horizontal, so the opposite sides will be right and top respectively. This is typically used with dual or multiple axes.")]
            public bool? Opposite
            {
                get
                {
                    return this.State.Get<bool?>("Opposite", false);
                }
                set
                {
                    this.State.Set("Opposite", value);
                }
            }

            /// <summary>
            /// Whether to reverse the axis so that the highest number is closest to the origin. If the chart is inverted, the x axis is reversed by default.
            /// </summary>
            [ConfigOption("reversed", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to reverse the axis so that the highest number is closest to the origin. If the chart is inverted, the x axis is reversed by default.")]
            public bool? Reversed
            {
                get
                {
                    return this.State.Get<bool?>("Reversed", false);
                }
                set
                {
                    this.State.Set("Reversed", value);
                }
            }

            /// <summary>
            /// Whether to show the axis line and title when the axis has no data.
            /// </summary>
            [ConfigOption("showEmpty", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to show the axis line and title when the axis has no data.")]
            public bool? ShowEmpty
            {
                get
                {
                    return this.State.Get<bool?>("ShowEmpty", true);
                }
                set
                {
                    this.State.Set("ShowEmpty", value);
                }
            }

            /// <summary>
            /// Whether to show the first tick label.
            /// </summary>
            [ConfigOption("showFirstLabel", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to show the first tick label.")]
            public bool? ShowFirstLabel
            {
                get
                {
                    return this.State.Get<bool?>("ShowFirstLabel", true);
                }
                set
                {
                    this.State.Set("ShowFirstLabel", value);
                }
            }

            /// <summary>
            /// Whether to show the last tick label.
            /// </summary>
            [ConfigOption("showLastLabel", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to show the last tick label.")]
            public bool? ShowLastLabel
            {
                get
                {
                    return this.State.Get<bool?>("ShowLastLabel", true);
                }
                set
                {
                    this.State.Set("ShowLastLabel", value);
                }
            }

            /// <summary>
            /// For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.
            /// </summary>
            [ConfigOption("startOfWeek", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"For datetime axes, this decides where to put the tick between weeks. 0 = Sunday, 1 = Monday.")]
            public double? StartOfWeek
            {
                get
                {
                    return this.State.Get<double?>("StartOfWeek", 1);
                }
                set
                {
                    this.State.Set("StartOfWeek", value);
                }
            }

            /// <summary>
            /// Whether to force the axis to start on a tick. Use this option with the minPadding option to control the axis start.
            /// </summary>
            [ConfigOption("startOnTick", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to force the axis to start on a tick. Use this option with the minPadding option to control the axis start.")]
            public bool? StartOnTick
            {
                get
                {
                    return this.State.Get<bool?>("StartOnTick", false);
                }
                set
                {
                    this.State.Set("StartOnTick", value);
                }
            }

            /// <summary>
            /// The amount of ticks to draw on the axis. This opens up for aligning the ticks of multiple charts or panes within a chart. This option overrides the tickPixelInterval option.This option only has an effect on linear axes. Datetime, logarithmic or category axes are not affected.
            /// </summary>
            [ConfigOption("tickAmount", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The amount of ticks to draw on the axis. This opens up for aligning the ticks of multiple charts or panes within a chart. This option overrides the tickPixelInterval option.This option only has an effect on linear axes. Datetime, logarithmic or category axes are not affected.")]
            public double? TickAmount
            {
                get
                {
                    return this.State.Get<double?>("TickAmount", null);
                }
                set
                {
                    this.State.Set("TickAmount", value);
                }
            }

            /// <summary>
            /// Color for the main tick marks.
            /// </summary>
            [ConfigOption("tickColor", null)]
            [DefaultValue(@"#C0D0E0")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Color for the main tick marks.")]
            public string TickColor
            {
                get
                {
                    return this.State.Get<string>("TickColor", @"#C0D0E0");
                }
                set
                {
                    this.State.Set("TickColor", value);
                }
            }

            /// <summary>
            /// The interval of the tick marks in axis units. When null, the tick interval is computed to approximately follow the tickPixelInterval on linear and datetime axes. On categorized axes, a null tickInterval will default to 1, one category.  Note that datetime axes are based on milliseconds, so for  example an interval of one day is expressed as 24 * 3600 * 1000. On logarithmic axes, the tickInterval is based on powers, so a tickInterval of 1 means 	one tick on each of 0.1, 1, 10, 100 etc. A tickInterval of 2 means a tick of 0.1, 10, 1000 etc. 	A tickInterval of 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.If the tickInterval is too dense for labels to be drawn, Highcharts may remove ticks.
            /// </summary>
            [ConfigOption("tickInterval", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The interval of the tick marks in axis units. When null, the tick interval is computed to approximately follow the tickPixelInterval on linear and datetime axes. On categorized axes, a null tickInterval will default to 1, one category.  Note that datetime axes are based on milliseconds, so for  example an interval of one day is expressed as 24 * 3600 * 1000. On logarithmic axes, the tickInterval is based on powers, so a tickInterval of 1 means 	one tick on each of 0.1, 1, 10, 100 etc. A tickInterval of 2 means a tick of 0.1, 10, 1000 etc. 	A tickInterval of 0.2 puts a tick on 0.1, 0.2, 0.4, 0.6, 0.8, 1, 2, 4, 6, 8, 10, 20, 40 etc.If the tickInterval is too dense for labels to be drawn, Highcharts may remove ticks.")]
            public double? TickInterval
            {
                get
                {
                    return this.State.Get<double?>("TickInterval", null);
                }
                set
                {
                    this.State.Set("TickInterval", value);
                }
            }

            /// <summary>
            /// The pixel length of the main tick marks.
            /// </summary>
            [ConfigOption("tickLength", null)]
            [DefaultValue(10)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel length of the main tick marks.")]
            public double? TickLength
            {
                get
                {
                    return this.State.Get<double?>("TickLength", 10);
                }
                set
                {
                    this.State.Set("TickLength", value);
                }
            }

            /// <summary>
            /// If tickInterval is null this option sets the approximate pixel interval of the tick marks. Not applicable to categorized axis. Defaults to 72  for the Y axis and 100 for	the X axis.
            /// </summary>
            [ConfigOption("tickPixelInterval", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If tickInterval is null this option sets the approximate pixel interval of the tick marks. Not applicable to categorized axis. Defaults to 72  for the Y axis and 100 for	the X axis.")]
            public double? TickPixelInterval
            {
                get
                {
                    return this.State.Get<double?>("TickPixelInterval", null);
                }
                set
                {
                    this.State.Set("TickPixelInterval", value);
                }
            }

            /// <summary>
            /// The position of the major tick marks relative to the axis line. Can be one of inside and outside.
            /// </summary>
            [ConfigOption("tickPosition", null)]
            [DefaultValue(@"outside")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The position of the major tick marks relative to the axis line. Can be one of inside and outside.")]
            public string TickPosition
            {
                get
                {
                    return this.State.Get<string>("TickPosition", @"outside");
                }
                set
                {
                    this.State.Set("TickPosition", value);
                }
            }

            /// <summary>
            /// A callback function returning array defining where the ticks are laid out on the axis. This overrides the default behaviour of tickPixelInterval and tickInterval. The automatic tick positions are accessible through this.tickPositions and can be modified by the callback.
            /// </summary>
            [ConfigOption("tickPositioner", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A callback function returning array defining where the ticks are laid out on the axis. This overrides the default behaviour of tickPixelInterval and tickInterval. The automatic tick positions are accessible through this.tickPositions and can be modified by the callback.")]
            public string TickPositioner
            {
                get
                {
                    return this.State.Get<string>("TickPositioner", "");
                }
                set
                {
                    this.State.Set("TickPositioner", value);
                }
            }

            /// <summary>
            /// An array defining where the ticks are laid out on the axis. This overrides the default behaviour of tickPixelInterval and tickInterval.
            /// </summary>
            [ConfigOption("tickPositions", JsonMode.AlwaysArray)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An array defining where the ticks are laid out on the axis. This overrides the default behaviour of tickPixelInterval and tickInterval.")]
            public double[] TickPositions
            {
                get
                {
                    return this.State.Get<double[]>("TickPositions", null);
                }
                set
                {
                    this.State.Set("TickPositions", value);
                }
            }

            /// <summary>
            /// The pixel width of the major tick marks.
            /// </summary>
            [ConfigOption("tickWidth", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel width of the major tick marks.")]
            public double? TickWidth
            {
                get
                {
                    return this.State.Get<double?>("TickWidth", 1);
                }
                set
                {
                    this.State.Set("TickWidth", value);
                }
            }

            /// <summary>
            /// For categorized axes only. If on the tick mark is placed in the center of  the category, if between the tick mark is placed between categories. The default is between if the tickInterval is 1, else on.
            /// </summary>
            [ConfigOption("tickmarkPlacement", null)]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"For categorized axes only. If on the tick mark is placed in the center of  the category, if between the tick mark is placed between categories. The default is between if the tickInterval is 1, else on.")]
            public string TickmarkPlacement
            {
                get
                {
                    return this.State.Get<string>("TickmarkPlacement", @"null");
                }
                set
                {
                    this.State.Set("TickmarkPlacement", value);
                }
            }

            /// <summary>
            /// The type of axis. Can be one of ""linear"", ""logarithmic"", ""datetime"" or ""category"". In a datetime axis, the numbers are given in milliseconds, and tick marks are placed 		on appropriate values like full hours or days. In a category axis, the point names of the chart's series are used for categories, if not a categories array is defined.
            /// </summary>
            [ConfigOption("type", null)]
            [DefaultValue(@"linear")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The type of axis. Can be one of ""linear"", ""logarithmic"", ""datetime"" or ""category"". In a datetime axis, the numbers are given in milliseconds, and tick marks are placed 		on appropriate values like full hours or days. In a category axis, the point names of the chart's series are used for categories, if not a categories array is defined.")]
            public string Type
            {
                get
                {
                    return this.State.Get<string>("Type", @"linear");
                }
                set
                {
                    this.State.Set("Type", value);
                }
            }

            /// <summary>
            /// Datetime axis only. An array determining what time intervals the ticks are allowed to fall on. Each array item is an array where the first value is the time unit and the  second value another array of allowed multiples. Defaults to:units: [[	'millisecond', // unit name	[1, 2, 5, 10, 20, 25, 50, 100, 200, 500] // allowed multiples], [	'second',	[1, 2, 5, 10, 15, 30]], [	'minute',	[1, 2, 5, 10, 15, 30]], [	'hour',	[1, 2, 3, 4, 6, 8, 12]], [	'day',	[1]], [	'week',	[1]], [	'month',	[1, 3, 6]], [	'year',	null]]
            /// </summary>
            [ConfigOption("units", JsonMode.AlwaysArray)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Datetime axis only. An array determining what time intervals the ticks are allowed to fall on. Each array item is an array where the first value is the time unit and the  second value another array of allowed multiples. Defaults to:units: [[	'millisecond', // unit name	[1, 2, 5, 10, 20, 25, 50, 100, 200, 500] // allowed multiples], [	'second',	[1, 2, 5, 10, 15, 30]], [	'minute',	[1, 2, 5, 10, 15, 30]], [	'hour',	[1, 2, 3, 4, 6, 8, 12]], [	'day',	[1]], [	'week',	[1]], [	'month',	[1, 3, 6]], [	'year',	null]]")]
            public string Units
            {
                get
                {
                    return this.State.Get<string>("Units", "");
                }
                set
                {
                    this.State.Set("Units", value);
                }
            }

        private Breaks _Breaks;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("breaks", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"An array defining breaks in the axis, the sections defined will be left out and all the points shifted closer to each other. Requires that the broken-axis.js module is loaded.")]
        public virtual Breaks Breaks
        {
            get
            {
                return this._Breaks;
            }
            set
            {
                if (this._Breaks != null)
                {
                    this.Controls.Remove(this._Breaks);
                    this.LazyItems.Remove(this._Breaks);
                }

                this._Breaks = value;

                if (this._Breaks != null)
                {
                    this.LazyItems.Add(this._Breaks);
                    this.Controls.Add(this._Breaks);
                }
            }
        }
        private Labels _Labels;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("labels", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"The axis labels show the number or category for each tick.")]
        public virtual Labels Labels
        {
            get
            {
                return this._Labels;
            }
            set
            {
                if (this._Labels != null)
                {
                    this.Controls.Remove(this._Labels);
                    this.LazyItems.Remove(this._Labels);
                }

                this._Labels = value;

                if (this._Labels != null)
                {
                    this.LazyItems.Add(this._Labels);
                    this.Controls.Add(this._Labels);
                }
            }
        }
        private PlotBands _PlotBands;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("plotBands", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"An array of colored bands stretching across the plot area marking an interval on the axis.In a gauge, a plot band on the Y axis (value axis) will stretch along the perimeter of the gauge.")]
        public virtual PlotBands PlotBands
        {
            get
            {
                return this._PlotBands;
            }
            set
            {
                if (this._PlotBands != null)
                {
                    this.Controls.Remove(this._PlotBands);
                    this.LazyItems.Remove(this._PlotBands);
                }

                this._PlotBands = value;

                if (this._PlotBands != null)
                {
                    this.LazyItems.Add(this._PlotBands);
                    this.Controls.Add(this._PlotBands);
                }
            }
        }
        private PlotLines _PlotLines;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("plotLines", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"An array of lines stretching across the plot area, marking a specific value on one of the axes.")]
        public virtual PlotLines PlotLines
        {
            get
            {
                return this._PlotLines;
            }
            set
            {
                if (this._PlotLines != null)
                {
                    this.Controls.Remove(this._PlotLines);
                    this.LazyItems.Remove(this._PlotLines);
                }

                this._PlotLines = value;

                if (this._PlotLines != null)
                {
                    this.LazyItems.Add(this._PlotLines);
                    this.Controls.Add(this._PlotLines);
                }
            }
        }
        private Title _Title;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("title", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"The axis title, showing next to the axis line.")]
        public virtual Title Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                if (this._Title != null)
                {
                    this.Controls.Remove(this._Title);
                    this.LazyItems.Remove(this._Title);
                }

                this._Title = value;

                if (this._Title != null)
                {
                    this.LazyItems.Add(this._Title);
                    this.Controls.Add(this._Title);
                }
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


                list.Add("allowDecimals", new ConfigOption("allowDecimals", null, true, this.AllowDecimals));

                list.Add("alternateGridColor", new ConfigOption("alternateGridColor", null, "", this.AlternateGridColor));

                list.Add("categories", new ConfigOption("categories", new SerializationOptions("categories", JsonMode.AlwaysArray), null, this.Categories));

                list.Add("ceiling", new ConfigOption("ceiling", null, null, this.Ceiling));

                list.Add("dateTimeLabelFormats", new ConfigOption("dateTimeLabelFormats", null, null, this.DateTimeLabelFormats));

                list.Add("endOnTick", new ConfigOption("endOnTick", null, false, this.EndOnTick));

                list.Add("floor", new ConfigOption("floor", null, null, this.Floor));

                list.Add("gridLineColor", new ConfigOption("gridLineColor", null, @"#D8D8D8", this.GridLineColor));

                list.Add("gridLineDashStyle", new ConfigOption("gridLineDashStyle", null, @"Solid", this.GridLineDashStyle));

                list.Add("gridLineWidth", new ConfigOption("gridLineWidth", null, 0, this.GridLineWidth));

                list.Add("gridZIndex", new ConfigOption("gridZIndex", null, 1, this.GridZIndex));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("lineColor", new ConfigOption("lineColor", null, @"#C0D0E0", this.LineColor));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 1, this.LineWidth));

                list.Add("linkedTo", new ConfigOption("linkedTo", null, null, this.LinkedTo));

                list.Add("max", new ConfigOption("max", null, null, this.Max));

                list.Add("maxPadding", new ConfigOption("maxPadding", null, 0.01, this.MaxPadding));

                list.Add("maxZoom", new ConfigOption("maxZoom", null, null, this.MaxZoom));

                list.Add("min", new ConfigOption("min", null, null, this.Min));

                list.Add("minPadding", new ConfigOption("minPadding", null, 0.01, this.MinPadding));

                list.Add("minRange", new ConfigOption("minRange", null, null, this.MinRange));

                list.Add("minTickInterval", new ConfigOption("minTickInterval", null, null, this.MinTickInterval));

                list.Add("minorGridLineColor", new ConfigOption("minorGridLineColor", null, @"#E0E0E0", this.MinorGridLineColor));

                list.Add("minorGridLineDashStyle", new ConfigOption("minorGridLineDashStyle", null, @"Solid", this.MinorGridLineDashStyle));

                list.Add("minorGridLineWidth", new ConfigOption("minorGridLineWidth", null, 1, this.MinorGridLineWidth));

                list.Add("minorTickColor", new ConfigOption("minorTickColor", null, @"#A0A0A0", this.MinorTickColor));

                list.Add("minorTickInterval", new ConfigOption("minorTickInterval", null, null, this.MinorTickInterval));

                list.Add("minorTickLength", new ConfigOption("minorTickLength", null, 2, this.MinorTickLength));

                list.Add("minorTickPosition", new ConfigOption("minorTickPosition", null, @"outside", this.MinorTickPosition));

                list.Add("minorTickWidth", new ConfigOption("minorTickWidth", null, 0, this.MinorTickWidth));

                list.Add("offset", new ConfigOption("offset", null, 0, this.Offset));

                list.Add("opposite", new ConfigOption("opposite", null, false, this.Opposite));

                list.Add("reversed", new ConfigOption("reversed", null, false, this.Reversed));

                list.Add("showEmpty", new ConfigOption("showEmpty", null, true, this.ShowEmpty));

                list.Add("showFirstLabel", new ConfigOption("showFirstLabel", null, true, this.ShowFirstLabel));

                list.Add("showLastLabel", new ConfigOption("showLastLabel", null, true, this.ShowLastLabel));

                list.Add("startOfWeek", new ConfigOption("startOfWeek", null, 1, this.StartOfWeek));

                list.Add("startOnTick", new ConfigOption("startOnTick", null, false, this.StartOnTick));

                list.Add("tickAmount", new ConfigOption("tickAmount", null, null, this.TickAmount));

                list.Add("tickColor", new ConfigOption("tickColor", null, @"#C0D0E0", this.TickColor));

                list.Add("tickInterval", new ConfigOption("tickInterval", null, null, this.TickInterval));

                list.Add("tickLength", new ConfigOption("tickLength", null, 10, this.TickLength));

                list.Add("tickPixelInterval", new ConfigOption("tickPixelInterval", null, null, this.TickPixelInterval));

                list.Add("tickPosition", new ConfigOption("tickPosition", null, @"outside", this.TickPosition));

                list.Add("tickPositioner", new ConfigOption("tickPositioner", null, "", this.TickPositioner));

                list.Add("tickPositions", new ConfigOption("tickPositions", new SerializationOptions("tickPositions", JsonMode.AlwaysArray), null, this.TickPositions));

                list.Add("tickWidth", new ConfigOption("tickWidth", null, 1, this.TickWidth));

                list.Add("tickmarkPlacement", new ConfigOption("tickmarkPlacement", null, @"null", this.TickmarkPlacement));

                list.Add("type", new ConfigOption("type", null, @"linear", this.Type));

                list.Add("units", new ConfigOption("units", new SerializationOptions("units", JsonMode.AlwaysArray), "", this.Units));

                list.Add("breaks", new ConfigOption("breaks", new SerializationOptions("breaks", typeof(LazyControlJsonConverter)), null, this.Breaks));

                list.Add("labels", new ConfigOption("labels", new SerializationOptions("labels", typeof(LazyControlJsonConverter)), null, this.Labels));

                list.Add("plotBands", new ConfigOption("plotBands", new SerializationOptions("plotBands", typeof(LazyControlJsonConverter)), null, this.PlotBands));

                list.Add("plotLines", new ConfigOption("plotLines", new SerializationOptions("plotLines", typeof(LazyControlJsonConverter)), null, this.PlotLines));

                list.Add("title", new ConfigOption("title", new SerializationOptions("title", typeof(LazyControlJsonConverter)), null, this.Title));
list.Add("events", new ConfigOption("events", new SerializationOptions("events", JsonMode.Object), null, this.Listeners));
                return list;
            }
        }


    
	        private XAxisEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public XAxisEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new XAxisEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class XAxisEvents : ComponentListeners
        {


        private JFunction afterBreaks;

        /// <summary>
        /// An event fired after the breaks have rendered.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("afterBreaks", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"An event fired after the breaks have rendered.")]
        public virtual JFunction AfterBreaks
        {
            get
            {
                return this.afterBreaks ?? (this.afterBreaks = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction afterSetExtremes;

        /// <summary>
        /// As opposed to the setExtremes event, this event fires after the final min and max values are computed and corrected for minRange.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("afterSetExtremes", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"As opposed to the setExtremes event, this event fires after the final min and max values are computed and corrected for minRange.")]
        public virtual JFunction AfterSetExtremes
        {
            get
            {
                return this.afterSetExtremes ?? (this.afterSetExtremes = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction pointBreak;

        /// <summary>
        /// An event fired when a break from this axis occurs on a point.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("pointBreak", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"An event fired when a break from this axis occurs on a point.")]
        public virtual JFunction PointBreak
        {
            get
            {
                return this.pointBreak ?? (this.pointBreak = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction setExtremes;

        /// <summary>
        /// Fires when the minimum and maximum is set for the axis, either by calling the .setExtremes() method or by selecting an area in the chart. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.The new user set minimum and maximum values can be found by event.min and event.max. When an axis is zoomed all the way out from the ""Reset zoom"" button, event.min and event.max are null, and the new extremes are set based on this.dataMin and this.dataMax.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("setExtremes", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the minimum and maximum is set for the axis, either by calling the .setExtremes() method or by selecting an area in the chart. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on which library is used as the base for Highcharts.The new user set minimum and maximum values can be found by event.min and event.max. When an axis is zoomed all the way out from the ""Reset zoom"" button, event.min and event.max are null, and the new extremes are set based on this.dataMin and this.dataMax.")]
        public virtual JFunction SetExtremes
        {
            get
            {
                return this.setExtremes ?? (this.setExtremes = new JFunction(){
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
                    list.Add("afterBreaks", new ConfigOption("afterBreaks", new SerializationOptions("afterBreaks", typeof(JFunctionJsonConverter)), null, this.AfterBreaks));list.Add("afterSetExtremes", new ConfigOption("afterSetExtremes", new SerializationOptions("afterSetExtremes", typeof(JFunctionJsonConverter)), null, this.AfterSetExtremes));list.Add("pointBreak", new ConfigOption("pointBreak", new SerializationOptions("pointBreak", typeof(JFunctionJsonConverter)), null, this.PointBreak));list.Add("setExtremes", new ConfigOption("setExtremes", new SerializationOptions("setExtremes", typeof(JFunctionJsonConverter)), null, this.SetExtremes));
                    return list;
                }
            }

        }


        }

        
}
            