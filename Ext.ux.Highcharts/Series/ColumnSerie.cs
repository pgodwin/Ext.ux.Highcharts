using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using Ext.Net;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.ColumnSerie.js", "text/javascript")]
namespace Ext.ux.Highcharts.Series
{
    /// <summary>
    /// Serie class is the base class for all the series types. Users shouldn't use any of the series classes directly, 
    /// they are created internally from Chart.ux.Highcharts depending on the series configuration.
    /// Serie class is a general class for series data representation.
    /// </summary>
    [Designer(typeof(EmptyDesigner))]
    [DefaultProperty("")]
    [ToolboxData("<{0}:ColumnSerie runat=\"server\"></{0}:ColumnSerie>")]
    [Description("Column Serie")]
    public partial class ColumnSerie : ColumnSerieBase
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(HighChart), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.ColumnSerie.js", "Resources/Chart/ux/Highcharts/ColumnSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.ColumnSerie";
            }
        }
    }
}
