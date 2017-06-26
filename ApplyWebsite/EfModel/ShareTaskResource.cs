using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ShareTaskResource
    {
        public int Id { get; set; }
        public int ShareId { get; set; }
        public int ResourceId { get; set; }

        public virtual TaskResource Resource { get; set; }
        public virtual Share Share { get; set; }
    }
}
