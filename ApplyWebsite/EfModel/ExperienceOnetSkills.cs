using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceOnetSkills
    {
        public int ExperienceId { get; set; }
        public int SkillsId { get; set; }
        public int DisplayRank { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Experience Experience { get; set; }
        public virtual OnetSkills Skills { get; set; }
    }
}
