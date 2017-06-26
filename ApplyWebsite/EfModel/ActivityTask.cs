using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ActivityTask
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int TaskId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Task Task { get; set; }
    }
}
