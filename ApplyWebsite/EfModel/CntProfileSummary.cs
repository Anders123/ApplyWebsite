using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntProfileSummary
    {
        public int SummaryId { get; set; }
        public int Cnt { get; set; }

        public virtual ProfileSummary Summary { get; set; }
    }
}
