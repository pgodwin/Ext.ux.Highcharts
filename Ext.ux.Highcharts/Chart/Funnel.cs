
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
        /// A funnel series. If the .type">type option is not specified, it is inherited from chart.type.For options that apply to multiple series, it is recommended to add them to the pointOptions.series options structure. To apply to all series of this specific type, apply it to plotOptions.funnel.
        /// </summary>
        public partial class Funnel : Observable
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
            /// The center of the series. By default, it is centered in the middle of the plot area, so it fills the plot area height.
            /// </summary>
            [ConfigOption]
            [DefaultValue(new object[] { "50%", "50%"})]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The center of the series. By default, it is centered in the middle of the plot area, so it fills the plot area height.")]
            public object[] Center
            {
                get
                {
                    return this.State.Get<object[]>("Center", new object[] { "50%", "50%"});
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
            /// The height of the funnel or pyramid. If it is a number it defines the pixel height, if it is a percentage string it is the percentage of the plot area height.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The height of the funnel or pyramid. If it is a number it defines the pixel height, if it is a percentage string it is the percentage of the plot area height.")]
            public object Height
            {
                get
                {
                    return this.State.Get<object>("Height", null);
                }
                set
                {
                    this.State.Set("Height", value);
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
            /// The height of the neck, the lower part of the funnel. A number defines pixel width, a percentage string defines a percentage of the plot area height.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The height of the neck, the lower part of the funnel. A number defines pixel width, a percentage string defines a percentage of the plot area height.")]
            public object NeckHeight
            {
                get
                {
                    return this.State.Get<object>("NeckHeight", null);
                }
                set
                {
                    this.State.Set("NeckHeight", value);
                }
            }

            /// <summary>
            /// The width of the neck, the lower part of the funnel. A number defines pixel width, a percentage string defines a percentage of the plot area width.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the neck, the lower part of the funnel. A number defines pixel width, a percentage string defines a percentage of the plot area width.")]
            public object NeckWidth
            {
                get
                {
                    return this.State.Get<object>("NeckWidth", null);
                }
                set
                {
                    this.State.Set("NeckWidth", value);
                }
            }

            /// <summary>
            /// A reversed funnel has the widest area down. A reversed funnel with no neck width and neck height is a pyramid.
            /// </summary>
            [ConfigOption]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A reversed funnel has the widest area down. A reversed funnel with no neck width and neck height is a pyramid.")]
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
            /// The width of the funnel compared to the width of the plot area, or the pixel width if it is a number.
            /// </summary>
            [ConfigOption]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the funnel compared to the width of the plot area, or the pixel width if it is a number.")]
            public object Width
            {
                get
                {
                    return this.State.Get<object>("Width", null);
                }
                set
                {
                    this.State.Set("Width", value);
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

                list.Add("borderColor", new ConfigOption("borderColor", null, @"#FFFFFF", this.BorderColor));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 1, this.BorderWidth));

                list.Add("center", new ConfigOption("center", null, new object[] { "50%", "50%"}, this.Center));

                list.Add("colors", new ConfigOption("colors", null, null, this.Colors));

                list.Add("cursor", new ConfigOption("cursor", null, "", this.Cursor));

                list.Add("depth", new ConfigOption("depth", null, 0, this.Depth));

                list.Add("enableMouseTracking", new ConfigOption("enableMouseTracking", null, true, this.EnableMouseTracking));

                list.Add("getExtremesFromAll", new ConfigOption("getExtremesFromAll", null, false, this.GetExtremesFromAll));

                list.Add("height", new ConfigOption("height", null, null, this.Height));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("index", new ConfigOption("index", null, null, this.Index));

                list.Add("keys", new ConfigOption("keys", null, null, this.Keys));

                list.Add("legendIndex", new ConfigOption("legendIndex", null, null, this.LegendIndex));

                list.Add("linkedTo", new ConfigOption("linkedTo", null, "", this.LinkedTo));

                list.Add("minSize", new ConfigOption("minSize", null, 80, this.MinSize));

                list.Add("name", new ConfigOption("name", null, "", this.Name));

                list.Add("neckHeight", new ConfigOption("neckHeight", null, null, this.NeckHeight));

                list.Add("neckWidth", new ConfigOption("neckWidth", null, null, this.NeckWidth));

                list.Add("reversed", new ConfigOption("reversed", null, false, this.Reversed));

                list.Add("selected", new ConfigOption("selected", null, false, this.Selected));

                list.Add("shadow", new ConfigOption("shadow", null, null, this.Shadow));

                list.Add("showInLegend", new ConfigOption("showInLegend", null, false, this.ShowInLegend));

                list.Add("slicedOffset", new ConfigOption("slicedOffset", null, 10, this.SlicedOffset));

                list.Add("stickyTracking", new ConfigOption("stickyTracking", null, false, this.StickyTracking));

                list.Add("type", new ConfigOption("type", null, "", this.Type));

                list.Add("visible", new ConfigOption("visible", null, true, this.Visible));

                list.Add("width", new ConfigOption("width", null, null, this.Width));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                list.Add("zoneAxis", new ConfigOption("zoneAxis", null, @"y", this.ZoneAxis));

                return list;
            }
        }


    

        /// <summary>
        /// An array of data points for the series. For the funnel series type, points can be given in the following ways:  	An array of numerical values. In this case, the numerical values will  	be interpreted as y options.  Example:data: [0, 5, 3, 5] 	 An array of objects with named values. The objects are 	point configuration objects as seen below. If the total number of data points exceeds the series' .turboThreshold'>turboThreshold, this option is not available.data: [{    y: 3,    name: "Point2",    color: "#00FF00"}, {    y: 1,    name: "Point1",    color: "#FF00FF"}] 
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
            