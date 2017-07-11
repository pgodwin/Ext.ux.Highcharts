using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Ext.Net;
using Ext.ux.Highcharts.ChartSeries;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.BubbleSerie.js", "text/javascript")]
namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    ///  Serie class for bubble type series
    /// 
    ///  The bubble series support two types of data input
    /// 
    ///  # Single Bubble Series
    ///  For single bubble series, the series can be specified as 
    ///      series: [{
    ///          xField: 'x',
    ///          yField: 'y',
    ///          radiusField: 'r'
    ///          type: 'bubble'
    ///      }]
    /// 
    ///  # Single / Multiple Bubble Series
    ///  For single/multiple bubble series, the series should be specified as 
    ///  the Irregular data example, i.e.
    ///      series: [{
    ///          type: 'bubble',
    ///          dataIndex: 'series1'
    ///      }, {
    ///          type: 'bubble',
    ///          dataIndex: 'series2'
    ///      }]
    /// 
    ///  The Json data returning from the server side should looking like the following:
    ///      'root': [{
    ///          'series1': [ [ 97,36,79],[94,74,60],[68,76,58], .... ] ],
    ///          'series2': [ [25,10,87],[2,75,59],[11,54,8],[86,55,93] .... ] ],
    ///       }]
    ///  
    ///  See {@link Chart.ux.Highcharts.Serie} class for more info
    /// </summary>
    public partial class BaseBubbleSerie : Series
    {

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The field stores the radius value of a bubble data point")]
        public virtual string RadiusField
        {
            get
            {
                object obj = this.ViewState["RadiusField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["RadiusField"] = value;
            }
        }

        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                list.Add("radiusField", new ConfigOption("radiusField", null, "", this.RadiusField));
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
                baseList.Add(new ClientScriptItem(typeof(BaseBubbleSerie), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.BubbleSerie.js", "Resources/Chart/ux/Highcharts/BubbleSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.BubbleSerie";
            }
        }


    }
}

