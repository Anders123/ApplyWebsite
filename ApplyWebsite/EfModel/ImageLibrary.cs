using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ImageLibrary
    {
        public ImageLibrary()
        {
            AccountBanner = new HashSet<Account>();
            AccountDefaultLogo = new HashSet<Account>();
            AccountThumbnail = new HashSet<Account>();
            AccountAlbumPhoto = new HashSet<AccountAlbumPhoto>();
            AccountLogo = new HashSet<AccountLogo>();
            Attr = new HashSet<Attr>();
            ImageLibraryAttr = new HashSet<ImageLibraryAttr>();
            ImageLibraryIndustry = new HashSet<ImageLibraryIndustry>();
            ImageLibraryTag = new HashSet<ImageLibraryTag>();
            PostThumbnail = new HashSet<Post>();
            PostVideoCoverPhoto = new HashSet<Post>();
            PostMapFeature = new HashSet<PostMapFeature>();
            ThemeFavicon = new HashSet<Theme>();
            ThemeThemeLogo = new HashSet<Theme>();
        }

        public int Id { get; set; }
        public string PictureName { get; set; }
        public string PictureFileName { get; set; }
        public int? PictureLength { get; set; }
        public string PictureContentType { get; set; }
        public int AccountId { get; set; }

        public virtual ICollection<Account> AccountBanner { get; set; }
        public virtual ICollection<Account> AccountDefaultLogo { get; set; }
        public virtual ICollection<Account> AccountThumbnail { get; set; }
        public virtual ICollection<AccountAlbumPhoto> AccountAlbumPhoto { get; set; }
        public virtual ICollection<AccountLogo> AccountLogo { get; set; }
        public virtual ICollection<Attr> Attr { get; set; }
        public virtual ICollection<ImageLibraryAttr> ImageLibraryAttr { get; set; }
        public virtual ICollection<ImageLibraryIndustry> ImageLibraryIndustry { get; set; }
        public virtual ICollection<ImageLibraryTag> ImageLibraryTag { get; set; }
        public virtual ICollection<Post> PostThumbnail { get; set; }
        public virtual ICollection<Post> PostVideoCoverPhoto { get; set; }
        public virtual ICollection<PostMapFeature> PostMapFeature { get; set; }
        public virtual ICollection<Theme> ThemeFavicon { get; set; }
        public virtual ICollection<Theme> ThemeThemeLogo { get; set; }
        public virtual Account Account { get; set; }
    }
}
