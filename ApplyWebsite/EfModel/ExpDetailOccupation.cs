using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExpDetailOccupation
    {
        public int DetailId { get; set; }
        public int OnetId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ExperienceDetail Detail { get; set; }
        public virtual OnetOccupationData Onet { get; set; }
    }
}
