using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ThemeParameterAttr
    {
        public int ParameterId { get; set; }
        public int AttrId { get; set; }
        public int AttrRank { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual ThemeParameter Parameter { get; set; }
    }
}
