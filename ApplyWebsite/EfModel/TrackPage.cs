using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TrackPage
    {
        public TrackPage()
        {
            AssetItem = new HashSet<AssetItem>();
            TrackPageContent = new HashSet<TrackPageContent>();
        }

        public int Id { get; set; }
        public int TrackId { get; set; }
        public int PageTypeId { get; set; }
        public string Name { get; set; }
        public int PageRank { get; set; }
        public int NavigationMenuLevel { get; set; }

        public virtual ICollection<AssetItem> AssetItem { get; set; }
        public virtual ICollection<TrackPageContent> TrackPageContent { get; set; }
        public virtual TrackPageType PageType { get; set; }
        public virtual Track Track { get; set; }
    }
}
