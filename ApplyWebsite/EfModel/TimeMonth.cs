using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TimeMonth
    {
        public TimeMonth()
        {
            Experience = new HashSet<Experience>();
        }

        public int Id { get; set; }
        public int MonthValue { get; set; }
        public string MonthText { get; set; }

        public virtual ICollection<Experience> Experience { get; set; }
    }
}
