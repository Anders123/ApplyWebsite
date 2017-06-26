using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileIndustry
    {
        public int ProfileId { get; set; }
        public int IndustryId { get; set; }

        public virtual Industry Industry { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
