
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

namespace Ext.ux.Highcharts.ChartSeries
{
        


        /// <summary>
        /// A gauge series. If the .type">type option is not specified, it is inherited from chart.type.For options that apply to multiple series, it is recommended to add them to the pointOptions.series options structure. To apply to all series of this specific type, apply it to plotOptions.gauge.
        /// </summary>
        public partial class GaugeSeries : BaseGaugeSerie
        {

    
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
            /// An id for the series. This can be used after render time to get a pointer to the series object through chart.get().
            /// </summary>
            [ConfigOption("id", null)]
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
            [ConfigOption("index", null)]
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
            [ConfigOption("keys", JsonMode.AlwaysArray)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [TypeConverter(typeof(StringArrayConverter))]
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
            [ConfigOption("legendIndex", null)]
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
            /// The name of the series as shown in the legend, tooltip etc.
            /// </summary>
            [ConfigOption("name", null)]
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
            [ConfigOption("negativeColor", null)]
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
            /// Allow the dial to overshoot the end of the perimeter axis by this many degrees. Say if the gauge axis goes from 0 to 60, a value of 100, or 1000, will show 5 degrees beyond the end of the axis.
            /// </summary>
            [ConfigOption("overshoot", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Allow the dial to overshoot the end of the perimeter axis by this many degrees. Say if the gauge axis goes from 0 to 60, a value of 100, or 1000, will show 5 degrees beyond the end of the axis.")]
            public double? Overshoot
            {
                get
                {
                    return this.State.Get<double?>("Overshoot", 0);
                }
                set
                {
                    this.State.Set("Overshoot", value);
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
            /// Whether to display this particular series or series type in the legend. Defaults to false for gauge series.
            /// </summary>
            [ConfigOption("showInLegend", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Whether to display this particular series or series type in the legend. Defaults to false for gauge series.")]
            public bool? ShowInLegend
            {
                get
                {
                    return this.State.Get<bool?>("ShowInLegend", null);
                }
                set
                {
                    this.State.Set("ShowInLegend", value);
                }
            }

            /// <summary>
            /// Sticky tracking of mouse events. When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When stickyTracking is false and tooltip.shared is false, the  tooltip will be hidden when moving the mouse between series. Defaults to true for line and area type series, but to false for columns, pies etc.
            /// </summary>
            [ConfigOption("stickyTracking", null)]
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
            /// The type of series. Can be one of area, areaspline, bar, column, line, pie, scatter or spline. From version 2.3, arearange, areasplinerange and columnrange are supported with the highcharts-more.js component.
            /// </summary>
            [ConfigOption("type", null)]
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
            /// When this option is true, the dial will wrap around the axes. For instance, in a full-range gauge going from 0 to 360, a value of 400 will point to 40. When wrap is false, the dial stops at 360.
            /// </summary>
            [ConfigOption("wrap", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"When this option is true, the dial will wrap around the axes. For instance, in a full-range gauge going from 0 to 360, a value of 400 will point to 40. When wrap is false, the dial stops at 360.")]
            public bool? Wrap
            {
                get
                {
                    return this.State.Get<bool?>("Wrap", true);
                }
                set
                {
                    this.State.Set("Wrap", value);
                }
            }

            /// <summary>
            /// When using dual or multiple x axes, this number defines which xAxis the particular series is connected to. It refers to either the axis id or the index of the axis in the xAxis array, with 0 being the first.
            /// </summary>
            [ConfigOption("xAxis", null)]
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
            [ConfigOption("yAxis", null)]
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
            [ConfigOption("zIndex", null)]
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

        private Data _Data;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("data", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"An array of data points for the series. For the gauge series type, points can be given in the following ways:  	An array of numerical values. In this case, the numerical values will  	be interpreted as y options.  Example:data: [0, 5, 3, 5] 	 An array of objects with named values. The objects are 	point configuration objects as seen below. If the total number of data points exceeds the series' .turboThreshold'>turboThreshold, this option is not available.data: [{    y: 6,    name: ""Point2"",    color: ""#00FF00""}, {    y: 8,    name: ""Point1"",    color: ""#FF00FF""}] The typical gauge only contains a single data value.")]
        public virtual Data Data
        {
            get
            {
                return this._Data;
            }
            set
            {
                if (this._Data != null)
                {
                    this.Controls.Remove(this._Data);
                    this.LazyItems.Remove(this._Data);
                }

                this._Data = value;

                if (this._Data != null)
                {
                    this.LazyItems.Add(this._Data);
                    this.Controls.Add(this._Data);
                }
            }
        }
        private DataLabels _DataLabels;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("dataLabels", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Data labels for the gauge. For gauges, the data labels are enabled by default and shown in a bordered box below the point.")]
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
        private Dial _Dial;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("dial", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Options for the dial or arrow pointer of the gauge.")]
        public virtual Dial Dial
        {
            get
            {
                return this._Dial;
            }
            set
            {
                if (this._Dial != null)
                {
                    this.Controls.Remove(this._Dial);
                    this.LazyItems.Remove(this._Dial);
                }

                this._Dial = value;

                if (this._Dial != null)
                {
                    this.LazyItems.Add(this._Dial);
                    this.Controls.Add(this._Dial);
                }
            }
        }
        private Pivot _Pivot;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("pivot", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Options for the pivot or the center point of the gauge.")]
        public virtual Pivot Pivot
        {
            get
            {
                return this._Pivot;
            }
            set
            {
                if (this._Pivot != null)
                {
                    this.Controls.Remove(this._Pivot);
                    this.LazyItems.Remove(this._Pivot);
                }

                this._Pivot = value;

                if (this._Pivot != null)
                {
                    this.LazyItems.Add(this._Pivot);
                    this.Controls.Add(this._Pivot);
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


                list.Add("animation", new ConfigOption("animation", null, true, this.Animation));

                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("cursor", new ConfigOption("cursor", null, "", this.Cursor));

                list.Add("enableMouseTracking", new ConfigOption("enableMouseTracking", null, true, this.EnableMouseTracking));

                list.Add("getExtremesFromAll", new ConfigOption("getExtremesFromAll", null, false, this.GetExtremesFromAll));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("index", new ConfigOption("index", null, null, this.Index));

                list.Add("keys", new ConfigOption("keys", new SerializationOptions("keys", JsonMode.AlwaysArray), null, this.Keys));

                list.Add("legendIndex", new ConfigOption("legendIndex", null, null, this.LegendIndex));

                list.Add("linkedTo", new ConfigOption("linkedTo", null, "", this.LinkedTo));

                list.Add("name", new ConfigOption("name", null, "", this.Name));

                list.Add("negativeColor", new ConfigOption("negativeColor", null, @"null", this.NegativeColor));

                list.Add("overshoot", new ConfigOption("overshoot", null, 0, this.Overshoot));

                list.Add("selected", new ConfigOption("selected", null, false, this.Selected));

                list.Add("showCheckbox", new ConfigOption("showCheckbox", null, false, this.ShowCheckbox));

                list.Add("showInLegend", new ConfigOption("showInLegend", null, null, this.ShowInLegend));

                list.Add("stickyTracking", new ConfigOption("stickyTracking", null, true, this.StickyTracking));

                list.Add("threshold", new ConfigOption("threshold", null, 0, this.Threshold));

                list.Add("type", new ConfigOption("type", null, "", this.Type));

                list.Add("visible", new ConfigOption("visible", null, true, this.Visible));

                list.Add("wrap", new ConfigOption("wrap", null, true, this.Wrap));

                list.Add("xAxis", new ConfigOption("xAxis", null, null, this.XAxis));

                list.Add("yAxis", new ConfigOption("yAxis", null, null, this.YAxis));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                list.Add("zoneAxis", new ConfigOption("zoneAxis", null, @"y", this.ZoneAxis));

                list.Add("data", new ConfigOption("data", new SerializationOptions("data", typeof(LazyControlJsonConverter)), null, this.Data));


                list.Add("dataLabels", new ConfigOption("dataLabels", new SerializationOptions("dataLabels", typeof(LazyControlJsonConverter)), null, this.DataLabels));


                list.Add("dial", new ConfigOption("dial", new SerializationOptions("dial", typeof(LazyControlJsonConverter)), null, this.Dial));


                list.Add("pivot", new ConfigOption("pivot", new SerializationOptions("pivot", typeof(LazyControlJsonConverter)), null, this.Pivot));


                list.Add("point", new ConfigOption("point", new SerializationOptions("point", typeof(LazyControlJsonConverter)), null, this.Point));


                list.Add("states", new ConfigOption("states", new SerializationOptions("states", typeof(LazyControlJsonConverter)), null, this.States));


                list.Add("tooltip", new ConfigOption("tooltip", new SerializationOptions("tooltip", typeof(LazyControlJsonConverter)), null, this.Tooltip));


                list.Add("zones", new ConfigOption("zones", new SerializationOptions("zones", typeof(LazyControlJsonConverter)), null, this.Zones));

list.Add("events", new ConfigOption("events", new SerializationOptions("events", JsonMode.Object), null, this.Listeners));
                return list;
            }
        }


    
	        private GaugeSeriesEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public GaugeSeriesEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new GaugeSeriesEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
            public partial class GaugeSeriesEvents : SeriesEvents
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
            