using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class SearchStatementPost
    {
        public int SearchId { get; set; }
        public int PostId { get; set; }

        public virtual Post Post { get; set; }
        public virtual SearchStatement Search { get; set; }
    }
}
