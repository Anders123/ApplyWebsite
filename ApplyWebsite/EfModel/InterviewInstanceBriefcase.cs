using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewInstanceBriefcase
    {
        public int BriefcaseId { get; set; }
        public int InstanceId { get; set; }

        public virtual Briefcase Briefcase { get; set; }
        public virtual InterviewInstance Instance { get; set; }
    }
}
