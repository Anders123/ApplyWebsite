using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class SuggestionReference
    {
        public int Id { get; set; }
        public int SuggestionId { get; set; }
        public int ReferenceId { get; set; }

        public virtual ReviewSuggestion Suggestion { get; set; }
    }
}
