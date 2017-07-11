using System.Collections.Generic;
using System.Web.UI;
using Ext.Net;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.GaugeSerie.js", "text/javascript")]
namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    ///  Heatmap is part of the Highcharts series (i.e. no store in it's own series definition) and is
    ///  packaged as a module. Therefore, users need to include the module in their HTML file.
    /// 
    ///      <script src="http://code.highcharts.com/maps/modules/heatmap.js"></script>
    /// 
    ///  To configure a heatmap series, 3 fields are mandatory: xField, yField and valueField.
    ///  The following is an example of a series configuration:
    /// 
    ///       xtype: 'highcharts',
    ///       chartConfig: {
    ///            ....
    ///       },
    ///       series: [{
    ///           type: 'heatmap',
    ///           xField: 'Date',
    ///           yField: 'Time',
    ///           dataIndex: 'Temperature',
    /// 
    ///           borderWidth: 0,
    ///           colsize: 24///  3600000, // one day
    ///           tooltip: {
    ///               headerFormat: 'Temperature<br/>',
    ///               pointFormat: '{point.x:%e %b, %Y} {point.y}:00: <b>{point.value} degrees</b>'
    ///           }
    ///       }]
    /// </summary>
    public partial class BaseGaugeSerie : Series
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(BaseGaugeSerie), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.GaugeSerie.js", "Resources/Chart/ux/Highcharts/GaugeSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.GaugeSerie";
            }
        }


    }
}