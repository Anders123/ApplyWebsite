using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class FeedLog
    {
        public FeedLog()
        {
            FeedLogProperty = new HashSet<FeedLogProperty>();
        }

        public int Id { get; set; }
        public int FeedBatchId { get; set; }
        public DateTime CrDt { get; set; }
        public string CrBy { get; set; }
        public DateTime MdDt { get; set; }
        public string MdBy { get; set; }

        public virtual ICollection<FeedLogProperty> FeedLogProperty { get; set; }
        public virtual FeedBatch FeedBatch { get; set; }
    }
}
