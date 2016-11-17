
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
        /// The actual series to append to the chart. In addition to 	the members listed below, any member of the plotOptions for that specific	type of plot can be added to a series individually. For example, even though a general	lineWidth is specified in plotOptions.series, an individual	lineWidth can be specified for each series.
        /// </summary>
        public partial class Series : BaseSerie
        {

    
            /// <summary>
            /// This method is deprecated as of version 2.0. Instead, use options preprocessing as described in the docs.
            /// </summary>
            [ConfigOption("dataParser", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"This method is deprecated as of version 2.0. Instead, use options preprocessing as described in the docs.")]
            public string DataParser
            {
                get
                {
                    return this.State.Get<string>("DataParser", "");
                }
                set
                {
                    this.State.Set("DataParser", value);
                }
            }

            /// <summary>
            /// This method is deprecated as of version 2.0. Instead, load the data using jQuery.ajax and use options preprocessing as described in the docs.
            /// </summary>
            [ConfigOption("dataURL", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            
            [Category("HighChart")]
            [Description(@"This method is deprecated as of version 2.0. Instead, load the data using jQuery.ajax and use options preprocessing as described in the docs.")]
            public string DataURL
            {
                get
                {
                    return this.State.Get<string>("DataURL", "");
                }
                set
                {
                    this.State.Set("DataURL", value);
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
            /// This option allows grouping series in a stacked chart. The stack option can be a string  or a number or anything else, as long as the grouped series' stack options match each other.
            /// </summary>
            [ConfigOption("stack", null)]
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

        private Data _Data;
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("data", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description(@"An array of data points for the series. The points can be given in three ways:  	An array of numerical values. In this case, the numerical values will  	be interpreted as y values, and x values will be automatically calculated, 	either starting at 0 and incrementing by 1, or from pointStart  	and pointInterval given in the plotOptions. If the axis is 	has categories, these will be used. This option is not available for range series. Example:data: [0, 5, 3, 5] 	 	An array of arrays with two values. In this case, the first value is the 	x value and the second is the y value. If the first value is a string, it is 	applied as the name of the point, and the x value is incremented following 	the above rules.For range series, the arrays will be interpreted as [x, low, high]. In this cases, the X value can be skipped altogether to make use of pointStart and pointRange. Example:data: [[5, 2], [6, 3], [8, 2]]An array of objects with named values. In this case the objects are 	point configuration objects as seen below.Range series values are given by low and high.Example:data: [{	name: 'Point 1',	color: '#00FF00',	y: 0}, {	name: 'Point 2',	color: '#FF00FF',	y: 5}] Note that line series and derived types like spline and area, require data to be sorted by X because it interpolates mouse coordinates for the tooltip. Column and scatter series, where each point has its own mouse event, does not require sorting.")]
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


                list.Add("dataParser", new ConfigOption("dataParser", null, "", this.DataParser));

                list.Add("dataURL", new ConfigOption("dataURL", null, "", this.DataURL));

                list.Add("id", new ConfigOption("id", null, "", this.Id));

                list.Add("index", new ConfigOption("index", null, null, this.Index));

                list.Add("legendIndex", new ConfigOption("legendIndex", null, null, this.LegendIndex));

                list.Add("name", new ConfigOption("name", null, "", this.Name));

                list.Add("stack", new ConfigOption("stack", null, "", this.Stack));

                list.Add("type", new ConfigOption("type", null, "", this.Type));

                list.Add("xAxis", new ConfigOption("xAxis", null, null, this.XAxis));

                list.Add("yAxis", new ConfigOption("yAxis", null, null, this.YAxis));

                list.Add("zIndex", new ConfigOption("zIndex", null, null, this.ZIndex));

                list.Add("data", new ConfigOption("data", new SerializationOptions("data", typeof(LazyControlJsonConverter)), null, this.Data));


                return list;
            }
        }


    
	        private SeriesEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public SeriesEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new SeriesEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class SeriesEvents : BaseSerieEvents
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
            