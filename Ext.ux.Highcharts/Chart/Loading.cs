
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
        /// The loading options control the appearance of the loading screen that covers the 	plot area on chart operations. This screen only appears after an explicit call	to chart.showLoading(). It is a utility for developers to communicate	to the end user that something is going on, for example while retrieving new data	via an XHR connection. The "Loading..." text itself is not part of this configuration	object, but part of the lang object.
        /// </summary>
        public partial class Loading : Observable
        {

    
            /// <summary>
            /// The duration in milliseconds of the fade out effect.
            /// </summary>
            [ConfigOption]
            [DefaultValue(100)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The duration in milliseconds of the fade out effect.")]
            public double? HideDuration
            {
                get
                {
                    return this.State.Get<double?>("HideDuration", 100);
                }
                set
                {
                    this.State.Set("HideDuration", value);
                }
            }

            /// <summary>
            /// CSS styles for the loading label span.
            /// </summary>
            [ConfigOption]
            [DefaultValue(@"{ ""fontWeight"": ""bold"", ""position"": ""relative"", ""top"": ""45%"" }")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the loading label span.")]
            public string LabelStyle
            {
                get
                {
                    return this.State.Get<string>("LabelStyle", @"{ ""fontWeight"": ""bold"", ""position"": ""relative"", ""top"": ""45%"" }");
                }
                set
                {
                    this.State.Set("LabelStyle", value);
                }
            }

            /// <summary>
            /// The duration in milliseconds of the fade in effect.
            /// </summary>
            [ConfigOption]
            [DefaultValue(100)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The duration in milliseconds of the fade in effect.")]
            public double? ShowDuration
            {
                get
                {
                    return this.State.Get<double?>("ShowDuration", 100);
                }
                set
                {
                    this.State.Set("ShowDuration", value);
                }
            }

            /// <summary>
            /// CSS styles for the loading screen that covers the plot area. Defaults to:style: {	position: 'absolute',	backgroundColor: 'white',	opacity: 0.5,	textAlign: 'center'}
            /// </summary>
            [ConfigOption]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the loading screen that covers the plot area. Defaults to:style: {	position: 'absolute',	backgroundColor: 'white',	opacity: 0.5,	textAlign: 'center'}")]
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


                list.Add("hideDuration", new ConfigOption("hideDuration", null, 100, this.HideDuration));

                list.Add("labelStyle", new ConfigOption("labelStyle", null, @"{ ""fontWeight"": ""bold"", ""position"": ""relative"", ""top"": ""45%"" }", this.LabelStyle));

                list.Add("showDuration", new ConfigOption("showDuration", null, 100, this.ShowDuration));

                list.Add("style", new ConfigOption("style", null, "", this.Style));

                return list;
            }
        }


    

        }

        
}
            