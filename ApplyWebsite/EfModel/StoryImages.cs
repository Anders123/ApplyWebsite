using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class StoryImages
    {
        public int Id { get; set; }
        public int StoryId { get; set; }
        public string ImageSrc { get; set; }
        public string ImageTitle { get; set; }
        public string ImageCaption { get; set; }
        public int ImageRank { get; set; }

        public virtual Story Story { get; set; }
    }
}
