using GitHubStyleHeatmap.Models;
using GitHubStyleHeatmap.ViewData;
using Prism.Mvvm;
using System.Collections.Generic;

namespace GitHubStyleHeatmap.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IMainWindowModel _mainWindowModel;

        public MainWindowViewModel(
            IMainWindowModel mainWindowModel)
        {
            _mainWindowModel = mainWindowModel;

            WeekHeatmaps = _mainWindowModel.WeekHeatmaps;
            HeatmapSamples = _mainWindowModel.HeatmapSamples;
        }

        public List<WeekHeatmap> WeekHeatmaps { get; }
        public List<string> HeatmapSamples { get; }
    }
}
