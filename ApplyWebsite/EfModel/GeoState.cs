using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class GeoState
    {
        public GeoState()
        {
            ExperienceState = new HashSet<ExperienceState>();
            GeoCity = new HashSet<GeoCity>();
            PostMapGeoState = new HashSet<PostMapGeoState>();
        }

        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string St { get; set; }
        public string Stname { get; set; }

        public virtual ICollection<ExperienceState> ExperienceState { get; set; }
        public virtual ICollection<GeoCity> GeoCity { get; set; }
        public virtual ICollection<PostMapGeoState> PostMapGeoState { get; set; }
        public virtual GeoCountry Country { get; set; }
    }
}
