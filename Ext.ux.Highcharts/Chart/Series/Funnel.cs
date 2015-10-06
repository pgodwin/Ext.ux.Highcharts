
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

namespace Ext.ux.Highcharts.ChartSeries
{
        


        /// <summary>
        /// A funnel series. If the .type">type option is not specified, it is inherited from chart.type.For options that apply to multiple series, it is recommended to add them to the pointOptions.series options structure. To apply to all series of this specific type, apply it to plotOptions.funnel.
        /// </summary>
        public partial class Funnel : Series
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
            /// The color of the border surrounding each slice.
            /// </summary>
            [ConfigOption("borderColor", null)]
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
            [ConfigOption("borderWidth", null)]
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
            [ConfigOption("center", JsonMode.AlwaysArray)]
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
            [ConfigOption("colors", JsonMode.AlwaysArray)]
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
            /// The thickness of a 3D pie. Requires highcharts-3d.js
            /// </summary>
            [ConfigOption("depth", null)]
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
            /// The height of the funnel or pyramid. If it is a number it defines the pixel height, if it is a percentage string it is the percentage of the plot area height.
            /// </summary>
            [ConfigOption("height", null)]
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
            /// The minimum size for a pie in response to auto margins. The pie will try to shrink to make room for data labels in side the plot area, but only to this size.
            /// </summary>
            [ConfigOption("minSize", null)]
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
            /// The height of the neck, the lower part of the funnel. A number defines pixel width, a percentage string defines a percentage of the plot area height.
            /// </summary>
            [ConfigOption("neckHeight", null)]
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
            [ConfigOption("neckWidth", null)]
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
            [ConfigOption("reversed", null)]
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
            /// Whether to display this particular series or series type in the legend. Since 2.1, pies are not shown in the legend by default.
            /// </summary>
            [ConfigOption("showInLegend", null)]
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
            [ConfigOption("slicedOffset", null)]
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
            /// The width of the funnel compared to the width of the plot area, or the pixel width if it is a number.
            /// </summary>
            [ConfigOption("width", null)]
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

                list.Add("center", new ConfigOption("center", new SerializationOptions("center", JsonMode.AlwaysArray), new object[] { "50%", "50%"}, this.Center));

                list.Add("colors", new ConfigOption("colors", new SerializationOptions("colors", JsonMode.AlwaysArray), null, this.Colors));

                list.Add("cursor", new ConfigOption("cursor", null, "", this.Cursor));

                list.Add("depth", new ConfigOption("depth", null, 0, this.Depth));

                list.Add("enableMouseTracking", new ConfigOption("enableMouseTracking", null, true, this.EnableMouseTracking));

                list.Add("getExtremesFromAll", new ConfigOption("getExtremesFromAll", null, false, this.GetExtremesFromAll));

                list.Add("height", new ConfigOption("height", null, null, this.Height));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("index", new ConfigOption("index", null, null, this.Index));

                list.Add("keys", new ConfigOption("keys", new SerializationOptions("keys", JsonMode.AlwaysArray), null, this.Keys));

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
list.Add("events", new ConfigOption("events", new SerializationOptions("events", JsonMode.Object), null, this.Listeners));
                return list;
            }
        }


    
	        private FunnelEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public FunnelEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new FunnelEvents();
					}
			
					return this.events;
				}
			}


    

        /// <summary>
        /// An array of data points for the series. For the funnel series type, points can be given in the following ways:  	An array of numerical values. In this case, the numerical values will  	be interpreted as y options.  Example:data: [0, 5, 3, 5] 	 An array of objects with named values. The objects are 	point configuration objects as seen below. If the total number of data points exceeds the series' .turboThreshold'>turboThreshold, this option is not available.data: [{    y: 3,    name: "Point2",    color: "#00FF00"}, {    y: 1,    name: "Point1",    color: "#FF00FF"}] 
        /// </summary>
        public partial class Data : Observable
        {

    
            /// <summary>
            /// Individual color for the point. By default the color is pulled from the global colors array.
            /// </summary>
            [ConfigOption("color", null)]
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
            [ConfigOption("dataLabels", null)]
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
            [ConfigOption("drilldown", null)]
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
            [ConfigOption("id", null)]
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
            [ConfigOption("legendIndex", null)]
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
            [ConfigOption("name", null)]
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
            [ConfigOption("selected", null)]
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
            /// The y value of the point.
            /// </summary>
            [ConfigOption("y", null)]
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

                list.Add("y", new ConfigOption("y", null, null, this.y));
list.Add("events", new ConfigOption("events", new SerializationOptions("events", JsonMode.Object), null, this.Listeners));
                return list;
            }
        }


    
	        private DataEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public DataEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new DataEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class DataEvents : ComponentListeners
        {


        private JFunction click;

        /// <summary>
        /// Fires when a point is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state. Returning false cancels this action.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when a point is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state. Returning false cancels this action.")]
        public virtual JFunction Click
        {
            get
            {
                return this.click ?? (this.click = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction mouseOut;

        /// <summary>
        /// Fires when the mouse leaves the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseOut", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the mouse leaves the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
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
        /// Fires when the mouse enters the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseOver", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the mouse enters the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
        public virtual JFunction MouseOver
        {
            get
            {
                return this.mouseOver ?? (this.mouseOver = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction remove;

        /// <summary>
        /// Fires when the point is removed using the .remove() method. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("remove", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is removed using the .remove() method. One parameter, event, is passed to the function. Returning false cancels the operation.")]
        public virtual JFunction Remove
        {
            get
            {
                return this.remove ?? (this.remove = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction select;

        /// <summary>
        /// Fires when the point is selected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is selected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.")]
        public virtual JFunction Select
        {
            get
            {
                return this.select ?? (this.select = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction unselect;

        /// <summary>
        /// Fires when the point is unselected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("unselect", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is unselected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.")]
        public virtual JFunction Unselect
        {
            get
            {
                return this.unselect ?? (this.unselect = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction update;

        /// <summary>
        /// Fires when the point is updated programmatically through the .update() method. One parameter, event, is passed to the function. The  new point options can be accessed through event.options. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("update", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is updated programmatically through the .update() method. One parameter, event, is passed to the function. The  new point options can be accessed through event.options. Returning false cancels the operation.")]
        public virtual JFunction Update
        {
            get
            {
                return this.update ?? (this.update = new JFunction(){
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
                    list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(JFunctionJsonConverter)), null, this.Click));list.Add("mouseOut", new ConfigOption("mouseOut", new SerializationOptions("mouseOut", typeof(JFunctionJsonConverter)), null, this.MouseOut));list.Add("mouseOver", new ConfigOption("mouseOver", new SerializationOptions("mouseOver", typeof(JFunctionJsonConverter)), null, this.MouseOver));list.Add("remove", new ConfigOption("remove", new SerializationOptions("remove", typeof(JFunctionJsonConverter)), null, this.Remove));list.Add("select", new ConfigOption("select", new SerializationOptions("select", typeof(JFunctionJsonConverter)), null, this.Select));list.Add("unselect", new ConfigOption("unselect", new SerializationOptions("unselect", typeof(JFunctionJsonConverter)), null, this.Unselect));list.Add("update", new ConfigOption("update", new SerializationOptions("update", typeof(JFunctionJsonConverter)), null, this.Update));
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
            [ConfigOption("backgroundColor", null)]
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
            [ConfigOption("borderColor", null)]
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
            [ConfigOption("borderRadius", null)]
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
            [ConfigOption("borderWidth", null)]
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
            [ConfigOption("color", null)]
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
            [ConfigOption("connectorColor", null)]
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
            [ConfigOption("connectorPadding", null)]
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
            [ConfigOption("connectorWidth", null)]
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
            [ConfigOption("crop", null)]
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
            [ConfigOption("defer", null)]
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
            [ConfigOption("distance", null)]
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
            [ConfigOption("enabled", null)]
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
            [ConfigOption("format", null)]
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
            [ConfigOption("formatter", null)]
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
            [ConfigOption("inside", null)]
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
            [ConfigOption("overflow", null)]
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
            [ConfigOption("padding", null)]
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
            [ConfigOption("rotation", null)]
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
            [ConfigOption("shadow", null)]
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
            [ConfigOption("shape", null)]
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
            [ConfigOption("softConnector", null)]
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
            [ConfigOption("style", null)]
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
            [ConfigOption("useHTML", null)]
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
            [ConfigOption("verticalAlign", null)]
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
            [ConfigOption("x", null)]
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
            [ConfigOption("y", null)]
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
            [ConfigOption("zIndex", null)]
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


    
	        private DataLabelsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public DataLabelsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new DataLabelsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class DataLabelsEvents : ComponentListeners
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

list.Add("events", new ConfigOption("events", new SerializationOptions("events", JsonMode.Object), null, this.Listeners));
                return list;
            }
        }


    
	        private PointEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public PointEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new PointEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class PointEvents : ComponentListeners
        {


        private JFunction click;

        /// <summary>
        /// Fires when a point is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state. Returning false cancels this action.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when a point is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state. Returning false cancels this action.")]
        public virtual JFunction Click
        {
            get
            {
                return this.click ?? (this.click = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction mouseOut;

        /// <summary>
        /// Fires when the mouse leaves the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseOut", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the mouse leaves the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
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
        /// Fires when the mouse enters the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseOver", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the mouse enters the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
        public virtual JFunction MouseOver
        {
            get
            {
                return this.mouseOver ?? (this.mouseOver = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction remove;

        /// <summary>
        /// Fires when the point is removed using the .remove() method. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("remove", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is removed using the .remove() method. One parameter, event, is passed to the function. Returning false cancels the operation.")]
        public virtual JFunction Remove
        {
            get
            {
                return this.remove ?? (this.remove = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction select;

        /// <summary>
        /// Fires when the point is selected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is selected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.")]
        public virtual JFunction Select
        {
            get
            {
                return this.select ?? (this.select = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction unselect;

        /// <summary>
        /// Fires when the point is unselected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("unselect", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is unselected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.")]
        public virtual JFunction Unselect
        {
            get
            {
                return this.unselect ?? (this.unselect = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction update;

        /// <summary>
        /// Fires when the point is updated programmatically through the .update() method. One parameter, event, is passed to the function. The  new point options can be accessed through event.options. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("update", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is updated programmatically through the .update() method. One parameter, event, is passed to the function. The  new point options can be accessed through event.options. Returning false cancels the operation.")]
        public virtual JFunction Update
        {
            get
            {
                return this.update ?? (this.update = new JFunction(){
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
                    list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(JFunctionJsonConverter)), null, this.Click));list.Add("mouseOut", new ConfigOption("mouseOut", new SerializationOptions("mouseOut", typeof(JFunctionJsonConverter)), null, this.MouseOut));list.Add("mouseOver", new ConfigOption("mouseOver", new SerializationOptions("mouseOver", typeof(JFunctionJsonConverter)), null, this.MouseOver));list.Add("remove", new ConfigOption("remove", new SerializationOptions("remove", typeof(JFunctionJsonConverter)), null, this.Remove));list.Add("select", new ConfigOption("select", new SerializationOptions("select", typeof(JFunctionJsonConverter)), null, this.Select));list.Add("unselect", new ConfigOption("unselect", new SerializationOptions("unselect", typeof(JFunctionJsonConverter)), null, this.Unselect));list.Add("update", new ConfigOption("update", new SerializationOptions("update", typeof(JFunctionJsonConverter)), null, this.Update));
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


    
	        private StatesEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public StatesEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new StatesEvents();
					}
			
					return this.events;
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
            [ConfigOption("enabled", null)]
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
            [ConfigOption("lineWidth", null)]
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
            [ConfigOption("lineWidthPlus", null)]
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


    
	        private HoverEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public HoverEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new HoverEvents();
					}
			
					return this.events;
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
            [ConfigOption("attributes", null)]
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
            [ConfigOption("opacity", null)]
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
            [ConfigOption("size", null)]
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


    
	        private HaloEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public HaloEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new HaloEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class HaloEvents : ComponentListeners
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
        /// 
        /// </summary>
        public partial class Marker : Observable
        {

    
            /// <summary>
            /// Enable or disable the point marker. If null, the markers are hidden when the data is dense, and shown for more widespread data points.
            /// </summary>
            [ConfigOption("enabled", null)]
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
            [ConfigOption("fillColor", null)]
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
            [ConfigOption("height", null)]
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
            [ConfigOption("lineColor", null)]
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
            [ConfigOption("lineWidth", null)]
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
            [ConfigOption("radius", null)]
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
            [ConfigOption("states", null)]
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
            [ConfigOption("symbol", null)]
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
            [ConfigOption("width", null)]
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


    
	        private MarkerEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public MarkerEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new MarkerEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class MarkerEvents : ComponentListeners
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
        public partial class HoverEvents : ComponentListeners
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
        public partial class StatesEvents : ComponentListeners
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
        /// A configuration object for the tooltip rendering of each single series. Properties are inherited from tooltip, but only the following properties can be defined on a series level.
        /// </summary>
        public partial class Tooltip : Observable
        {

    
            /// <summary>
            /// For series on a datetime axes, the date format in the tooltip's header will by default be guessed based on the closest data points. This member gives the default string representations used for each unit. For an overview of the replacement codes, see dateFormat.Defaults to:{    millisecond:""%A, %b %e, %H:%M:%S.%L"",    second:""%A, %b %e, %H:%M:%S"",    minute:""%A, %b %e, %H:%M"",    hour:""%A, %b %e, %H:%M"",    day:""%A, %b %e, %Y"",    week:""Week from %A, %b %e, %Y"",    month:""%B %Y"",    year:""%Y""}
            /// </summary>
            [ConfigOption("dateTimeLabelFormats", null)]
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
            [ConfigOption("followPointer", null)]
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
            [ConfigOption("followTouchMove", null)]
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
            [ConfigOption("footerFormat", null)]
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
            [ConfigOption("headerFormat", null)]
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
            [ConfigOption("hideDelay", null)]
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
            [ConfigOption("pointFormat", null)]
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
            [ConfigOption("pointFormatter", null)]
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
            [ConfigOption("valueDecimals", null)]
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
            [ConfigOption("valuePrefix", null)]
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
            [ConfigOption("valueSuffix", null)]
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
            [ConfigOption("xDateFormat", null)]
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


    
	        private TooltipEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public TooltipEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new TooltipEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class TooltipEvents : ComponentListeners
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
        /// An array defining zones within a series. Zones can be applied to the X axis, Y axis or Z axis for bubbles, according to the zoneAxis option.
        /// </summary>
        public partial class Zones : Observable
        {

    
            /// <summary>
            /// Defines the color of the series.
            /// </summary>
            [ConfigOption("color", null)]
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
            [ConfigOption("dashStyle", null)]
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
            [ConfigOption("fillColor", null)]
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
            [ConfigOption("value", null)]
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


    
	        private ZonesEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public ZonesEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new ZonesEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class ZonesEvents : ComponentListeners
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
        public partial class FunnelEvents : ComponentListeners
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
        /// Fires when the checkbox next to the point name in the legend is clicked. One parameter, event, is passed to the function. The state of the checkbox is found by event.checked. The checked item is found by event.item. Return false to prevent the default action which is to toggle the select state of the series.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("checkboxClick", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the checkbox next to the point name in the legend is clicked. One parameter, event, is passed to the function. The state of the checkbox is found by event.checked. The checked item is found by event.item. Return false to prevent the default action which is to toggle the select state of the series.")]
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
        /// Not applicable to pies, as the legend item is per point. See point.events.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("legendItemClick", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Not applicable to pies, as the legend item is per point. See point.events.")]
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
            