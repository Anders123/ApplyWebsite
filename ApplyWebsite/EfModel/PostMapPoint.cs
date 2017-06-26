using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostMapPoint
    {
        public int Id { get; set; }
        public int FeatureId { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public int? ZipId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Zoom { get; set; }
        public int? Pitch { get; set; }
        public double? Bearing { get; set; }

        public virtual PostMapFeature Feature { get; set; }
        public virtual GeoZip Zip { get; set; }
    }
}
