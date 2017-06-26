using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommStateLog
    {
        public int Id { get; set; }
        public int CommId { get; set; }
        public int CommStateId { get; set; }
        public int StateById { get; set; }
        public DateTime StateAt { get; set; }

        public virtual Comm Comm { get; set; }
        public virtual CommState CommState { get; set; }
        public virtual Person StateBy { get; set; }
    }
}
