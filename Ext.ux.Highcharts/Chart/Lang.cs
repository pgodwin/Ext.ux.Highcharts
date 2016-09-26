
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
        /// Language object. The language object is global and it can't		be set on each chart initiation. Instead, use Highcharts.setOptions to		set it before any chart is initiated. Highcharts.setOptions({	lang: {		months: ['Janvier', 'Février', 'Mars', 'Avril', 'Mai', 'Juin',  'Juillet', 'Août', 'Septembre', 'Octobre', 'Novembre', 'Décembre'],		weekdays: ['Dimanche', 'Lundi', 'Mardi', 'Mercredi', 'Jeudi', 'Vendredi', 'Samedi']	}});
        /// </summary>
        public partial class Lang : Observable
        {

    
            /// <summary>
            /// Exporting module menu. The tooltip title for the context menu holding print and export menu items.
            /// </summary>
            [ConfigOption("contextButtonTitle", null)]
            [DefaultValue(@"Chart context menu")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Exporting module menu. The tooltip title for the context menu holding print and export menu items.")]
            public string ContextButtonTitle
            {
                get
                {
                    return this.State.Get<string>("ContextButtonTitle", @"Chart context menu");
                }
                set
                {
                    this.State.Set("ContextButtonTitle", value);
                }
            }

            /// <summary>
            /// The default decimal point used in the Highcharts.numberFormat method unless otherwise specified in the function arguments.
            /// </summary>
            [ConfigOption("decimalPoint", null)]
            [DefaultValue(@".")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The default decimal point used in the Highcharts.numberFormat method unless otherwise specified in the function arguments.")]
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
            /// Exporting module only. The text for the JPEG download menu item.
            /// </summary>
            [ConfigOption("downloadJPEG", null)]
            [DefaultValue(@"Download JPEG image")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Exporting module only. The text for the JPEG download menu item.")]
            public string DownloadJPEG
            {
                get
                {
                    return this.State.Get<string>("DownloadJPEG", @"Download JPEG image");
                }
                set
                {
                    this.State.Set("DownloadJPEG", value);
                }
            }

            /// <summary>
            /// Exporting module only. The text for the PDF download menu item.
            /// </summary>
            [ConfigOption("downloadPDF", null)]
            [DefaultValue(@"Download PDF document")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Exporting module only. The text for the PDF download menu item.")]
            public string DownloadPDF
            {
                get
                {
                    return this.State.Get<string>("DownloadPDF", @"Download PDF document");
                }
                set
                {
                    this.State.Set("DownloadPDF", value);
                }
            }

            /// <summary>
            /// Exporting module only. The text for the PNG download menu item.
            /// </summary>
            [ConfigOption("downloadPNG", null)]
            [DefaultValue(@"Download PNG image")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Exporting module only. The text for the PNG download menu item.")]
            public string DownloadPNG
            {
                get
                {
                    return this.State.Get<string>("DownloadPNG", @"Download PNG image");
                }
                set
                {
                    this.State.Set("DownloadPNG", value);
                }
            }

            /// <summary>
            /// Exporting module only. The text for the SVG download menu item.
            /// </summary>
            [ConfigOption("downloadSVG", null)]
            [DefaultValue(@"Download SVG vector image")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Exporting module only. The text for the SVG download menu item.")]
            public string DownloadSVG
            {
                get
                {
                    return this.State.Get<string>("DownloadSVG", @"Download SVG vector image");
                }
                set
                {
                    this.State.Set("DownloadSVG", value);
                }
            }

            /// <summary>
            /// The text for the button that appears when drilling down, linking back to the parent series. The parent series' name is inserted for {series.name}.
            /// </summary>
            [ConfigOption("drillUpText", null)]
            [DefaultValue(@"Back to {series.name}")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The text for the button that appears when drilling down, linking back to the parent series. The parent series' name is inserted for {series.name}.")]
            public string DrillUpText
            {
                get
                {
                    return this.State.Get<string>("DrillUpText", @"Back to {series.name}");
                }
                set
                {
                    this.State.Set("DrillUpText", value);
                }
            }

            /// <summary>
            /// What to show in a date field for invalid dates. Defaults to an empty string.
            /// </summary>
            [ConfigOption("invalidDate", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"What to show in a date field for invalid dates. Defaults to an empty string.")]
            public string InvalidDate
            {
                get
                {
                    return this.State.Get<string>("InvalidDate", "");
                }
                set
                {
                    this.State.Set("InvalidDate", value);
                }
            }

            /// <summary>
            /// The loading text that appears when the chart is set into the loading state following a call to chart.showLoading.
            /// </summary>
            [ConfigOption("loading", null)]
            [DefaultValue(@"Loading...")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The loading text that appears when the chart is set into the loading state following a call to chart.showLoading.")]
            public string Loading
            {
                get
                {
                    return this.State.Get<string>("Loading", @"Loading...");
                }
                set
                {
                    this.State.Set("Loading", value);
                }
            }

            /// <summary>
            /// An array containing the months names. Corresponds to the  %B format in Highcharts.dateFormat().
            /// </summary>
            [ConfigOption("months", JsonMode.AlwaysArray)]
            [DefaultValue(new string[] {  "January" , "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December"})]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An array containing the months names. Corresponds to the  %B format in Highcharts.dateFormat().")]
            public string[] Months
            {
                get
                {
                    return this.State.Get<string[]>("Months", new string[] {  "January" , "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December"});
                }
                set
                {
                    this.State.Set("Months", value);
                }
            }

            /// <summary>
            /// The text to display when the chart contains no data. Requires the no-data module, see noData.
            /// </summary>
            [ConfigOption("noData", null)]
            [DefaultValue(@"No data to display")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The text to display when the chart contains no data. Requires the no-data module, see noData.")]
            public string NoData
            {
                get
                {
                    return this.State.Get<string>("NoData", @"No data to display");
                }
                set
                {
                    this.State.Set("NoData", value);
                }
            }

            /// <summary>
            /// Metric prefixes used to shorten high numbers in axis labels. Replacing any of the positions with null causes the full number to be written. Setting numericSymbols to null disables shortening altogether.
            /// </summary>
            [ConfigOption("numericSymbols", JsonMode.AlwaysArray)]
            [DefaultValue(new string[] {  "k" , "M" , "G" , "T" , "P" , "E"})]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Metric prefixes used to shorten high numbers in axis labels. Replacing any of the positions with null causes the full number to be written. Setting numericSymbols to null disables shortening altogether.")]
            public string[] NumericSymbols
            {
                get
                {
                    return this.State.Get<string[]>("NumericSymbols", new string[] {  "k" , "M" , "G" , "T" , "P" , "E"});
                }
                set
                {
                    this.State.Set("NumericSymbols", value);
                }
            }

            /// <summary>
            /// Exporting module only. The text for the menu item to print the chart.
            /// </summary>
            [ConfigOption("printChart", null)]
            [DefaultValue(@"Print chart")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Exporting module only. The text for the menu item to print the chart.")]
            public string PrintChart
            {
                get
                {
                    return this.State.Get<string>("PrintChart", @"Print chart");
                }
                set
                {
                    this.State.Set("PrintChart", value);
                }
            }

            /// <summary>
            /// The text for the label appearing when a chart is zoomed.
            /// </summary>
            [ConfigOption("resetZoom", null)]
            [DefaultValue(@"Reset zoom")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The text for the label appearing when a chart is zoomed.")]
            public string ResetZoom
            {
                get
                {
                    return this.State.Get<string>("ResetZoom", @"Reset zoom");
                }
                set
                {
                    this.State.Set("ResetZoom", value);
                }
            }

            /// <summary>
            /// The tooltip title for the label appearing when a chart is zoomed.
            /// </summary>
            [ConfigOption("resetZoomTitle", null)]
            [DefaultValue(@"Reset zoom level 1:1")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The tooltip title for the label appearing when a chart is zoomed.")]
            public string ResetZoomTitle
            {
                get
                {
                    return this.State.Get<string>("ResetZoomTitle", @"Reset zoom level 1:1");
                }
                set
                {
                    this.State.Set("ResetZoomTitle", value);
                }
            }

            /// <summary>
            /// An array containing the months names in abbreviated form. Corresponds to the  %b format in Highcharts.dateFormat(). 
            /// </summary>
            [ConfigOption("shortMonths", JsonMode.AlwaysArray)]
            [DefaultValue(new string[] {  "Jan" , "Feb" , "Mar" , "Apr" , "May" , "Jun" , "Jul" , "Aug" , "Sep" , "Oct" , "Nov" , "Dec"})]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An array containing the months names in abbreviated form. Corresponds to the  %b format in Highcharts.dateFormat(). ")]
            public string[] ShortMonths
            {
                get
                {
                    return this.State.Get<string[]>("ShortMonths", new string[] {  "Jan" , "Feb" , "Mar" , "Apr" , "May" , "Jun" , "Jul" , "Aug" , "Sep" , "Oct" , "Nov" , "Dec"});
                }
                set
                {
                    this.State.Set("ShortMonths", value);
                }
            }

            /// <summary>
            /// The default thousands separator used in the Highcharts.numberFormat method unless otherwise specified in the function arguments. Since Highcharts 4.1 it defaults to a single space character, which is compatible with ISO and works across Anglo-American and continental European languages.
            /// </summary>
            [ConfigOption("thousandsSep", null)]
            [DefaultValue(@" ")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The default thousands separator used in the Highcharts.numberFormat method unless otherwise specified in the function arguments. Since Highcharts 4.1 it defaults to a single space character, which is compatible with ISO and works across Anglo-American and continental European languages.")]
            public string ThousandsSep
            {
                get
                {
                    return this.State.Get<string>("ThousandsSep", @" ");
                }
                set
                {
                    this.State.Set("ThousandsSep", value);
                }
            }

            /// <summary>
            /// An array containing the weekday names.		 
            /// </summary>
            [ConfigOption("weekdays", JsonMode.AlwaysArray)]
            [DefaultValue(new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"An array containing the weekday names.		 ")]
            public string[] Weekdays
            {
                get
                {
                    return this.State.Get<string[]>("Weekdays", new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"});
                }
                set
                {
                    this.State.Set("Weekdays", value);
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


                list.Add("contextButtonTitle", new ConfigOption("contextButtonTitle", null, @"Chart context menu", this.ContextButtonTitle));

                list.Add("decimalPoint", new ConfigOption("decimalPoint", null, @".", this.DecimalPoint));

                list.Add("downloadJPEG", new ConfigOption("downloadJPEG", null, @"Download JPEG image", this.DownloadJPEG));

                list.Add("downloadPDF", new ConfigOption("downloadPDF", null, @"Download PDF document", this.DownloadPDF));

                list.Add("downloadPNG", new ConfigOption("downloadPNG", null, @"Download PNG image", this.DownloadPNG));

                list.Add("downloadSVG", new ConfigOption("downloadSVG", null, @"Download SVG vector image", this.DownloadSVG));

                list.Add("drillUpText", new ConfigOption("drillUpText", null, @"Back to {series.name}", this.DrillUpText));

                list.Add("invalidDate", new ConfigOption("invalidDate", null, "", this.InvalidDate));

                list.Add("loading", new ConfigOption("loading", null, @"Loading...", this.Loading));

                list.Add("months", new ConfigOption("months", new SerializationOptions("months", JsonMode.AlwaysArray), new string[] {  "January" , "February" , "March" , "April" , "May" , "June" , "July" , "August" , "September" , "October" , "November" , "December"}, this.Months));

                list.Add("noData", new ConfigOption("noData", null, @"No data to display", this.NoData));

                list.Add("numericSymbols", new ConfigOption("numericSymbols", new SerializationOptions("numericSymbols", JsonMode.AlwaysArray), new string[] {  "k" , "M" , "G" , "T" , "P" , "E"}, this.NumericSymbols));

                list.Add("printChart", new ConfigOption("printChart", null, @"Print chart", this.PrintChart));

                list.Add("resetZoom", new ConfigOption("resetZoom", null, @"Reset zoom", this.ResetZoom));

                list.Add("resetZoomTitle", new ConfigOption("resetZoomTitle", null, @"Reset zoom level 1:1", this.ResetZoomTitle));

                list.Add("shortMonths", new ConfigOption("shortMonths", new SerializationOptions("shortMonths", JsonMode.AlwaysArray), new string[] {  "Jan" , "Feb" , "Mar" , "Apr" , "May" , "Jun" , "Jul" , "Aug" , "Sep" , "Oct" , "Nov" , "Dec"}, this.ShortMonths));

                list.Add("thousandsSep", new ConfigOption("thousandsSep", null, @" ", this.ThousandsSep));

                list.Add("weekdays", new ConfigOption("weekdays", new SerializationOptions("weekdays", JsonMode.AlwaysArray), new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}, this.Weekdays));

                return list;
            }
        }


    
	        private LangEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public LangEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new LangEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class LangEvents : ComponentListeners
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
            