using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class StoryTaskResource
    {
        public int Id { get; set; }
        public int StoryId { get; set; }
        public int ResourceId { get; set; }

        public virtual TaskResource Resource { get; set; }
        public virtual Story Story { get; set; }
    }
}
