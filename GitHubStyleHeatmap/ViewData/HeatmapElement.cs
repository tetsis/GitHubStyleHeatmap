namespace GitHubStyleHeatmap.ViewData
{
    public class HeatmapElement
    {
        public HeatmapElement(string color, string comment)
        {
            Color = color;
            Comment = comment;
        }

        public string Color { get; }
        public string Comment { get; }
    }
}
