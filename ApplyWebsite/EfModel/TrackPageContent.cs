using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TrackPageContent
    {
        public int Id { get; set; }
        public int? TrackPageId { get; set; }
        public int? ContentTypeId { get; set; }
        public string ContentTitle { get; set; }
        public string ContentDescription { get; set; }
        public int ContentRank { get; set; }
        public int? AssetId { get; set; }
        public int? AssetIdOld { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual TrackContentType ContentType { get; set; }
        public virtual TrackPage TrackPage { get; set; }
    }
}
