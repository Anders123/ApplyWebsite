using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskResourceLink
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public string LinkText { get; set; }
        public string LinkUrl { get; set; }

        public virtual TaskResource Resource { get; set; }
    }
}
