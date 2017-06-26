using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExpDetailSkills
    {
        public int DetailId { get; set; }
        public int SkillsId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ExperienceDetail Detail { get; set; }
        public virtual OnetSkills Skills { get; set; }
    }
}
