using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Comm
    {
        public Comm()
        {
            CommMember = new HashSet<CommMember>();
            CommMessage = new HashSet<CommMessage>();
            CommProfile = new HashSet<CommProfile>();
            CommReview = new HashSet<CommReview>();
            CommStateLog = new HashSet<CommStateLog>();
        }

        public int Id { get; set; }
        public int PurposeId { get; set; }
        public int? SubjectId { get; set; }
        public int? AccountId { get; set; }
        public int CommStateId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? LastMessageId { get; set; }

        public virtual ICollection<CommMember> CommMember { get; set; }
        public virtual ICollection<CommMessage> CommMessage { get; set; }
        public virtual ICollection<CommProfile> CommProfile { get; set; }
        public virtual ICollection<CommReview> CommReview { get; set; }
        public virtual ICollection<CommStateLog> CommStateLog { get; set; }
        public virtual Account Account { get; set; }
        public virtual CommState CommState { get; set; }
        public virtual CommMessage LastMessage { get; set; }
        public virtual CommPurpose Purpose { get; set; }
        public virtual Person Subject { get; set; }
    }
}
