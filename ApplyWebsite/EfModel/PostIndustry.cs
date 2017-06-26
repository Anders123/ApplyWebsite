using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostIndustry
    {
        public int PostId { get; set; }
        public int IndustryId { get; set; }

        public virtual Industry Industry { get; set; }
        public virtual Post Post { get; set; }
    }
}
