using System.Collections.Generic;
using System.Data;

namespace project
{
    public interface DataSource
    {
        Metadata FetchMetadata(ModelConstraints dataConstraints);
        void DrawNotes(DC ctx, Canvas canvas, IEnumerable<Metadata> metadata);
        void AccountForOtherProviders(IEnumerable<Metadata> metadata);
        IEnumerable<DataItem> FetchData(Filter filterInfo);
        DataTable EvaluateWithResults(AbstractQuery partialComputationFor);
    }
}