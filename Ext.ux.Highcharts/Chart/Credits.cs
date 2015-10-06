
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
        /// Highchart by default puts a credits label in the lower right corner of the chart.		This can be changed using these options.
        /// </summary>
        public partial class Credits : Observable
        {

    
            /// <summary>
            /// Whether to show the credits text.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to show the credits text.")]
            public bool? Enabled
            {
                get
                {
                    return this.State.Get<bool?>("Enabled", true);
                }
                set
                {
                    this.State.Set("Enabled", value);
                }
            }

            /// <summary>
            /// The URL for the credits label.
            /// </summary>
            [ConfigOption("href", null)]
            [DefaultValue(@"http://www.highcharts.com")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The URL for the credits label.")]
            public string Href
            {
                get
                {
                    return this.State.Get<string>("Href", @"http://www.highcharts.com");
                }
                set
                {
                    this.State.Set("Href", value);
                }
            }

            /// <summary>
            /// Position configuration for the credits label. Supported properties are  align, verticalAlign, x and y. Defaults to position: {	align: 'right',	x: -10,	verticalAlign: 'bottom',	y: -5}
            /// </summary>
            [ConfigOption("position", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Position configuration for the credits label. Supported properties are  align, verticalAlign, x and y. Defaults to position: {	align: 'right',	x: -10,	verticalAlign: 'bottom',	y: -5}")]
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
            /// CSS styles for the credits label. Defaults to:style: {	cursor: 'pointer',	color: '#909090',	fontSize: '10px'}
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the credits label. Defaults to:style: {	cursor: 'pointer',	color: '#909090',	fontSize: '10px'}")]
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

            /// <summary>
            /// The text for the credits label.
            /// </summary>
            [ConfigOption("text", null)]
            [DefaultValue(@"Highcharts.com")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The text for the credits label.")]
            public string Text
            {
                get
                {
                    return this.State.Get<string>("Text", @"Highcharts.com");
                }
                set
                {
                    this.State.Set("Text", value);
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


                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("href", new ConfigOption("href", null, @"http://www.highcharts.com", this.Href));

                list.Add("position", new ConfigOption("position", null, null, this.Position));

                list.Add("style", new ConfigOption("style", null, "", this.Style));

                list.Add("text", new ConfigOption("text", null, @"Highcharts.com", this.Text));

                return list;
            }
        }


    
	        private CreditsEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public CreditsEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new CreditsEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class CreditsEvents : ComponentListeners
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
            