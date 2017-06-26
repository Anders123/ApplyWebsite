using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ActivityPerson
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int PersonId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Person Person { get; set; }
    }
}
