using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountRelationshipStatus
    {
        public AccountRelationshipStatus()
        {
            AccountRelationship = new HashSet<AccountRelationship>();
            AccountRelationshipStatusHistory = new HashSet<AccountRelationshipStatusHistory>();
            AccountRelationshipStatusReason = new HashSet<AccountRelationshipStatusReason>();
            CommMessage = new HashSet<CommMessage>();
            CommRequestOptions = new HashSet<CommRequestOptions>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }
        public int StatusRank { get; set; }

        public virtual ICollection<AccountRelationship> AccountRelationship { get; set; }
        public virtual ICollection<AccountRelationshipStatusHistory> AccountRelationshipStatusHistory { get; set; }
        public virtual ICollection<AccountRelationshipStatusReason> AccountRelationshipStatusReason { get; set; }
        public virtual ICollection<CommMessage> CommMessage { get; set; }
        public virtual ICollection<CommRequestOptions> CommRequestOptions { get; set; }
    }
}
