using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ApprovalUtilities.Utilities;

namespace project
{
    public class Marker_Legend : MarkProvider
    {
        public void probably_DrawMarks_AndReplaceMarksAndDoDistributedAnalysisAndPotentiallyOtherStuffAcrossAllDataSources(
            DC ctx,
            Canvas canvas,
            ChartData data,
            List<DataSource> sources,
            ChartInfo info,
            ChartData chartData)
        {
            var legendMetrics = CalculateTotalMetrics(info, chartData.AllMetadata);
            foreach (var metadata in chartData.AllMetadata)
            {
                var name = GetName(metadata);
                var metrics = CalculateMetrics(info, legendMetrics, metadata);
                var style = CalculateStyle(metadata);
                DrawLegendEntry(ctx, canvas, name, metrics, style, legendMetrics);
            }

            DrawLegendBorder(ctx, canvas, legendMetrics);
        }

        private void DrawLegendBorder(DC ctx, Canvas canvas, DrawingMetrics legendMetrics)
        {
            throw new System.NotImplementedException();
        }

        private void DrawLegendEntry(DC ctx, Canvas canvas, string name, DrawingMetrics metrics, DrawingStyleInfo style,
            DrawingMetrics legendMetrics)
        {
            throw new System.NotImplementedException();
        }

        private DrawingStyleInfo CalculateStyle(Metadata metadata)
        {
            throw new System.NotImplementedException();
        }

        private class DrawingStyleInfo
        {
        }

        private string GetName(Metadata metadata)
        {
            throw new System.NotImplementedException();
        }

        private DrawingMetrics CalculateMetrics(ChartInfo info, DrawingMetrics legendMetrics, Metadata metadata)
        {
            throw new System.NotImplementedException();
        }

        private DrawingMetrics CalculateTotalMetrics(ChartInfo info, IEnumerable<Metadata> chartDataAllMetadata)
        {
            throw new System.NotImplementedException();
        }

        private class DrawingMetrics
        {
        }
    }
}