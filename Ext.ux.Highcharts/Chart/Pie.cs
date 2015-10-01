
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
            