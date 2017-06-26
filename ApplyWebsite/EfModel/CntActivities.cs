using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntActivities
    {
        public int ActivitiesId { get; set; }
        public int Cnt { get; set; }

        public virtual OnetWorkActivities Activities { get; set; }
    }
}
