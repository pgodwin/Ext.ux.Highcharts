using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml.Serialization;
using Ext.Net;
using Ext.ux.Highcharts.Config;
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


        private Chart.Data _data;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("data", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The Data module provides a simplified interface for adding data to a chart from sources like CVS, HTML tables or grid views")]
        public virtual Chart.Data Data
        {
            get
            {
                return this._data;
            }
            set
            {
                if (this._data  != null)
                {
                    this.Controls.Remove(this._data);
                    this.LazyItems.Remove(this._data);
                }

                this._data = value;

                if (this._data != null)
                {
                    this.LazyItems.Add(this._data);
                    this.Controls.Add(this._data);
                }
            }
        }

        private Chart.Drilldown _drilldown;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("drilldown", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Options for drill down, the concept of inspecting increasingly high resolution data through clicking on chart items like columns or pie slices.")]
        public virtual Chart.Drilldown Drilldown
        {
            get
            {
                return this._drilldown;
            }
            set
            {
                if (this._drilldown != null)
                {
                    this.Controls.Remove(this._drilldown);
                    this.LazyItems.Remove(this._drilldown);
                }

                this._drilldown = value;

                if (this._drilldown != null)
                {
                    this.LazyItems.Add(this._drilldown);
                    this.Controls.Add(this._drilldown);
                }
            }
        }



        private Chart.Exporting _exporting;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("exporting", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Options for the exporting module")]
        public virtual Chart.Exporting Exporting
        {
            get
            {
                return this._exporting;
            }
            set
            {
                if (this._exporting != null)
                {
                    this.Controls.Remove(this._exporting);
                    this.LazyItems.Remove(this._exporting);
                }

                this._exporting = value;

                if (this._exporting != null)
                {
                    this.LazyItems.Add(this._exporting);
                    this.Controls.Add(this._exporting);
                }
            }
        }

        private Chart.Labels _labels;

        // TODO: Fix labels as the imported type is wrong!
        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("labels", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("HTML labels that can be positioned anywhere in the chart area.")]
        public virtual Chart.Labels Labels
        {
            get
            {
                return this._labels;
            }
            set
            {
                if (this._labels != null)
                {
                    this.Controls.Remove(this._labels);
                    this.LazyItems.Remove(this._labels);
                }

                this._labels = value;

                if (this._labels != null)
                {
                    this.LazyItems.Add(this._labels);
                    this.Controls.Add(this._labels);
                }
            }
        }

        private Chart.Legend _legend;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("legend", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The legend is a box containing a symbol and name for each series item or point item in the chart. Each series (or points in case of pie charts) is represented by a symbol and its name in the legend. It is also possible to override the symbol creator function and create custom legend symbols")]
        public virtual Chart.Legend Legend
        {
            get
            {
                return this._legend;
            }
            set
            {
                if (this._legend != null)
                {
                    this.Controls.Remove(this._legend);
                    this.LazyItems.Remove(this._legend);
                }

                this._legend = value;

                if (this._legend != null)
                {
                    this.LazyItems.Add(this._legend);
                    this.Controls.Add(this._legend);
                }
            }
        }

        private Chart.Loading _loading;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("loading", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The loading options control the appearance of the loading screen that covers the plot area on chart operations. This screen only appears after an explicit call to chart.showLoading(). It is a utility for developers to communicate to the end user that something is going on, for example while retrieving new data via an XHR connection. The \"Loading...\" text itself is not part of this configuration object, but part of the lang object.")]
        public virtual Chart.Loading Loading
        {
            get
            {
                return this._loading;
            }
            set
            {
                if (this._loading != null)
                {
                    this.Controls.Remove(this._loading);
                    this.LazyItems.Remove(this._loading);
                }

                this._loading = value;

                if (this._loading != null)
                {
                    this.LazyItems.Add(this._loading);
                    this.Controls.Add(this._loading);
                }
            }
        }

        private Chart.Navigation _navigation;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("navigation", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("A collection of options for buttons and menus appearing in the exporting module.")]
        public virtual Chart.Navigation Navigation
        {
            get
            {
                return this._navigation;
            }
            set
            {
                if (this._navigation != null)
                {
                    this.Controls.Remove(this._navigation);
                    this.LazyItems.Remove(this._navigation);
                }

                this._navigation = value;

                if (this._navigation != null)
                {
                    this.LazyItems.Add(this._navigation);
                    this.Controls.Add(this._navigation);
                }
            }
        }
        private Chart.NoData _NoData;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("noData", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Options for displaying a message like \"No data to display\". This feature requires the file no-data-to-display.js to be loaded in the page. The actual text to display is set in the lang.noData option.")]
        public virtual Chart.NoData NoData
        {
            get
            {
                return this._NoData;
            }
            set
            {
                if (this._NoData != null)
                {
                    this.Controls.Remove(this._NoData);
                    this.LazyItems.Remove(this._NoData);
                }

                this._NoData = value;

                if (this._NoData != null)
                {
                    this.LazyItems.Add(this._NoData);
                    this.Controls.Add(this._NoData);
                }
            }
        }


        private Chart.Pane _Pane;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("pane", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("Applies only to polar charts and angular gauges. This configuration object holds general options for the combined X and Y axes set. Each xAxis or yAxis can reference the pane by index.")]
        public virtual Chart.Pane Pane
        {
            get
            {
                return this._Pane;
            }
            set
            {
                if (this._Pane != null)
                {
                    this.Controls.Remove(this._Pane);
                    this.LazyItems.Remove(this._Pane);
                }

                this._Pane = value;

                if (this._Pane != null)
                {
                    this.LazyItems.Add(this._Pane);
                    this.Controls.Add(this._Pane);
                }
            }
        }

        private Chart.PlotOptions _PlotOptions;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("plotOptions", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The plotOptions is a wrapper object for config objects for each series type. The config objects for each series can also be overridden for each series item as given in the series array.")]
        public virtual Chart.PlotOptions PlotOptions
        {
            get
            {
                return this._PlotOptions;
            }
            set
            {
                if (this._PlotOptions != null)
                {
                    this.Controls.Remove(this._PlotOptions);
                    this.LazyItems.Remove(this._PlotOptions);
                }

                this._PlotOptions = value;

                if (this._PlotOptions != null)
                {
                    this.LazyItems.Add(this._PlotOptions);
                    this.Controls.Add(this._PlotOptions);
                }
            }
        }

        private Chart.Subtitle _Subtitle;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("subtitle", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The chart's subtitle")]
        public virtual Chart.Subtitle Subtitle
        {
            get
            {
                return this._Subtitle;
            }
            set
            {
                if (this._Subtitle != null)
                {
                    this.Controls.Remove(this._Subtitle);
                    this.LazyItems.Remove(this._Subtitle);
                }

                this._Subtitle = value;

                if (this._Subtitle != null)
                {
                    this.LazyItems.Add(this._Subtitle);
                    this.Controls.Add(this._Subtitle);
                }
            }
        }

        private Chart.Tooltip _Tooltip;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("tooltip", typeof(LazyControlJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The Tooltip module provides a simplified interface for adding Tooltip to a chart from sources like CVS, HTML tables or grid views")]
        public virtual Chart.Tooltip Tooltip
        {
            get
            {
                return this._Tooltip;
            }
            set
            {
                if (this._Tooltip != null)
                {
                    this.Controls.Remove(this._Tooltip);
                    this.LazyItems.Remove(this._Tooltip);
                }

                this._Tooltip = value;

                if (this._Tooltip != null)
                {
                    this.LazyItems.Add(this._Tooltip);
                    this.Controls.Add(this._Tooltip);
                }
            }
        }

        private XAxisCollection _XAxis;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("xAxis", typeof(ItemCollectionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The X axis or category axis. Normally this is the horizontal axis, though if the chart is inverted this is the vertical axis. In case of multiple axes, the xAxis node is an array of configuration objects.")]
        public virtual XAxisCollection XAxis
        {
            get
            {
                if (this._XAxis == null)
                {
                    this._XAxis = new XAxisCollection();
                    this._XAxis.AfterItemAdd += this.AfterItemAdd;
                    this._XAxis.AfterItemRemove += this.AfterItemRemove;

                }
                return this._XAxis;
            }
        }

        private YAxisCollection _YAxis;

        [Meta]
        [DefaultValue(null)]
        [Category("HighCharts")]
        [ConfigOption("yAxis", typeof(ItemCollectionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [Description("The Y axis or value axis. Normally this is the vertical axis, though if the chart is inverted this is the horizontal axis. In case of multiple axes, the yAxis node is an array of configuration objects.")]
        public virtual YAxisCollection YAxis
        {
            get
            {
                if (this._YAxis == null)
                {
                    this._YAxis = new YAxisCollection();
                    this._YAxis.AfterItemAdd += this.AfterItemAdd;
                    this._YAxis.AfterItemRemove += this.AfterItemRemove;

                }
                return this._YAxis;
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
                list.Add("data", new ConfigOption("data", new SerializationOptions("data", typeof(LazyControlJsonConverter)), null, this.Data));
                list.Add("colors", new ConfigOption("colors", new SerializationOptions("colors", JsonMode.AlwaysArray), null, this.Chart));
                list.Add("title", new ConfigOption("title", new SerializationOptions("title", typeof(LazyControlJsonConverter)), null, this.Title));
                list.Add("drilldown", new ConfigOption("drilldown", new SerializationOptions("drilldown", typeof(LazyControlJsonConverter)), null, this.Drilldown));
                list.Add("exporting", new ConfigOption("exporting", new SerializationOptions("exporting", typeof(LazyControlJsonConverter)), null, this.Exporting));
                list.Add("labels", new ConfigOption("labels", new SerializationOptions("labels", typeof(LazyControlJsonConverter)), null, this.Labels));
                list.Add("legend", new ConfigOption("legend", new SerializationOptions("legend", typeof(LazyControlJsonConverter)), null, this.Legend));
                list.Add("loading", new ConfigOption("loading", new SerializationOptions("loading", typeof(LazyControlJsonConverter)), null, this.Loading));
                list.Add("navigation", new ConfigOption("navigation", new SerializationOptions("navigation", typeof(LazyControlJsonConverter)), null, this.Navigation));
                list.Add("noData", new ConfigOption("noData", new SerializationOptions("noData", typeof(LazyControlJsonConverter)), null, this.NoData));
                list.Add("pane", new ConfigOption("pane", new SerializationOptions("pane", typeof(LazyControlJsonConverter)), null, this.Pane));
                list.Add("subtitle", new ConfigOption("subtitle", new SerializationOptions("subtitle", typeof(LazyControlJsonConverter)), null, this.Subtitle));
                list.Add("tooltip", new ConfigOption("tooltip", new SerializationOptions("tooltip", typeof(LazyControlJsonConverter)), null, this.Tooltip));
                list.Add("xAxis", new ConfigOption("xAxis", new SerializationOptions("xAxis", typeof(ItemCollectionJsonConverter)), null, this.XAxis));
                list.Add("yAxis", new ConfigOption("yAxis", new SerializationOptions("yAxis", typeof(ItemCollectionJsonConverter)), null, this.YAxis));

                return list;
            }
        }

    }
}
