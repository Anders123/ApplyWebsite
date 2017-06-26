using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskResourceAttr
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int? AttrId { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual TaskResource Resource { get; set; }
    }
}
