using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskTaskResource
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int? ResourceId { get; set; }
        public int ResourceRank { get; set; }

        public virtual TaskResource Resource { get; set; }
        public virtual Task Task { get; set; }
    }
}
