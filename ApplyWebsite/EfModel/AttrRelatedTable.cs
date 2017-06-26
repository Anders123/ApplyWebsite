using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AttrRelatedTable
    {
        public int Id { get; set; }
        public int AttrId { get; set; }
        public int RelatedId { get; set; }
        public int TableId { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual DatabaseTable Table { get; set; }
    }
}
