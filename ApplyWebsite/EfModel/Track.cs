using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Track
    {
        public Track()
        {
            TrackAccount = new HashSet<TrackAccount>();
            TrackPage = new HashSet<TrackPage>();
            TrackStory = new HashSet<TrackStory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? AssetId { get; set; }

        public virtual ICollection<TrackAccount> TrackAccount { get; set; }
        public virtual ICollection<TrackPage> TrackPage { get; set; }
        public virtual ICollection<TrackStory> TrackStory { get; set; }
        public virtual Asset Asset { get; set; }
    }
}
