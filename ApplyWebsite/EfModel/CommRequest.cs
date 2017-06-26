using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommRequest
    {
        public CommRequest()
        {
            CommMessage = new HashSet<CommMessage>();
            CommRequestOptionsNewRequest = new HashSet<CommRequestOptions>();
            CommRequestOptionsRequest = new HashSet<CommRequestOptions>();
        }

        public int Id { get; set; }
        public int PurposeId { get; set; }
        public string RequestName { get; set; }
        public string RequestText { get; set; }
        public string PendingText { get; set; }
        public string EmailSubject { get; set; }
        public int RequestRank { get; set; }
        public bool FirstStateRequest { get; set; }
        public bool LastStateRequest { get; set; }
        public bool AvailableToAccount { get; set; }

        public virtual ICollection<CommMessage> CommMessage { get; set; }
        public virtual ICollection<CommRequestOptions> CommRequestOptionsNewRequest { get; set; }
        public virtual ICollection<CommRequestOptions> CommRequestOptionsRequest { get; set; }
        public virtual CommPurpose Purpose { get; set; }
    }
}
