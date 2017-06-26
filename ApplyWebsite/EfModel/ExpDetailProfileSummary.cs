using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExpDetailProfileSummary
    {
        public int DetailId { get; set; }
        public int SummaryId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ExperienceDetail Detail { get; set; }
        public virtual ProfileSummary Summary { get; set; }
    }
}
