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

        private Chart.Chart _chart;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("chart", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Options regarding the chart area and plot area as well as general chart options.")]
        [NotifyParentProperty(true)]
        public virtual Chart.Chart Chart
        {
            get
            {
                return this._chart;
            }
            set
            {
                if (this._chart != null)
                {
                    this.Controls.Remove(this._chart);
                    this.LazyItems.Remove(this._chart);
                }

                this._chart = value;

                if (this._chart != null)
                {
                    this.LazyItems.Add(this._chart);
                    this.Controls.Add(this._chart);
                }
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

        private Chart.Title _title;

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
                return this._title;
            }
            set
            {
                if (this._title != null)
                {
                    this.Controls.Remove(this._title);
                    this.LazyItems.Remove(this._title);
                }

                this._title = value;

                if (this._title != null)
                {
                    this.LazyItems.Add(this._title);
                    this.Controls.Add(this._title);
                }
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
