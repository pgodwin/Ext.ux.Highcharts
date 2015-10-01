using System.ComponentModel;
using Ext.Net;

namespace Ext.ux.Highcharts.Series
{
    public abstract partial class ColumnSerieBase : Serie
    {
        [ConfigOption]
        [DefaultValue("column")]
        [NotifyParentProperty(true)]
        [Description("Highcharts series type name. This field must be specified. Line, area, scatter and column series are the simplest form of charts (includes Polar) which has the simple data mappings: dataIndex or yField for y-axis values and xField for either x-axis category field or data point's x-axis coordinate.")]
        public override string Type
        {
            get { return "column"; }
            set
            {
                this.ViewState["Type"] = value;
            }
        }

    }
}
