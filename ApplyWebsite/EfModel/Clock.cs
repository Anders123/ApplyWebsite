using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Clock
    {
        public Clock()
        {
            LogClock = new HashSet<LogClock>();
        }

        public int Id { get; set; }
        public int PersonId { get; set; }
        public int AccountId { get; set; }
        public int AssignedToId { get; set; }
        public int StatusId { get; set; }
        public DateTime LastStatusAt { get; set; }

        public virtual ICollection<LogClock> LogClock { get; set; }
        public virtual Account Account { get; set; }
        public virtual Person AssignedTo { get; set; }
        public virtual Person Person { get; set; }
        public virtual ClockStatus Status { get; set; }
    }
}
