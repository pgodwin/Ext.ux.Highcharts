using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Ext.Net;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.Serie.js", "text/javascript")]
namespace Ext.ux.Highcharts
{
    /// <summary>
    /// Serie class is the base class for all the series types. Users shouldn't use any of the series classes directly, 
    /// they are created internally from Chart.ux.Highcharts depending on the series configuration.
    /// Serie class is a general class for series data representation.
    /// </summary>
    [Designer(typeof(EmptyDesigner))]
    [DefaultProperty("")]
    [ToolboxData("<{0}:Serie runat=\"server\"></{0}:Serie>")]
    [Description("Serie")]

    public partial class Serie : SerieBase
    {

        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(HighChart), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.Serie.js", "Resources/Chart/ux/Highcharts/Serie.js"));

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

    public partial class HighChartSeriesCollection : ItemsCollection<Serie>
    {
        
    }

    
}
