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

namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    /// Base Client-Side Event object 
    /// </summary>
    public class BaseSerieEvents : ComponentListeners
    {

        private JFunction pointclick;

        /// <summary>
        /// Fires when the point of the serie is clicked.
        /// </summary>
        [ListenerArgument(0, "serie")]
        [ListenerArgument(1, "point")]
        [ListenerArgument(2, "record")]
        [ListenerArgument(3, "evt")]
        [ListenerArgument(3, "eOpts")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("pointclick", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point of the serie is clicked.")]
        public virtual JFunction PointClick
        {
            get
            {
                return this.pointclick ?? (this.pointclick = new JFunction()
                {
                    Args = new string[]
                    {
                        "serie", "point", "record", "evt", "eOps"
                    }
                });
            }
        }


        /// <summary>
        /// 
        /// </summary>
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
                list.Add("pointclick", new ConfigOption("pointclick", new SerializationOptions("pointclick", typeof(JFunctionJsonConverter)), null, this.PointClick));
                return list;
            }
        }
    }
}
