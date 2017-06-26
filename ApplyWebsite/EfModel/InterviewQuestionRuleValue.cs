using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewQuestionRuleValue
    {
        public InterviewQuestionRuleValue()
        {
            InterviewQuestionRule = new HashSet<InterviewQuestionRule>();
        }

        public int Id { get; set; }
        public string RuleValueName { get; set; }

        public virtual ICollection<InterviewQuestionRule> InterviewQuestionRule { get; set; }
    }
}
