using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Activity
    {
        public Activity()
        {
            ActivityPerson = new HashSet<ActivityPerson>();
            ActivityTask = new HashSet<ActivityTask>();
            ActivityTaskResource = new HashSet<ActivityTaskResource>();
            ActivityTaskStory = new HashSet<ActivityTaskStory>();
            ActivtyTaskPhase = new HashSet<ActivtyTaskPhase>();
        }

        public int Id { get; set; }
        public int ActivityTypeId { get; set; }
        public DateTime ActivityAt { get; set; }
        public int? PersonId { get; set; }

        public virtual ICollection<ActivityPerson> ActivityPerson { get; set; }
        public virtual ICollection<ActivityTask> ActivityTask { get; set; }
        public virtual ICollection<ActivityTaskResource> ActivityTaskResource { get; set; }
        public virtual ICollection<ActivityTaskStory> ActivityTaskStory { get; set; }
        public virtual ICollection<ActivtyTaskPhase> ActivtyTaskPhase { get; set; }
        public virtual ActivityType ActivityType { get; set; }
    }
}
