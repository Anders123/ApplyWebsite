using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskPhaseHint
    {
        public int Id { get; set; }
        public int PhaseId { get; set; }
        public string HintText { get; set; }
        public int HintRank { get; set; }

        public virtual TaskPhase Phase { get; set; }
    }
}
