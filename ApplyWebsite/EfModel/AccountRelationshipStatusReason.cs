using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountRelationshipStatusReason
    {
        public AccountRelationshipStatusReason()
        {
            AccountRelationshipStatusHistoryReason = new HashSet<AccountRelationshipStatusHistoryReason>();
        }

        public int Id { get; set; }
        public int RelationshipStatusId { get; set; }
        public string ReasonName { get; set; }
        public int ReasonRank { get; set; }

        public virtual ICollection<AccountRelationshipStatusHistoryReason> AccountRelationshipStatusHistoryReason { get; set; }
        public virtual AccountRelationshipStatus RelationshipStatus { get; set; }
    }
}
