using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PersonCommMethodPref
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int MethodId { get; set; }

        public virtual CommMethod Method { get; set; }
        public virtual Person Person { get; set; }
    }
}
