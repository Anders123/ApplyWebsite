using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommMessageLog
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public int CommMemberId { get; set; }
        public int MethodId { get; set; }
        public DateTime LoggedAt { get; set; }
        public DateTime? SentAt { get; set; }
        public DateTime? ReadAt { get; set; }

        public virtual CommMember CommMember { get; set; }
        public virtual CommMessage Message { get; set; }
        public virtual CommMethod Method { get; set; }
    }
}
