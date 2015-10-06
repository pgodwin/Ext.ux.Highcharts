
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
        /// The Data module provides a simplified interface for adding data to a chart from sources like CVS, HTML tables or grid views. See also the tutorial article on the Data module.It requires the modules/data.js file to be loaded.Please note that the default way of adding data in Highcharts, without the need of a module, is through the series.data option.
        /// </summary>
        public partial class Data : Observable
        {

    
            /// <summary>
            /// A two-dimensional array representing the input data on tabular form. This input can be used when the data is already parsed, for example from a grid view component. Each cell can be a string or number. If not switchRowsAndColumns is set, the columns are interpreted as series.
            /// </summary>
            [ConfigOption("columns", JsonMode.AlwaysArray)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A two-dimensional array representing the input data on tabular form. This input can be used when the data is already parsed, for example from a grid view component. Each cell can be a string or number. If not switchRowsAndColumns is set, the columns are interpreted as series.")]
            public object[,] Columns
            {
                get
                {
                    return this.State.Get<object[,]>("Columns", null);
                }
                set
                {
                    this.State.Set("Columns", value);
                }
            }

            /// <summary>
            /// The callback that is evaluated when the data is finished loading, optionally from an external source, and parsed. The first argument passed is a finished chart options object, containing the series. These options can be extended with additional options and passed directly to the chart constructor.
            /// </summary>
            [ConfigOption("complete", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The callback that is evaluated when the data is finished loading, optionally from an external source, and parsed. The first argument passed is a finished chart options object, containing the series. These options can be extended with additional options and passed directly to the chart constructor.")]
            public string Complete
            {
                get
                {
                    return this.State.Get<string>("Complete", "");
                }
                set
                {
                    this.State.Set("Complete", value);
                }
            }

            /// <summary>
            /// A comma delimited string to be parsed. Related options are startRow, endRow, startColumn and endColumn to delimit what part of the table is used. The lineDelimiter and itemDelimiter options define the CSV delimiter formats.
            /// </summary>
            [ConfigOption("csv", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A comma delimited string to be parsed. Related options are startRow, endRow, startColumn and endColumn to delimit what part of the table is used. The lineDelimiter and itemDelimiter options define the CSV delimiter formats.")]
            public string Csv
            {
                get
                {
                    return this.State.Get<string>("Csv", "");
                }
                set
                {
                    this.State.Set("Csv", value);
                }
            }

            /// <summary>
            /// Which of the predefined date formats in Date.prototype.dateFormats to use to parse date values. Defaults to a best guess based on what format gives valid and ordered dates.Valid options include:YYYY-mm-dddd/mm/YYYYmm/dd/YYYYdd/mm/YYmm/dd/YY
            /// </summary>
            [ConfigOption("dateFormat", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Which of the predefined date formats in Date.prototype.dateFormats to use to parse date values. Defaults to a best guess based on what format gives valid and ordered dates.Valid options include:YYYY-mm-dddd/mm/YYYYmm/dd/YYYYdd/mm/YYmm/dd/YY")]
            public string DateFormat
            {
                get
                {
                    return this.State.Get<string>("DateFormat", "");
                }
                set
                {
                    this.State.Set("DateFormat", value);
                }
            }

            /// <summary>
            /// The decimal point used for parsing numbers in the CSV.
            /// </summary>
            [ConfigOption("decimalPoint", null)]
            [DefaultValue(@".")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The decimal point used for parsing numbers in the CSV.")]
            public string DecimalPoint
            {
                get
                {
                    return this.State.Get<string>("DecimalPoint", @".");
                }
                set
                {
                    this.State.Set("DecimalPoint", value);
                }
            }

            /// <summary>
            /// In tabular input data, the last column (indexed by 0) to use. Defaults to the last column containing data.
            /// </summary>
            [ConfigOption("endColumn", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"In tabular input data, the last column (indexed by 0) to use. Defaults to the last column containing data.")]
            public double? EndColumn
            {
                get
                {
                    return this.State.Get<double?>("EndColumn", null);
                }
                set
                {
                    this.State.Set("EndColumn", value);
                }
            }

            /// <summary>
            /// In tabular input data, the last row (indexed by 0) to use. Defaults to the last row containing data.
            /// </summary>
            [ConfigOption("endRow", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"In tabular input data, the last row (indexed by 0) to use. Defaults to the last row containing data.")]
            public double? EndRow
            {
                get
                {
                    return this.State.Get<double?>("EndRow", null);
                }
                set
                {
                    this.State.Set("EndRow", value);
                }
            }

            /// <summary>
            /// Whether to use the first row in the data set as series names. 
            /// </summary>
            [ConfigOption("firstRowAsNames", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to use the first row in the data set as series names. ")]
            public bool? FirstRowAsNames
            {
                get
                {
                    return this.State.Get<bool?>("FirstRowAsNames", true);
                }
                set
                {
                    this.State.Set("FirstRowAsNames", value);
                }
            }

            /// <summary>
            /// The key for a Google Spreadsheet to load. See general information on GS.
            /// </summary>
            [ConfigOption("googleSpreadsheetKey", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The key for a Google Spreadsheet to load. See general information on GS.")]
            public string GoogleSpreadsheetKey
            {
                get
                {
                    return this.State.Get<string>("GoogleSpreadsheetKey", "");
                }
                set
                {
                    this.State.Set("GoogleSpreadsheetKey", value);
                }
            }

            /// <summary>
            /// The Google Spreadsheet worksheet to use in combination with googleSpreadsheetKey. The available id's from your sheet can be read from https://spreadsheets.google.com/feeds/worksheets/{key}/public/basic
            /// </summary>
            [ConfigOption("googleSpreadsheetWorksheet", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The Google Spreadsheet worksheet to use in combination with googleSpreadsheetKey. The available id's from your sheet can be read from https://spreadsheets.google.com/feeds/worksheets/{key}/public/basic")]
            public string GoogleSpreadsheetWorksheet
            {
                get
                {
                    return this.State.Get<string>("GoogleSpreadsheetWorksheet", "");
                }
                set
                {
                    this.State.Set("GoogleSpreadsheetWorksheet", value);
                }
            }

            /// <summary>
            /// Item or cell delimiter for parsing CSV. Defaults to the tab character \t if a tab character is found in the CSV string, if not it defaults to ,.
            /// </summary>
            [ConfigOption("itemDelimiter", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Item or cell delimiter for parsing CSV. Defaults to the tab character \t if a tab character is found in the CSV string, if not it defaults to ,.")]
            public string ItemDelimiter
            {
                get
                {
                    return this.State.Get<string>("ItemDelimiter", "");
                }
                set
                {
                    this.State.Set("ItemDelimiter", value);
                }
            }

            /// <summary>
            /// Line delimiter for parsing CSV.
            /// </summary>
            [ConfigOption("lineDelimiter", null)]
            [DefaultValue(@"\n")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Line delimiter for parsing CSV.")]
            public string LineDelimiter
            {
                get
                {
                    return this.State.Get<string>("LineDelimiter", @"\n");
                }
                set
                {
                    this.State.Set("LineDelimiter", value);
                }
            }

            /// <summary>
            /// A callback function to parse string representations of dates into JavaScript timestamps. Should return an integer timestamp on success.
            /// </summary>
            [ConfigOption("parseDate", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A callback function to parse string representations of dates into JavaScript timestamps. Should return an integer timestamp on success.")]
            public string ParseDate
            {
                get
                {
                    return this.State.Get<string>("ParseDate", "");
                }
                set
                {
                    this.State.Set("ParseDate", value);
                }
            }

            /// <summary>
            /// A callback function to access the parsed columns, the two-dimentional input data array directly, before they are interpreted into series data and categories. Return false to stop completion, or call this.complete() to continue async.
            /// </summary>
            [ConfigOption("parsed", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A callback function to access the parsed columns, the two-dimentional input data array directly, before they are interpreted into series data and categories. Return false to stop completion, or call this.complete() to continue async.")]
            public string Parsed
            {
                get
                {
                    return this.State.Get<string>("Parsed", "");
                }
                set
                {
                    this.State.Set("Parsed", value);
                }
            }

            /// <summary>
            /// The same as the columns input option, but defining rows intead of columns.
            /// </summary>
            [ConfigOption("rows", JsonMode.AlwaysArray)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The same as the columns input option, but defining rows intead of columns.")]
            public object[,] Rows
            {
                get
                {
                    return this.State.Get<object[,]>("Rows", null);
                }
                set
                {
                    this.State.Set("Rows", value);
                }
            }

            /// <summary>
            /// An array containing object with Point property names along with what column id the property should be taken from.
            /// </summary>
            [ConfigOption("seriesMapping", JsonMode.AlwaysArray)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An array containing object with Point property names along with what column id the property should be taken from.")]
            public object[] SeriesMapping
            {
                get
                {
                    return this.State.Get<object[]>("SeriesMapping", null);
                }
                set
                {
                    this.State.Set("SeriesMapping", value);
                }
            }

            /// <summary>
            /// In tabular input data, the first column (indexed by 0) to use.
            /// </summary>
            [ConfigOption("startColumn", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"In tabular input data, the first column (indexed by 0) to use.")]
            public double? StartColumn
            {
                get
                {
                    return this.State.Get<double?>("StartColumn", 0);
                }
                set
                {
                    this.State.Set("StartColumn", value);
                }
            }

            /// <summary>
            /// In tabular input data, the first row (indexed by 0) to use.
            /// </summary>
            [ConfigOption("startRow", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"In tabular input data, the first row (indexed by 0) to use.")]
            public double? StartRow
            {
                get
                {
                    return this.State.Get<double?>("StartRow", 0);
                }
                set
                {
                    this.State.Set("StartRow", value);
                }
            }

            /// <summary>
            /// Switch rows and columns of the input data, so that this.columns effectively becomes the rows of the data set, and the rows are interpreted as series.
            /// </summary>
            [ConfigOption("switchRowsAndColumns", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Switch rows and columns of the input data, so that this.columns effectively becomes the rows of the data set, and the rows are interpreted as series.")]
            public bool? SwitchRowsAndColumns
            {
                get
                {
                    return this.State.Get<bool?>("SwitchRowsAndColumns", false);
                }
                set
                {
                    this.State.Set("SwitchRowsAndColumns", value);
                }
            }

            /// <summary>
            /// A HTML table or the id of such to be parsed as input data. Related options are startRow, endRow, startColumn and endColumn to delimit what part of the table is used.
            /// </summary>
            [ConfigOption("table", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A HTML table or the id of such to be parsed as input data. Related options are startRow, endRow, startColumn and endColumn to delimit what part of the table is used.")]
            public object Table
            {
                get
                {
                    return this.State.Get<object>("Table", null);
                }
                set
                {
                    this.State.Set("Table", value);
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


                list.Add("columns", new ConfigOption("columns", new SerializationOptions("columns", JsonMode.AlwaysArray), null, this.Columns));

                list.Add("complete", new ConfigOption("complete", null, "", this.Complete));

                list.Add("csv", new ConfigOption("csv", null, "", this.Csv));

                list.Add("dateFormat", new ConfigOption("dateFormat", null, "", this.DateFormat));

                list.Add("decimalPoint", new ConfigOption("decimalPoint", null, @".", this.DecimalPoint));

                list.Add("endColumn", new ConfigOption("endColumn", null, null, this.EndColumn));

                list.Add("endRow", new ConfigOption("endRow", null, null, this.EndRow));

                list.Add("firstRowAsNames", new ConfigOption("firstRowAsNames", null, true, this.FirstRowAsNames));

                list.Add("googleSpreadsheetKey", new ConfigOption("googleSpreadsheetKey", null, "", this.GoogleSpreadsheetKey));

                list.Add("googleSpreadsheetWorksheet", new ConfigOption("googleSpreadsheetWorksheet", null, "", this.GoogleSpreadsheetWorksheet));

                list.Add("itemDelimiter", new ConfigOption("itemDelimiter", null, "", this.ItemDelimiter));

                list.Add("lineDelimiter", new ConfigOption("lineDelimiter", null, @"\n", this.LineDelimiter));

                list.Add("parseDate", new ConfigOption("parseDate", null, "", this.ParseDate));

                list.Add("parsed", new ConfigOption("parsed", null, "", this.Parsed));

                list.Add("rows", new ConfigOption("rows", new SerializationOptions("rows", JsonMode.AlwaysArray), null, this.Rows));

                list.Add("seriesMapping", new ConfigOption("seriesMapping", new SerializationOptions("seriesMapping", JsonMode.AlwaysArray), null, this.SeriesMapping));

                list.Add("startColumn", new ConfigOption("startColumn", null, 0, this.StartColumn));

                list.Add("startRow", new ConfigOption("startRow", null, 0, this.StartRow));

                list.Add("switchRowsAndColumns", new ConfigOption("switchRowsAndColumns", null, false, this.SwitchRowsAndColumns));

                list.Add("table", new ConfigOption("table", null, null, this.Table));

                return list;
            }
        }


    
	        private DataEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public DataEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new DataEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class DataEvents : ComponentListeners
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
            