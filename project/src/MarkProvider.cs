using System.Collections.Generic;

namespace project
{
    public interface MarkProvider
    {
        void probably_DrawMarks_AndReplaceMarksAndDoDistributedAnalysisAndPotentiallyOtherStuffAcrossAllDataSources(DC ctx,
            Canvas canvas,
            ChartData data,
            List<DataSource> sources,
            ChartInfo info,
            ChartData chartData);
    }
}