using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostListing
    {
        public int PostId { get; set; }
        public int ListingId { get; set; }
        public DateTime MarriedAt { get; set; }
        public bool Unmarry { get; set; }

        public virtual Listing Listing { get; set; }
        public virtual Post Post { get; set; }
    }
}
