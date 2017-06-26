using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewQuestionRule
    {
        public InterviewQuestionRule()
        {
            InterviewRuleFollowUp = new HashSet<InterviewRuleFollowUp>();
        }

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string RuleName { get; set; }
        public int RuleTypeId { get; set; }
        public int RuleValueId { get; set; }
        public string RuleMessage { get; set; }
        public bool SetAsDefault { get; set; }
        public bool YesNoAnswer { get; set; }
        public int? AttrAnswerId { get; set; }
        public int? AttrAnswerIdMax { get; set; }
        public int IntAnswer { get; set; }
        public int? IntAnswerMax { get; set; }
        public DateTime? DateAnswer { get; set; }
        public DateTime? DateAnswerMax { get; set; }

        public virtual ICollection<InterviewRuleFollowUp> InterviewRuleFollowUp { get; set; }
        public virtual Attr AttrAnswer { get; set; }
        public virtual Attr AttrAnswerIdMaxNavigation { get; set; }
        public virtual InterviewQuestionLibrary Question { get; set; }
        public virtual InterviewQuestionRuleType RuleType { get; set; }
        public virtual InterviewQuestionRuleValue RuleValue { get; set; }
    }
}
