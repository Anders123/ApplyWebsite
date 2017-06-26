using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ActivityTaskResource
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int ResourceId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual TaskResource Resource { get; set; }
    }
}
