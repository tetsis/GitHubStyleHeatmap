using System;
using System.Collections.Generic;

namespace GitHubStyleHeatmap.ViewData
{
    public class WeekHeatmap
    {
        public WeekHeatmap(List<HeatmapElement> heatmapElements)
        {
            if (heatmapElements.Count > 7) throw new ArgumentOutOfRangeException(nameof(heatmapElements), "ヒートマップの数が7を超えています。");
            HeatmapElements = heatmapElements;
        }

        public List<HeatmapElement> HeatmapElements { get; }
    }
}
