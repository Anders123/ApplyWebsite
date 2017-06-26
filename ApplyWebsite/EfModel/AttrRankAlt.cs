using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AttrRankAlt
    {
        public int Id { get; set; }
        public int AltRank { get; set; }
        public int? ParentId { get; set; }
        public int? RankAltId { get; set; }

        public virtual Attr Parent { get; set; }
        public virtual Attr RankAlt { get; set; }
    }
}
