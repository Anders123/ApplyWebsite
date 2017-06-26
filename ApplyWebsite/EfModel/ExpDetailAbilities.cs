using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExpDetailAbilities
    {
        public int DetailId { get; set; }
        public int AbilitiesId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual OnetAbilities Abilities { get; set; }
        public virtual ExperienceDetail Detail { get; set; }
    }
}
