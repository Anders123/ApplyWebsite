using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TrackPageType
    {
        public TrackPageType()
        {
            TrackPage = new HashSet<TrackPage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TrackPage> TrackPage { get; set; }
    }
}
