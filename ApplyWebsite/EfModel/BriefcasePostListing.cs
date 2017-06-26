using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class BriefcasePostListing
    {
        public int BriefcaseId { get; set; }
        public int PostId { get; set; }
        public int ListingId { get; set; }
        public bool PrimaryApply { get; set; }

        public virtual Briefcase Briefcase { get; set; }
        public virtual Listing Listing { get; set; }
        public virtual Post Post { get; set; }
    }
}
