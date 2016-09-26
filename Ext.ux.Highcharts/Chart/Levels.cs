
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
        /// Set options on specific levels. Takes precedence over series options, but not point options.
        /// </summary>
        public partial class Levels : Observable
        {

    
            /// <summary>
            /// Can set borderColor on all points which lies on the same level.
            /// </summary>
            [ConfigOption("borderColor", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Can set borderColor on all points which lies on the same level.")]
            public string BorderColor
            {
                get
                {
                    return this.State.Get<string>("BorderColor", "");
                }
                set
                {
                    this.State.Set("BorderColor", value);
                }
            }

            /// <summary>
            /// Set the dash style of the border of all the point which lies on the level.See plotOptions.scatter.dashStyle for possible options.
            /// </summary>
            [ConfigOption("borderDashStyle", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Set the dash style of the border of all the point which lies on the level.See plotOptions.scatter.dashStyle for possible options.")]
            public string BorderDashStyle
            {
                get
                {
                    return this.State.Get<string>("BorderDashStyle", "");
                }
                set
                {
                    this.State.Set("BorderDashStyle", value);
                }
            }

            /// <summary>
            /// Can set the borderWidth on all points which lies on the same level.
            /// </summary>
            [ConfigOption("borderWidth", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Can set the borderWidth on all points which lies on the same level.")]
            public double? BorderWidth
            {
                get
                {
                    return this.State.Get<double?>("BorderWidth", null);
                }
                set
                {
                    this.State.Set("BorderWidth", value);
                }
            }

            /// <summary>
            /// Can set a color on all points which lies on the same level.
            /// </summary>
            [ConfigOption("color", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Can set a color on all points which lies on the same level.")]
            public string Color
            {
                get
                {
                    return this.State.Get<string>("Color", "");
                }
                set
                {
                    this.State.Set("Color", value);
                }
            }

            /// <summary>
            /// Can set the options of dataLabels on each point which lies on the level.plotOptions.treemap.dataLabels for possible values.
            /// </summary>
            [ConfigOption("dataLabels", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Can set the options of dataLabels on each point which lies on the level.plotOptions.treemap.dataLabels for possible values.")]
            public object DataLabels
            {
                get
                {
                    return this.State.Get<object>("DataLabels", null);
                }
                set
                {
                    this.State.Set("DataLabels", value);
                }
            }

            /// <summary>
            /// Can set the layoutAlgorithm option on a specific level. 
            /// </summary>
            [ConfigOption("layoutAlgorithm", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Can set the layoutAlgorithm option on a specific level. ")]
            public string LayoutAlgorithm
            {
                get
                {
                    return this.State.Get<string>("LayoutAlgorithm", "");
                }
                set
                {
                    this.State.Set("LayoutAlgorithm", value);
                }
            }

            /// <summary>
            /// Can set the layoutStartingDirection option on a specific level.
            /// </summary>
            [ConfigOption("layoutStartingDirection", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Can set the layoutStartingDirection option on a specific level.")]
            public string LayoutStartingDirection
            {
                get
                {
                    return this.State.Get<string>("LayoutStartingDirection", "");
                }
                set
                {
                    this.State.Set("LayoutStartingDirection", value);
                }
            }

            /// <summary>
            /// Decides which level takes effect from the options set in the levels object.
            /// </summary>
            [ConfigOption("level", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Decides which level takes effect from the options set in the levels object.")]
            public double? Level
            {
                get
                {
                    return this.State.Get<double?>("Level", null);
                }
                set
                {
                    this.State.Set("Level", value);
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


                list.Add("borderColor", new ConfigOption("borderColor", null, "", this.BorderColor));

                list.Add("borderDashStyle", new ConfigOption("borderDashStyle", null, "", this.BorderDashStyle));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, null, this.BorderWidth));

                list.Add("color", new ConfigOption("color", null, "", this.Color));

                list.Add("dataLabels", new ConfigOption("dataLabels", null, null, this.DataLabels));

                list.Add("layoutAlgorithm", new ConfigOption("layoutAlgorithm", null, "", this.LayoutAlgorithm));

                list.Add("layoutStartingDirection", new ConfigOption("layoutStartingDirection", null, "", this.LayoutStartingDirection));

                list.Add("level", new ConfigOption("level", null, null, this.Level));

                return list;
            }
        }


    
	        private LevelsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public LevelsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new LevelsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class LevelsEvents : ComponentListeners
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
            