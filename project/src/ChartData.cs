using System.Collections.Generic;
using System.Linq;

namespace project
{
    public class ChartData
    {
        private List<Metadata> _data = new List<Metadata>();
        public ModelConstraints Constraints { get; }

        public IEnumerable<Metadata> AllMetadata
        {
            get => _data;
            set => _data = value.ToList();
        }
    }
}