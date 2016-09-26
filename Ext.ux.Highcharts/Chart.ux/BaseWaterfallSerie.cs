using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using Ext.Net;

namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    /// Serie class for water fall series type
    /// 
    ///  See {@link Chart.ux.Highcharts.Serie} class for more info
    /// 
    ///  The following is the config example converted from the original 
    ///  [Highcharts waterfall demo][1]
    ///  [1]: http://www.highcharts.com/demo/waterfall
    /// 
    ///      series: [{
    ///          type: 'waterfall',
    ///          upColor: Highcharts.getOptions().colors[2],
    ///          color: Highcharts.getOptions().colors[3],
    ///          categorieField: 'category',
    ///          yField: 'value',
    ///          colorField: 'color',
    ///          sumTypeField: 'sum',
    ///          dataLabels: {
    ///              ....
    ///          }
    ///      }]
    /// 
    ///  The Json data returning from the server side should look like as follows:
    ///  
    ///      {"root":[{ "category":"Start","value":120000 }, 
    ///               { "category":"Product Revenue","value":569000 },
    ///               { "category":"Service Revenue","value":231000 },
    ///               { "category":"Positive Balance","color": "#0d233a", "sum": "intermediate" },
    ///               { "category":"Fixed Costs","value":-342000 },
    ///               { "category":"Variable Cost","value": -233000 },
    ///               { "category":"Balance","color": "#0d233a", "sum": "final" }
    ///      ]}
    /// 
    /// /
    /// </summary>
    [assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.WaterfallSerie.js", "text/javascript")]
    public partial class BaseWaterfallSerie : Series
    {

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("Column value is whether derived from precious values. Possible values: 'intermediate', 'final' or null (expect dataIndex or yField contains value)")]
        public virtual string SumTypeField
        {
            get
            {
                object obj = this.ViewState["SumTypeField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["SumTypeField"] = value;
            }
        }

        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                list.Add("sumTypeField", new ConfigOption("sumTypeField", null, "", this.SumTypeField));
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
                baseList.Add(new ClientScriptItem(typeof(BaseWaterfallSerie), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.WaterfallSerie.js", "Resources/Chart/ux/Highcharts/WaterfallSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.WaterfallSerie";
            }
        }


    }
}