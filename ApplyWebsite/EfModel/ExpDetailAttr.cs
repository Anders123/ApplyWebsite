using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExpDetailAttr
    {
        public int DetailId { get; set; }
        public int AttrId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual ExperienceDetail Detail { get; set; }
    }
}
