using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskHide
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int PersonId { get; set; }
        public bool Hide { get; set; }
        public DateTime RecordedAt { get; set; }

        public virtual Person Person { get; set; }
        public virtual Task Task { get; set; }
    }
}
