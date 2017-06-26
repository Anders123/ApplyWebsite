using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AddrPerson
    {
        public int Id { get; set; }
        public int AddrId { get; set; }
        public int PersonId { get; set; }
        public DateTime? MovedIn { get; set; }
        public bool MovedOut { get; set; }
        public DateTime? MovedOutOn { get; set; }

        public virtual Addr Addr { get; set; }
        public virtual Person Person { get; set; }
    }
}
