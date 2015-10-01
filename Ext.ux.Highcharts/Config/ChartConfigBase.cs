using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Serialization;
using Ext.Net;
using Newtonsoft.Json;

namespace Ext.ux.Highcharts
{
    public abstract class ChartConfigBase : Observable
    {


        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("chart", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Options regarding the chart area and plot area as well as general chart options.")]
        public virtual Chart.Chart Chart
        {
            get
            {
                return this.State.Get<Chart.Chart>("Chart", null);
            }
            set
            {
                this.State.Set("Chart", value);
            }
        }


        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("colors", JsonMode.AlwaysArray)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again.")]
        public virtual string[] Colors
        {
            get
            {
                return this.State.Get<string[]>("Colors", null);
            }
            set
            {
                this.State.Set("Colors", value);
            }
        }

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("title", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("An array containing the default colors for the chart's series. When all colors are used, new colors are pulled from the start again.")]
        public virtual Chart.Title Title
        {
            get
            {
                return this.State.Get<Chart.Title>("Title", null);
            }
            set
            {
                this.State.Set("Title", value);
            }
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [XmlIgnore]
        [JsonIgnore]
        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;

                list.Add("chart", new ConfigOption("chart", new SerializationOptions("chart", typeof(LazyControlJsonConverter)), null, this.Chart));
                list.Add("colors", new ConfigOption("colors", new SerializationOptions("colors", JsonMode.AlwaysArray), null, this.Chart));
                list.Add("title", new ConfigOption("title", new SerializationOptions("title", typeof(LazyControlJsonConverter)), null, this.Title));

                return list;
            }
        }

    }
}
