using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostMapGeoRegion
    {
        public int RegionId { get; set; }
        public int FeatureId { get; set; }

        public virtual PostMapFeature Feature { get; set; }
        public virtual GeoRegion Region { get; set; }
    }
}
