using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using Ext.Net;

namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    ///  MapBubble Serie class is for plotting bubble data points on the map.
    ///  Expect z-axis value from the data store.
    /// </summary>
    [assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.MapBubbleSerie.js", "text/javascript")]
    public partial class BaseMapBubbleSerie : Series
    {
        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The field stores the radius value of a bubble data point")]
        public virtual string ZField
        {
            get
            {
                object obj = this.ViewState["ZField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["ZField"] = value;
            }
        }

        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                list.Add("zField", new ConfigOption("zField", null, "", this.ZField));
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
                baseList.Add(new ClientScriptItem(typeof(BaseMapBubbleSerie), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.MapBubbleSerie.js", "Resources/Chart/ux/Highcharts/MapBubbleSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.MapBubbleSerie";
            }
        }


    }
}