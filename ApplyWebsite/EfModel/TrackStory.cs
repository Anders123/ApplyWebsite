using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TrackStory
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public int StoryId { get; set; }

        public virtual Story Story { get; set; }
        public virtual Track Track { get; set; }
    }
}
