using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PersonDashboard
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int DashboardId { get; set; }

        public virtual Dashboard Dashboard { get; set; }
        public virtual Person Person { get; set; }
    }
}
