using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommPurpose
    {
        public CommPurpose()
        {
            Comm = new HashSet<Comm>();
            CommRequest = new HashSet<CommRequest>();
        }

        public int Id { get; set; }
        public string PurposeName { get; set; }

        public virtual ICollection<Comm> Comm { get; set; }
        public virtual ICollection<CommRequest> CommRequest { get; set; }
    }
}
