using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using Ext.Net;

namespace Ext.ux.Highcharts.ChartSeries
{
    [assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.ScatterSerie.js", "text/javascript")]
    public partial class BaseScatterSerie : Series
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
                baseList.Add(new ClientScriptItem(typeof(BaseScatterSerie), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.ScatterSerie.js", "Resources/Chart/ux/Highcharts/ScatterSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.ScatterSerie";
            }
        }


    }
}