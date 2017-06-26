using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TipAttr
    {
        public int Id { get; set; }
        public int TipId { get; set; }
        public int? AttrId { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual Tip Tip { get; set; }
    }
}
