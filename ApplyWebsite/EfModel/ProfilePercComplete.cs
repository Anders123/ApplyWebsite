using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfilePercComplete
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public double PercComplete { get; set; }
        public DateTime PercCompleteAt { get; set; }
        public bool GotAjob { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
