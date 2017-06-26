using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ActivtyTaskPhase
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int PhaseId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual TaskPhase Phase { get; set; }
    }
}
