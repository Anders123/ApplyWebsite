using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostMapFeatureType
    {
        public PostMapFeatureType()
        {
            PostMapFeature = new HashSet<PostMapFeature>();
        }

        public int Id { get; set; }
        public string FeatureTypeName { get; set; }

        public virtual ICollection<PostMapFeature> PostMapFeature { get; set; }
    }
}
