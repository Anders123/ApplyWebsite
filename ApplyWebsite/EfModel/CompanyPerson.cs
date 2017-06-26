using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CompanyPerson
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int PersonId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Person Person { get; set; }
    }
}
