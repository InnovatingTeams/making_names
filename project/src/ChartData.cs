using System.Collections.Generic;
using System.Linq;

namespace project
{
    public class ChartData
    {
        private List<DataItem> _data = new List<DataItem>();
        public ModelConstraints Constraints { get; }

        public IEnumerable<DataItem> CachedDataPoints
        {
            get => _data;
            set => _data = value.ToList();
        }
    }
}