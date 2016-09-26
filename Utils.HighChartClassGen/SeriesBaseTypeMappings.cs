using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.HighChartClassGen
{
    public static class SeriesBaseTypeMappings
    {
        /// <summary>
        /// Maps between the series types of highcharts and our Wrappers for Chart.ux.HighCharts
        /// </summary>
        public static Dictionary<string, string> Mappings = new Dictionary<string, string>()
        {
            {"default", "Series"},
            {"area", "BaseAreaSerie"},
            {"arearange", "BaseAreaRangeSerie"},
            {"areasplinerange", "BaseAreaSplineRangeSerie"},
            {"bar", "BaseBarSerie"},
            {"boxplot", "BaseBoxPlotSerie"},
            {"bubble", "BaseBubbleSerie"},
            {"column", "BaseColumnSerie"},
            {"columnrange", "BaseColumnRangeSerie"},
            {"errorbar", "BaseErrorBarSerie"},
            {"funnel", "BaseFunnelSerie"},
            {"gauge", "BaseGaugeSerie"},
            {"heatmap", "BaseHeatmapSerie"},
            {"line", "BaseLineSerie"},
            {"pie", "BasePieSerie"},
            {"polygon", "Series"},
            {"pyramid", "BasePyramidSerie"},
            {"scatter", "BaseScatterSerie"},
            {"solidgauge", "BaseSolidGaugeSerie"},
            {"spline", "BaseSplineSerie"},
            {"treemap", "Series"},
            {"waterfall", "BaseWaterfallSerie"},
            {"series", "BaseSerie"},
        };

        public static string GetMappingForSeries(string name)
        {
            if (Mappings.ContainsKey(name))
                return Mappings[name];
            else
                return Mappings["default"];
        }
    }
}
