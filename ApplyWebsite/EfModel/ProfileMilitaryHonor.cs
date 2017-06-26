using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileMilitaryHonor
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int? OutsideId { get; set; }
        public int? HonorId { get; set; }

        public virtual Attr Honor { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
