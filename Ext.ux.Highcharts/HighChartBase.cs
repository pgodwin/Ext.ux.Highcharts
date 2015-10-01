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
using Component = Ext.Net.Component;

namespace Ext.ux.Highcharts
{
    public abstract partial class HighChartBase : Component
    {

        private HighChartSeriesCollection series;

        [ConfigOption("series", JsonMode.AlwaysArray)]
        [Category("Config Options")]
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
                
                return list;
            }
        }
    }
}
