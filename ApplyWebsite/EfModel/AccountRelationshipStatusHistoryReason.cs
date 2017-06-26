using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountRelationshipStatusHistoryReason
    {
        public int Id { get; set; }
        public int HistoryId { get; set; }
        public int ReasonId { get; set; }

        public virtual AccountRelationshipStatusHistory History { get; set; }
        public virtual AccountRelationshipStatusReason Reason { get; set; }
    }
}
