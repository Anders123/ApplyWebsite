using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ReviewSuggestion
    {
        public ReviewSuggestion()
        {
            SuggestionAdditionalInfo = new HashSet<SuggestionAdditionalInfo>();
            SuggestionExperienceDetail = new HashSet<SuggestionExperienceDetail>();
            SuggestionReference = new HashSet<SuggestionReference>();
        }

        public int Id { get; set; }
        public int ReviewId { get; set; }
        public string SuggestionOn { get; set; }
        public string Suggestion { get; set; }
        public DateTime SuggestionAt { get; set; }
        public string CommentOnSuggestion { get; set; }
        public string ReplacedText { get; set; }
        public string AcceptReject { get; set; }
        public DateTime? AcceptedRejectedAt { get; set; }
        public DateTime? SuggestionWithdrawn { get; set; }

        public virtual ICollection<SuggestionAdditionalInfo> SuggestionAdditionalInfo { get; set; }
        public virtual ICollection<SuggestionExperienceDetail> SuggestionExperienceDetail { get; set; }
        public virtual ICollection<SuggestionReference> SuggestionReference { get; set; }
        public virtual Review Review { get; set; }
    }
}
