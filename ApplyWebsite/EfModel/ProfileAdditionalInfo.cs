using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileAdditionalInfo
    {
        public ProfileAdditionalInfo()
        {
            SuggestionAdditionalInfo = new HashSet<SuggestionAdditionalInfo>();
        }

        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string InfoTitle { get; set; }
        public string InfoDescription { get; set; }
        public bool HideAdditionalInfo { get; set; }
        public int? AdditionalInfoRank { get; set; }

        public virtual ICollection<SuggestionAdditionalInfo> SuggestionAdditionalInfo { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
