
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
        /// A pie series. If the .type">type option is not specified, it is inherited from chart.type.For options that apply to multiple series, it is recommended to add them to the pointOptions.series options structure. To apply to all series of this specific type, apply it to plotOptions.pie.
        /// </summary>
        public partial class Pie : Observable
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
            /// The color of the border surrounding each slice.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"#FFFFFF")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the border surrounding each slice.")]
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
            /// The width of the border surrounding each slice.
            /// </summary>
            [ConfigOption]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the border surrounding each slice.")]
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
            /// The center of the pie chart relative to the plot area. Can be percentages or pixel values. The default behaviour (as of 3.0) is to center the pie so that all slices and data labels are within the plot area. As a consequence, the pie may actually jump around in a chart with dynamic values, as the data labels move. In that case, the center should be explicitly set, for example to [""50%"", ""50%""].		 
            /// </summary>
            [ConfigOption]
            [DefaultValue(new object[] { null, null})]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The center of the pie chart relative to the plot area. Can be percentages or pixel values. The default behaviour (as of 3.0) is to center the pie so that all slices and data labels are within the plot area. As a consequence, the pie may actually jump around in a chart with dynamic values, as the data labels move. In that case, the center should be explicitly set, for example to [""50%"", ""50%""].		 ")]
            public object[] Center
            {
                get
                {
                    return this.State.Get<object[]>("Center", new object[] { null, null});
                }
                set
                {
                    this.State.Set("Center", value);
                }
            }

            /// <summary>
            /// A series specific or series type specific color set to use instead of the global colors.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A series specific or series type specific color set to use instead of the global colors.")]
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
            /// The thickness of a 3D pie. Requires highcharts-3d.js
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The thickness of a 3D pie. Requires highcharts-3d.js")]
            public double? Depth
            {
                get
                {
                    return this.State.Get<double?>("Depth", 0);
                }
                set
                {
                    this.State.Set("Depth", value);
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
            /// The end angle of the pie in degrees where 0 is top and 90 is right. Defaults to startAngle plus 360.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The end angle of the pie in degrees where 0 is top and 90 is right. Defaults to startAngle plus 360.")]
            public double? EndAngle
            {
                get
                {
                    return this.State.Get<double?>("EndAngle", null);
                }
                set
                {
                    this.State.Set("EndAngle", value);
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
            /// Equivalent to chart.ignoreHiddenSeries, this option tells whether the series shall be redrawn as if the hidden point were null.The default value changed from false to true with Highcharts 3.0.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Equivalent to chart.ignoreHiddenSeries, this option tells whether the series shall be redrawn as if the hidden point were null.The default value changed from false to true with Highcharts 3.0.")]
            public bool? IgnoreHiddenPoint
            {
                get
                {
                    return this.State.Get<bool?>("IgnoreHiddenPoint", true);
                }
                set
                {
                    this.State.Set("IgnoreHiddenPoint", value);
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
            /// The size of the inner diameter for the pie. A size greater than 0 renders a donut chart. Can be a percentage or pixel value. Percentages are relative to the pie size. Pixel values are given as integers.Note: in Highcharts 
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The size of the inner diameter for the pie. A size greater than 0 renders a donut chart. Can be a percentage or pixel value. Percentages are relative to the pie size. Pixel values are given as integers.Note: in Highcharts ")]
            public object InnerSize
            {
                get
                {
                    return this.State.Get<object>("InnerSize", null);
                }
                set
                {
                    this.State.Set("InnerSize", value);
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
            /// The minimum size for a pie in response to auto margins. The pie will try to shrink to make room for data labels in side the plot area, but only to this size.
            /// </summary>
            [ConfigOption]
            [DefaultValue(80)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The minimum size for a pie in response to auto margins. The pie will try to shrink to make room for data labels in side the plot area, but only to this size.")]
            public double? MinSize
            {
                get
                {
                    return this.State.Get<double?>("MinSize", 80);
                }
                set
                {
                    this.State.Set("MinSize", value);
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
            /// Whether to display this particular series or series type in the legend. Since 2.1, pies are not shown in the legend by default.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to display this particular series or series type in the legend. Since 2.1, pies are not shown in the legend by default.")]
            public bool? ShowInLegend
            {
                get
                {
                    return this.State.Get<bool?>("ShowInLegend", false);
                }
                set
                {
                    this.State.Set("ShowInLegend", value);
                }
            }

            /// <summary>
            /// The diameter of the pie relative to the plot area. Can be a percentage or pixel value. Pixel values are given as integers. The default behaviour (as of 3.0) is to scale to the plot area and give room for data labels within the plot area. As a consequence, the size of the pie may vary when points are updated and data labels more around. In that case it is best to set a fixed value, for example ""75%"".
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The diameter of the pie relative to the plot area. Can be a percentage or pixel value. Pixel values are given as integers. The default behaviour (as of 3.0) is to scale to the plot area and give room for data labels within the plot area. As a consequence, the size of the pie may vary when points are updated and data labels more around. In that case it is best to set a fixed value, for example ""75%"".")]
            public object Size
            {
                get
                {
                    return this.State.Get<object>("Size", null);
                }
                set
                {
                    this.State.Set("Size", value);
                }
            }

            /// <summary>
            /// If a point is sliced, moved out from the center, how many pixels should  it be moved?.
            /// </summary>
            [ConfigOption]
            [DefaultValue(10)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If a point is sliced, moved out from the center, how many pixels should  it be moved?.")]
            public double? SlicedOffset
            {
                get
                {
                    return this.State.Get<double?>("SlicedOffset", 10);
                }
                set
                {
                    this.State.Set("SlicedOffset", value);
                }
            }

            /// <summary>
            /// The start angle of the pie slices in degrees where 0 is top and 90 right. 
            /// </summary>
            [ConfigOption]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The start angle of the pie slices in degrees where 0 is top and 90 right. ")]
            public double? StartAngle
            {
                get
                {
                    return this.State.Get<double?>("StartAngle", 0);
                }
                set
                {
                    this.State.Set("StartAngle", value);
                }
            }

            /// <summary>
            /// Sticky tracking of mouse events. When true, the mouseOut event on a series isn't triggered until the mouse moves over another series, or out of the plot area. When false, the mouseOut event on a series is triggered when the mouse leaves the area around the series' graph or markers. This also implies the tooltip. When stickyTracking is false and tooltip.shared is false, the  tooltip will be hidden when moving the mouse between series.
            /// </summary>
            [ConfigOption]
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

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 1, this.BorderWidth));

                list.Add("center", new ConfigOption("center", null, new object[] { null, null}, this.Center));

                list.Add("colors", new ConfigOption("colors", null, null, this.Colors));

                list.Add("cursor", new ConfigOption("cursor", null, "", this.Cursor));

                list.Add("depth", new ConfigOption("depth", null, 0, this.Depth));

                list.Add("enableMouseTracking", new ConfigOption("enableMouseTracking", null, true, this.EnableMouseTracking));

                list.Add("endAngle", new ConfigOption("endAngle", null, null, this.EndAngle));

                list.Add("getExtremesFromAll", new ConfigOption("getExtremesFromAll", null, false, this.GetExtremesFromAll));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("ignoreHiddenPoint", new ConfigOption("ignoreHiddenPoint", null, true, this.IgnoreHiddenPoint));

                list.Add("index", new ConfigOption("index", null, null, this.Index));

                list.Add("innerSize", new ConfigOption("innerSize", null, null, this.InnerSize));

                list.Add("keys", new ConfigOption("keys", null, null, this.Keys));

                list.Add("legendIndex", new ConfigOption("legendIndex", null, null, this.LegendIndex));

                list.Add("linkedTo", new ConfigOption("linkedTo", null, "", this.LinkedTo));

                list.Add("minSize", new ConfigOption("minSize", null, 80, this.MinSize));

                list.Add("name", new ConfigOption("name", null, "", this.Name));

                list.Add("selected", new ConfigOption("selected", null, false, this.Selected));

                list.Add("shadow", new ConfigOption("shadow", null, null, this.Shadow));

                list.Add("showInLegend", new ConfigOption("showInLegend", null, false, this.ShowInLegend));

                list.Add("size", new ConfigOption("size", null, null, this.Size));

                list.Add("slicedOffset", new ConfigOption("slicedOffset", null, 10, this.SlicedOffset));

                list.Add("startAngle", new ConfigOption("startAngle", null, 0, this.StartAngle));

                list.Add("stickyTracking", new ConfigOption("stickyTracking", null, false, this.StickyTracking));

                list.Add("type", new ConfigOption("type", null, "", this.Type));

                list.Add("visible", new ConfigOption("visible", null, true, this.Visible));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                list.Add("zoneAxis", new ConfigOption("zoneAxis", null, @"y", this.ZoneAxis));

                return list;
            }
        }


    

        /// <summary>
        /// An array of data points for the series. For the pie series type, points can be given in the following ways:  	An array of numerical values. In this case, the numerical values will  	be interpreted as y options.  Example:data: [0, 5, 3, 5] 	 An array of objects with named values. The objects are 	point configuration objects as seen below. If the total number of data points exceeds the series' .turboThreshold'>turboThreshold, this option is not available.data: [{    y: 1,    name: "Point2",    color: "#00FF00"}, {    y: 7,    name: "Point1",    color: "#FF00FF"}] 
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
            /// The sequential index of the data point in the legend.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The sequential index of the data point in the legend.")]
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
            /// Whether to display a slice offset from the center.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to display a slice offset from the center.")]
            public bool? Sliced
            {
                get
                {
                    return this.State.Get<bool?>("Sliced", false);
                }
                set
                {
                    this.State.Set("Sliced", value);
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

                list.Add("legendIndex", new ConfigOption("legendIndex", null, null, this.LegendIndex));

                list.Add("name", new ConfigOption("name", null, "", this.Name));

                list.Add("selected", new ConfigOption("selected", null, false, this.Selected));

                list.Add("sliced", new ConfigOption("sliced", null, false, this.Sliced));

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


        }


        /// <summary>
        /// 
        /// </summary>
        public partial class DataLabels : Observable
        {

    
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
            /// The color of the line connecting the data label to the pie slice. The default color is the same as the point's color.
            /// </summary>
            [ConfigOption]
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
            [ConfigOption]
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
            [ConfigOption]
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
            /// The distance of the data label from the pie's edge. Negative numbers put the data label on top of the pie slices. Connectors are only shown for data labels outside the pie.
            /// </summary>
            [ConfigOption]
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
            /// Enable or disable the data labels.
            /// </summary>
            [ConfigOption]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the data labels.")]
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
            /// Whether to render the connector as a soft arc or a line with sharp break.
            /// </summary>
            [ConfigOption]
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


                list.Add("backgroundColor", new ConfigOption("backgroundColor", null, "", this.BackgroundColor));

                list.Add("borderColor", new ConfigOption("borderColor", null, "", this.BorderColor));

                list.Add("borderRadius", new ConfigOption("borderRadius", null, 0, this.BorderRadius));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 0, this.BorderWidth));

                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("connectorColor", new ConfigOption("connectorColor", null, @"{point.color}", this.ConnectorColor));

                list.Add("connectorPadding", new ConfigOption("connectorPadding", null, 5, this.ConnectorPadding));

                list.Add("connectorWidth", new ConfigOption("connectorWidth", null, 1, this.ConnectorWidth));

                list.Add("crop", new ConfigOption("crop", null, true, this.Crop));

                list.Add("defer", new ConfigOption("defer", null, true, this.Defer));

                list.Add("distance", new ConfigOption("distance", null, 30, this.Distance));

                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("format", new ConfigOption("format", null, @"{y}", this.Format));

                list.Add("formatter", new ConfigOption("formatter", null, "", this.Formatter));

                list.Add("inside", new ConfigOption("inside", null, null, this.Inside));

                list.Add("overflow", new ConfigOption("overflow", null, @"justify", this.Overflow));

                list.Add("padding", new ConfigOption("padding", null, 5, this.Padding));

                list.Add("rotation", new ConfigOption("rotation", null, 0, this.Rotation));

                list.Add("shadow", new ConfigOption("shadow", null, null, this.Shadow));

                list.Add("shape", new ConfigOption("shape", null, @"square", this.Shape));

                list.Add("softConnector", new ConfigOption("softConnector", null, true, this.SoftConnector));

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
            /// Fires when the checkbox next to the point name in the legend is clicked. One parameter, event, is passed to the function. The state of the checkbox is found by event.checked. The checked item is found by event.item. Return false to prevent the default action which is to toggle the select state of the series.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Fires when the checkbox next to the point name in the legend is clicked. One parameter, event, is passed to the function. The state of the checkbox is found by event.checked. The checked item is found by event.item. Return false to prevent the default action which is to toggle the select state of the series.")]
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
            /// Not applicable to pies, as the legend item is per point. See point.events.
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Not applicable to pies, as the legend item is per point. See point.events.")]
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
            