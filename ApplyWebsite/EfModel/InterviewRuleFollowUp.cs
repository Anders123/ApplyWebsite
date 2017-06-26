using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewRuleFollowUp
    {
        public int RuleId { get; set; }
        public int Questionid { get; set; }

        public virtual InterviewQuestionLibrary Question { get; set; }
        public virtual InterviewQuestionRule Rule { get; set; }
    }
}
