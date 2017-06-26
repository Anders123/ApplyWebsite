using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostKeywordExclude
    {
        public int PostId { get; set; }
        public int KeywordId { get; set; }

        public virtual Keyword Keyword { get; set; }
        public virtual Post Post { get; set; }
    }
}
