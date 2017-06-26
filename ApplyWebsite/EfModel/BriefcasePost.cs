using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class BriefcasePost
    {
        public int BriefcaseId { get; set; }
        public int PostId { get; set; }
        public bool PrimaryApply { get; set; }

        public virtual Briefcase Briefcase { get; set; }
        public virtual Post Post { get; set; }
    }
}
