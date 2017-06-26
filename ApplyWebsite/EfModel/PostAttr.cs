using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostAttr
    {
        public int PostId { get; set; }
        public int AttrId { get; set; }
        public bool Featured { get; set; }
        public int AttrRank { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual Post Post { get; set; }
    }
}
