using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Log
    {
        public Log()
        {
            LogClock = new HashSet<LogClock>();
        }

        public int Id { get; set; }
        public int LogEventId { get; set; }
        public int? LoggedById { get; set; }
        public DateTime LoggedAt { get; set; }
        public string LogDetails { get; set; }

        public virtual ICollection<LogClock> LogClock { get; set; }
        public virtual LogEvent LogEvent { get; set; }
        public virtual Person LoggedBy { get; set; }
    }
}
