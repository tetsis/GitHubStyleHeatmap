using GitHubStyleHeatmap.ViewData;
using System.Collections.Generic;

namespace GitHubStyleHeatmap.Models
{
    public interface IMainWindowModel
    {
        List<WeekHeatmap> WeekHeatmaps { get; }
        List<string> HeatmapSamples { get; }
    }
}