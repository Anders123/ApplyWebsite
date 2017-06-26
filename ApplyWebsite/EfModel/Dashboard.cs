using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Dashboard
    {
        public Dashboard()
        {
            PersonDashboard = new HashSet<PersonDashboard>();
            Result = new HashSet<Result>();
        }

        public int Id { get; set; }
        public string DashboardName { get; set; }

        public virtual ICollection<PersonDashboard> PersonDashboard { get; set; }
        public virtual ICollection<Result> Result { get; set; }
    }
}
