using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Task
    {
        public Task()
        {
            ActivityTask = new HashSet<ActivityTask>();
            TaskAttr = new HashSet<TaskAttr>();
            TaskComplete = new HashSet<TaskComplete>();
            TaskHide = new HashSet<TaskHide>();
            TaskTaskResource = new HashSet<TaskTaskResource>();
        }

        public int Id { get; set; }
        public string TaskName { get; set; }
        public int TaskPhaseId { get; set; }
        public string TaskDescription { get; set; }
        public string TaskShortDescription { get; set; }
        public string TaskQuestion { get; set; }
        public bool TaskFeatured { get; set; }
        public int TaskRank { get; set; }
        public bool CommonlySearched { get; set; }
        public int? AssetId { get; set; }

        public virtual ICollection<ActivityTask> ActivityTask { get; set; }
        public virtual ICollection<TaskAttr> TaskAttr { get; set; }
        public virtual ICollection<TaskComplete> TaskComplete { get; set; }
        public virtual ICollection<TaskHide> TaskHide { get; set; }
        public virtual ICollection<TaskTaskResource> TaskTaskResource { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual TaskPhase TaskPhase { get; set; }
    }
}
