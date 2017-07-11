using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Ext.Net;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.RangeSerie.js", "text/javascript")]
namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    /// Serie class for general range series type
    /// 
    /// See {@link Chart.ux.Highcharts.Serie} class for more info
    /// 
    /// This is the base class for dealing range series type. RangeSerie offers
    /// sorted and unsorted ways of specifying range data. If it is desired to
    /// plot range data that are natively in sorted manner, the series can be specified as
    ///     series:[{
    ///         minDataIndex: 'low',
    ///         maxDataIndex: 'high',
    ///         type: 'columnrange'
    ///     }]
    /// As for plotting range series data that are naturally without high and low ends, do
    ///     series:[{
    ///         dataIndex: [ 'marketOpen', 'marketClose' ],
    ///         type: 'columnrange'
    ///     }]
    /// </summary>
    public partial class BaseRangeSerie : Ext.ux.Highcharts.ChartSeries.Series
    {
        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("Data field mapping to store record which has minimum value")]
        public virtual string MinDataIndex
        {
            get
            {
                return this.State.Get<string>("MinDataIndex", "");
            }
            set
            {
                this.State.Set("MinDataIndex", value);
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("Data field mapping to store record which has maximum value")]
        public virtual string MaxDataIndex
        {
            get
            {
                return this.State.Get<string>("MaxDataIndex", "");
            }
            set
            {
                this.State.Set("MaxDataIndex", value);
            }
        }

        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {

                ConfigOptionsCollection list = base.ConfigOptions;

                list.Add("minDataIndex", new ConfigOption("minDataIndex", null, "", this.MinDataIndex));
                list.Add("maxDataIndex", new ConfigOption("maxDataIndex", null, "", this.MaxDataIndex));

                return list;
            }

        }


        public object ViewState { get; set; }
    }
}
