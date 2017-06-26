using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ActivityTaskStory
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int StoryId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Story Story { get; set; }
    }
}
