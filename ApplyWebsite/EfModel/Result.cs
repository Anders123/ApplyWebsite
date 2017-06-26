using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Result
    {
        public int Id { get; set; }
        public int DashboardId { get; set; }
        public DateTime ResultDte { get; set; }
        public int MetricId { get; set; }
        public string ResultValue { get; set; }
        public string BudgetValue { get; set; }
        public string ResultNotes { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Dashboard Dashboard { get; set; }
        public virtual Metric Metric { get; set; }
    }
}
