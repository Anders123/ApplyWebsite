using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountReleationshipIntroBy
    {
        public int Id { get; set; }
        public int RelationshipId { get; set; }
        public int AccountId { get; set; }
        public int PersonId { get; set; }
        public string IntroNotes { get; set; }
        public DateTime? IntroAt { get; set; }

        public virtual Account Account { get; set; }
        public virtual Person Person { get; set; }
        public virtual AccountRelationship Relationship { get; set; }
    }
}
