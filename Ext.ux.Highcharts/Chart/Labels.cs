
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
using Newtonsoft.Json;

namespace Ext.ux.Highcharts.Chart
{
        


        /// <summary>
        /// HTML labels that can be positioned anywhere in the chart area.
        /// </summary>
        public partial class Labels : Observable
        {

    
            /// <summary>
            /// Shared CSS styles for all labels. Defaults to:style: {	color: '#3E576F'}
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Shared CSS styles for all labels. Defaults to:style: {	color: '#3E576F'}")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", "");
                }
                set
                {
                    this.State.Set("Style", value);
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


                list.Add("style", new ConfigOption("style", null, "", this.Style));

                return list;
            }
        }


    

        /// <summary>
        /// A HTML label that can be positioned anywhere in the chart area.
        /// </summary>
        public partial class Items : Observable
        {

    

    
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


                return list;
            }
        }


    

        }


        }

        
}
            