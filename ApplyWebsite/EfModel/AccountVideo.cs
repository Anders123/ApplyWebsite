using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountVideo
    {
        public AccountVideo()
        {
            Post = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string VideoName { get; set; }
        public string VideoDescription { get; set; }
        public string VideoCode { get; set; }
        public int VideoProviderId { get; set; }
        public int AccountId { get; set; }

        public virtual ICollection<Post> Post { get; set; }
        public virtual Account Account { get; set; }
        public virtual MediaVideoProvider VideoProvider { get; set; }
    }
}
