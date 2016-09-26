
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
using Ext.ux.Highcharts.Chart;

namespace Ext.ux.Highcharts.Chart
{
        


        /// <summary>
        /// Global options that don't apply to each chart. These options, like the lang		options, must be set using the Highcharts.setOptions method.Highcharts.setOptions({	global: {		useUTC: false	}});
        /// </summary>
        public partial class Global : Observable
        {

    
            /// <summary>
            /// A custom Date class for advanced date handling. For example, JDate can be hooked in to handle Jalali dates.
            /// </summary>
            [ConfigOption("Date", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A custom Date class for advanced date handling. For example, JDate can be hooked in to handle Jalali dates.")]
            public object Date
            {
                get
                {
                    return this.State.Get<object>("Date", null);
                }
                set
                {
                    this.State.Set("Date", value);
                }
            }

            /// <summary>
            /// Path to the pattern image required by VML browsers in order to draw radial gradients.
            /// </summary>
            [ConfigOption("VMLRadialGradientURL", null)]
            [DefaultValue(@"http://code.highcharts.com/{version}/gfx/vml-radial-gradient.png")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Path to the pattern image required by VML browsers in order to draw radial gradients.")]
            public string VMLRadialGradientURL
            {
                get
                {
                    return this.State.Get<string>("VMLRadialGradientURL", @"http://code.highcharts.com/{version}/gfx/vml-radial-gradient.png");
                }
                set
                {
                    this.State.Set("VMLRadialGradientURL", value);
                }
            }

            /// <summary>
            /// The URL to the additional file to lazy load for Android 2.x devices. These devices don't  support SVG, so we download a helper file that contains canvg, its dependency rbcolor, and our own CanVG Renderer class. To avoid hotlinking to our site, you can install canvas-tools.js on your own server and change this option accordingly.
            /// </summary>
            [ConfigOption("canvasToolsURL", null)]
            [DefaultValue(@"http://code.highcharts.com/{version}/modules/canvas-tools.js")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The URL to the additional file to lazy load for Android 2.x devices. These devices don't  support SVG, so we download a helper file that contains canvg, its dependency rbcolor, and our own CanVG Renderer class. To avoid hotlinking to our site, you can install canvas-tools.js on your own server and change this option accordingly.")]
            public string CanvasToolsURL
            {
                get
                {
                    return this.State.Get<string>("CanvasToolsURL", @"http://code.highcharts.com/{version}/modules/canvas-tools.js");
                }
                set
                {
                    this.State.Set("CanvasToolsURL", value);
                }
            }

            /// <summary>
            /// A callback to return the time zone offset for a given datetime. It takes the timestamp in terms of milliseconds since January 1 1970, and returns the timezone offset in minutes. This provides a hook for drawing time based charts in specific time zones using their local DST crossover dates, with the help of external libraries. 
            /// </summary>
            [ConfigOption("getTimezoneOffset", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A callback to return the time zone offset for a given datetime. It takes the timestamp in terms of milliseconds since January 1 1970, and returns the timezone offset in minutes. This provides a hook for drawing time based charts in specific time zones using their local DST crossover dates, with the help of external libraries. ")]
            public string GetTimezoneOffset
            {
                get
                {
                    return this.State.Get<string>("GetTimezoneOffset", "");
                }
                set
                {
                    this.State.Set("GetTimezoneOffset", value);
                }
            }

            /// <summary>
            /// The timezone offset in minutes. Positive values are west, negative values are east of UTC, as in the ECMAScript getTimezoneOffset method. Use this to display UTC based data in a predefined time zone. 
            /// </summary>
            [ConfigOption("timezoneOffset", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The timezone offset in minutes. Positive values are west, negative values are east of UTC, as in the ECMAScript getTimezoneOffset method. Use this to display UTC based data in a predefined time zone. ")]
            public double? TimezoneOffset
            {
                get
                {
                    return this.State.Get<double?>("TimezoneOffset", 0);
                }
                set
                {
                    this.State.Set("TimezoneOffset", value);
                }
            }

            /// <summary>
            /// Whether to use UTC time for axis scaling, tickmark placement and time display in  Highcharts.dateFormat. Advantages of using UTC is that the time displays equally regardless of the user agent's time zone settings. Local time can be used when the data is loaded in real time or when correct Daylight Saving Time transitions are required.
            /// </summary>
            [ConfigOption("useUTC", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to use UTC time for axis scaling, tickmark placement and time display in  Highcharts.dateFormat. Advantages of using UTC is that the time displays equally regardless of the user agent's time zone settings. Local time can be used when the data is loaded in real time or when correct Daylight Saving Time transitions are required.")]
            public bool? UseUTC
            {
                get
                {
                    return this.State.Get<bool?>("UseUTC", true);
                }
                set
                {
                    this.State.Set("UseUTC", value);
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


                list.Add("Date", new ConfigOption("Date", null, null, this.Date));

                list.Add("VMLRadialGradientURL", new ConfigOption("VMLRadialGradientURL", null, @"http://code.highcharts.com/{version}/gfx/vml-radial-gradient.png", this.VMLRadialGradientURL));

                list.Add("canvasToolsURL", new ConfigOption("canvasToolsURL", null, @"http://code.highcharts.com/{version}/modules/canvas-tools.js", this.CanvasToolsURL));

                list.Add("getTimezoneOffset", new ConfigOption("getTimezoneOffset", null, "", this.GetTimezoneOffset));

                list.Add("timezoneOffset", new ConfigOption("timezoneOffset", null, 0, this.TimezoneOffset));

                list.Add("useUTC", new ConfigOption("useUTC", null, true, this.UseUTC));

                return list;
            }
        }


    
	        private GlobalEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public GlobalEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new GlobalEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class GlobalEvents : ComponentListeners
        {




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
                    
                    return list;
                }
            }

        }


        }

        
}
            