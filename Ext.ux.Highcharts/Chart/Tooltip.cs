
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

namespace Ext.ux.Highcharts.Chart
{
        


        /// <summary>
        /// Options for the tooltip that appears when the user hovers over a series or point.
        /// </summary>
        public partial class Tooltip : Observable
        {

    
            /// <summary>
            /// Enable or disable animation of the tooltip. In slow legacy IE browsers the animation is disabled by default.
            /// </summary>
            [ConfigOption("animation", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Enable or disable animation of the tooltip. In slow legacy IE browsers the animation is disabled by default.")]
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
            /// The background color or gradient for the tooltip.
            /// </summary>
            [ConfigOption("backgroundColor", null)]
            [DefaultValue(@"rgba(255, 255, 255, 0.85)")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The background color or gradient for the tooltip.")]
            public string BackgroundColor
            {
                get
                {
                    return this.State.Get<string>("BackgroundColor", @"rgba(255, 255, 255, 0.85)");
                }
                set
                {
                    this.State.Set("BackgroundColor", value);
                }
            }

            /// <summary>
            /// The color of the tooltip border. When null, the border takes the color of the corresponding series or point.
            /// </summary>
            [ConfigOption("borderColor", null)]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The color of the tooltip border. When null, the border takes the color of the corresponding series or point.")]
            public string BorderColor
            {
                get
                {
                    return this.State.Get<string>("BorderColor", @"null");
                }
                set
                {
                    this.State.Set("BorderColor", value);
                }
            }

            /// <summary>
            /// The radius of the rounded border corners.
            /// </summary>
            [ConfigOption("borderRadius", null)]
            [DefaultValue(3)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The radius of the rounded border corners.")]
            public double? BorderRadius
            {
                get
                {
                    return this.State.Get<double?>("BorderRadius", 3);
                }
                set
                {
                    this.State.Set("BorderRadius", value);
                }
            }

            /// <summary>
            /// The pixel width of the tooltip border.
            /// </summary>
            [ConfigOption("borderWidth", null)]
            [DefaultValue(1)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The pixel width of the tooltip border.")]
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
            /// Display crosshairs to connect the points with their corresponding axis values. The crosshairs can be defined as a boolean, an array of booleans or an object.  	Boolean 	If the crosshairs option is true, a single crosshair relating to the 	x axis will be shown. 	 	Array of booleans 	In an array of booleans, the first value turns on the x axis crosshair and the second 	value to the y axis crosshair. Use [true, true] to show complete crosshairs. 	 	Array of objects 	In an array of objects, the first value applies to the x axis crosshair and the second 	value to the y axis crosshair. For each dimension, a width, color, 	dashStyle and zIndex can be given.		 Defaults to null.
            /// </summary>
            [ConfigOption("crosshairs", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Display crosshairs to connect the points with their corresponding axis values. The crosshairs can be defined as a boolean, an array of booleans or an object.  	Boolean 	If the crosshairs option is true, a single crosshair relating to the 	x axis will be shown. 	 	Array of booleans 	In an array of booleans, the first value turns on the x axis crosshair and the second 	value to the y axis crosshair. Use [true, true] to show complete crosshairs. 	 	Array of objects 	In an array of objects, the first value applies to the x axis crosshair and the second 	value to the y axis crosshair. For each dimension, a width, color, 	dashStyle and zIndex can be given.		 Defaults to null.")]
            public object Crosshairs
            {
                get
                {
                    return this.State.Get<object>("Crosshairs", null);
                }
                set
                {
                    this.State.Set("Crosshairs", value);
                }
            }

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
            /// Enable or disable the tooltip.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Enable or disable the tooltip.")]
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
            /// Callback function to format the text of the tooltip. Return false to disable tooltip for a specific point on series. A subset of HTML is supported. The HTML of the tooltip is parsed and converted to SVG,  therefore this isn't a complete HTML renderer. The following tabs are supported:  &lt;b&gt;, &lt;strong&gt;, &lt;i&gt;, &lt;em&gt;, &lt;br/&gt;, &lt;span&gt;. Spans can be styled with a style attribute, but only text-related CSS that is  shared with SVG is handled.  Since version 2.1 the tooltip can be shared between multiple series through  the shared option. The available data in the formatter differ a bit depending on whether the tooltip is shared or not. In a shared tooltip, all  properties except x, which is common for all points, are kept in  an array, this.points.  Available data are:  	this.percentage (not shared) / this.points[i].percentage (shared) 	Stacked series and pies only. The point's percentage of the total. 	 	this.point (not shared) / this.points[i].point (shared) 	The point object. The point name, if defined, is available  through this.point.name. 	 	this.points 	In a shared tooltip, this is an array containing all other properties for each point. 	 	this.series (not shared) / this.points[i].series (shared) 	The series object. The series name is available  through this.series.name.  	this.total (not shared) / this.points[i].total (shared) 	Stacked series only. The total value at this point's x value. 	 	this.x 	The x value. This property is the same regardless of the tooltip being shared or not. 	 	this.y (not shared) / this.points[i].y (shared) 	The y value.  
            /// </summary>
            [ConfigOption("formatter", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Callback function to format the text of the tooltip. Return false to disable tooltip for a specific point on series. A subset of HTML is supported. The HTML of the tooltip is parsed and converted to SVG,  therefore this isn't a complete HTML renderer. The following tabs are supported:  &lt;b&gt;, &lt;strong&gt;, &lt;i&gt;, &lt;em&gt;, &lt;br/&gt;, &lt;span&gt;. Spans can be styled with a style attribute, but only text-related CSS that is  shared with SVG is handled.  Since version 2.1 the tooltip can be shared between multiple series through  the shared option. The available data in the formatter differ a bit depending on whether the tooltip is shared or not. In a shared tooltip, all  properties except x, which is common for all points, are kept in  an array, this.points.  Available data are:  	this.percentage (not shared) / this.points[i].percentage (shared) 	Stacked series and pies only. The point's percentage of the total. 	 	this.point (not shared) / this.points[i].point (shared) 	The point object. The point name, if defined, is available  through this.point.name. 	 	this.points 	In a shared tooltip, this is an array containing all other properties for each point. 	 	this.series (not shared) / this.points[i].series (shared) 	The series object. The series name is available  through this.series.name.  	this.total (not shared) / this.points[i].total (shared) 	Stacked series only. The total value at this point's x value. 	 	this.x 	The x value. This property is the same regardless of the tooltip being shared or not. 	 	this.y (not shared) / this.points[i].y (shared) 	The y value.  ")]
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
            /// A callback function to place the tooltip in a default position. The callback receives three parameters: labelWidth, labelHeight and point, where point contains values for plotX and plotY telling where the reference point is in the plot area. Add chart.plotLeft and chart.plotTop to get the full coordinates.The return should be an object containing x and y values, for example { x: 100, y: 100 }.
            /// </summary>
            [ConfigOption("positioner", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"A callback function to place the tooltip in a default position. The callback receives three parameters: labelWidth, labelHeight and point, where point contains values for plotX and plotY telling where the reference point is in the plot area. Add chart.plotLeft and chart.plotTop to get the full coordinates.The return should be an object containing x and y values, for example { x: 100, y: 100 }.")]
            public string Positioner
            {
                get
                {
                    return this.State.Get<string>("Positioner", "");
                }
                set
                {
                    this.State.Set("Positioner", value);
                }
            }

            /// <summary>
            /// Whether to apply a drop shadow to the tooltip.
            /// </summary>
            [ConfigOption("shadow", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Whether to apply a drop shadow to the tooltip.")]
            public bool? Shadow
            {
                get
                {
                    return this.State.Get<bool?>("Shadow", true);
                }
                set
                {
                    this.State.Set("Shadow", value);
                }
            }

            /// <summary>
            /// The name of a symbol to use for the border around the tooltip. In Highcharts 3.x and less, the shape was square. 
            /// </summary>
            [ConfigOption("shape", null)]
            [DefaultValue(@"callout")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"The name of a symbol to use for the border around the tooltip. In Highcharts 3.x and less, the shape was square. ")]
            public string Shape
            {
                get
                {
                    return this.State.Get<string>("Shape", @"callout");
                }
                set
                {
                    this.State.Set("Shape", value);
                }
            }

            /// <summary>
            /// When the tooltip is shared, the entire plot area will capture mouse movement or touch events. Tooltip texts for series types with ordered data (not pie, scatter, flags etc) will be shown in a single bubble. This is recommended for single series charts and for tablet/mobile optimized charts.
            /// </summary>
            [ConfigOption("shared", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"When the tooltip is shared, the entire plot area will capture mouse movement or touch events. Tooltip texts for series types with ordered data (not pie, scatter, flags etc) will be shown in a single bubble. This is recommended for single series charts and for tablet/mobile optimized charts.")]
            public bool? Shared
            {
                get
                {
                    return this.State.Get<bool?>("Shared", false);
                }
                set
                {
                    this.State.Set("Shared", value);
                }
            }

            /// <summary>
            /// Proximity snap for graphs or single points. Does not apply to bars, columns and pie slices. It defaults to 10 for mouse-powered devices and 25 for touch  devices. Note that since Highcharts 4.1 the whole plot area by default captures pointer events in order to show the tooltip, so for tooltip.snap to make sense, stickyTracking must be false.
            /// </summary>
            [ConfigOption("snap", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Proximity snap for graphs or single points. Does not apply to bars, columns and pie slices. It defaults to 10 for mouse-powered devices and 25 for touch  devices. Note that since Highcharts 4.1 the whole plot area by default captures pointer events in order to show the tooltip, so for tooltip.snap to make sense, stickyTracking must be false.")]
            public double? Snap
            {
                get
                {
                    return this.State.Get<double?>("Snap", null);
                }
                set
                {
                    this.State.Set("Snap", value);
                }
            }

            /// <summary>
            /// CSS styles for the tooltip. The tooltip can also be styled through the CSS class .highcharts-tooltip. Default value:style: {	color: '#333333',	fontSize: '12px',	padding: '8px'}
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"CSS styles for the tooltip. The tooltip can also be styled through the CSS class .highcharts-tooltip. Default value:style: {	color: '#333333',	fontSize: '12px',	padding: '8px'}")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", "");
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// Use HTML to render the contents of the tooltip instead of SVG. Using HTML allows advanced formatting like tables and images in the tooltip. It is also recommended for rtl languages as it works around rtl bugs in early Firefox.
            /// </summary>
            [ConfigOption("useHTML", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"Use HTML to render the contents of the tooltip instead of SVG. Using HTML allows advanced formatting like tables and images in the tooltip. It is also recommended for rtl languages as it works around rtl bugs in early Firefox.")]
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


                list.Add("animation", new ConfigOption("animation", null, true, this.Animation));

                list.Add("backgroundColor", new ConfigOption("backgroundColor", null, @"rgba(255, 255, 255, 0.85)", this.BackgroundColor));

                list.Add("borderColor", new ConfigOption("borderColor", null, @"null", this.BorderColor));

                list.Add("borderRadius", new ConfigOption("borderRadius", null, 3, this.BorderRadius));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 1, this.BorderWidth));

                list.Add("crosshairs", new ConfigOption("crosshairs", null, null, this.Crosshairs));

                list.Add("dateTimeLabelFormats", new ConfigOption("dateTimeLabelFormats", null, null, this.DateTimeLabelFormats));

                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("followPointer", new ConfigOption("followPointer", null, false, this.FollowPointer));

                list.Add("followTouchMove", new ConfigOption("followTouchMove", null, true, this.FollowTouchMove));

                list.Add("footerFormat", new ConfigOption("footerFormat", null, @"false", this.FooterFormat));

                list.Add("formatter", new ConfigOption("formatter", null, "", this.Formatter));

                list.Add("headerFormat", new ConfigOption("headerFormat", null, "", this.HeaderFormat));

                list.Add("hideDelay", new ConfigOption("hideDelay", null, 500, this.HideDelay));

                list.Add("pointFormat", new ConfigOption("pointFormat", null, @"<span style=""color:{point.color}"">\u25CF</span> {series.name}: <b>{point.y}</b><br/>", this.PointFormat));

                list.Add("pointFormatter", new ConfigOption("pointFormatter", null, "", this.PointFormatter));

                list.Add("positioner", new ConfigOption("positioner", null, "", this.Positioner));

                list.Add("shadow", new ConfigOption("shadow", null, true, this.Shadow));

                list.Add("shape", new ConfigOption("shape", null, @"callout", this.Shape));

                list.Add("shared", new ConfigOption("shared", null, false, this.Shared));

                list.Add("snap", new ConfigOption("snap", null, null, this.Snap));

                list.Add("style", new ConfigOption("style", null, "", this.Style));

                list.Add("useHTML", new ConfigOption("useHTML", null, false, this.UseHTML));

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

        
}
            