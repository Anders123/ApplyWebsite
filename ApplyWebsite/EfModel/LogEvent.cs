using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class LogEvent
    {
        public LogEvent()
        {
            Log = new HashSet<Log>();
        }

        public int Id { get; set; }
        public string EventName { get; set; }

        public virtual ICollection<Log> Log { get; set; }
    }
}
