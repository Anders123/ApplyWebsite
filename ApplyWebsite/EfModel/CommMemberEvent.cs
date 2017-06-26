using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommMemberEvent
    {
        public CommMemberEvent()
        {
            CommCommMemberEvent = new HashSet<CommCommMemberEvent>();
        }

        public int Id { get; set; }
        public string Event { get; set; }
        public int EventRank { get; set; }

        public virtual ICollection<CommCommMemberEvent> CommCommMemberEvent { get; set; }
    }
}
