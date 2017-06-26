using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommMember
    {
        public CommMember()
        {
            CommCommMemberEvent = new HashSet<CommCommMemberEvent>();
            CommMemberCommMethod = new HashSet<CommMemberCommMethod>();
            CommMessageLog = new HashSet<CommMessageLog>();
        }

        public int Id { get; set; }
        public int CommId { get; set; }
        public int PersonId { get; set; }
        public bool OwnerYesNo { get; set; }
        public bool RemovedYesNo { get; set; }

        public virtual ICollection<CommCommMemberEvent> CommCommMemberEvent { get; set; }
        public virtual ICollection<CommMemberCommMethod> CommMemberCommMethod { get; set; }
        public virtual ICollection<CommMessageLog> CommMessageLog { get; set; }
        public virtual Comm Comm { get; set; }
        public virtual Person Person { get; set; }
    }
}
