using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class MetricCategory
    {
        public MetricCategory()
        {
            Metric = new HashSet<Metric>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Metric> Metric { get; set; }
    }
}
