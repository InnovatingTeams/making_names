using System.Collections.Generic;
using System.Linq;

namespace project
{
    // ReSharper disable once UnusedType.Global
    public class ChartDisplay
    {
        // ReSharper disable once UnusedMember.Global
        public static void probably_DrawChart_AndNothingMore(
            DC ctx,
            Canvas canvas,
            List<DataSource> providers,
            List<MarkProvider> markers,
            ChartInfo info,
            ChartData data)
        {
            probably_DrawBackgroundAndLayOutAreas_AndDirectlyDrawOtherChartInfoButNotText(ctx, canvas, info);
            probably_AskProvidersForDataContextInfo_AndStuffUsingRestApisAndDatabasesAndOtherDataSources(ctx, canvas, data, providers);
            probably_DrawAxes_AndDirectlyDrawOtherData(ctx, canvas, data);
            markers.ForEach(m =>
                m.probably_DrawMarks_AndStuff(ctx, canvas, data, providers, info, data));
            probably_AddTextForTitlesAndAxisLabels_AndDirectlyDrawOtherChartInfo(ctx, canvas, info);
            probably_AddTextForDataLabels_AndDirectlyDrawOtherData(ctx, canvas, data);
        }

        private static void probably_AskProvidersForDataContextInfo_AndStuffUsingRestApisAndDatabasesAndOtherDataSources(
            DC ctx,
            Canvas canvas,
            ChartData data,
            List<DataSource> providers)
        {
            data.AllMetadata = providers.Select(source => source.FetchMetadata(data.Constraints));
            providers.ForEach(p => p.AccountForOtherProviders(data.AllMetadata));
            providers.ForEach(p => p.DrawNotes(ctx, canvas, data.AllMetadata));
        }

        private static void probably_AddTextForDataLabels_AndDirectlyDrawOtherData(DC ctx, Canvas canvas, ChartData data)
        {
            throw new System.NotImplementedException();
        }

        private static void probably_AddTextForTitlesAndAxisLabels_AndDirectlyDrawOtherChartInfo(DC ctx, Canvas canvas, ChartInfo info)
        {
            throw new System.NotImplementedException();
        }

        private static void probably_DrawAxes_AndDirectlyDrawOtherData(DC ctx, Canvas canvas, ChartData data)
        {
            throw new System.NotImplementedException();
        }

        private static void probably_DrawBackgroundAndLayOutAreas_AndDirectlyDrawOtherChartInfoButNotText(DC ctx, Canvas canvas,
            ChartInfo info)
        {
            throw new System.NotImplementedException();
        }
    }
}