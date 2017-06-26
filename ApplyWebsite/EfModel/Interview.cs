using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Interview
    {
        public Interview()
        {
            InterviewQuestion = new HashSet<InterviewQuestion>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public string InterviewName { get; set; }

        public virtual ICollection<InterviewQuestion> InterviewQuestion { get; set; }
        public virtual Account Account { get; set; }
    }
}
