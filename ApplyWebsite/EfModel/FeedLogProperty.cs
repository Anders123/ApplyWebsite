using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class FeedLogProperty
    {
        public int Id { get; set; }
        public int FeedLogId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }
        public DateTime CrDt { get; set; }
        public string CrBy { get; set; }
        public DateTime MdDt { get; set; }
        public string MdBy { get; set; }

        public virtual FeedLog FeedLog { get; set; }
    }
}
