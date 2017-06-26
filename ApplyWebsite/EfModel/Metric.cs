using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Metric
    {
        public Metric()
        {
            Result = new HashSet<Result>();
        }

        public int Id { get; set; }
        public string MetricName { get; set; }
        public int CategoryId { get; set; }
        public int DataTypeId { get; set; }
        public int MetricRank { get; set; }

        public virtual ICollection<Result> Result { get; set; }
        public virtual MetricCategory Category { get; set; }
        public virtual DataType DataType { get; set; }
    }
}
