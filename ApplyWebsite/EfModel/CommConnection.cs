using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommConnection
    {
        public string ConnectionId { get; set; }
        public int PersonId { get; set; }
        public DateTime ConnectedAt { get; set; }
        public DateTime? DisconnectedAt { get; set; }

        public virtual Person Person { get; set; }
    }
}
