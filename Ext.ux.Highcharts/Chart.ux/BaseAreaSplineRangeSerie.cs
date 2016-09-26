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
    /// Serie class for area spline range series type
    /// 
    ///  See {@link Chart.ux.Highcharts.RangeSerie} class for more info
    /// 
    /// </summary>
    [assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.AreaSplineRangeSerie.js", "text/javascript")]

    public partial class BaseAreaSplineRangeSerie : BaseRangeSerie
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(Series), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.AreaRangeSerie.js", "Resources/Chart/ux/Highcharts/AreaSplineRangeSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.AreaSplineRangeSerie";
            }
        }


    }
}
