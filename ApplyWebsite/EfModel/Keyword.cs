using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Keyword
    {
        public Keyword()
        {
            PostKeyword = new HashSet<PostKeyword>();
            PostKeywordExclude = new HashSet<PostKeywordExclude>();
        }

        public int Id { get; set; }
        public string KeywordText { get; set; }

        public virtual ICollection<PostKeyword> PostKeyword { get; set; }
        public virtual ICollection<PostKeywordExclude> PostKeywordExclude { get; set; }
    }
}
