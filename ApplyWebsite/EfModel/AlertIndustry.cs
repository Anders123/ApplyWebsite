using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AlertIndustry
    {
        public int Id { get; set; }
        public int AlertId { get; set; }
        public int? IndustryId { get; set; }

        public virtual Alert Alert { get; set; }
        public virtual Industry Industry { get; set; }
    }
}
