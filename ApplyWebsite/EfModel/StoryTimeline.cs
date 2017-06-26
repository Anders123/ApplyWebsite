using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class StoryTimeline
    {
        public int Id { get; set; }
        public int StoryId { get; set; }
        public string TimelineTitle { get; set; }
        public string TimelineDescription { get; set; }
        public string TimelineImage { get; set; }
        public int? CityId { get; set; }
        public double? LatOverride { get; set; }
        public double? LongOverride { get; set; }
        public double? Zoom { get; set; }
        public int? Pitch { get; set; }
        public double? Bearing { get; set; }
        public int? AccountId { get; set; }
        public int TimlineRank { get; set; }

        public virtual Account Account { get; set; }
        public virtual Story Story { get; set; }
    }
}
