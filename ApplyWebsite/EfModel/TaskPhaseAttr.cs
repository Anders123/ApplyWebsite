using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskPhaseAttr
    {
        public int Id { get; set; }
        public int PhaseId { get; set; }
        public int? AttrId { get; set; }

        public virtual Attr Attr { get; set; }
        public virtual TaskPhase Phase { get; set; }
    }
}
