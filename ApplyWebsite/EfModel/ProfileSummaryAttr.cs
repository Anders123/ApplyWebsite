using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileSummaryAttr
    {
        public int Id { get; set; }
        public int ProfileSummaryId { get; set; }
        public int? AttrId { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual ProfileSummary ProfileSummary { get; set; }
    }
}
