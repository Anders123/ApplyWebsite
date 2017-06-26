using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ActivityType
    {
        public ActivityType()
        {
            Activity = new HashSet<Activity>();
        }

        public int Id { get; set; }
        public string ActivityTypeName { get; set; }

        public virtual ICollection<Activity> Activity { get; set; }
    }
}
