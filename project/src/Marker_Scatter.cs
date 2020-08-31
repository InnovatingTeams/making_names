using System.Collections.Generic;
using System.Linq;
using ApprovalUtilities.Utilities;

namespace project
{
    public class Marker_Scatter : MarkProvider
    {
        public void probably_DrawMarks_AndStuff(DC ctx,
            Canvas canvas,
            ChartData data,
            List<DataSource> sources,
            ChartInfo info,
            ChartData chartData)
        {
            chartData.AllMetadata
                .SelectMany(m => 
                    m.Source.FetchData(
                        SampleTheData(m)))
                .ForEach(p => DrawMark(p));
        }

        private void DrawMark(DataItem point)
        {
            throw new System.NotImplementedException();
        }

        private Filter SampleTheData(Metadata metadata)
        {
            return true;
        }
    }
}