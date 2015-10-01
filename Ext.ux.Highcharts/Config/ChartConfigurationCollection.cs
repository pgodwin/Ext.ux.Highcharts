using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ext.Net;

namespace Ext.ux.Highcharts.Config
{
    public class ChartConfigurationCollection<T> : SingleItemCollection<T> where T : ChartConfig
    {
        
		/// <summary>
		/// 
		/// </summary>
        [ConfigOption("chartConfig", typeof(LazyControlJsonConverter))]
		[Description("")]
        public T Config
        {
            get
            {
                if (this.Count > 0)
                {
                    return this[0];
                }

                return null;
            }
        }
    }
}
