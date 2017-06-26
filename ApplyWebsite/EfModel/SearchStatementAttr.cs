using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class SearchStatementAttr
    {
        public int SearchId { get; set; }
        public int AttrId { get; set; }

        public virtual SearchStatement Search { get; set; }
    }
}
