using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostMapFeature
    {
        public PostMapFeature()
        {
            PostMapGeoRegion = new HashSet<PostMapGeoRegion>();
            PostMapGeoState = new HashSet<PostMapGeoState>();
            PostMapPoint = new HashSet<PostMapPoint>();
        }

        public int Id { get; set; }
        public int MapId { get; set; }
        public string FeatureName { get; set; }
        public int FeatureTypeId { get; set; }
        public string FeatureDesc { get; set; }
        public int? ImageId { get; set; }
        public string GeoJson { get; set; }
        public int FeatureRank { get; set; }

        public virtual ICollection<PostMapGeoRegion> PostMapGeoRegion { get; set; }
        public virtual ICollection<PostMapGeoState> PostMapGeoState { get; set; }
        public virtual ICollection<PostMapPoint> PostMapPoint { get; set; }
        public virtual PostMapFeatureType FeatureType { get; set; }
        public virtual ImageLibrary Image { get; set; }
        public virtual PostMap Map { get; set; }
    }
}
