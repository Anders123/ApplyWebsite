using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class DatabaseTable
    {
        public DatabaseTable()
        {
            AttrRelatedTable = new HashSet<AttrRelatedTable>();
        }

        public int Id { get; set; }
        public string TableName { get; set; }

        public virtual ICollection<AttrRelatedTable> AttrRelatedTable { get; set; }
    }
}
