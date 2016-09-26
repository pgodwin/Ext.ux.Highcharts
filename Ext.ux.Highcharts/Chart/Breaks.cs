
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
        /// An array defining breaks in the axis, the sections defined will be left out and all the points shifted closer to each other. Requires that the broken-axis.js module is loaded.
        /// </summary>
        public partial class Breaks : Observable
        {

    
            /// <summary>
            /// A number indicating how much space should be left between the start and the end of the break. The break size is given in axis units, so for instance on a datetime axis, a break size of 3600000 would indicate the equivalent of an hour.
            /// </summary>
            [ConfigOption("breakSize", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A number indicating how much space should be left between the start and the end of the break. The break size is given in axis units, so for instance on a datetime axis, a break size of 3600000 would indicate the equivalent of an hour.")]
            public double? BreakSize
            {
                get
                {
                    return this.State.Get<double?>("BreakSize", 0);
                }
                set
                {
                    this.State.Set("BreakSize", value);
                }
            }

            /// <summary>
            /// The point where the break starts.
            /// </summary>
            [ConfigOption("from", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The point where the break starts.")]
            public double? From
            {
                get
                {
                    return this.State.Get<double?>("From", null);
                }
                set
                {
                    this.State.Set("From", value);
                }
            }

            /// <summary>
            /// Defines an interval after which the break appears again. By default the breaks do not repeat.
            /// </summary>
            [ConfigOption("repeat", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Defines an interval after which the break appears again. By default the breaks do not repeat.")]
            public double? Repeat
            {
                get
                {
                    return this.State.Get<double?>("Repeat", 0);
                }
                set
                {
                    this.State.Set("Repeat", value);
                }
            }

            /// <summary>
            /// The point where the break ends.
            /// </summary>
            [ConfigOption("to", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The point where the break ends.")]
            public double? To
            {
                get
                {
                    return this.State.Get<double?>("To", null);
                }
                set
                {
                    this.State.Set("To", value);
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


                list.Add("breakSize", new ConfigOption("breakSize", null, 0, this.BreakSize));

                list.Add("from", new ConfigOption("from", null, null, this.From));

                list.Add("repeat", new ConfigOption("repeat", null, 0, this.Repeat));

                list.Add("to", new ConfigOption("to", null, null, this.To));

                return list;
            }
        }


    
	        private BreaksEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public BreaksEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new BreaksEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class BreaksEvents : ComponentListeners
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
            