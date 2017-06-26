using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewQuestionLibrary
    {
        public InterviewQuestionLibrary()
        {
            InterviewAnswer = new HashSet<InterviewAnswer>();
            InterviewQuestion = new HashSet<InterviewQuestion>();
            InterviewQuestionFeedMapping = new HashSet<InterviewQuestionFeedMapping>();
            InterviewQuestionRule = new HashSet<InterviewQuestionRule>();
            InterviewRuleFollowUp = new HashSet<InterviewRuleFollowUp>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public string QuestionTitle { get; set; }
        public int QuestionCategoryId { get; set; }
        public string QuestionText { get; set; }
        public int QuestionTypeId { get; set; }
        public int? MultipleChoiceId { get; set; }
        public bool AnswerRequired { get; set; }
        public int QuestionRank { get; set; }

        public virtual ICollection<InterviewAnswer> InterviewAnswer { get; set; }
        public virtual ICollection<InterviewQuestion> InterviewQuestion { get; set; }
        public virtual ICollection<InterviewQuestionFeedMapping> InterviewQuestionFeedMapping { get; set; }
        public virtual ICollection<InterviewQuestionRule> InterviewQuestionRule { get; set; }
        public virtual ICollection<InterviewRuleFollowUp> InterviewRuleFollowUp { get; set; }
        public virtual Account Account { get; set; }
        public virtual Attr MultipleChoice { get; set; }
        public virtual InterviewQuestionCategory QuestionCategory { get; set; }
        public virtual InterviewQuestionType QuestionType { get; set; }
    }
}
