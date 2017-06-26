using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountAlbum
    {
        public AccountAlbum()
        {
            AccountAlbumPhoto = new HashSet<AccountAlbumPhoto>();
            Post = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string AlbumName { get; set; }
        public string AlbumDescription { get; set; }
        public int AccountId { get; set; }

        public virtual ICollection<AccountAlbumPhoto> AccountAlbumPhoto { get; set; }
        public virtual ICollection<Post> Post { get; set; }
        public virtual Account Account { get; set; }
    }
}
