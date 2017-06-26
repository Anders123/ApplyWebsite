using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class DatabaseJobType
    {
        public DatabaseJobType()
        {
            DatabaseJob = new HashSet<DatabaseJob>();
        }

        public int Id { get; set; }
        public string JobTypeName { get; set; }
        public string JobTypeDesc { get; set; }

        public virtual ICollection<DatabaseJob> DatabaseJob { get; set; }
    }
}
