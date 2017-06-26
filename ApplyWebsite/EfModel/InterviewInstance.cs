using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewInstance
    {
        public InterviewInstance()
        {
            InterviewAnswer = new HashSet<InterviewAnswer>();
            InterviewInstanceBriefcase = new HashSet<InterviewInstanceBriefcase>();
        }

        public int Id { get; set; }
        public int? ProfileId { get; set; }
        public DateTime InterviewAt { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public DateTime? AbandonedAt { get; set; }

        public virtual ICollection<InterviewAnswer> InterviewAnswer { get; set; }
        public virtual ICollection<InterviewInstanceBriefcase> InterviewInstanceBriefcase { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
