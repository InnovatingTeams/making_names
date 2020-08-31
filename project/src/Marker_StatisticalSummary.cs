using System.Collections.Generic;
using System.Linq;
using ApprovalUtilities.Utilities;

namespace project
{
    public class Marker_StatisticalSummary : MarkProvider
    {
        private AnalyticalFunction analysis;

        public void probably_DrawMarks_AndStuff(DC ctx,
            Canvas canvas,
            ChartData data,
            List<DataSource> sources,
            ChartInfo info,
            ChartData chartData)
        {
            var partialResults = chartData.AllMetadata
                .Select(m =>
                    m.Source.EvaluateWithResults(
                        analysis.PartialComputationFor(m)));
            var finalResult = analysis.ComputeFinalResult(partialResults);
            DrawMarks(ctx, canvas, finalResult);
        }

        private void DrawMarks(DC ctx, Canvas canvas, AnalyticalResult finalResult)
        {
            throw new System.NotImplementedException();
        }
    }
}