using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskResourceImage
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public string ImageSrc { get; set; }
        public int ImageRank { get; set; }

        public virtual TaskResource Resource { get; set; }
    }
}
