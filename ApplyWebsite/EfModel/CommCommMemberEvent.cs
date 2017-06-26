using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommCommMemberEvent
    {
        public int Id { get; set; }
        public int CommMemberId { get; set; }
        public int EventId { get; set; }
        public DateTime EventAt { get; set; }

        public virtual CommMember CommMember { get; set; }
        public virtual CommMemberEvent Event { get; set; }
    }
}
