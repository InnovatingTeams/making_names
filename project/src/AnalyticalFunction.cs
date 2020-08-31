using System.Collections.Generic;
using System.Data;

namespace project
{
    internal class AnalyticalFunction
    {
        public AbstractQuery PartialComputationFor(Metadata metadata)
        {
            throw new System.NotImplementedException();
        }

        public AnalyticalResult ComputeFinalResult(IEnumerable<DataTable> partialResults)
        {
            throw new System.NotImplementedException();
        }
    }
}