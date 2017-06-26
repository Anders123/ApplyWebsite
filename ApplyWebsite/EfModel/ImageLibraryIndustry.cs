using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ImageLibraryIndustry
    {
        public int LibraryId { get; set; }
        public int IndustryId { get; set; }

        public virtual Industry Industry { get; set; }
        public virtual ImageLibrary Library { get; set; }
    }
}
