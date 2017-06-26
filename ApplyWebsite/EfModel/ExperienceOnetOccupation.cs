using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceOnetOccupation
    {
        public int ExperienceId { get; set; }
        public int OnetId { get; set; }
        public int DisplayRank { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Experience Experience { get; set; }
        public virtual OnetOccupationData Onet { get; set; }
    }
}
