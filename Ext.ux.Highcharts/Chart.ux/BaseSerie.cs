using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Serialization;
using Ext.Net;
//using Ext.ux.Highcharts.Series;
using Newtonsoft.Json;

namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    ///  Serie class is the base class for all the series types. Users shouldn't use any of the 
    ///  series classes directly, they are created internally from Chart.ux.Highcharts depending on the
    ///  series configuration.
    /// 
    ///  Serie class is a general class for series data representation. 
    ///  # Mapping data fields 
    ///  In the Highcharts extension, the series option is declared outside of chartConfig, so as the/// xField*. 
    ///  There is a subtle difference for declaring xField outside or inside a series. For example:
    /// 
    ///      series:[{
    ///         name: 'Share A',
    ///         type: 'line',
    ///         yField: 'sharePriceA'
    ///      }, {
    ///         name: 'Share B',
    ///         type: 'line',
    ///         yField: 'sharePriceB'
    ///      }],
    ///      xField: 'datetime',
    ///      ....
    ///  This means both series share the same categories and each series has it own set of y-values. 
    ///  In this case, the datetime field can be either string or numerical representation of date time.
    /// 
    ///      series:[{
    ///         name: 'Share A',
    ///         type: 'line',
    ///         yField: 'sharePriceA',
    ///         xField: 'datetimeA'
    ///      }, {
    ///         name: 'Share B',
    ///         type: 'line',
    ///         yField: 'sharePriceB',
    ///         xField: 'datetimeB'
    ///      }],
    ///  This means both series have their own (x,y) data. In this case, the xField must refer to numerical values.
    ///  
    ///  # Mapping multiple series with irregular datasets
    ///  Suppose we have 3 series with different set of data points. To map the store with the series, first
    ///  the store is required to return Json data in the following format:
    /// 
    ///      { root: [ 
    ///            series1: [ [ 1, 3 ], [ 2, 5 ], [ 7, 1 ] ],
    ///            series2: [ [ 2, 4 ], [ 5, 7 ] ],
    ///            series3: [ [ 1, 8 ], [ 4, 6 ], [ 5, 1 ], [ 9, 4 ] ]
    ///        ]
    ///      }
    /// 
    ///  Then use {@link Chart.ux.Highcharts.Serie#cfg-dataIndex} to map the series data array
    /// 
    ///      series: [{
    ///          name: 'Series A',
    ///          dataIndex: 'series1'
    ///      }, {
    ///          name: 'Series B',
    ///          dataIndex: 'series2'
    ///      }, {
    ///          name: 'Series C',
    ///          dataIndex: 'series3'
    ///      }]
    /// 
    ///  # 3D charts
    ///  Highcharts 3D charts require including additional Javascript file.
    /// 
    ///      <script type="text/javascript" src="http://code.highcharts.com/highcharts-3d.js"></script>
    /// 
    ///  To plot 3D charts, simply uses the as the Highcharts 3D option, [*options3d*](http://api.highcharts.com/highcharts#chart.options3d). 
    ///  Below is an example of 3D scatter using addition/// zField* option for mapping z-axis value:
    ///  
    ///      series : [{
    ///          type : 'scatter',
    ///          xField: 'x',
    ///          yField: 'y',
    ///          zField: 'z'
    ///      }],
    ///      chartConfig : {
    ///          chart : {
    ///              ....
    ///              options3d: {
    ///                   enabled: true,
    ///                   ....
    ///              }
    ///          },
    ///          ....,
    ///          zAxis: {
    ///              ....
    ///          },
    /// 
    ///  For 3D column chart, users need to also specify/// chartConfig.chart.type* as 'column'. 
    /// </summary>
    [assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.Serie.js", "text/javascript")]
    
    public partial class BaseSerie : Observable
    {



        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("This field is used for setting data point color number or color hex in '#([0-9])'. Otherwise, the option is treated as a field name and the store should return rows with the same color field name. For column type series, if you want Highcharts to automatically color each data point, then you should use plotOptions.column.colorByPoint option in the series config.")]
        public virtual string ColorField
        {
            get
            {
                object obj = this.ViewState["ColorField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["ColorField"] = value;
            }
        }


        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("can be either an alias of yField (which has higher precedence if both are defined) or mapping to store's field with array of data points")]
        public virtual string DataIndex
        {
            get
            {
                object obj = this.ViewState["DataIndex"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["DataIndex"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("Highcharts series type name. This field must be specified. Line, area, scatter and column series are the simplest form of charts (includes Polar) which has the simple data mappings: dataIndex or yField for y-axis values and xField for either x-axis category field or data point's x-axis coordinate.")]
        public virtual string Type
        {
            get
            {
                object obj = this.ViewState["Type"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["Type"] = value;
            }

        }


        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("Setting this option to true will enforce the chart to clear the series if there is no record returned for the series")]
        public virtual bool UpdateNoRecord
        {
            get
            {
                object obj = this.ViewState["UpdateNoRecord"];
                return obj != null ? (bool)obj : false;
            }
            set
            {
                this.ViewState["UpdateNoRecord"] = value;
            }
        }


        [ConfigOption]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The field used to hide the serie initial. Defaults to true.")]
        public virtual bool Visible
        {
            get
            {
                object obj = this.ViewState["Visible"];
                return obj != null ? (bool)obj : true;
            }
            set
            {
                this.ViewState["Visible"] = value;
            }
        }


        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The field used to access the x-axis value from the items from the data source. Store's record")]
        public virtual string XField
        {
            get
            {
                object obj = this.ViewState["XField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["XField"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The field used to access the y-axis value from the items from the data source. Store's record")]
        public virtual string YField
        {
            get
            {
                object obj = this.ViewState["YField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["YField"] = value;
            }
        }



        public void RegisterResources()
        {
            var baseType = this.GetType();

            this.RegisterAllResources = true;
            baseType
                .GetMethod("RegisterScripts", BindingFlags.NonPublic | BindingFlags.Instance, System.Type.DefaultBinder, System.Type.EmptyTypes, null)
                .Invoke(this, new object[0]);
            baseType
                .GetMethod("RegisterStyles", BindingFlags.NonPublic | BindingFlags.Instance, System.Type.DefaultBinder, System.Type.EmptyTypes, null)
                .Invoke(this, new object[0]);

            //component.RegisterScripts();
            //component.RegisterStyles();
        //    this.PreventRenderTo = true;

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

                list.Add("colorField", new ConfigOption("colorField", null, "", this.ColorField));
                list.Add("dataIndex", new ConfigOption("dataIndex", null, "", this.DataIndex));
                list.Add("type", new ConfigOption("type", null, "", this.Type));
                list.Add("updateNoRecord", new ConfigOption("updateNoRecord", null, false, this.UpdateNoRecord));
                list.Add("visible", new ConfigOption("visible", null, true, this.Visible));
                list.Add("xField", new ConfigOption("xField", null, "", this.XField));
                list.Add("yField", new ConfigOption("yField", null, "", this.YField));

                return list;
            }
        }
     

        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(Series), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.Serie.js", "Resources/Chart/ux/Highcharts/Serie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.Serie";
            }
        }

     
    }
}
