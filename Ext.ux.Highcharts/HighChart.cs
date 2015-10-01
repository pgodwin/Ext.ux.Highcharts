﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using Ext.Net;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.js", "text/javascript")]
namespace Ext.ux.Highcharts
{

    [Designer(typeof(EmptyDesigner))]
    [DefaultProperty("")]
    [ToolboxData("<{0}:HighChart runat=\"server\"></{0}:HighChart>")]
    [Description("High Chart")]

    public class HighChart : HighChartBase
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Highchart itself
                baseList.Add(new ClientScriptItem("Ext.ux.Highcharts.Resources.Highcharts.highcharts.js", "Ext.ux.Highcharts.Resources.Highcharts.highcharts.src.js", "Resources/Highcharts/highcharts.js", "Resources/Highcharts/highcharts.src.js"));
                
                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(HighChart), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.js", "Resources/Chart/ux/Highcharts.js"));

                return baseList;
            }
        }

        public override string XType
        {
            get
            {
                return "widget.highchart";
            }
        }

        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts";
            }
        }

    }
}