using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Rating
    {
        public Rating()
        {
            RatingTaskResource = new HashSet<RatingTaskResource>();
        }

        public int Id { get; set; }
        public int RatedById { get; set; }
        public DateTime RatedAt { get; set; }
        public double Rating1 { get; set; }
        public string RatingDetails { get; set; }

        public virtual ICollection<RatingTaskResource> RatingTaskResource { get; set; }
        public virtual Person RatedBy { get; set; }
    }
}
