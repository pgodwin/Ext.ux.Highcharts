using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Ext.Net;

namespace Ext.ux.Highcharts.Chart
{
    /// <summary>
    /// Class to bring in the 3d Resource Files
    /// </summary>
    [assembly: WebResource("Ext.ux.Highcharts.Resources.Highcharts.highcharts-3d.js", "text/javascript")]
    
    public partial class Options3d
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(Options3d), "Ext.ux.Highcharts.Resources.Highcharts.highcharts-3d.js", "Resources/Highcharts/highcharts-3d.js"));

                return baseList;
            }
        }

    }
}
