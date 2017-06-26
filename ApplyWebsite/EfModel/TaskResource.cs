using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskResource
    {
        public TaskResource()
        {
            ActivityTaskResource = new HashSet<ActivityTaskResource>();
            RatingTaskResource = new HashSet<RatingTaskResource>();
            ShareTaskResource = new HashSet<ShareTaskResource>();
            StoryTaskResource = new HashSet<StoryTaskResource>();
            TaskResourceAttr = new HashSet<TaskResourceAttr>();
            TaskResourceFeatured = new HashSet<TaskResourceFeatured>();
            TaskResourceHide = new HashSet<TaskResourceHide>();
            TaskResourceImage = new HashSet<TaskResourceImage>();
            TaskResourceLink = new HashSet<TaskResourceLink>();
            TaskResourceRollupChild = new HashSet<TaskResourceRollup>();
            TaskResourceRollupParent = new HashSet<TaskResourceRollup>();
            TaskTaskResource = new HashSet<TaskTaskResource>();
        }

        public int Id { get; set; }
        public string ResourceName { get; set; }
        public bool Article { get; set; }
        public int? ResourceAccountId { get; set; }
        public string ResourceDescription { get; set; }
        public string ResourceShortDescription { get; set; }
        public string ResourceIcon { get; set; }
        public string ResourceUrl { get; set; }
        public string ResourceVideo { get; set; }
        public bool Hohresource { get; set; }
        public bool ResourceHide { get; set; }
        public int ResourceRank { get; set; }
        public int? AssetId { get; set; }
        public bool? HideFromGlossary { get; set; }

        public virtual ICollection<ActivityTaskResource> ActivityTaskResource { get; set; }
        public virtual ICollection<RatingTaskResource> RatingTaskResource { get; set; }
        public virtual ICollection<ShareTaskResource> ShareTaskResource { get; set; }
        public virtual ICollection<StoryTaskResource> StoryTaskResource { get; set; }
        public virtual ICollection<TaskResourceAttr> TaskResourceAttr { get; set; }
        public virtual ICollection<TaskResourceFeatured> TaskResourceFeatured { get; set; }
        public virtual ICollection<TaskResourceHide> TaskResourceHide { get; set; }
        public virtual ICollection<TaskResourceImage> TaskResourceImage { get; set; }
        public virtual ICollection<TaskResourceLink> TaskResourceLink { get; set; }
        public virtual ICollection<TaskResourceRollup> TaskResourceRollupChild { get; set; }
        public virtual ICollection<TaskResourceRollup> TaskResourceRollupParent { get; set; }
        public virtual ICollection<TaskTaskResource> TaskTaskResource { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual Account ResourceAccount { get; set; }
    }
}
