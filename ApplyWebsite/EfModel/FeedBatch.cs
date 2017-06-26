using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class FeedBatch
    {
        public FeedBatch()
        {
            FeedException = new HashSet<FeedException>();
            FeedLog = new HashSet<FeedLog>();
        }

        public int Id { get; set; }
        public int FeedControlId { get; set; }
        public DateTime CrDt { get; set; }
        public string CrBy { get; set; }
        public DateTime MdDt { get; set; }
        public string MdBy { get; set; }

        public virtual ICollection<FeedException> FeedException { get; set; }
        public virtual ICollection<FeedLog> FeedLog { get; set; }
        public virtual FeedControl FeedControl { get; set; }
    }
}
