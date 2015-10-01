using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ext.Net;

namespace Ext.ux.Highcharts.Config
{
    public class TitleConfig : BaseItem
    {
        [ConfigOption]
        [DefaultValue("center")]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The horizontal alignment of the title. Can be one of \"left\", \"center\" and \"right\". Defaults to center.")]
        public virtual string Align
        {
            get
            {
                object obj = this.ViewState["Align"];
                return obj != null ? (string)obj : "center";
            }
            set
            {
                this.ViewState["Align"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("When the title is floating, the plot area will not move to make space for it. Defaults to false.")]
        public virtual bool Floating
        {
            get
            {
                object obj = this.ViewState["Floating"];
                return obj != null ? (bool)obj : false;
            }
            set
            {
                this.ViewState["Floating"] = value;
            }
        }


        [ConfigOption]
        [DefaultValue(15)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The margin between the title and the plot area, or if a subtitle is present, the margin between the subtitle and the plot area. Defaults to 15.")]
        public virtual int Margin
        {
            get
            {
                object obj = this.ViewState["Margin"];
                return obj != null ? (int)obj : 15;
            }
            set
            {
                this.ViewState["Margin"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(null)]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The title of the chart. To disable the title, set the text to null. Defaults to Chart title.")]
        public virtual string Text
        {
            get
            {
                object obj = this.ViewState["Text"];
                return obj != null ? (string)obj : null;
            }
            set
            {
                this.ViewState["Text"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(false)]
        [NotifyParentProperty(false)]
        [Category("HighChart")]
        [Description("Whether to use HTML to render the text. Defaults to false.")]
        public virtual bool UseHtml
        {
            get
            {
                object obj = this.ViewState["UseHtml"];
                return obj != null ? (bool)obj : false;
            }
            set
            {
                this.ViewState["UseHtml"] = value;
            }
        }

        [ConfigOption]
        [DefaultValue(".")]
        [NotifyParentProperty(true)]
        [Category("HighChart")]
        [Description("The vertical alignment of the title. Can be one of \"top\", \"middle\" and \"bottom\". When a value is given, the title behaves as floating. Defaults to .")]
        public virtual string VerticalAlign
        {
            get
            {
                object obj = this.ViewState["VerticalAlign"];
                return obj != null ? (string)obj : null;
            }
            set
            {
                this.ViewState["VerticalAlign"] = value;
            }
        }

    }
}
