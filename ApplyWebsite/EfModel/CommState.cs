using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommState
    {
        public CommState()
        {
            Comm = new HashSet<Comm>();
            CommMessage = new HashSet<CommMessage>();
            CommRequestOptions = new HashSet<CommRequestOptions>();
            CommStateLog = new HashSet<CommStateLog>();
        }

        public int Id { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<Comm> Comm { get; set; }
        public virtual ICollection<CommMessage> CommMessage { get; set; }
        public virtual ICollection<CommRequestOptions> CommRequestOptions { get; set; }
        public virtual ICollection<CommStateLog> CommStateLog { get; set; }
    }
}
