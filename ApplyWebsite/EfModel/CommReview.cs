using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommReview
    {
        public int Id { get; set; }
        public int CommId { get; set; }
        public int ReviewId { get; set; }

        public virtual Comm Comm { get; set; }
    }
}
