using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntOccupation
    {
        public int OnetId { get; set; }
        public int Cnt { get; set; }

        public virtual OnetOccupationData Onet { get; set; }
    }
}
