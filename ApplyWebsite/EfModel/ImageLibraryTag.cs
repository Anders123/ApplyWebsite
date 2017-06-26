using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ImageLibraryTag
    {
        public int ImageId { get; set; }
        public int TagId { get; set; }

        public virtual ImageLibrary Image { get; set; }
        public virtual ImageTag Tag { get; set; }
    }
}
