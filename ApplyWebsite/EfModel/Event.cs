using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Event
    {
        public Event()
        {
            EventAccount = new HashSet<EventAccount>();
            EventAccountRelationship = new HashSet<EventAccountRelationship>();
            EventPerson = new HashSet<EventPerson>();
        }

        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime? EventStart { get; set; }
        public DateTime? EventEnd { get; set; }
        public bool EventLive { get; set; }

        public virtual ICollection<EventAccount> EventAccount { get; set; }
        public virtual ICollection<EventAccountRelationship> EventAccountRelationship { get; set; }
        public virtual ICollection<EventPerson> EventPerson { get; set; }
    }
}
