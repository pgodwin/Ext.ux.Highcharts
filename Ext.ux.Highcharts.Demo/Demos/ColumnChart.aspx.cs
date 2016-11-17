using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;

namespace Ext.ux.Highcharts.Demo
{
    public partial class ColumnChart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (X.IsAjaxRequest)
                return;

            storeTest.DataSource = new List<object>
            {
                new {Name = "Test", Value = 123.3},
                new {Name = "Test2", Value = 75.9},
            };
            storeTest.DataBind();
        }
    }
}