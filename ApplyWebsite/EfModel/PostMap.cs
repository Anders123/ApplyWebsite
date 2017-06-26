using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostMap
    {
        public PostMap()
        {
            Post = new HashSet<Post>();
            PostMapFeature = new HashSet<PostMapFeature>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public string MapName { get; set; }
        public string MapDesc { get; set; }
        public bool Imported { get; set; }
        public bool HideMap { get; set; }
        public int MapRank { get; set; }
        public int? TempId { get; set; }

        public virtual ICollection<Post> Post { get; set; }
        public virtual ICollection<PostMapFeature> PostMapFeature { get; set; }
        public virtual Account Account { get; set; }
    }
}
