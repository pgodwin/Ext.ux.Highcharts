using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ext.ux.Highcharts.Demo.Demos
{
    public partial class Area : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.storeTest.DataSource = new List<object>
            {
                new { month = "Jan", data1 = 20 },
                new { month = "Feb", data1 = 20 },
                new { month = "Mar", data1 = 19 },
                new { month = "Apr", data1 = 18 },
                new { month = "May", data1 = 18 },
                new { month = "Jun", data1 = 17 },
                new { month = "Jul", data1 = 16 },
                new { month = "Aug", data1 = 16 },
                new { month = "Sep", data1 = 16 },
                new { month = "Oct", data1 = 16 },
                new { month = "Nov", data1 = 15 },
                new { month = "Dec", data1 = 15 }
            };

            this.storeTest.DataBind();
        }
    }
}