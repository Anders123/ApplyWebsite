using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ThemeIndustry
    {
        public int ThemeId { get; set; }
        public int IndustryId { get; set; }

        public virtual Industry Industry { get; set; }
        public virtual Theme Theme { get; set; }
    }
}
