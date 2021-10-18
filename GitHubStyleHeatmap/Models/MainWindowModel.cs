using GitHubStyleHeatmap.ViewData;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubStyleHeatmap.Models
{
    public class MainWindowModel : IMainWindowModel
    {
        public MainWindowModel()
        {
            WeekHeatmaps = new List<WeekHeatmap>
            {
                new WeekHeatmap(new List<HeatmapElement>
                {
                    null,
                    null,
                    null,
                    null,
                    null,
                    new HeatmapElement(HeatmapColors.Value[0], "2021/10/01, No achivement"),
                    new HeatmapElement(HeatmapColors.Value[1], "2021/10/02, 1 achivement"),
                }),
                new WeekHeatmap(new List<HeatmapElement>
                {
                    new HeatmapElement(HeatmapColors.Value[2], "2021/10/03, 2 achivements"),
                    new HeatmapElement(HeatmapColors.Value[3], "2021/10/04, 3 achivements"),
                    new HeatmapElement(HeatmapColors.Value[4], "2021/10/05, 4 achivements"),
                    new HeatmapElement(HeatmapColors.Value[0], "2021/10/06, No achivement"),
                    new HeatmapElement(HeatmapColors.Value[0], "2021/10/07, No achivement"),
                    new HeatmapElement(HeatmapColors.Value[0], "2021/10/08, No achivement"),
                    new HeatmapElement(HeatmapColors.Value[1], "2021/10/09, 1 achivement"),
                }),
                new WeekHeatmap(new List<HeatmapElement>
                {
                    new HeatmapElement(HeatmapColors.Value[1], "2021/10/10, 1 achivement"),
                    new HeatmapElement(HeatmapColors.Value[0], "2021/10/11, No achivement"),
                    new HeatmapElement(HeatmapColors.Value[4], "2021/10/12, 4 achivements"),
                    new HeatmapElement(HeatmapColors.Value[1], "2021/10/13, 1 achivement"),
                    new HeatmapElement(HeatmapColors.Value[0], "2021/10/14, No achivement"),
                    new HeatmapElement(HeatmapColors.Value[0], "2021/10/15, No achivement"),
                    new HeatmapElement(HeatmapColors.Value[2], "2021/10/16, 2 achivements"),
                }),
                new WeekHeatmap(new List<HeatmapElement>
                {
                    new HeatmapElement(HeatmapColors.Value[0], "2021/10/17, No achivement"),
                    new HeatmapElement(HeatmapColors.Value[2], "2021/10/18, 2 achivements"),
                    new HeatmapElement(HeatmapColors.Value[3], "2021/10/19, 3 achivements"),
                    new HeatmapElement(HeatmapColors.Value[2], "2021/10/20, 2 achivements"),
                    new HeatmapElement(HeatmapColors.Value[4], "2021/10/21, 4 achivements"),
                })
            };

            HeatmapSamples = HeatmapColors.Value;
        }

        public List<WeekHeatmap> WeekHeatmaps { get; }

        public List<string> HeatmapSamples { get; }
    }
}
