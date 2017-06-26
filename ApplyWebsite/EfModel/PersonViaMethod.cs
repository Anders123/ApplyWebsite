using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PersonViaMethod
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int MethodIsd { get; set; }

        public virtual ChatMessageViaMethod MethodIsdNavigation { get; set; }
        public virtual Person Person { get; set; }
    }
}
