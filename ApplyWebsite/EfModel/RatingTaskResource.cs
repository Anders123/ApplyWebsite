using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class RatingTaskResource
    {
        public int Id { get; set; }
        public int RatingId { get; set; }
        public int ResourceId { get; set; }

        public virtual Rating Rating { get; set; }
        public virtual TaskResource Resource { get; set; }
    }
}
