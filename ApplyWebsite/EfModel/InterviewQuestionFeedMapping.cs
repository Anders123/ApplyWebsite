using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewQuestionFeedMapping
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int AccountId { get; set; }
        public string FeedMapName { get; set; }
        public string FeedNode { get; set; }

        public virtual Account Account { get; set; }
        public virtual InterviewQuestionLibrary Question { get; set; }
    }
}
