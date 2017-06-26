using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileSearch
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public string SearchNickname { get; set; }
        public string FMyRecruits { get; set; }
        public string FLastActive { get; set; }
        public double? FPercentComplete { get; set; }
        public int? FWishToWorkNearCityId { get; set; }
        public string FWillRelocate { get; set; }
        public bool Alert { get; set; }
        public DateTime? AlertActiveAt { get; set; }
        public int? FJobTitleId { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
