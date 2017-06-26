using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewQuestionType
    {
        public InterviewQuestionType()
        {
            InterviewQuestionLibrary = new HashSet<InterviewQuestionLibrary>();
        }

        public int Id { get; set; }
        public string QuestionTypeName { get; set; }

        public virtual ICollection<InterviewQuestionLibrary> InterviewQuestionLibrary { get; set; }
    }
}
