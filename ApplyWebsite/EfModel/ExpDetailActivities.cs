using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExpDetailActivities
    {
        public int DetailId { get; set; }
        public int ActivitiesId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual OnetWorkActivities Activities { get; set; }
        public virtual ExperienceDetail Detail { get; set; }
    }
}
