using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountRelationship
    {
        public AccountRelationship()
        {
            AccountRelationshipStatusHistory = new HashSet<AccountRelationshipStatusHistory>();
            AccountReleationshipIntroBy = new HashSet<AccountReleationshipIntroBy>();
            EventAccountRelationship = new HashSet<EventAccountRelationship>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public int PersonId { get; set; }
        public int RelationshipStatusId { get; set; }
        public DateTime RelationshipStatusAt { get; set; }
        public bool ContactInfoShared { get; set; }
        public bool Archived { get; set; }

        public virtual ICollection<AccountRelationshipStatusHistory> AccountRelationshipStatusHistory { get; set; }
        public virtual ICollection<AccountReleationshipIntroBy> AccountReleationshipIntroBy { get; set; }
        public virtual ICollection<EventAccountRelationship> EventAccountRelationship { get; set; }
        public virtual Account Account { get; set; }
        public virtual Person Person { get; set; }
        public virtual AccountRelationshipStatus RelationshipStatus { get; set; }
    }
}
