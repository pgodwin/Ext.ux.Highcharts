
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
        /// The legend is a box containing a symbol and name for each series item	or point item in the chart.
        /// </summary>
        public partial class Legend : Observable
        {

    
            /// <summary>
            /// The horizontal alignment of the legend box within the chart area. Valid values are left, center and right.In the case that the legend is aligned in a corner position, the layout option will determine whether to place it above/below or on the side of the plot area.
            /// </summary>
            [ConfigOption("align", null)]
            [DefaultValue(@"center")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The horizontal alignment of the legend box within the chart area. Valid values are left, center and right.In the case that the legend is aligned in a corner position, the layout option will determine whether to place it above/below or on the side of the plot area.")]
            public string Align
            {
                get
                {
                    return this.State.Get<string>("Align", @"center");
                }
                set
                {
                    this.State.Set("Align", value);
                }
            }

            /// <summary>
            /// The background color of the legend.
            /// </summary>
            [ConfigOption("backgroundColor", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The background color of the legend.")]
            public string BackgroundColor
            {
                get
                {
                    return this.State.Get<string>("BackgroundColor", "");
                }
                set
                {
                    this.State.Set("BackgroundColor", value);
                }
            }

            /// <summary>
            /// The color of the drawn border around the legend.
            /// </summary>
            [ConfigOption("borderColor", null)]
            [DefaultValue(@"#909090")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the drawn border around the legend.")]
            public string BorderColor
            {
                get
                {
                    return this.State.Get<string>("BorderColor", @"#909090");
                }
                set
                {
                    this.State.Set("BorderColor", value);
                }
            }

            /// <summary>
            /// The border corner radius of the legend.
            /// </summary>
            [ConfigOption("borderRadius", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The border corner radius of the legend.")]
            public double? BorderRadius
            {
                get
                {
                    return this.State.Get<double?>("BorderRadius", 0);
                }
                set
                {
                    this.State.Set("BorderRadius", value);
                }
            }

            /// <summary>
            /// The width of the drawn border around the legend.
            /// </summary>
            [ConfigOption("borderWidth", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the drawn border around the legend.")]
            public double? BorderWidth
            {
                get
                {
                    return this.State.Get<double?>("BorderWidth", 0);
                }
                set
                {
                    this.State.Set("BorderWidth", value);
                }
            }

            /// <summary>
            /// Enable or disable the legend.
            /// </summary>
            [ConfigOption("enabled", null)]
            [DefaultValue(true)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Enable or disable the legend.")]
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
            /// When the legend is floating, the plot area ignores it and is allowed to be placed below it.
            /// </summary>
            [ConfigOption("floating", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"When the legend is floating, the plot area ignores it and is allowed to be placed below it.")]
            public bool? Floating
            {
                get
                {
                    return this.State.Get<bool?>("Floating", false);
                }
                set
                {
                    this.State.Set("Floating", value);
                }
            }

            /// <summary>
            /// In a legend with horizontal layout, the itemDistance defines the pixel distance between each item. 
            /// </summary>
            [ConfigOption("itemDistance", null)]
            [DefaultValue(20)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"In a legend with horizontal layout, the itemDistance defines the pixel distance between each item. ")]
            public double? ItemDistance
            {
                get
                {
                    return this.State.Get<double?>("ItemDistance", 20);
                }
                set
                {
                    this.State.Set("ItemDistance", value);
                }
            }

            /// <summary>
            /// CSS styles for each legend item when the corresponding series or point is hidden. Only a subset of CSS is supported, notably those options related to text. Properties are inherited from style unless overridden here. Defaults to:itemHiddenStyle: {	color: '#CCC'}
            /// </summary>
            [ConfigOption("itemHiddenStyle", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for each legend item when the corresponding series or point is hidden. Only a subset of CSS is supported, notably those options related to text. Properties are inherited from style unless overridden here. Defaults to:itemHiddenStyle: {	color: '#CCC'}")]
            public string ItemHiddenStyle
            {
                get
                {
                    return this.State.Get<string>("ItemHiddenStyle", "");
                }
                set
                {
                    this.State.Set("ItemHiddenStyle", value);
                }
            }

            /// <summary>
            /// CSS styles for each legend item in hover mode. Only a subset of CSS is supported, notably those options related to text. Properties are inherited from style unless overridden here. Defaults to:itemHoverStyle: {	color: '#000'}
            /// </summary>
            [ConfigOption("itemHoverStyle", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for each legend item in hover mode. Only a subset of CSS is supported, notably those options related to text. Properties are inherited from style unless overridden here. Defaults to:itemHoverStyle: {	color: '#000'}")]
            public string ItemHoverStyle
            {
                get
                {
                    return this.State.Get<string>("ItemHoverStyle", "");
                }
                set
                {
                    this.State.Set("ItemHoverStyle", value);
                }
            }

            /// <summary>
            /// The pixel bottom margin for each legend item.
            /// </summary>
            [ConfigOption("itemMarginBottom", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel bottom margin for each legend item.")]
            public double? ItemMarginBottom
            {
                get
                {
                    return this.State.Get<double?>("ItemMarginBottom", 0);
                }
                set
                {
                    this.State.Set("ItemMarginBottom", value);
                }
            }

            /// <summary>
            /// The pixel top margin for each legend item.
            /// </summary>
            [ConfigOption("itemMarginTop", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel top margin for each legend item.")]
            public double? ItemMarginTop
            {
                get
                {
                    return this.State.Get<double?>("ItemMarginTop", 0);
                }
                set
                {
                    this.State.Set("ItemMarginTop", value);
                }
            }

            /// <summary>
            /// CSS styles for each legend item. Only a subset of CSS is supported, notably those options related to text.
            /// </summary>
            [ConfigOption("itemStyle", null)]
            [DefaultValue(@"{ ""color"": ""#333333"", ""cursor"": ""pointer"", ""fontSize"": ""12px"", ""fontWeight"": ""bold"" }")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for each legend item. Only a subset of CSS is supported, notably those options related to text.")]
            public string ItemStyle
            {
                get
                {
                    return this.State.Get<string>("ItemStyle", @"{ ""color"": ""#333333"", ""cursor"": ""pointer"", ""fontSize"": ""12px"", ""fontWeight"": ""bold"" }");
                }
                set
                {
                    this.State.Set("ItemStyle", value);
                }
            }

            /// <summary>
            /// The width for each legend item. This is useful in a horizontal layout with many items when you want the items to align vertically.  .
            /// </summary>
            [ConfigOption("itemWidth", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width for each legend item. This is useful in a horizontal layout with many items when you want the items to align vertically.  .")]
            public double? ItemWidth
            {
                get
                {
                    return this.State.Get<double?>("ItemWidth", null);
                }
                set
                {
                    this.State.Set("ItemWidth", value);
                }
            }

            /// <summary>
            /// A format string for each legend label. Available variables relates to properties on the series, or the point in case of pies.
            /// </summary>
            [ConfigOption("labelFormat", null)]
            [DefaultValue(@"{name}")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A format string for each legend label. Available variables relates to properties on the series, or the point in case of pies.")]
            public string LabelFormat
            {
                get
                {
                    return this.State.Get<string>("LabelFormat", @"{name}");
                }
                set
                {
                    this.State.Set("LabelFormat", value);
                }
            }

            /// <summary>
            /// Callback function to format each of the series' labels. The this keyword refers to the series object, or the point object in case of pie charts. By default the series or point name is printed.
            /// </summary>
            [ConfigOption("labelFormatter", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Callback function to format each of the series' labels. The this keyword refers to the series object, or the point object in case of pie charts. By default the series or point name is printed.")]
            public string LabelFormatter
            {
                get
                {
                    return this.State.Get<string>("LabelFormatter", "");
                }
                set
                {
                    this.State.Set("LabelFormatter", value);
                }
            }

            /// <summary>
            /// The layout of the legend items. Can be one of ""horizontal"" or ""vertical"".
            /// </summary>
            [ConfigOption("layout", null)]
            [DefaultValue(@"horizontal")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The layout of the legend items. Can be one of ""horizontal"" or ""vertical"".")]
            public string Layout
            {
                get
                {
                    return this.State.Get<string>("Layout", @"horizontal");
                }
                set
                {
                    this.State.Set("Layout", value);
                }
            }

            /// <summary>
            /// Line height for the legend items. Deprecated as of 2.1. Instead, the line height for each  item can be set using itemStyle.lineHeight, and the padding between items using itemMarginTop and itemMarginBottom.
            /// </summary>
            [ConfigOption("lineHeight", null)]
            [DefaultValue(16)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Line height for the legend items. Deprecated as of 2.1. Instead, the line height for each  item can be set using itemStyle.lineHeight, and the padding between items using itemMarginTop and itemMarginBottom.")]
            public double? LineHeight
            {
                get
                {
                    return this.State.Get<double?>("LineHeight", 16);
                }
                set
                {
                    this.State.Set("LineHeight", value);
                }
            }

            /// <summary>
            /// If the plot area sized is calculated automatically and the legend is not floating, the legend margin is the  space between the legend and the axis labels or plot area.
            /// </summary>
            [ConfigOption("margin", null)]
            [DefaultValue(12)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"If the plot area sized is calculated automatically and the legend is not floating, the legend margin is the  space between the legend and the axis labels or plot area.")]
            public double? Margin
            {
                get
                {
                    return this.State.Get<double?>("Margin", 12);
                }
                set
                {
                    this.State.Set("Margin", value);
                }
            }

            /// <summary>
            /// Maximum pixel height for the legend. When the maximum height is extended, navigation will show.
            /// </summary>
            [ConfigOption("maxHeight", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Maximum pixel height for the legend. When the maximum height is extended, navigation will show.")]
            public double? MaxHeight
            {
                get
                {
                    return this.State.Get<double?>("MaxHeight", null);
                }
                set
                {
                    this.State.Set("MaxHeight", value);
                }
            }

            /// <summary>
            /// The inner padding of the legend box.
            /// </summary>
            [ConfigOption("padding", null)]
            [DefaultValue(8)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The inner padding of the legend box.")]
            public double? Padding
            {
                get
                {
                    return this.State.Get<double?>("Padding", 8);
                }
                set
                {
                    this.State.Set("Padding", value);
                }
            }

            /// <summary>
            /// Whether to reverse the order of the legend items compared to the order of the series or points as defined in the configuration object.
            /// </summary>
            [ConfigOption("reversed", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to reverse the order of the legend items compared to the order of the series or points as defined in the configuration object.")]
            public bool? Reversed
            {
                get
                {
                    return this.State.Get<bool?>("Reversed", false);
                }
                set
                {
                    this.State.Set("Reversed", value);
                }
            }

            /// <summary>
            /// Whether to show the symbol on the right side of the text rather than the left side.  This is common in Arabic and Hebraic.
            /// </summary>
            [ConfigOption("rtl", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to show the symbol on the right side of the text rather than the left side.  This is common in Arabic and Hebraic.")]
            public bool? Rtl
            {
                get
                {
                    return this.State.Get<bool?>("Rtl", false);
                }
                set
                {
                    this.State.Set("Rtl", value);
                }
            }

            /// <summary>
            /// Whether to apply a drop shadow to the legend. A backgroundColor also needs to be applied for this to take effect. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.
            /// </summary>
            [ConfigOption("shadow", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to apply a drop shadow to the legend. A backgroundColor also needs to be applied for this to take effect. Since 2.3 the shadow can be an object configuration containing color, offsetX, offsetY, opacity and width.")]
            public object Shadow
            {
                get
                {
                    return this.State.Get<object>("Shadow", null);
                }
                set
                {
                    this.State.Set("Shadow", value);
                }
            }

            /// <summary>
            /// CSS styles for the legend area. In the 1.x versions the position of the legend area was determined by CSS. In 2.x, the position is determined by properties like  align, verticalAlign, x and y, but the styles are still parsed for backwards compatibility.
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"CSS styles for the legend area. In the 1.x versions the position of the legend area was determined by CSS. In 2.x, the position is determined by properties like  align, verticalAlign, x and y, but the styles are still parsed for backwards compatibility.")]
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
            /// The pixel height of the symbol for series types that use a rectangle in the legend. Defaults to the font size of legend items.
            /// </summary>
            [ConfigOption("symbolHeight", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel height of the symbol for series types that use a rectangle in the legend. Defaults to the font size of legend items.")]
            public double? SymbolHeight
            {
                get
                {
                    return this.State.Get<double?>("SymbolHeight", null);
                }
                set
                {
                    this.State.Set("SymbolHeight", value);
                }
            }

            /// <summary>
            /// The pixel padding between the legend item symbol and the legend item text.
            /// </summary>
            [ConfigOption("symbolPadding", null)]
            [DefaultValue(5)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel padding between the legend item symbol and the legend item text.")]
            public double? SymbolPadding
            {
                get
                {
                    return this.State.Get<double?>("SymbolPadding", 5);
                }
                set
                {
                    this.State.Set("SymbolPadding", value);
                }
            }

            /// <summary>
            /// The border radius of the symbol for series types that use a rectangle in the legend.
            /// </summary>
            [ConfigOption("symbolRadius", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The border radius of the symbol for series types that use a rectangle in the legend.")]
            public double? SymbolRadius
            {
                get
                {
                    return this.State.Get<double?>("SymbolRadius", 0);
                }
                set
                {
                    this.State.Set("SymbolRadius", value);
                }
            }

            /// <summary>
            /// The pixel width of the legend item symbol.
            /// </summary>
            [ConfigOption("symbolWidth", null)]
            [DefaultValue(16)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel width of the legend item symbol.")]
            public double? SymbolWidth
            {
                get
                {
                    return this.State.Get<double?>("SymbolWidth", 16);
                }
                set
                {
                    this.State.Set("SymbolWidth", value);
                }
            }

            /// <summary>
            /// Whether to use HTML to render the legend item texts. Prior to 4.1.7, when using HTML, legend.navigation was disabled.
            /// </summary>
            [ConfigOption("useHTML", null)]
            [DefaultValue(false)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Whether to use HTML to render the legend item texts. Prior to 4.1.7, when using HTML, legend.navigation was disabled.")]
            public bool? UseHTML
            {
                get
                {
                    return this.State.Get<bool?>("UseHTML", false);
                }
                set
                {
                    this.State.Set("UseHTML", value);
                }
            }

            /// <summary>
            /// The vertical alignment of the legend box. Can be one of top, middle or  bottom. Vertical position can be further determined by the y option.In the case that the legend is aligned in a corner position, the layout option will determine whether to place it above/below or on the side of the plot area.
            /// </summary>
            [ConfigOption("verticalAlign", null)]
            [DefaultValue(@"bottom")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The vertical alignment of the legend box. Can be one of top, middle or  bottom. Vertical position can be further determined by the y option.In the case that the legend is aligned in a corner position, the layout option will determine whether to place it above/below or on the side of the plot area.")]
            public string VerticalAlign
            {
                get
                {
                    return this.State.Get<string>("VerticalAlign", @"bottom");
                }
                set
                {
                    this.State.Set("VerticalAlign", value);
                }
            }

            /// <summary>
            /// The width of the legend box.
            /// </summary>
            [ConfigOption("width", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The width of the legend box.")]
            public double? Width
            {
                get
                {
                    return this.State.Get<double?>("Width", null);
                }
                set
                {
                    this.State.Set("Width", value);
                }
            }

            /// <summary>
            /// The x offset of the legend relative to its horizontal alignment align within chart.spacingLeft and chart.spacingRight. Negative x moves it to the left, positive x moves it to the right. 
            /// </summary>
            [ConfigOption("x", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The x offset of the legend relative to its horizontal alignment align within chart.spacingLeft and chart.spacingRight. Negative x moves it to the left, positive x moves it to the right. ")]
            public double? x
            {
                get
                {
                    return this.State.Get<double?>("x", 0);
                }
                set
                {
                    this.State.Set("x", value);
                }
            }

            /// <summary>
            /// The vertical offset of the legend relative to it's vertical alignment verticalAlign within chart.spacingTop and chart.spacingBottom. Negative y moves it up, positive y moves it down.
            /// </summary>
            [ConfigOption("y", null)]
            [DefaultValue(0)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The vertical offset of the legend relative to it's vertical alignment verticalAlign within chart.spacingTop and chart.spacingBottom. Negative y moves it up, positive y moves it down.")]
            public double? y
            {
                get
                {
                    return this.State.Get<double?>("y", 0);
                }
                set
                {
                    this.State.Set("y", value);
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


                list.Add("align", new ConfigOption("align", null, @"center", this.Align));

                list.Add("backgroundColor", new ConfigOption("backgroundColor", null, "", this.BackgroundColor));

                list.Add("borderColor", new ConfigOption("borderColor", null, @"#909090", this.BorderColor));

                list.Add("borderRadius", new ConfigOption("borderRadius", null, 0, this.BorderRadius));

                list.Add("borderWidth", new ConfigOption("borderWidth", null, 0, this.BorderWidth));

                list.Add("enabled", new ConfigOption("enabled", null, true, this.Enabled));

                list.Add("floating", new ConfigOption("floating", null, false, this.Floating));

                list.Add("itemDistance", new ConfigOption("itemDistance", null, 20, this.ItemDistance));

                list.Add("itemHiddenStyle", new ConfigOption("itemHiddenStyle", null, "", this.ItemHiddenStyle));

                list.Add("itemHoverStyle", new ConfigOption("itemHoverStyle", null, "", this.ItemHoverStyle));

                list.Add("itemMarginBottom", new ConfigOption("itemMarginBottom", null, 0, this.ItemMarginBottom));

                list.Add("itemMarginTop", new ConfigOption("itemMarginTop", null, 0, this.ItemMarginTop));

                list.Add("itemStyle", new ConfigOption("itemStyle", null, @"{ ""color"": ""#333333"", ""cursor"": ""pointer"", ""fontSize"": ""12px"", ""fontWeight"": ""bold"" }", this.ItemStyle));

                list.Add("itemWidth", new ConfigOption("itemWidth", null, null, this.ItemWidth));

                list.Add("labelFormat", new ConfigOption("labelFormat", null, @"{name}", this.LabelFormat));

                list.Add("labelFormatter", new ConfigOption("labelFormatter", null, "", this.LabelFormatter));

                list.Add("layout", new ConfigOption("layout", null, @"horizontal", this.Layout));

                list.Add("lineHeight", new ConfigOption("lineHeight", null, 16, this.LineHeight));

                list.Add("margin", new ConfigOption("margin", null, 12, this.Margin));

                list.Add("maxHeight", new ConfigOption("maxHeight", null, null, this.MaxHeight));

                list.Add("padding", new ConfigOption("padding", null, 8, this.Padding));

                list.Add("reversed", new ConfigOption("reversed", null, false, this.Reversed));

                list.Add("rtl", new ConfigOption("rtl", null, false, this.Rtl));

                list.Add("shadow", new ConfigOption("shadow", null, null, this.Shadow));

                list.Add("style", new ConfigOption("style", null, "", this.Style));

                list.Add("symbolHeight", new ConfigOption("symbolHeight", null, null, this.SymbolHeight));

                list.Add("symbolPadding", new ConfigOption("symbolPadding", null, 5, this.SymbolPadding));

                list.Add("symbolRadius", new ConfigOption("symbolRadius", null, 0, this.SymbolRadius));

                list.Add("symbolWidth", new ConfigOption("symbolWidth", null, 16, this.SymbolWidth));

                list.Add("useHTML", new ConfigOption("useHTML", null, false, this.UseHTML));

                list.Add("verticalAlign", new ConfigOption("verticalAlign", null, @"bottom", this.VerticalAlign));

                list.Add("width", new ConfigOption("width", null, null, this.Width));

                list.Add("x", new ConfigOption("x", null, 0, this.x));

                list.Add("y", new ConfigOption("y", null, 0, this.y));

                return list;
            }
        }


    
	        private LegendEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public LegendEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new LegendEvents();
					}
			
					return this.events;
				}
			}


    

        /// <summary>
        /// Options for the paging or navigation appearing when the legend is overflown.
        /// </summary>
        public partial class Navigation : Observable
        {

    
            /// <summary>
            /// The color for the active up or down arrow in the legend page navigation.
            /// </summary>
            [ConfigOption("activeColor", null)]
            [DefaultValue(@"#3E576F")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color for the active up or down arrow in the legend page navigation.")]
            public string ActiveColor
            {
                get
                {
                    return this.State.Get<string>("ActiveColor", @"#3E576F");
                }
                set
                {
                    this.State.Set("ActiveColor", value);
                }
            }

            /// <summary>
            /// How to animate the pages when navigating up or down. A value of true applies the default navigation given in  the chart.animation option. Additional options can be given as an object containing values for easing and duration.  .
            /// </summary>
            [ConfigOption("animation", null)]
            [DefaultValue(null)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"How to animate the pages when navigating up or down. A value of true applies the default navigation given in  the chart.animation option. Additional options can be given as an object containing values for easing and duration.  .")]
            public object Animation
            {
                get
                {
                    return this.State.Get<object>("Animation", null);
                }
                set
                {
                    this.State.Set("Animation", value);
                }
            }

            /// <summary>
            /// The pixel size of the up and down arrows in the legend paging navigation.  .
            /// </summary>
            [ConfigOption("arrowSize", null)]
            [DefaultValue(12)]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The pixel size of the up and down arrows in the legend paging navigation.  .")]
            public double? ArrowSize
            {
                get
                {
                    return this.State.Get<double?>("ArrowSize", 12);
                }
                set
                {
                    this.State.Set("ArrowSize", value);
                }
            }

            /// <summary>
            /// The color of the inactive up or down arrow in the legend page navigation.  .
            /// </summary>
            [ConfigOption("inactiveColor", null)]
            [DefaultValue(@"#CCC")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"The color of the inactive up or down arrow in the legend page navigation.  .")]
            public string InactiveColor
            {
                get
                {
                    return this.State.Get<string>("InactiveColor", @"#CCC");
                }
                set
                {
                    this.State.Set("InactiveColor", value);
                }
            }

            /// <summary>
            /// Text styles for the legend page navigation.
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue("")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Text styles for the legend page navigation.")]
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


                list.Add("activeColor", new ConfigOption("activeColor", null, @"#3E576F", this.ActiveColor));

                list.Add("animation", new ConfigOption("animation", null, null, this.Animation));

                list.Add("arrowSize", new ConfigOption("arrowSize", null, 12, this.ArrowSize));

                list.Add("inactiveColor", new ConfigOption("inactiveColor", null, @"#CCC", this.InactiveColor));

                list.Add("style", new ConfigOption("style", null, "", this.Style));

                return list;
            }
        }


    
	        private NavigationEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public NavigationEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new NavigationEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class NavigationEvents : ComponentListeners
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


        /// <summary>
        /// A title to be added on top of the legend.
        /// </summary>
        public partial class Title : Observable
        {

    
            /// <summary>
            /// Generic CSS styles for the legend title.
            /// </summary>
            [ConfigOption("style", null)]
            [DefaultValue(@"{""fontWeight"":""bold""}")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"Generic CSS styles for the legend title.")]
            public string Style
            {
                get
                {
                    return this.State.Get<string>("Style", @"{""fontWeight"":""bold""}");
                }
                set
                {
                    this.State.Set("Style", value);
                }
            }

            /// <summary>
            /// A text or HTML string for the title. 
            /// </summary>
            [ConfigOption("text", null)]
            [DefaultValue(@"null")]
            [NotifyParentProperty(true)]
            [Category("HighChart")]
            [Description(@"A text or HTML string for the title. ")]
            public string Text
            {
                get
                {
                    return this.State.Get<string>("Text", @"null");
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


                list.Add("style", new ConfigOption("style", null, @"{""fontWeight"":""bold""}", this.Style));

                list.Add("text", new ConfigOption("text", null, @"null", this.Text));

                return list;
            }
        }


    
	        private TitleEvents events;

			/// <summary>
			/// Client-side JavaScript Event Handlers
			/// </summary>
			[Meta]
            [ConfigOption("events", JsonMode.Object)]
            [Category("2. Observable")]
            [NotifyParentProperty(true)]
            [PersistenceMode(PersistenceMode.InnerProperty)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
            public TitleEvents Listeners
			{
				get
				{
					if (this.events == null)
					{
						this.events = new TitleEvents();
					}
			
					return this.events;
				}
			}


    

    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class TitleEvents : ComponentListeners
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


    

        /// <summary>
        /// Client Side Events#
        /// </summary>
        public partial class LegendEvents : ComponentListeners
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
            