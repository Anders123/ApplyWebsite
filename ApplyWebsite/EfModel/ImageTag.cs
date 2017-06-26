using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ImageTag
    {
        public ImageTag()
        {
            ImageLibraryTag = new HashSet<ImageLibraryTag>();
        }

        public int TagId { get; set; }
        public string ImageTagName { get; set; }

        public virtual ICollection<ImageLibraryTag> ImageLibraryTag { get; set; }
    }
}
