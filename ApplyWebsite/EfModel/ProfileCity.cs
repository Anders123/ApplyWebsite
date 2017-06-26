using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileCity
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int CityId { get; set; }
        public bool HideCity { get; set; }

        public virtual GeoCity City { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
