using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ext.Net;

namespace Ext.ux.Highcharts
{
    public abstract partial class SerieBase : Observable
    {

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Description("This field is used for setting data point color number or color hex in '#([0-9])'. Otherwise, the option is treated as a field name and the store should return rows with the same color field name. For column type series, if you want Highcharts to automatically color each data point, then you should use plotOptions.column.colorByPoint option in the series config.")]
        public virtual string ColorField
        {
            get
            {
                object obj = this.ViewState["ColorField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["ColorField"] = value;
            }
        }


        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Description("can be either an alias of yField (which has higher precedence if both are defined) or mapping to store's field with array of data points")]
        public virtual string DataIndex
        {
            get
            {
                object obj = this.ViewState["DataIndex"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["DataIndex"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Description("Highcharts series type name. This field must be specified. Line, area, scatter and column series are the simplest form of charts (includes Polar) which has the simple data mappings: dataIndex or yField for y-axis values and xField for either x-axis category field or data point's x-axis coordinate.")]
        public virtual string Type
        {
            get
            {
                object obj = this.ViewState["Type"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["Type"] = value;
            }
        }


        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Description("Setting this option to true will enforce the chart to clear the series if there is no record returned for the series")]
        public virtual bool UpdateNoRecord
        {
            get
            {
                object obj = this.ViewState["UpdateNoRecord"];
                return obj != null ? (bool)obj : false;
            }
            set
            {
                this.ViewState["UpdateNoRecord"] = value;
            }
        }


        [ConfigOption]
        [DefaultValue(true)]
        [NotifyParentProperty(true)]
        [Description("The field used to hide the serie initial. Defaults to true.")]
        public virtual bool Visible
        {
            get
            {
                object obj = this.ViewState["Visible"];
                return obj != null ? (bool)obj : true;
            }
            set
            {
                this.ViewState["Visible"] = value;
            }
        }


        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Description("The field used to access the x-axis value from the items from the data source. Store's record")]
        public virtual string XField
        {
            get
            {
                object obj = this.ViewState["XField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["XField"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Description("The field used to access the y-axis value from the items from the data source. Store's record")]
        public virtual string YField
        {
            get
            {
                object obj = this.ViewState["YField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["YField"] = value;
            }
        }
     
     
    }
    
}
