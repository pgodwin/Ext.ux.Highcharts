
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
        /// Options for drill down, the concept of inspecting increasingly high resolution data through clicking on chart items like columns or pie slices.The drilldown feature requires the drilldown.js file to be loaded, found in the modules directory of the download package, or online at code.highcharts.com/modules/drilldown.js.
        /// </summary>
        public partial class Drilldown : Observable
        {

    
            /// <summary>
            /// Additional styles to apply to the X axis label for a point that has drilldown data. By default it is underlined and blue to invite to interaction. Defaults to:activeAxisLabelStyle: {	cursor: 'pointer',	color: '#0d233a',	fontWeight: 'bold',	textDecoration: 'underline'			}
            /// </summary>
            [ConfigOption("activeAxisLabelStyle", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Additional styles to apply to the X axis label for a point that has drilldown data. By default it is underlined and blue to invite to interaction. Defaults to:activeAxisLabelStyle: {	cursor: 'pointer',	color: '#0d233a',	fontWeight: 'bold',	textDecoration: 'underline'			}")]
            public string ActiveAxisLabelStyle
            {
                get
                {
                    return this.State.Get<string>("ActiveAxisLabelStyle", "");
                }
                set
                {
                    this.State.Set("ActiveAxisLabelStyle", value);
                }
            }

            /// <summary>
            /// Additional styles to apply to the data label of a point that has drilldown data. By default it is underlined and blue to invite to interaction. Defaults to:activeAxisLabelStyle: {	cursor: 'pointer',	color: '#0d233a',	fontWeight: 'bold',	textDecoration: 'underline'			}
            /// </summary>
            [ConfigOption("activeDataLabelStyle", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Additional styles to apply to the data label of a point that has drilldown data. By default it is underlined and blue to invite to interaction. Defaults to:activeAxisLabelStyle: {	cursor: 'pointer',	color: '#0d233a',	fontWeight: 'bold',	textDecoration: 'underline'			}")]
            public string ActiveDataLabelStyle
            {
                get
                {
                    return this.State.Get<string>("ActiveDataLabelStyle", "");
                }
                set
                {
                    this.State.Set("ActiveDataLabelStyle", value);
                }
            }

            /// <summary>
            /// When this option is false, clicking a single point will drill down all points in the same category, equivalent to clicking the X axis label.
            /// </summary>
            [ConfigOption("allowPointDrilldown", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When this option is false, clicking a single point will drill down all points in the same category, equivalent to clicking the X axis label.")]
            public bool? AllowPointDrilldown
            {
                get
                {
                    return this.State.Get<bool?>("AllowPointDrilldown", true);
                }
                set
                {
                    this.State.Set("AllowPointDrilldown", value);
                }
            }

            /// <summary>
            /// Set the animation for all drilldown animations. Animation of a drilldown occurs when drilling between a column point and a column series, or a pie slice and a full pie series. Drilldown can still be used between series and points of different types, but animation will not occur.  The animation can either be set as a boolean or a configuration object. If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:   	duration 	The duration of the animation in milliseconds. 	 	easing 	When using jQuery as the general framework, the easing can be set to linear or 	swing. More easing functions are available with the use of jQuery plug-ins, most notably 	the jQuery UI suite. See the jQuery docs. When using  	MooTools as the general framework, use the property name transition instead  	of easing. 
            /// </summary>
            [ConfigOption("animation", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Set the animation for all drilldown animations. Animation of a drilldown occurs when drilling between a column point and a column series, or a pie slice and a full pie series. Drilldown can still be used between series and points of different types, but animation will not occur.  The animation can either be set as a boolean or a configuration object. If true, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:   	duration 	The duration of the animation in milliseconds. 	 	easing 	When using jQuery as the general framework, the easing can be set to linear or 	swing. More easing functions are available with the use of jQuery plug-ins, most notably 	the jQuery UI suite. See the jQuery docs. When using  	MooTools as the general framework, use the property name transition instead  	of easing. ")]
            public object Animation
            {
                get
                {
                    return this.State.Get<object>("Animation", null);
                }
                set
                {
                    this.State.Set("Animation", value);
                }
            }

            /// <summary>
            /// An array of series configurations for the drill down. Each series configuration uses the same syntax as the series option set. These drilldown series are hidden by default. The drilldown series is linked to the parent series' point by its id.
            /// </summary>
            [ConfigOption("series", JsonMode.AlwaysArray)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An array of series configurations for the drill down. Each series configuration uses the same syntax as the series option set. These drilldown series are hidden by default. The drilldown series is linked to the parent series' point by its id.")]
            public object[] Series
            {
                get
                {
                    return this.State.Get<object[]>("Series", null);
                }
                set
                {
                    this.State.Set("Series", value);
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


                list.Add("activeAxisLabelStyle", new ConfigOption("activeAxisLabelStyle", null, "", this.ActiveAxisLabelStyle));

                list.Add("activeDataLabelStyle", new ConfigOption("activeDataLabelStyle", null, "", this.ActiveDataLabelStyle));

                list.Add("allowPointDrilldown", new ConfigOption("allowPointDrilldown", null, true, this.AllowPointDrilldown));

                list.Add("animation", new ConfigOption("animation", null, null, this.Animation));

                list.Add("series", new ConfigOption("series", new SerializationOptions("series", JsonMode.AlwaysArray), null, this.Series));

                return list;
            }
        }


    
	        private DrilldownEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public DrilldownEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new DrilldownEvents();
					}
			
					return this.events;
				}
			}


    

        /// <summary>
        /// Options for the drill up button that appears when drilling down on a series. The text for the button is defined in lang.drillUpText.
        /// </summary>
        public partial class DrillUpButton : Observable
        {

    
            /// <summary>
            /// Positioning options for the button within the relativeTo box. Available properties are x, y, align and verticalAlign.
            /// </summary>
            [ConfigOption("position", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Positioning options for the button within the relativeTo box. Available properties are x, y, align and verticalAlign.")]
            public object Position
            {
                get
                {
                    return this.State.Get<object>("Position", null);
                }
                set
                {
                    this.State.Set("Position", value);
                }
            }

            /// <summary>
            /// What box to align the button to. Can be either ""plotBox"" or ""spacingBox"".
            /// </summary>
            [ConfigOption("relativeTo", null)]
            [DefaultValue(@"plotBox")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"What box to align the button to. Can be either ""plotBox"" or ""spacingBox"".")]
            public string RelativeTo
            {
                get
                {
                    return this.State.Get<string>("RelativeTo", @"plotBox");
                }
                set
                {
                    this.State.Set("RelativeTo", value);
                }
            }

            /// <summary>
            /// A collection of attributes for the button. The object takes SVG attributes like  fill, stroke, stroke-width or r, the border radius. The theme also supports style, a collection of CSS properties for the text. Equivalent attributes for the hover state are given in theme.states.hover.
            /// </summary>
            [ConfigOption("theme", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A collection of attributes for the button. The object takes SVG attributes like  fill, stroke, stroke-width or r, the border radius. The theme also supports style, a collection of CSS properties for the text. Equivalent attributes for the hover state are given in theme.states.hover.")]
            public object Theme
            {
                get
                {
                    return this.State.Get<object>("Theme", null);
                }
                set
                {
                    this.State.Set("Theme", value);
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


                list.Add("position", new ConfigOption("position", null, null, this.Position));

                list.Add("relativeTo", new ConfigOption("relativeTo", null, @"plotBox", this.RelativeTo));

                list.Add("theme", new ConfigOption("theme", null, null, this.Theme));

                return list;
            }
        }


    
	        private DrillUpButtonEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public DrillUpButtonEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new DrillUpButtonEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class DrillUpButtonEvents : ComponentListeners
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


    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class DrilldownEvents : ComponentListeners
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
            