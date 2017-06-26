using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceOnetActivities
    {
        public int ExperienceId { get; set; }
        public int ActivitiesId { get; set; }
        public int DisplayRank { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual OnetWorkActivities Activities { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
