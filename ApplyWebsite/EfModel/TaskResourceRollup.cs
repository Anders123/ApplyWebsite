using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskResourceRollup
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ChildId { get; set; }

        public virtual TaskResource Child { get; set; }
        public virtual TaskResource Parent { get; set; }
    }
}
