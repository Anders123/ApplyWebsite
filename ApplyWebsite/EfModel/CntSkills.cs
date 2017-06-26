using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntSkills
    {
        public int SkillId { get; set; }
        public int Cnt { get; set; }

        public virtual OnetSkills Skill { get; set; }
    }
}
