using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskResourceFeatured
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int FeaturedOnId { get; set; }
        public bool PremiumSpot { get; set; }

        public virtual TaskResourceFeaturedOn FeaturedOn { get; set; }
        public virtual TaskResource Resource { get; set; }
    }
}
