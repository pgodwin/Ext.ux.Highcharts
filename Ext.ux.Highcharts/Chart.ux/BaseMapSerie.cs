using System.Collections.Generic;
using System.ComponentModel;
using System.Web.UI;
using Ext.Net;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.MapSerie.js", "text/javascript")]
namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    ///  MapSerie class is the most basic map series class and it is the default
    ///  map series type. Other map classes are extended from MapSerie. 
    ///  All the native Highmaps series options can be specfied in the map series
    ///  which will be included when the map is rendered.
    /// 
    ///  The following is a more advance example with series data and mapData
    ///  from separate stores and also different index fields.
    /// 
    ///      series : [{
    /// 
    ///          // Following fields are to construct map series data
    ///          // field
    ///          dataNameField: 'name',
    ///          dataValueField: 'value',
    ///          store: Ext.StoreMgr.get('PopDensity1'),
    /// 
    ///          // Get the mapData from store instead
    ///          mapDataStore: Ext.StoreMgr.get('MapData2'),
    ///          mapDataPathField: 'path',
    /// 
    ///          // Both stores have different index field names.
    ///          // Use joinBy as an array to link both stores data
    ///          // getData method will extract code2 value from 
    ///          // MapData2 and getMapData will also get code1 value
    ///          // from PopDensity1
    ///          joinBy: [ 'code2', 'code1' ],
    /// 
    ///          // other Highmaps options
    ///          name: 'Population density',
    ///          borderColor: 'black',
    ///          borderWidth: 0.2,
    ///          states: {
    ///              hover: {
    ///                  borderWidth: 1
    ///              }
    ///          },
    ///          tooltip: {
    ///              valueSuffix: '/km²'
    ///          }
    ///      }]
    /// </summary>
    public partial class BaseMapSerie : Series
    {


        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("map path field from the data store. ")]
        public virtual string DataPathField
        {
            get
            {
                object obj = this.ViewState["DataPathField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["DataPathField"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("map name field from the data store")]
        public virtual string DataNameField
        {
            get
            {
                object obj = this.ViewState["DataNameField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["DataNameField"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("map color field from the data store")]
        public virtual string DataColorField
        {
            get
            {
                object obj = this.ViewState["DataColorField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["DataColorField"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("Map value field from the data store")]
        public virtual string DataValueField
        {
            get
            {
                object obj = this.ViewState["DataValueField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["DataValueField"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("If the map is configured drilldown option, then this is the id field to associate with the drilldown data")]
        public virtual string DataDrilldownField
        {
            get
            {
                object obj = this.ViewState["DataDrilldownField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["DataDrilldownField"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("string/number. Path field for mapData store. If users want to redirect mapData from a store, then this field must be specified.")]
        public virtual string MapDataPathField
        {
            get
            {
                object obj = this.ViewState["MapDataPathField"];
                return obj != null ? (string)obj : "";
            }
            set
            {
                this.ViewState["MapDataPathField"] = value;
            }
        }

        // TODO Build in additional store support

        public override ConfigOptionsCollection ConfigOptions
        {
            get
            {
                ConfigOptionsCollection list = base.ConfigOptions;
                list.Add("dataPathField", new ConfigOption("dataPathField", null, "", this.DataPathField));
                list.Add("dataNameField", new ConfigOption("dataNameField", null, "", this.DataNameField));
                list.Add("dataColorField", new ConfigOption("dataColorField", null, "", this.DataColorField));
                list.Add("dataValueField", new ConfigOption("dataValueField", null, "", this.DataValueField));
                list.Add("dataDrilldownField", new ConfigOption("dataDrilldownField", null, "", this.DataDrilldownField));
                list.Add("mapDataPathField", new ConfigOption("mapDataPathField", null, "", this.MapDataPathField));

                return list;
            }

        }


        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(BaseMapSerie), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.MapSerie.js", "Resources/Chart/ux/Highcharts/MapSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.MapSerie";
            }
        }


    }
}