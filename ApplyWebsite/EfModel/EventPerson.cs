using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class EventPerson
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int PersonId { get; set; }
        public int? AccountId { get; set; }
        public bool Available { get; set; }
        public DateTime? EnteredEventAt { get; set; }
        public int QueueMemberRank { get; set; }

        public virtual Account Account { get; set; }
        public virtual Event Event { get; set; }
        public virtual Person Person { get; set; }
    }
}
