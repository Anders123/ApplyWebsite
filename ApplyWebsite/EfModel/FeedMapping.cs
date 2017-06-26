using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class FeedMapping
    {
        public int Id { get; set; }
        public int ControlId { get; set; }
        public string MappingName { get; set; }
        public int MappingColumnId { get; set; }
        public int MappingRank { get; set; }

        public virtual FeedControl Control { get; set; }
        public virtual FeedMappingColumn MappingColumn { get; set; }
    }
}
