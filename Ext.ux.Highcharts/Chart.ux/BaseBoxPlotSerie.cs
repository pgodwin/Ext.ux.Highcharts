using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Ext.Net;


[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.BoxPlotSerie.js", "text/javascript")]
namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    /// Serie class for BoxPlot series type
    /// See {@link Chart.ux.Highcharts.RangeSerie} class for more info
    /// 
    /// Here is an example of BoxPlot series config:
    ///      series: [{
    ///          type: 'boxplot',
    ///          minDataIndex: 'min',
    ///          lowQtrDataIndex: 'q1',
    ///          medianDataIndex: 'med',
    ///          highQtrDataIndex: 'q2',
    ///          maxDataIndex: 'max',
    ///          xField: 'date'
    ///      }]     
    /// </summary>
    
    public partial class BaseBoxPlotSerie : Series
    {

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The low Quartile data field ")]
        public virtual string LowQtrDataIndex
        {
            get
            {
                object obj = this.ViewState["LowQtrDataIndex"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["LowQtrDataIndex"] = value;
            }
        }


        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The high Quartile data field")]
        public virtual string HighQtrDataIndex
        {
            get
            {
                object obj = this.ViewState["HighQtrDataIndex"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["HighQtrDataIndex"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The median data field")]
        public virtual string MedianDataIndex
        {
            get
            {
                object obj = this.ViewState["MedianDataIndex"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["MedianDataIndex"] = value;
            }
        }

        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {

                ConfigOptionsCollection list = base.ConfigOptions;

                list.Add("lowQtrDataIndex", new ConfigOption("lowQtrDataIndex", null, "", this.LowQtrDataIndex));
                list.Add("highQtrDataIndex", new ConfigOption("highQtrDataIndex", null, "", this.HighQtrDataIndex));
                list.Add("medianDataIndex", new ConfigOption("medianDataIndex", null, "", this.MedianDataIndex));

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
                baseList.Add(new ClientScriptItem(typeof(global::Ext.ux.Highcharts.ChartSeries.Series), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.BoxPlotSerie.js", "Resources/Chart/ux/Highcharts/BoxPlotSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.BoxPlotSerie";
            }
        }


    }
}

