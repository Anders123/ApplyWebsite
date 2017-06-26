using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class BriefcaseType
    {
        public BriefcaseType()
        {
            Briefcase = new HashSet<Briefcase>();
        }

        public int Id { get; set; }
        public string BriefcaseType1 { get; set; }

        public virtual ICollection<Briefcase> Briefcase { get; set; }
    }
}
