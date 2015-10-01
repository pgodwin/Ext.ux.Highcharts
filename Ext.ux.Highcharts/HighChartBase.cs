using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Serialization;
using Ext.Net;
using Ext.Net.Utilities;
using Ext.ux.Highcharts.Config;
using Ext.ux.Highcharts.Series;
using Newtonsoft.Json;
using Component = Ext.Net.Component;

namespace Ext.ux.Highcharts
{
   
    public abstract partial class HighChartBase : Component, IStore<Store>
    {


      
        private StoreCollection<Store> store;

        /// <summary>
        /// The Ext.Net.Store the chart should use as its data source (required).
        /// </summary>
        [Meta]
        [ConfigOption("store>Primary", 1)]
        [Category("HighChart")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The Ext.Net.Store the grid should use as its data source (required).")]
        public virtual StoreCollection<Store> Store
        {
            get
            {
                if (this.store == null)
                {
                    this.store = new StoreCollection<Store>();
                    this.store.AfterItemAdd += this.AfterStoreAdd;
                    this.store.AfterItemRemove += this.AfterItemRemove;
                }

                return this.store;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        [Description("")]
        protected virtual void AfterStoreAdd(Store item)
        {
            this.LazyItems.Insert(0, item);
            this.Controls.AddAt(0, item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Store GetStore()
        {
            if (this.Store.Primary != null)
            {
                return this.Store.Primary;
            }

            if (this.StoreID.IsNotEmpty())
            {
                return ControlUtils.FindControl<Store>(this, this.StoreID, true);
            }

            return null;
        }

        /// <summary>
        /// The data store to use.
        /// </summary>
        [Meta]
        [ConfigOption("store", JsonMode.ToClientID)]
        [Category("HighChart")]
        [DefaultValue("")]
        [IDReferenceProperty(typeof(Store))]
        [Description("The data store to use.")]
        public virtual string StoreID
        {
            get
            {
                return this.State.Get<string>("StoreID", "");
            }
            set
            {
                this.State.Set("StoreID", value);
            }
        }



        private HighChartSeriesCollection series;

        [ConfigOption("series", JsonMode.AlwaysArray)]
        [Category("HighChart")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        //[ViewStateMember]
        public virtual HighChartSeriesCollection Series
        {
            get
            {
                if (this.series == null)
                {
                    this.series = new HighChartSeriesCollection();
                    //this.series.TrackViewState();
                }
                return this.series;
            }
        }


        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
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
        [Category("HighChart")]
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


        private ChartConfigurationCollection<ChartConfig> chartConfig;


        [Meta]
        [Category("HighCharts")]
        [ConfigOption("chartConfig>Config")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Options regarding the chart area and plot area as well as general chart options.")]
        public ChartConfigurationCollection<ChartConfig> ChartConfig
        {
            get
            {
                if (this.chartConfig == null)
                {
                    this.chartConfig = new ChartConfigurationCollection<ChartConfig>();
                    //this.chartConfig.AfterItemAdd += this.AfterItemAdd;
                    //this.chartConfig.AfterItemRemove += this.AfterItemRemove;
                }

                return this.chartConfig;
            }
        }

        /// <summary>
        /// Returns a the charts Configuration
        /// </summary>
        public ChartConfig GetView()
        {
            return this.ChartConfig.Config;
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

                list.Add("series", new ConfigOption("series", new SerializationOptions("series", JsonMode.AlwaysArray), null, this.Series));
                list.Add("store", new ConfigOption("store", new SerializationOptions("store>Primary", 1), null, this.Store));
                list.Add("xField", new ConfigOption("xField", null, "", this.XField));
                list.Add("yField", new ConfigOption("yField", null, "", this.XField));
                list.Add("chartConfig", new ConfigOption("chartConfig", new SerializationOptions("chartConfig", typeof(LazyControlJsonConverter)), "", this.ChartConfig));

                return list;
            }
        }

    }
}
