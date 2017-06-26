using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class EventAccountRelationship
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int RelationshipId { get; set; }
        public bool AlertJobSeeker { get; set; }
        public bool AlertAccount { get; set; }

        public virtual Event Event { get; set; }
        public virtual AccountRelationship Relationship { get; set; }
    }
}
