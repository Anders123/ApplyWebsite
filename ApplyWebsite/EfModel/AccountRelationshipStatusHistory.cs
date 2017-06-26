using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountRelationshipStatusHistory
    {
        public AccountRelationshipStatusHistory()
        {
            AccountRelationshipStatusHistoryReason = new HashSet<AccountRelationshipStatusHistoryReason>();
        }

        public int Id { get; set; }
        public int RelationshipId { get; set; }
        public int RelationshipStatusId { get; set; }
        public int StatusById { get; set; }
        public DateTime StatusAt { get; set; }

        public virtual ICollection<AccountRelationshipStatusHistoryReason> AccountRelationshipStatusHistoryReason { get; set; }
        public virtual AccountRelationship Relationship { get; set; }
        public virtual AccountRelationshipStatus RelationshipStatus { get; set; }
        public virtual Person StatusBy { get; set; }
    }
}
