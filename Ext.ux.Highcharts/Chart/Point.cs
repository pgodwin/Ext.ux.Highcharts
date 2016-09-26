
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using Ext.Net;
using Ext.Net.Utilities;

using Newtonsoft.Json;
using Ext.ux.Highcharts.Chart;

namespace Ext.ux.Highcharts.Chart
{
        


        /// <summary>
        /// Properties for each single point
        /// </summary>
        public partial class Point : Observable
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

list.Add("events", new ConfigOption("events", new SerializationOptions("events", JsonMode.Object), null, this.Listeners));
                return list;
            }
        }


    
	        private PointEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public PointEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new PointEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class PointEvents : ComponentListeners
        {


        private JFunction click;

        /// <summary>
        /// Fires when a point is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state. Returning false cancels this action.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("click", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when a point is clicked. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts. If the series.allowPointSelect option is true, the default action for the point's click event is to toggle the point's select state. Returning false cancels this action.")]
        public virtual JFunction Click
        {
            get
            {
                return this.click ?? (this.click = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction mouseOut;

        /// <summary>
        /// Fires when the mouse leaves the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseOut", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the mouse leaves the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
        public virtual JFunction MouseOut
        {
            get
            {
                return this.mouseOut ?? (this.mouseOut = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction mouseOver;

        /// <summary>
        /// Fires when the mouse enters the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("mouseOver", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the mouse enters the area close to the point. One parameter, event, is passed to the function. This contains common event information based on jQuery or MooTools depending on  which library is used as the base for Highcharts.")]
        public virtual JFunction MouseOver
        {
            get
            {
                return this.mouseOver ?? (this.mouseOver = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction remove;

        /// <summary>
        /// Fires when the point is removed using the .remove() method. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("remove", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is removed using the .remove() method. One parameter, event, is passed to the function. Returning false cancels the operation.")]
        public virtual JFunction Remove
        {
            get
            {
                return this.remove ?? (this.remove = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction select;

        /// <summary>
        /// Fires when the point is selected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("select", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is selected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.")]
        public virtual JFunction Select
        {
            get
            {
                return this.select ?? (this.select = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction unselect;

        /// <summary>
        /// Fires when the point is unselected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("unselect", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is unselected either programmatically or following a click on the point. One parameter, event, is passed to the function. Returning false cancels the operation.")]
        public virtual JFunction Unselect
        {
            get
            {
                return this.unselect ?? (this.unselect = new JFunction(){
                    Args = new string[] {"event"}
                });
            }
        }

        private JFunction update;

        /// <summary>
        /// Fires when the point is updated programmatically through the .update() method. One parameter, event, is passed to the function. The  new point options can be accessed through event.options. Returning false cancels the operation.
        /// </summary>
        [ListenerArgument(0, "event")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        [ConfigOption("update", typeof(JFunctionJsonConverter))]
        [PersistenceMode(PersistenceMode.InnerProperty)]
        [NotifyParentProperty(true)]
        [Description(@"Fires when the point is updated programmatically through the .update() method. One parameter, event, is passed to the function. The  new point options can be accessed through event.options. Returning false cancels the operation.")]
        public virtual JFunction Update
        {
            get
            {
                return this.update ?? (this.update = new JFunction(){
                    Args = new string[] {"event"}
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
                    list.Add("click", new ConfigOption("click", new SerializationOptions("click", typeof(JFunctionJsonConverter)), null, this.Click));list.Add("mouseOut", new ConfigOption("mouseOut", new SerializationOptions("mouseOut", typeof(JFunctionJsonConverter)), null, this.MouseOut));list.Add("mouseOver", new ConfigOption("mouseOver", new SerializationOptions("mouseOver", typeof(JFunctionJsonConverter)), null, this.MouseOver));list.Add("remove", new ConfigOption("remove", new SerializationOptions("remove", typeof(JFunctionJsonConverter)), null, this.Remove));list.Add("select", new ConfigOption("select", new SerializationOptions("select", typeof(JFunctionJsonConverter)), null, this.Select));list.Add("unselect", new ConfigOption("unselect", new SerializationOptions("unselect", typeof(JFunctionJsonConverter)), null, this.Unselect));list.Add("update", new ConfigOption("update", new SerializationOptions("update", typeof(JFunctionJsonConverter)), null, this.Update));
                    return list;
                }
            }

        }


        }

        
}
            