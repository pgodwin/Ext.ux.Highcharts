
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
        /// A bubble series is a three dimensional series type where each point renders an X, Y and Z value. Each points is drawn as a bubble where the position along the X and Y axes mark the X and Y values, and the size of the bubble relates to the Z value.
        /// </summary>
        public partial class BubblePlotOptions : Observable
        {

    
            /// <summary>
            /// Allow this series' points to be selected by clicking on the markers, bars or pie slices.
            /// </summary>
            [ConfigOption("allowPointSelect", null)]
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
            [ConfigOption("animation", null)]
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
            [ConfigOption("color", null)]
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
            /// When the series contains less points than the crop threshold, all points are drawn,  event if the points fall outside the visible plot area at the current zoom. The advantage of drawing all points (including markers and columns), is that animation is performed on updates. On the other hand, when the series contains more points than the crop threshold, the series data is cropped to only contain points that fall within the plot area. The advantage of cropping away invisible points is to increase performance on large series.  .
            /// </summary>
            [ConfigOption("cropThreshold", null)]
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
            [ConfigOption("cursor", null)]
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
            [ConfigOption("dashStyle", null)]
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
            /// Whether to display negative sized bubbles. The threshold is given by the zThreshold option, and negative bubbles can be visualized by setting negativeColor.
            /// </summary>
            [ConfigOption("displayNegative", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to display negative sized bubbles. The threshold is given by the zThreshold option, and negative bubbles can be visualized by setting negativeColor.")]
            public bool? DisplayNegative
            {
                get
                {
                    return this.State.Get<bool?>("DisplayNegative", true);
                }
                set
                {
                    this.State.Set("DisplayNegative", value);
                }
            }

            /// <summary>
            /// Enable or disable the mouse tracking for a specific series. This includes point tooltips and click events on graphs and points. For large datasets it improves performance.
            /// </summary>
            [ConfigOption("enableMouseTracking", null)]
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
            [ConfigOption("getExtremesFromAll", null)]
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
            /// An array specifying which option maps to which key in the data point array. This makes it convenient to work with unstructured data arrays from different sources.
            /// </summary>
            [ConfigOption("keys", JsonMode.AlwaysArray)]
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
            /// The width of the line connecting the data points.
            /// </summary>
            [ConfigOption("lineWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the line connecting the data points.")]
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
            /// The id of another series to link to. Additionally, the value can be "":previous"" to link to the previous series. When two series are linked, only the first one appears in the legend. Toggling the visibility of this also toggles the linked series.
            /// </summary>
            [ConfigOption("linkedTo", null)]
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
            /// Maximum bubble size. Bubbles will automatically size between the minSize and maxSize to reflect the z value of each bubble. Can be either pixels (when no unit is given), or a percentage of the smallest one of the plot width and height. 
            /// </summary>
            [ConfigOption("maxSize", null)]
            [DefaultValue(@"20%")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Maximum bubble size. Bubbles will automatically size between the minSize and maxSize to reflect the z value of each bubble. Can be either pixels (when no unit is given), or a percentage of the smallest one of the plot width and height. ")]
            public string MaxSize
            {
                get
                {
                    return this.State.Get<string>("MaxSize", @"20%");
                }
                set
                {
                    this.State.Set("MaxSize", value);
                }
            }

            /// <summary>
            /// Minimum bubble size. Bubbles will automatically size between the minSize and maxSize to reflect the z value of each bubble. Can be either pixels (when no unit is given), or a percentage of the smallest one of the plot width and height. 
            /// </summary>
            [ConfigOption("minSize", null)]
            [DefaultValue(@"8")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Minimum bubble size. Bubbles will automatically size between the minSize and maxSize to reflect the z value of each bubble. Can be either pixels (when no unit is given), or a percentage of the smallest one of the plot width and height. ")]
            public string MinSize
            {
                get
                {
                    return this.State.Get<string>("MinSize", @"8");
                }
                set
                {
                    this.State.Set("MinSize", value);
                }
            }

            /// <summary>
            /// When a point's Z value is below the zThreshold setting, this color is used.
            /// </summary>
            [ConfigOption("negativeColor", null)]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When a point's Z value is below the zThreshold setting, this color is used.")]
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
            [ConfigOption("pointInterval", null)]
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
            [ConfigOption("pointIntervalUnit", null)]
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
            /// If no x values are given for the points in a series, pointStart defines on what value to start. For example, if a series contains one yearly value starting from 1945, set pointStart to 1945.
            /// </summary>
            [ConfigOption("pointStart", null)]
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
            [ConfigOption("selected", null)]
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
            [ConfigOption("shadow", null)]
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
            [ConfigOption("showCheckbox", null)]
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
            [ConfigOption("showInLegend", null)]
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
            /// Whether the bubble's value should be represented by the area or the width of the bubble. The default, area, corresponds best to the human perception of the size of each bubble. 
            /// </summary>
            [ConfigOption("sizeBy", null)]
            [DefaultValue(@"area")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether the bubble's value should be represented by the area or the width of the bubble. The default, area, corresponds best to the human perception of the size of each bubble. ")]
            public string SizeBy
            {
                get
                {
                    return this.State.Get<string>("SizeBy", @"area");
                }
                set
                {
                    this.State.Set("SizeBy", value);
                }
            }

            /// <summary>
            /// Sticky tracking of mouse events. When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When stickyTracking is false and tooltip.shared is false, the  tooltip will be hidden when moving the mouse between series.
            /// </summary>
            [ConfigOption("stickyTracking", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Sticky tracking of mouse events. When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When stickyTracking is false and tooltip.shared is false, the  tooltip will be hidden when moving the mouse between series.")]
            public bool? StickyTracking
            {
                get
                {
                    return this.State.Get<bool?>("StickyTracking", false);
                }
                set
                {
                    this.State.Set("StickyTracking", value);
                }
            }

            /// <summary>
            /// The threshold, also called zero level or base level. For line type series this is only used in conjunction with negativeColor.
            /// </summary>
            [ConfigOption("threshold", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The threshold, also called zero level or base level. For line type series this is only used in conjunction with negativeColor.")]
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
            /// Set the initial visibility of the series.
            /// </summary>
            [ConfigOption("visible", null)]
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
            /// The minimum for the Z value range. Defaults to the highest Z value in the data.
            /// </summary>
            [ConfigOption("zMax", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The minimum for the Z value range. Defaults to the highest Z value in the data.")]
            public double? ZMax
            {
                get
                {
                    return this.State.Get<double?>("ZMax", null);
                }
                set
                {
                    this.State.Set("ZMax", value);
                }
            }

            /// <summary>
            /// The minimum for the Z value range. Defaults to the lowest Z value in the data.
            /// </summary>
            [ConfigOption("zMin", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The minimum for the Z value range. Defaults to the lowest Z value in the data.")]
            public double? ZMin
            {
                get
                {
                    return this.State.Get<double?>("ZMin", null);
                }
                set
                {
                    this.State.Set("ZMin", value);
                }
            }

            /// <summary>
            /// When displayNegative is false, bubbles with lower Z values are skipped. When displayNegative is true and a negativeColor is given, points with lower Z is colored.
            /// </summary>
            [ConfigOption("zThreshold", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When displayNegative is false, bubbles with lower Z values are skipped. When displayNegative is true and a negativeColor is given, points with lower Z is colored.")]
            public double? ZThreshold
            {
                get
                {
                    return this.State.Get<double?>("ZThreshold", 0);
                }
                set
                {
                    this.State.Set("ZThreshold", value);
                }
            }

            /// <summary>
            /// Defines the Axis on which the zones are applied.
            /// </summary>
            [ConfigOption("zoneAxis", null)]
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

        private DataLabels _DataLabels;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("dataLabels", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual DataLabels DataLabels
        {
            get
            {
                return this._DataLabels;
            }
            set
            {
                if (this._DataLabels != null)
                {
                    this.Controls.Remove(this._DataLabels);
                    this.LazyItems.Remove(this._DataLabels);
                }

                this._DataLabels = value;

                if (this._DataLabels != null)
                {
                    this.LazyItems.Add(this._DataLabels);
                    this.Controls.Add(this._DataLabels);
                }
            }
        }
        private Marker _Marker;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("marker", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual Marker Marker
        {
            get
            {
                return this._Marker;
            }
            set
            {
                if (this._Marker != null)
                {
                    this.Controls.Remove(this._Marker);
                    this.LazyItems.Remove(this._Marker);
                }

                this._Marker = value;

                if (this._Marker != null)
                {
                    this.LazyItems.Add(this._Marker);
                    this.Controls.Add(this._Marker);
                }
            }
        }
        private Point _Point;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("point", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Properties for each single point")]
        public virtual Point Point
        {
            get
            {
                return this._Point;
            }
            set
            {
                if (this._Point != null)
                {
                    this.Controls.Remove(this._Point);
                    this.LazyItems.Remove(this._Point);
                }

                this._Point = value;

                if (this._Point != null)
                {
                    this.LazyItems.Add(this._Point);
                    this.Controls.Add(this._Point);
                }
            }
        }
        private States _States;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("states", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"A wrapper object for all the series options in specific states.")]
        public virtual States States
        {
            get
            {
                return this._States;
            }
            set
            {
                if (this._States != null)
                {
                    this.Controls.Remove(this._States);
                    this.LazyItems.Remove(this._States);
                }

                this._States = value;

                if (this._States != null)
                {
                    this.LazyItems.Add(this._States);
                    this.Controls.Add(this._States);
                }
            }
        }
        private Tooltip _Tooltip;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("tooltip", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip, but only the following properties can be defined on a series level.")]
        public virtual Tooltip Tooltip
        {
            get
            {
                return this._Tooltip;
            }
            set
            {
                if (this._Tooltip != null)
                {
                    this.Controls.Remove(this._Tooltip);
                    this.LazyItems.Remove(this._Tooltip);
                }

                this._Tooltip = value;

                if (this._Tooltip != null)
                {
                    this.LazyItems.Add(this._Tooltip);
                    this.Controls.Add(this._Tooltip);
                }
            }
        }
        private Zones _Zones;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("zones", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"An array defining zones within a series. Zones can be applied to the X axis, Y axis or Z axis for bubbles, according to the zoneAxis option.")]
        public virtual Zones Zones
        {
            get
            {
                return this._Zones;
            }
            set
            {
                if (this._Zones != null)
                {
                    this.Controls.Remove(this._Zones);
                    this.LazyItems.Remove(this._Zones);
                }

                this._Zones = value;

                if (this._Zones != null)
                {
                    this.LazyItems.Add(this._Zones);
                    this.Controls.Add(this._Zones);
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


                list.Add("allowPointSelect", new ConfigOption("allowPointSelect", null, false, this.AllowPointSelect));

                list.Add("animation", new ConfigOption("animation", null, true, this.Animation));

                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("cropThreshold", new ConfigOption("cropThreshold", null, 300, this.CropThreshold));

                list.Add("cursor", new ConfigOption("cursor", null, "", this.Cursor));

                list.Add("dashStyle", new ConfigOption("dashStyle", null, @"Solid", this.DashStyle));

                list.Add("displayNegative", new ConfigOption("displayNegative", null, true, this.DisplayNegative));

                list.Add("enableMouseTracking", new ConfigOption("enableMouseTracking", null, true, this.EnableMouseTracking));

                list.Add("getExtremesFromAll", new ConfigOption("getExtremesFromAll", null, false, this.GetExtremesFromAll));

                list.Add("keys", new ConfigOption("keys", new SerializationOptions("keys", JsonMode.AlwaysArray), null, this.Keys));

                list.Add("lineWidth", new ConfigOption("lineWidth", null, 0, this.LineWidth));

                list.Add("linkedTo", new ConfigOption("linkedTo", null, "", this.LinkedTo));

                list.Add("maxSize", new ConfigOption("maxSize", null, @"20%", this.MaxSize));

                list.Add("minSize", new ConfigOption("minSize", null, @"8", this.MinSize));

                list.Add("negativeColor", new ConfigOption("negativeColor", null, @"null", this.NegativeColor));

                list.Add("pointInterval", new ConfigOption("pointInterval", null, 1, this.PointInterval));

                list.Add("pointIntervalUnit", new ConfigOption("pointIntervalUnit", null, "", this.PointIntervalUnit));

                list.Add("pointStart", new ConfigOption("pointStart", null, 0, this.PointStart));

                list.Add("selected", new ConfigOption("selected", null, false, this.Selected));

                list.Add("shadow", new ConfigOption("shadow", null, null, this.Shadow));

                list.Add("showCheckbox", new ConfigOption("showCheckbox", null, false, this.ShowCheckbox));

                list.Add("showInLegend", new ConfigOption("showInLegend", null, true, this.ShowInLegend));

                list.Add("sizeBy", new ConfigOption("sizeBy", null, @"area", this.SizeBy));

                list.Add("stickyTracking", new ConfigOption("stickyTracking", null, false, this.StickyTracking));

                list.Add("threshold", new ConfigOption("threshold", null, 0, this.Threshold));

                list.Add("visible", new ConfigOption("visible", null, true, this.Visible));

                list.Add("zMax", new ConfigOption("zMax", null, null, this.ZMax));

                list.Add("zMin", new ConfigOption("zMin", null, null, this.ZMin));

                list.Add("zThreshold", new ConfigOption("zThreshold", null, 0, this.ZThreshold));

                list.Add("zoneAxis", new ConfigOption("zoneAxis", null, @"y", this.ZoneAxis));

                list.Add("dataLabels", new ConfigOption("dataLabels", new SerializationOptions("dataLabels", typeof(LazyControlJsonConverter)), null, this.DataLabels));

                list.Add("marker", new ConfigOption("marker", new SerializationOptions("marker", typeof(LazyControlJsonConverter)), null, this.Marker));

                list.Add("point", new ConfigOption("point", new SerializationOptions("point", typeof(LazyControlJsonConverter)), null, this.Point));

                list.Add("states", new ConfigOption("states", new SerializationOptions("states", typeof(LazyControlJsonConverter)), null, this.States));

                list.Add("tooltip", new ConfigOption("tooltip", new SerializationOptions("tooltip", typeof(LazyControlJsonConverter)), null, this.Tooltip));

                list.Add("zones", new ConfigOption("zones", new SerializationOptions("zones", typeof(LazyControlJsonConverter)), null, this.Zones));
list.Add("events", new ConfigOption("events", new SerializationOptions("events", JsonMode.Object), null, this.Listeners));
                return list;
            }
        }


    
	        private BubblePlotOptionsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public BubblePlotOptionsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new BubblePlotOptionsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class BubblePlotOptionsEvents : ComponentListeners
        {


        private JFunction afterAnimate;

        /// <summary>
        /// Fires after the series has finished its initial animation, or in case animation is disabled, immediately as the series is displayed.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("afterAnimate", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires after the series has finished its initial animation, or in case animation is disabled, immediately as the series is displayed.")]
        public virtual JFunction AfterAnimate
        {
            get
            {
                return this.afterAnimate ?? (this.afterAnimate = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction checkboxClick;

        /// <summary>
        /// Fires when the checkbox next to the series' name in the legend is clicked. One parameter, event, is passed to the function. The state of the checkbox is found by event.checked. The checked item is found by event.item. Return false to prevent the default action which is to toggle the select state of the series.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("checkboxClick", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the checkbox next to the series' name in the legend is clicked. One parameter, event, is passed to the function. The state of the checkbox is found by event.checked. The checked item is found by event.item. Return false to prevent the default action which is to toggle the select state of the series.")]
        public virtual JFunction CheckboxClick
        {
            get
            {
                return this.checkboxClick ?? (this.checkboxClick = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction click;

        /// <summary>
        /// Fires when the series is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Additionally, event.point holds a pointer to the nearest point on the graph.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the series is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. Additionally, event.point holds a pointer to the nearest point on the graph.")]
        public virtual JFunction Click
        {
            get
            {
                return this.click ?? (this.click = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction hide;

        /// <summary>
        /// Fires when the series is hidden after chart generation time, either by clicking the legend item or by calling .hide().
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("hide", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the series is hidden after chart generation time, either by clicking the legend item or by calling .hide().")]
        public virtual JFunction Hide
        {
            get
            {
                return this.hide ?? (this.hide = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction legendItemClick;

        /// <summary>
        /// Fires when the legend item belonging to the series is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. The default action is to toggle the visibility of the series. This can be prevented by returning false or calling event.preventDefault().
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("legendItemClick", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the legend item belonging to the series is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. The default action is to toggle the visibility of the series. This can be prevented by returning false or calling event.preventDefault().")]
        public virtual JFunction LegendItemClick
        {
            get
            {
                return this.legendItemClick ?? (this.legendItemClick = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction mouseOut;

        /// <summary>
        /// Fires when the mouse leaves the graph. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the  stickyTracking option is true, mouseOut doesn't happen before the mouse enters another graph or leaves the plot area.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseOut", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the mouse leaves the graph. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the  stickyTracking option is true, mouseOut doesn't happen before the mouse enters another graph or leaves the plot area.")]
        public virtual JFunction MouseOut
        {
            get
            {
                return this.mouseOut ?? (this.mouseOut = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction mouseOver;

        /// <summary>
        /// Fires when the mouse enters the graph. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseOver", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the mouse enters the graph. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
        public virtual JFunction MouseOver
        {
            get
            {
                return this.mouseOver ?? (this.mouseOver = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction show;

        /// <summary>
        /// Fires when the series is shown after chart generation time, either by clicking the legend item or by calling .show().
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("show", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the series is shown after chart generation time, either by clicking the legend item or by calling .show().")]
        public virtual JFunction Show
        {
            get
            {
                return this.show ?? (this.show = new JFunction(){
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
                    list.Add("afterAnimate", new ConfigOption("afterAnimate", new SerializationOptions("afterAnimate", typeof(JFunctionJsonConverter)), null, this.AfterAnimate));list.Add("checkboxClick", new ConfigOption("checkboxClick", new SerializationOptions("checkboxClick", typeof(JFunctionJsonConverter)), null, this.CheckboxClick));list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(JFunctionJsonConverter)), null, this.Click));list.Add("hide", new ConfigOption("hide", new SerializationOptions("hide", typeof(JFunctionJsonConverter)), null, this.Hide));list.Add("legendItemClick", new ConfigOption("legendItemClick", new SerializationOptions("legendItemClick", typeof(JFunctionJsonConverter)), null, this.LegendItemClick));list.Add("mouseOut", new ConfigOption("mouseOut", new SerializationOptions("mouseOut", typeof(JFunctionJsonConverter)), null, this.MouseOut));list.Add("mouseOver", new ConfigOption("mouseOver", new SerializationOptions("mouseOver", typeof(JFunctionJsonConverter)), null, this.MouseOver));list.Add("show", new ConfigOption("show", new SerializationOptions("show", typeof(JFunctionJsonConverter)), null, this.Show));
                    return list;
                }
            }

        }


        }

        
}
            