using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskResourceHide
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int PersonId { get; set; }
        public bool Hide { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Person Person { get; set; }
        public virtual TaskResource Resource { get; set; }
    }
}
