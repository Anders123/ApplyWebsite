using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class SearchStatementCoreTitle
    {
        public int SearchId { get; set; }
        public int TitleId { get; set; }

        public virtual SearchStatement Search { get; set; }
        public virtual CoreTitle Title { get; set; }
    }
}
