using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class SuggestionExperienceDetail
    {
        public int Id { get; set; }
        public int SuggestionId { get; set; }
        public int DetailId { get; set; }

        public virtual ExperienceDetail Detail { get; set; }
        public virtual ReviewSuggestion Suggestion { get; set; }
    }
}
