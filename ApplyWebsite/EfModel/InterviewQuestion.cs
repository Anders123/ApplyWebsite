using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewQuestion
    {
        public int Id { get; set; }
        public int InterviewId { get; set; }
        public int QuestionId { get; set; }
        public int QuestionRank { get; set; }

        public virtual Interview Interview { get; set; }
        public virtual InterviewQuestionLibrary Question { get; set; }
    }
}
