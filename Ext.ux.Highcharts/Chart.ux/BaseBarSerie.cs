using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Ext.Net;

namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    ///  Serie class for bar series type
    /// 
    ///  See {@link Chart.ux.Highcharts.Serie} class for more info
    /// </summary>
    [assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.BarSerie.js", "text/javascript")]
    public partial class BaseBarSerie : Series
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(global::Ext.ux.Highcharts.ChartSeries.Series), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.BarSerie.js", "Resources/Chart/ux/Highcharts/BarSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.BarSerie";
            }
        }


    }
}
