using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class LogClock
    {
        public int Id { get; set; }
        public int LogId { get; set; }
        public int ClockId { get; set; }
        public int StatusId { get; set; }

        public virtual Clock Clock { get; set; }
        public virtual Log Log { get; set; }
    }
}
