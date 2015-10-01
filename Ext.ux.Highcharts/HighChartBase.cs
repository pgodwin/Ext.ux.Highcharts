using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Ext.Net;
using Component = Ext.Net.Component;

namespace Ext.ux.Highcharts
{
    public abstract partial class HighChartBase : Component
    {
        
        private SeriesCollection series;

        [ConfigOption("series", JsonMode.AlwaysArray)]
        [Category("Config Options")]
        [DefaultValue(null)]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        //[ViewStateMember]
        public virtual SeriesCollection Series
        {
            get
            {
                if (this.series == null)
                {
                    this.series = new SeriesCollection();
                    this.series.TrackViewState();
                }
                return this.series;
            }
        }
    }
}
