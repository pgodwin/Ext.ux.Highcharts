using System.Collections.Generic;
using System.Web.UI;
using Ext.Net;

namespace Ext.ux.Highcharts.ChartSeries
{
    [assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.MapPointSerie.js", "text/javascript")]
    public partial class BaseMapPointSerie : BaseMapSerie
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(BaseMapPointSerie), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.MapPointSerie.js", "Resources/Chart/ux/Highcharts/MapPointSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.MapPointSerie";
            }
        }


    }
}