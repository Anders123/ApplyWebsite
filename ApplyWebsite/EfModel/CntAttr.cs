using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntAttr
    {
        public int AttrId { get; set; }
        public int Cnt { get; set; }

        public virtual Attr Attr { get; set; }
    }
}
