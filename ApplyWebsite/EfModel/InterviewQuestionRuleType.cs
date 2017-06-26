using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewQuestionRuleType
    {
        public InterviewQuestionRuleType()
        {
            InterviewQuestionRule = new HashSet<InterviewQuestionRule>();
        }

        public int Id { get; set; }
        public string RuleTypeName { get; set; }

        public virtual ICollection<InterviewQuestionRule> InterviewQuestionRule { get; set; }
    }
}
