using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ImageLibraryAttr
    {
        public int LibraryId { get; set; }
        public int AttrId { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual ImageLibrary Library { get; set; }
    }
}
