using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class GeoRegion
    {
        public GeoRegion()
        {
            PostMapGeoRegion = new HashSet<PostMapGeoRegion>();
        }

        public int Id { get; set; }
        public string RegionName { get; set; }
        public string GeoJson { get; set; }

        public virtual ICollection<PostMapGeoRegion> PostMapGeoRegion { get; set; }
    }
}
