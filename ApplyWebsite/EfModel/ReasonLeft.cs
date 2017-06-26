using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ReasonLeft
    {
        public ReasonLeft()
        {
            ExperienceReasonLeft = new HashSet<ExperienceReasonLeft>();
        }

        public int Id { get; set; }
        public string ReasonLeft1 { get; set; }
        public string ReasonLeftNotes { get; set; }

        public virtual ICollection<ExperienceReasonLeft> ExperienceReasonLeft { get; set; }
    }
}
