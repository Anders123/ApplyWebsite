using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewQuestionCategory
    {
        public InterviewQuestionCategory()
        {
            InterviewQuestionLibrary = new HashSet<InterviewQuestionLibrary>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int CategoryRank { get; set; }

        public virtual ICollection<InterviewQuestionLibrary> InterviewQuestionLibrary { get; set; }
    }
}
