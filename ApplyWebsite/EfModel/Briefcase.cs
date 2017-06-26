using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Briefcase
    {
        public Briefcase()
        {
            BriefcasePost = new HashSet<BriefcasePost>();
            BriefcasePostListing = new HashSet<BriefcasePostListing>();
            InterviewInstanceBriefcase = new HashSet<InterviewInstanceBriefcase>();
        }

        public int Id { get; set; }
        public int BriefcaseTypeId { get; set; }
        public int PersonId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<BriefcasePost> BriefcasePost { get; set; }
        public virtual ICollection<BriefcasePostListing> BriefcasePostListing { get; set; }
        public virtual ICollection<InterviewInstanceBriefcase> InterviewInstanceBriefcase { get; set; }
        public virtual BriefcaseType BriefcaseType { get; set; }
    }
}
