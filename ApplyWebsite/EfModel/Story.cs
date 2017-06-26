using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Story
    {
        public Story()
        {
            ActivityTaskStory = new HashSet<ActivityTaskStory>();
            StoryImages = new HashSet<StoryImages>();
            StoryTaskResource = new HashSet<StoryTaskResource>();
            StoryTimeline = new HashSet<StoryTimeline>();
            TrackStory = new HashSet<TrackStory>();
        }

        public int Id { get; set; }
        public int PersonId { get; set; }
        public int OwnerAccountId { get; set; }
        public string StoryTitle { get; set; }
        public string StorySummary { get; set; }
        public string StoryText { get; set; }
        public string StoryVideoUrl { get; set; }
        public bool Release { get; set; }
        public bool Feature { get; set; }

        public virtual ICollection<ActivityTaskStory> ActivityTaskStory { get; set; }
        public virtual ICollection<StoryImages> StoryImages { get; set; }
        public virtual ICollection<StoryTaskResource> StoryTaskResource { get; set; }
        public virtual ICollection<StoryTimeline> StoryTimeline { get; set; }
        public virtual ICollection<TrackStory> TrackStory { get; set; }
        public virtual Account OwnerAccount { get; set; }
        public virtual Person Person { get; set; }
    }
}
