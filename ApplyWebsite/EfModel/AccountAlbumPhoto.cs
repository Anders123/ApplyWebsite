using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountAlbumPhoto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public int? ImageId { get; set; }
        public int AlbumId { get; set; }
        public int PhotoRank { get; set; }

        public virtual AccountAlbum Album { get; set; }
        public virtual ImageLibrary Image { get; set; }
    }
}
