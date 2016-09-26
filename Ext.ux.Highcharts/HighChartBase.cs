using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Serialization;
using Ext.Net;
using Ext.Net.Utilities;
using Ext.ux.Highcharts.ChartSeries;
using Ext.ux.Highcharts.Config;
using Newtonsoft.Json;
using Component = Ext.Net.Component;

namespace Ext.ux.Highcharts
{
    [Meta]
    public abstract partial class HighChartBase : ComponentBase, IStore<Store>, INoneContentable
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

        [ConfigOption("series", typeof(ItemCollectionJsonConverter))]
        [Category("HighChart")]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Meta]
        public HighChartSeriesCollection Series
        {
            get
            {
                if (this.series == null)
                {
                    this.series = new HighChartSeriesCollection();
                    this.series.AfterItemAdd += this.series_AfterItemAdd;
                    this.series.AfterItemRemove += this.AfterItemRemove;
                    
                }
                return this.series;
            }
        }

        void series_AfterItemAdd(BaseSerie component)
        {
            component.RegisterResources();
            //ResourceManager.RegisterControlResources<Serie>();
            this.AfterItemAdd(component);

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


        ChartConfig chartConfig;


        [Meta]
        [Category("HighCharts")]
        [ConfigOption("chartConfig", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Options regarding the chart area and plot area as well as general chart options.")]
        public virtual ChartConfig ChartConfig
        {
            get
            {
                return this.chartConfig;
            }
            set
            {
                if (this.chartConfig != null)
                {
                    this.Controls.Remove(this.chartConfig);
                    this.LazyItems.Remove(this.chartConfig);
                }

                this.chartConfig = value;

                if (this.chartConfig != null)
                {
                    this.LazyItems.Add(this.chartConfig);
                    this.Controls.Add(this.chartConfig);
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

                list.Add("storeId", new ConfigOption("storeId", new SerializationOptions("store", JsonMode.ToClientID), "", this.StoreID));
                list.Add("store", new ConfigOption("store", new SerializationOptions("store>Primary"), null, this.Store));

                list.Add("series", new ConfigOption("series", new SerializationOptions("series", typeof(ItemCollectionJsonConverter)), null, this.Series));
                list.Add("xField", new ConfigOption("xField", null, "", this.XField));
                list.Add("yField", new ConfigOption("yField", null, "", this.YField));
                list.Add("chartConfig", new ConfigOption("chartConfig", new SerializationOptions("chartConfig", typeof(LazyControlJsonConverter)), null, this.ChartConfig));

                return list;
            }
        }

        new public abstract partial class Builder<THighChartBase, TBuilder> :
            ComponentBase.Builder<THighChartBase, TBuilder>
            where THighChartBase : HighChartBase
            where TBuilder : Builder<THighChartBase, TBuilder>
        {
            public Builder(THighChartBase component) : base(component) { }

            public virtual TBuilder Series(Action<HighChartSeriesCollection> action)
            {
                action(this.ToComponent().Series);
                return this as TBuilder;
            }

			 

        }


    }
}
