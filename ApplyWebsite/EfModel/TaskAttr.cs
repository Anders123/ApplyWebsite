using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskAttr
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int? AttrId { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual Task Task { get; set; }
    }
}
