using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class SuggestionAdditionalInfo
    {
        public int Id { get; set; }
        public int SuggestionId { get; set; }
        public int AdditionalInfoId { get; set; }

        public virtual ProfileAdditionalInfo AdditionalInfo { get; set; }
        public virtual ReviewSuggestion Suggestion { get; set; }
    }
}
