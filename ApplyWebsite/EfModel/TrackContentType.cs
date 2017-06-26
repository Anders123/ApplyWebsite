using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TrackContentType
    {
        public TrackContentType()
        {
            TrackPageContent = new HashSet<TrackPageContent>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TrackPageContent> TrackPageContent { get; set; }
    }
}
