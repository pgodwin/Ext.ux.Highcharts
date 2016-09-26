
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
        /// The plotOptions is a wrapper object for config objects for each series type.		The config objects for each series can also be overridden for each series 		item as given in the series array.		Configuration options for the series are given in three levels. Options		for all series in a chart are given in the plotOptions.series object. Then options for all series		of a specific type are given in the plotOptions of that type, for example plotOptions.line.		Next, options for one single series are given in the 		series array.
        /// </summary>
        public partial class PlotOptions : Observable
        {

    
        private AreaPlotOptions _Area;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("area", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual AreaPlotOptions Area
        {
            get
            {
                return this._Area;
            }
            set
            {
                if (this._Area != null)
                {
                    this.Controls.Remove(this._Area);
                    this.LazyItems.Remove(this._Area);
                }

                this._Area = value;

                if (this._Area != null)
                {
                    this.LazyItems.Add(this._Area);
                    this.Controls.Add(this._Area);
                }
            }
        }
        private ArearangePlotOptions _Arearange;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("arearange", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"The area range is a cartesian series type with higher and lower Y values along an X axis. Requires highcharts-more.js.")]
        public virtual ArearangePlotOptions Arearange
        {
            get
            {
                return this._Arearange;
            }
            set
            {
                if (this._Arearange != null)
                {
                    this.Controls.Remove(this._Arearange);
                    this.LazyItems.Remove(this._Arearange);
                }

                this._Arearange = value;

                if (this._Arearange != null)
                {
                    this.LazyItems.Add(this._Arearange);
                    this.Controls.Add(this._Arearange);
                }
            }
        }
        private AreasplinePlotOptions _Areaspline;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("areaspline", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual AreasplinePlotOptions Areaspline
        {
            get
            {
                return this._Areaspline;
            }
            set
            {
                if (this._Areaspline != null)
                {
                    this.Controls.Remove(this._Areaspline);
                    this.LazyItems.Remove(this._Areaspline);
                }

                this._Areaspline = value;

                if (this._Areaspline != null)
                {
                    this.LazyItems.Add(this._Areaspline);
                    this.Controls.Add(this._Areaspline);
                }
            }
        }
        private AreasplinerangePlotOptions _Areasplinerange;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("areasplinerange", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"The area spline range is a cartesian series type with higher and lower Y values along an X axis. Requires highcharts-more.js.")]
        public virtual AreasplinerangePlotOptions Areasplinerange
        {
            get
            {
                return this._Areasplinerange;
            }
            set
            {
                if (this._Areasplinerange != null)
                {
                    this.Controls.Remove(this._Areasplinerange);
                    this.LazyItems.Remove(this._Areasplinerange);
                }

                this._Areasplinerange = value;

                if (this._Areasplinerange != null)
                {
                    this.LazyItems.Add(this._Areasplinerange);
                    this.Controls.Add(this._Areasplinerange);
                }
            }
        }
        private BarPlotOptions _Bar;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("bar", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual BarPlotOptions Bar
        {
            get
            {
                return this._Bar;
            }
            set
            {
                if (this._Bar != null)
                {
                    this.Controls.Remove(this._Bar);
                    this.LazyItems.Remove(this._Bar);
                }

                this._Bar = value;

                if (this._Bar != null)
                {
                    this.LazyItems.Add(this._Bar);
                    this.Controls.Add(this._Bar);
                }
            }
        }
        private BoxplotPlotOptions _Boxplot;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("boxplot", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"A box plot is a convenient way of depicting groups of data through their five-number summaries: the smallest observation (sample minimum), lower quartile (Q1), median (Q2), upper quartile (Q3), and largest observation (sample maximum). ")]
        public virtual BoxplotPlotOptions Boxplot
        {
            get
            {
                return this._Boxplot;
            }
            set
            {
                if (this._Boxplot != null)
                {
                    this.Controls.Remove(this._Boxplot);
                    this.LazyItems.Remove(this._Boxplot);
                }

                this._Boxplot = value;

                if (this._Boxplot != null)
                {
                    this.LazyItems.Add(this._Boxplot);
                    this.Controls.Add(this._Boxplot);
                }
            }
        }
        private BubblePlotOptions _Bubble;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("bubble", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"A bubble series is a three dimensional series type where each point renders an X, Y and Z value. Each points is drawn as a bubble where the position along the X and Y axes mark the X and Y values, and the size of the bubble relates to the Z value.")]
        public virtual BubblePlotOptions Bubble
        {
            get
            {
                return this._Bubble;
            }
            set
            {
                if (this._Bubble != null)
                {
                    this.Controls.Remove(this._Bubble);
                    this.LazyItems.Remove(this._Bubble);
                }

                this._Bubble = value;

                if (this._Bubble != null)
                {
                    this.LazyItems.Add(this._Bubble);
                    this.Controls.Add(this._Bubble);
                }
            }
        }
        private ColumnPlotOptions _Column;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("column", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual ColumnPlotOptions Column
        {
            get
            {
                return this._Column;
            }
            set
            {
                if (this._Column != null)
                {
                    this.Controls.Remove(this._Column);
                    this.LazyItems.Remove(this._Column);
                }

                this._Column = value;

                if (this._Column != null)
                {
                    this.LazyItems.Add(this._Column);
                    this.Controls.Add(this._Column);
                }
            }
        }
        private ColumnrangePlotOptions _Columnrange;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("columnrange", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"The column range is a cartesian series type with higher and lower Y values along an X axis. Requires highcharts-more.js. To display horizontal bars, set chart.inverted to true.")]
        public virtual ColumnrangePlotOptions Columnrange
        {
            get
            {
                return this._Columnrange;
            }
            set
            {
                if (this._Columnrange != null)
                {
                    this.Controls.Remove(this._Columnrange);
                    this.LazyItems.Remove(this._Columnrange);
                }

                this._Columnrange = value;

                if (this._Columnrange != null)
                {
                    this.LazyItems.Add(this._Columnrange);
                    this.Controls.Add(this._Columnrange);
                }
            }
        }
        private ErrorbarPlotOptions _Errorbar;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("errorbar", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Error bars are a graphical representation of the variability of data and are used on graphs to indicate the error, or uncertainty in a reported measurement. ")]
        public virtual ErrorbarPlotOptions Errorbar
        {
            get
            {
                return this._Errorbar;
            }
            set
            {
                if (this._Errorbar != null)
                {
                    this.Controls.Remove(this._Errorbar);
                    this.LazyItems.Remove(this._Errorbar);
                }

                this._Errorbar = value;

                if (this._Errorbar != null)
                {
                    this.LazyItems.Add(this._Errorbar);
                    this.Controls.Add(this._Errorbar);
                }
            }
        }
        private FunnelPlotOptions _Funnel;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("funnel", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Funnel charts are a type of chart often used to visualize stages in a sales project, where the top are the initial stages with the most clients. It requires that the modules/funnel.js file is loaded.")]
        public virtual FunnelPlotOptions Funnel
        {
            get
            {
                return this._Funnel;
            }
            set
            {
                if (this._Funnel != null)
                {
                    this.Controls.Remove(this._Funnel);
                    this.LazyItems.Remove(this._Funnel);
                }

                this._Funnel = value;

                if (this._Funnel != null)
                {
                    this.LazyItems.Add(this._Funnel);
                    this.Controls.Add(this._Funnel);
                }
            }
        }
        private GaugePlotOptions _Gauge;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("gauge", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"General plotting options for the gauge series type. Requires highcharts-more.js")]
        public virtual GaugePlotOptions Gauge
        {
            get
            {
                return this._Gauge;
            }
            set
            {
                if (this._Gauge != null)
                {
                    this.Controls.Remove(this._Gauge);
                    this.LazyItems.Remove(this._Gauge);
                }

                this._Gauge = value;

                if (this._Gauge != null)
                {
                    this.LazyItems.Add(this._Gauge);
                    this.Controls.Add(this._Gauge);
                }
            }
        }
        private HeatmapPlotOptions _Heatmap;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("heatmap", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"The heatmap series type. This series type is available both in Highcharts and Highmaps.The colors of each heat map point is usually determined by its value and controlled by settings on the colorAxis.")]
        public virtual HeatmapPlotOptions Heatmap
        {
            get
            {
                return this._Heatmap;
            }
            set
            {
                if (this._Heatmap != null)
                {
                    this.Controls.Remove(this._Heatmap);
                    this.LazyItems.Remove(this._Heatmap);
                }

                this._Heatmap = value;

                if (this._Heatmap != null)
                {
                    this.LazyItems.Add(this._Heatmap);
                    this.Controls.Add(this._Heatmap);
                }
            }
        }
        private LinePlotOptions _Line;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("line", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual LinePlotOptions Line
        {
            get
            {
                return this._Line;
            }
            set
            {
                if (this._Line != null)
                {
                    this.Controls.Remove(this._Line);
                    this.LazyItems.Remove(this._Line);
                }

                this._Line = value;

                if (this._Line != null)
                {
                    this.LazyItems.Add(this._Line);
                    this.Controls.Add(this._Line);
                }
            }
        }
        private PiePlotOptions _Pie;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("pie", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"A pie chart is a circular chart divided into sectors, illustrating numerical proportion.")]
        public virtual PiePlotOptions Pie
        {
            get
            {
                return this._Pie;
            }
            set
            {
                if (this._Pie != null)
                {
                    this.Controls.Remove(this._Pie);
                    this.LazyItems.Remove(this._Pie);
                }

                this._Pie = value;

                if (this._Pie != null)
                {
                    this.LazyItems.Add(this._Pie);
                    this.Controls.Add(this._Pie);
                }
            }
        }
        private PolygonPlotOptions _Polygon;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("polygon", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"A polygon series can be used to draw any freeform shape in the cartesian coordinate system. A fill is applied with the color option, and stroke is applied through lineWidth and lineColor options. Requires the highcharts-more.js file.")]
        public virtual PolygonPlotOptions Polygon
        {
            get
            {
                return this._Polygon;
            }
            set
            {
                if (this._Polygon != null)
                {
                    this.Controls.Remove(this._Polygon);
                    this.LazyItems.Remove(this._Polygon);
                }

                this._Polygon = value;

                if (this._Polygon != null)
                {
                    this.LazyItems.Add(this._Polygon);
                    this.Controls.Add(this._Polygon);
                }
            }
        }
        private PyramidPlotOptions _Pyramid;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("pyramid", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"A pyramid chart consists of a single pyramid with item heights corresponding to each point value. Technically it is the same as a reversed funnel chart without a neck.")]
        public virtual PyramidPlotOptions Pyramid
        {
            get
            {
                return this._Pyramid;
            }
            set
            {
                if (this._Pyramid != null)
                {
                    this.Controls.Remove(this._Pyramid);
                    this.LazyItems.Remove(this._Pyramid);
                }

                this._Pyramid = value;

                if (this._Pyramid != null)
                {
                    this.LazyItems.Add(this._Pyramid);
                    this.Controls.Add(this._Pyramid);
                }
            }
        }
        private ScatterPlotOptions _Scatter;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("scatter", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual ScatterPlotOptions Scatter
        {
            get
            {
                return this._Scatter;
            }
            set
            {
                if (this._Scatter != null)
                {
                    this.Controls.Remove(this._Scatter);
                    this.LazyItems.Remove(this._Scatter);
                }

                this._Scatter = value;

                if (this._Scatter != null)
                {
                    this.LazyItems.Add(this._Scatter);
                    this.Controls.Add(this._Scatter);
                }
            }
        }
        private SeriesPlotOptions _Series;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("series", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"General options for all series types.")]
        public virtual SeriesPlotOptions Series
        {
            get
            {
                return this._Series;
            }
            set
            {
                if (this._Series != null)
                {
                    this.Controls.Remove(this._Series);
                    this.LazyItems.Remove(this._Series);
                }

                this._Series = value;

                if (this._Series != null)
                {
                    this.LazyItems.Add(this._Series);
                    this.Controls.Add(this._Series);
                }
            }
        }
        private SolidgaugePlotOptions _Solidgauge;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("solidgauge", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"A gauge showing values using a filled arc with colors indicating the value. The solid gauge plots values against the yAxis, which is extended with some color options, minColor, maxColor and stops, to control the color of the gauge itself.")]
        public virtual SolidgaugePlotOptions Solidgauge
        {
            get
            {
                return this._Solidgauge;
            }
            set
            {
                if (this._Solidgauge != null)
                {
                    this.Controls.Remove(this._Solidgauge);
                    this.LazyItems.Remove(this._Solidgauge);
                }

                this._Solidgauge = value;

                if (this._Solidgauge != null)
                {
                    this.LazyItems.Add(this._Solidgauge);
                    this.Controls.Add(this._Solidgauge);
                }
            }
        }
        private SplinePlotOptions _Spline;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("spline", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"")]
        public virtual SplinePlotOptions Spline
        {
            get
            {
                return this._Spline;
            }
            set
            {
                if (this._Spline != null)
                {
                    this.Controls.Remove(this._Spline);
                    this.LazyItems.Remove(this._Spline);
                }

                this._Spline = value;

                if (this._Spline != null)
                {
                    this.LazyItems.Add(this._Spline);
                    this.Controls.Add(this._Spline);
                }
            }
        }
        private TreemapPlotOptions _Treemap;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("treemap", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"The size of the point shape is determined by its value relative to its siblings values.Requires the module heatmap.js as well, if functionality such as the colorAxis is to be used.")]
        public virtual TreemapPlotOptions Treemap
        {
            get
            {
                return this._Treemap;
            }
            set
            {
                if (this._Treemap != null)
                {
                    this.Controls.Remove(this._Treemap);
                    this.LazyItems.Remove(this._Treemap);
                }

                this._Treemap = value;

                if (this._Treemap != null)
                {
                    this.LazyItems.Add(this._Treemap);
                    this.Controls.Add(this._Treemap);
                }
            }
        }
        private WaterfallPlotOptions _Waterfall;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("waterfall", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"Options for the waterfall series type.")]
        public virtual WaterfallPlotOptions Waterfall
        {
            get
            {
                return this._Waterfall;
            }
            set
            {
                if (this._Waterfall != null)
                {
                    this.Controls.Remove(this._Waterfall);
                    this.LazyItems.Remove(this._Waterfall);
                }

                this._Waterfall = value;

                if (this._Waterfall != null)
                {
                    this.LazyItems.Add(this._Waterfall);
                    this.Controls.Add(this._Waterfall);
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


                list.Add("area", new ConfigOption("area", new SerializationOptions("area", typeof(LazyControlJsonConverter)), null, this.Area));

                list.Add("arearange", new ConfigOption("arearange", new SerializationOptions("arearange", typeof(LazyControlJsonConverter)), null, this.Arearange));

                list.Add("areaspline", new ConfigOption("areaspline", new SerializationOptions("areaspline", typeof(LazyControlJsonConverter)), null, this.Areaspline));

                list.Add("areasplinerange", new ConfigOption("areasplinerange", new SerializationOptions("areasplinerange", typeof(LazyControlJsonConverter)), null, this.Areasplinerange));

                list.Add("bar", new ConfigOption("bar", new SerializationOptions("bar", typeof(LazyControlJsonConverter)), null, this.Bar));

                list.Add("boxplot", new ConfigOption("boxplot", new SerializationOptions("boxplot", typeof(LazyControlJsonConverter)), null, this.Boxplot));

                list.Add("bubble", new ConfigOption("bubble", new SerializationOptions("bubble", typeof(LazyControlJsonConverter)), null, this.Bubble));

                list.Add("column", new ConfigOption("column", new SerializationOptions("column", typeof(LazyControlJsonConverter)), null, this.Column));

                list.Add("columnrange", new ConfigOption("columnrange", new SerializationOptions("columnrange", typeof(LazyControlJsonConverter)), null, this.Columnrange));

                list.Add("errorbar", new ConfigOption("errorbar", new SerializationOptions("errorbar", typeof(LazyControlJsonConverter)), null, this.Errorbar));

                list.Add("funnel", new ConfigOption("funnel", new SerializationOptions("funnel", typeof(LazyControlJsonConverter)), null, this.Funnel));

                list.Add("gauge", new ConfigOption("gauge", new SerializationOptions("gauge", typeof(LazyControlJsonConverter)), null, this.Gauge));

                list.Add("heatmap", new ConfigOption("heatmap", new SerializationOptions("heatmap", typeof(LazyControlJsonConverter)), null, this.Heatmap));

                list.Add("line", new ConfigOption("line", new SerializationOptions("line", typeof(LazyControlJsonConverter)), null, this.Line));

                list.Add("pie", new ConfigOption("pie", new SerializationOptions("pie", typeof(LazyControlJsonConverter)), null, this.Pie));

                list.Add("polygon", new ConfigOption("polygon", new SerializationOptions("polygon", typeof(LazyControlJsonConverter)), null, this.Polygon));

                list.Add("pyramid", new ConfigOption("pyramid", new SerializationOptions("pyramid", typeof(LazyControlJsonConverter)), null, this.Pyramid));

                list.Add("scatter", new ConfigOption("scatter", new SerializationOptions("scatter", typeof(LazyControlJsonConverter)), null, this.Scatter));

                list.Add("series", new ConfigOption("series", new SerializationOptions("series", typeof(LazyControlJsonConverter)), null, this.Series));

                list.Add("solidgauge", new ConfigOption("solidgauge", new SerializationOptions("solidgauge", typeof(LazyControlJsonConverter)), null, this.Solidgauge));

                list.Add("spline", new ConfigOption("spline", new SerializationOptions("spline", typeof(LazyControlJsonConverter)), null, this.Spline));

                list.Add("treemap", new ConfigOption("treemap", new SerializationOptions("treemap", typeof(LazyControlJsonConverter)), null, this.Treemap));

                list.Add("waterfall", new ConfigOption("waterfall", new SerializationOptions("waterfall", typeof(LazyControlJsonConverter)), null, this.Waterfall));

                return list;
            }
        }


    
	        private PlotOptionsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public PlotOptionsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new PlotOptionsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class PlotOptionsEvents : ComponentListeners
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
            