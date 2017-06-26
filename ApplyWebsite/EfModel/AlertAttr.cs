using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AlertAttr
    {
        public int Id { get; set; }
        public int AlertId { get; set; }
        public int? AttrId { get; set; }

        public virtual Alert Alert { get; set; }
        public virtual Attr Attr { get; set; }
    }
}
