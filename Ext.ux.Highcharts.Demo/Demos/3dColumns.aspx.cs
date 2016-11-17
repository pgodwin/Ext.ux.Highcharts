using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;

namespace Ext.ux.Highcharts.Demo.Demos
{
    public partial class _3dColumns : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoadTemperatures(object sender, StoreReadDataEventArgs e)
        {
            var store = sender as Store;

            if (store == null)
                return;

            List<object> items = new List<object>();
            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                var timeValue = 1327600670 + (3600 * i);
                items.Add(new 
                {
                    time = timeValue,
                    yesterday = rnd.Next(20, 30),
                    today = rnd.Next(15,25)
                });
            }
            store.DataSource = items;
            store.DataBind();

        }
    }
}