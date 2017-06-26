using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class FeedMappingColumn
    {
        public FeedMappingColumn()
        {
            FeedMapping = new HashSet<FeedMapping>();
        }

        public int Id { get; set; }
        public string ColumnName { get; set; }

        public virtual ICollection<FeedMapping> FeedMapping { get; set; }
    }
}
