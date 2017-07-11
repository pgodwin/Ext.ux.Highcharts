using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Ext.Net;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.AreaSerie.js", "text/javascript")]
namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    ///  Serie class for area line series type
    /// 
    ///  See {@link Chart.ux.Highcharts.Serie} class for more info
    /// </summary>
    public partial class BaseAreaSerie : Series
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(Series), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.AreaSerie.js", "Resources/Chart/ux/Highcharts/AreaRangeSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.AreaSerie";
            }
        }


    }
}