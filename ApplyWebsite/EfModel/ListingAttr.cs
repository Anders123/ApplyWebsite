using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ListingAttr
    {
        public int ListingId { get; set; }
        public int AttrId { get; set; }
        public int MatchWeight { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual Listing Listing { get; set; }
    }
}
