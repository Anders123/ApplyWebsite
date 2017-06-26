using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostMapGeoState
    {
        public int StateId { get; set; }
        public int FeatureId { get; set; }

        public virtual PostMapFeature Feature { get; set; }
        public virtual GeoState State { get; set; }
    }
}
