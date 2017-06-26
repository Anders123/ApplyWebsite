using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommRequestOptions
    {
        public CommRequestOptions()
        {
            CommMessage = new HashSet<CommMessage>();
        }

        public int Id { get; set; }
        public int RequestId { get; set; }
        public string ButtonText { get; set; }
        public string ButtonTooltip { get; set; }
        public string ButtonColor { get; set; }
        public string MessageContent { get; set; }
        public int? NewRequestId { get; set; }
        public int? NewCommStateId { get; set; }
        public int? NewRelationshipStatusId { get; set; }
        public string CodeCommand { get; set; }
        public int ButtonRank { get; set; }

        public virtual ICollection<CommMessage> CommMessage { get; set; }
        public virtual CommState NewCommState { get; set; }
        public virtual AccountRelationshipStatus NewRelationshipStatus { get; set; }
        public virtual CommRequest NewRequest { get; set; }
        public virtual CommRequest Request { get; set; }
    }
}
