using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class FeedControl
    {
        public FeedControl()
        {
            FeedBatch = new HashSet<FeedBatch>();
            FeedControlAccount = new HashSet<FeedControlAccount>();
            FeedMapping = new HashSet<FeedMapping>();
            FeedProperty = new HashSet<FeedProperty>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool LastCommSuccessful { get; set; }
        public bool LastTaskCompleted { get; set; }
        public DateTime? TaskCompletedDate { get; set; }
        public int ExceptionCount { get; set; }
        public bool AutomaticFeed { get; set; }
        public bool ActiveFeed { get; set; }
        public DateTime CrDt { get; set; }
        public string CrBy { get; set; }
        public DateTime MdDt { get; set; }
        public string MdBy { get; set; }

        public virtual ICollection<FeedBatch> FeedBatch { get; set; }
        public virtual ICollection<FeedControlAccount> FeedControlAccount { get; set; }
        public virtual ICollection<FeedMapping> FeedMapping { get; set; }
        public virtual ICollection<FeedProperty> FeedProperty { get; set; }
    }
}
