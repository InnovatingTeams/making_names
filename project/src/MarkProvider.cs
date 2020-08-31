using System.Collections.Generic;

namespace project
{
    public interface MarkProvider
    {
        void probably_DrawMarks_AndStuff(DC ctx, Canvas canvas, ChartData data, List<DataSource> providers,
            ChartInfo info, ChartData chartData);
    }
}