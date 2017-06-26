using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ClockStatus
    {
        public ClockStatus()
        {
            Clock = new HashSet<Clock>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }
        public int StatusRank { get; set; }

        public virtual ICollection<Clock> Clock { get; set; }
    }
}
