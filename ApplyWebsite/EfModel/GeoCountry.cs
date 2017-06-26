using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class GeoCountry
    {
        public GeoCountry()
        {
            GeoState = new HashSet<GeoState>();
            MilitaryBase = new HashSet<MilitaryBase>();
        }

        public int CountryId { get; set; }
        public string Country { get; set; }
        public string CountryAbbr { get; set; }

        public virtual ICollection<GeoState> GeoState { get; set; }
        public virtual ICollection<MilitaryBase> MilitaryBase { get; set; }
    }
}
