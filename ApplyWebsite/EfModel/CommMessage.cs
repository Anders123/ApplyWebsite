using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommMessage
    {
        public CommMessage()
        {
            Comm = new HashSet<Comm>();
            CommMessageLog = new HashSet<CommMessageLog>();
        }

        public int Id { get; set; }
        public int CommId { get; set; }
        public int SentById { get; set; }
        public bool CopySender { get; set; }
        public string MessageContent { get; set; }
        public string EmailSubject { get; set; }
        public DateTime MessageAt { get; set; }
        public int? RequestId { get; set; }
        public bool CancelRequest { get; set; }
        public int? ResponseId { get; set; }
        public int? CommStateId { get; set; }
        public int? RelationshipStatusId { get; set; }
        public bool Private { get; set; }

        public virtual ICollection<Comm> Comm { get; set; }
        public virtual ICollection<CommMessageLog> CommMessageLog { get; set; }
        public virtual Comm CommNavigation { get; set; }
        public virtual CommState CommState { get; set; }
        public virtual AccountRelationshipStatus RelationshipStatus { get; set; }
        public virtual CommRequest Request { get; set; }
        public virtual CommRequestOptions Response { get; set; }
    }
}
