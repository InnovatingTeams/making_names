using System.Collections.Generic;

namespace project
{
    public class DataSource_MySql : DataSource
    {
        public Metadata FetchMetadata(ModelConstraints dataConstraints)
        {
            throw new System.NotImplementedException();
        }

        public void DrawNotes(DC ctx, Canvas canvas, IEnumerable<Metadata> metadata)
        {
            throw new System.NotImplementedException();
        }

        public void AccountForOtherProviders(IEnumerable<Metadata> metadata)
        {
            throw new System.NotImplementedException();
        }
    }
}