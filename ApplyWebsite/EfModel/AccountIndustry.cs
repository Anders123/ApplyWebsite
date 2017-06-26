using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountIndustry
    {
        public int AccountId { get; set; }
        public int IndustryId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Industry Industry { get; set; }
    }
}
