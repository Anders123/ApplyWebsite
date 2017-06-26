using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PersonTag
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int TagId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
