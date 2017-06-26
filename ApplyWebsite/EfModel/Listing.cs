using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Listing
    {
        public Listing()
        {
            BriefcasePostListing = new HashSet<BriefcasePostListing>();
            ListingAttr = new HashSet<ListingAttr>();
            PostListing = new HashSet<PostListing>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public string ReqNo { get; set; }
        public string Title { get; set; }
        public int? TitleId { get; set; }
        public DateTime? ReqDte { get; set; }
        public string ReqApply { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? ZipId { get; set; }
        public string Country { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? IndexedAt { get; set; }
        public int? TitleMatchWeight { get; set; }

        public virtual ICollection<BriefcasePostListing> BriefcasePostListing { get; set; }
        public virtual ICollection<ListingAttr> ListingAttr { get; set; }
        public virtual ICollection<PostListing> PostListing { get; set; }
        public virtual CoreTitle TitleNavigation { get; set; }
    }
}
