using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceOnetAbilities
    {
        public int ExperienceId { get; set; }
        public int AbilitiesId { get; set; }
        public int DisplayRank { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual OnetAbilities Abilities { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
