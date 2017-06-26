using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AttrIndustry
    {
        public int Id { get; set; }
        public int? AttrId { get; set; }
        public int? IndustryId { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual Industry Industry { get; set; }
    }
}
