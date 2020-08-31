using System.Collections.Generic;

namespace project
{
    public interface DataSource
    {
        IEnumerable<DataItem> FetchBasicData(ModelConstraints dataConstraints);
        void DrawNotes(DC ctx, Canvas canvas, IEnumerable<DataItem> allData);
    }
}