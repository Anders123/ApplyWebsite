using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskPhase
    {
        public TaskPhase()
        {
            ActivtyTaskPhase = new HashSet<ActivtyTaskPhase>();
            Task = new HashSet<Task>();
            TaskPhaseAttr = new HashSet<TaskPhaseAttr>();
            TaskPhaseHint = new HashSet<TaskPhaseHint>();
        }

        public int Id { get; set; }
        public string PhaseName { get; set; }
        public string PhaseDescription { get; set; }
        public string PhaseShortDescription { get; set; }
        public int PhaseRank { get; set; }
        public int? AssetId { get; set; }

        public virtual ICollection<ActivtyTaskPhase> ActivtyTaskPhase { get; set; }
        public virtual ICollection<Task> Task { get; set; }
        public virtual ICollection<TaskPhaseAttr> TaskPhaseAttr { get; set; }
        public virtual ICollection<TaskPhaseHint> TaskPhaseHint { get; set; }
        public virtual Asset Asset { get; set; }
    }
}
