using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceReasonLeft
    {
        public int Id { get; set; }
        public int ExperienceId { get; set; }
        public int ReasonLeftId { get; set; }

        public virtual Experience Experience { get; set; }
        public virtual ReasonLeft ReasonLeft { get; set; }
    }
}
