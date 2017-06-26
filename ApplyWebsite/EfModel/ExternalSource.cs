using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExternalSource
    {
        public ExternalSource()
        {
            AccountExternal = new HashSet<AccountExternal>();
        }

        public int Id { get; set; }
        public string SourceName { get; set; }

        public virtual ICollection<AccountExternal> AccountExternal { get; set; }
    }
}
