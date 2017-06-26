using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class EventAccount
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int AccountId { get; set; }
        public int QueueTypeId { get; set; }
        public int PositionsAvailable { get; set; }

        public virtual Account Account { get; set; }
        public virtual Event Event { get; set; }
    }
}
