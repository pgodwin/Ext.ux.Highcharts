using System.Collections.Generic;
using System.Web.UI;
using Ext.Net;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.LineSerie.js", "text/javascript")]
namespace Ext.ux.Highcharts.ChartSeries
{
    public partial class BaseLineSerie : Series
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(BaseLineSerie), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.LineSerie.js", "Resources/Chart/ux/Highcharts/LineSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.LineSerie";
            }
        }


    }
}