using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Review
    {
        public Review()
        {
            ProfileReferral = new HashSet<ProfileReferral>();
            ReviewSuggestion = new HashSet<ReviewSuggestion>();
        }

        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int ReviewerId { get; set; }
        public DateTime ReviewStarted { get; set; }
        public DateTime? ReviewComplete { get; set; }
        public string ReviewType { get; set; }
        public int? OutputFormatId { get; set; }
        public bool AllowSharing { get; set; }
        public bool AllowAccess { get; set; }

        public virtual ICollection<ProfileReferral> ProfileReferral { get; set; }
        public virtual ICollection<ReviewSuggestion> ReviewSuggestion { get; set; }
        public virtual ProfileOutputFormat OutputFormat { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Person Reviewer { get; set; }
    }
}
