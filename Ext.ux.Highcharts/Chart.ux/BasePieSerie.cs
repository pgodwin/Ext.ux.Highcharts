using System.Collections.Generic;
using System.Web.UI;
using Ext.Net;

[assembly: WebResource("Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.PieSerie.js", "text/javascript")]
namespace Ext.ux.Highcharts.ChartSeries
{
    /// <summary>
    ///  # Plotting Pie Series
    ///  There are two ways to plot pie chart from record data: a data point per record and
    ///  total values of all the records
    /// 
    ///  ## Data point per record
    ///  Pie series uses two options for mapping category name and data fields: 
    ///  *categoryField* and *dataField*, (This is historical reason instead of 
    ///  using *xField* and *dataIndex*). Suppose we have data model in the following format:
    /// 
    ///  <table>
    ///     <tbody>
    ///        <tr><td>productName</td><td>sold</td></tr>
    ///        <tr><td>Product A</td><td>15,645,242</td></tr>
    ///        <tr><td>Product B</td><td>22,642,358</td></tr>
    ///        <tr><td>Product C</td><td>21,432,330</td></tr>
    ///     </tbody>
    ///  </table>
    ///  Then we can define the series data as:
    ///  
    ///      series: [{
    ///         type: 'pie',
    ///         categoryField: 'productName',
    ///         dataField: 'sold'
    ///      }]
    /// 
    ///  # Data point as total value of all the records
    ///  Instead of mapping *dataField* and *categorieField* fields to the store record for each
    ///  pie data point, this approach uses the total value of a category as a data point. 
    ///  E.g. we have a class of pupils with a set of subject scores
    ///  <table>
    ///     <tbody>
    ///        <tr><td>Name</td><td>English</td><td>Math</td><td>Science</td></tr>
    ///        <tr><td>Joe</td><td>77</td><td>81</td><td>78</td></tr>
    ///        <tr><td>David</td><td>67</td><td>56</td><td>69</td><tr>
    ///        <tr><td>Nora</td><td>44</td><td>50</td><td>39</td><tr>
    ///     </tbody>
    ///  </table>
    ///  All we want is to plot distribution of total scores for each subject. Hence, we define
    ///  the pie series as follows:
    ///      series: [{
    ///         type: 'pie',
    ///         useTotals: true,
    ///         column: [ 'english', 'math', 'science' ]
    ///      }]
    ///  whereas the server-side should return JSON data as follows:
    ///      { "root": [{ "english": 77, "math": 81, "science": 78 },
    ///                 { "english": 67, "math": 56, "science": 69 },
    ///                 { "english": 44, "math": 50, "science": 39 },
    ///                 .....                                         ]
    ///      } 
    ///  and the data model for the store is defined as follows:
    ///      Ext.define('ExamResults', {
    ///         extend: 'Ext.data.Model',
    ///           fields: [
    ///               {name: 'english', type: 'int'},
    ///               {name: 'math',  type: 'int'},
    ///               {name: 'science',  type: 'int'}
    ///           ]
    ///      });
    ///   
    ///  # Multiple Pie Series (Donut chart)
    ///  A donut chart is really two pie series which a second pie series lay outside of the 
    ///  first series. The second series is subcategory data of the first series.
    ///  Suppose we want to plot a more detail chart with the breakdown of sold items into regions:
    ///  <table>
    ///     <tbody>
    ///        <tr><td>productName</td><td>sold</td><td>Europe</td><td>Asia</td><td>Americas</td></tr>
    ///        <tr><td>Product A</td><td>15,645,242</td><td>10,432,542</td><td>2,425,432</td><td>2,787,268</td></tr>
    ///        <tr><td>Product B</td><td>22,642,358</td><td>4,325,421</td><td>4,325,321</td><td>13,991,616</td></tr>
    ///        <tr><td>Product C</td><td>21,432,330</td><td>2,427,431</td><td>6,443,234</td><td>12,561,665</td></tr>
    ///     </tbody>
    ///  </table>
    ///  The data model for the donut chart store should be refined with fields: productName, 
    ///  sold and region. The rows returning from the store should look like:
    ///  <table>
    ///     <tbody>
    ///        <tr> <td>productName</td> <td>sold</td> <td>region</td> </tr>
    ///        <tr> <td>Product A</td> <td>10,432,542</td> <td>Europe</td> <td></td> </tr>
    ///        <tr> <td>Product A</td> <td>2,425,432</td> <td>Asia</td> <td></td> </tr>
    ///        <tr> <td>Product A</td> <td>2,787,268</td> <td>Americas</td> <td></td> </tr>
    ///        <tr> <td>Product B</td> <td>4,325,421</td> <td>Europe</td> <td></td> </tr>
    ///        <tr> <td>Product B</td> <td>4,325,321</td> <td>Asia</td> <td></td> </tr>
    ///     </tbody>
    ///  </table>
    /// The series definition for the donut chart should look like this:
    ///      series: [{
    ///         // Inner pie series
    ///         type: 'pie',
    ///         categoryField: 'productName',
    ///         dataField: 'sold',
    ///         size: '60%',
    ///         totalDataField: true
    ///      }, {
    ///         // Outer pie series
    ///         type: 'pie',
    ///         categoryField: 'region',
    ///         dataField: 'sold',
    ///         innerSize: '60%',
    ///         size: '75%'
    ///      }]
    ///  The *totalDataField* informs the first series to take the sum of *dataField* (sold) 
    ///  on entries with the same *categoryField* value, whereas the second series displays 
    ///  a section on each region (i.e. each record). The *innerSize* is just the Highcharts 
    ///  option to make the outer pie series appear as ring form.
    /// 
    ///  If you want to have a fix set of colours in the outer ring along each slice, then 
    ///  you can create an extra field in your store for the color code and use the 
    ///  *colorField* option to map the field.
    ///
    /// </summary>
    public partial class BasePieSerie : Series
    {
        protected override List<ResourceItem> Resources
        {
            get
            {
                List<ResourceItem> baseList = base.Resources;
                baseList.Capacity += 1;

                // Sencha Wrapper
                baseList.Add(new ClientScriptItem(typeof(BasePieSerie), "Ext.ux.Highcharts.Resources.Chart.ux.Highcharts.PieSerie.js", "Resources/Chart/ux/Highcharts/PieSerie.js"));

                return baseList;
            }
        }


        public override string InstanceOf
        {
            get
            {
                return "Chart.ux.Highcharts.PieSerie";
            }
        }


    }
}