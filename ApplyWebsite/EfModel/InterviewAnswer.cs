using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class InterviewAnswer
    {
        public int Id { get; set; }
        public int InstanceId { get; set; }
        public int QuestionId { get; set; }
        public bool? YesNoAnswer { get; set; }
        public int? AttrAnswerId { get; set; }
        public string StringAnswer { get; set; }
        public int? IntAnswer { get; set; }
        public DateTime? DateAnswer { get; set; }

        public virtual Attr AttrAnswer { get; set; }
        public virtual InterviewInstance Instance { get; set; }
        public virtual InterviewQuestionLibrary Question { get; set; }
    }
}
