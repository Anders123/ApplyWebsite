using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class DataType
    {
        public DataType()
        {
            Metric = new HashSet<Metric>();
        }

        public int Id { get; set; }
        public string DataType1 { get; set; }

        public virtual ICollection<Metric> Metric { get; set; }
    }
}
