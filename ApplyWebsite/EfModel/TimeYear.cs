using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TimeYear
    {
        public TimeYear()
        {
            Experience = new HashSet<Experience>();
        }

        public int Id { get; set; }
        public int YearValue { get; set; }
        public string YearText { get; set; }

        public virtual ICollection<Experience> Experience { get; set; }
    }
}
