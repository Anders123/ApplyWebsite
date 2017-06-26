using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileLink
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string LinkedSite { get; set; }
        public string LinkToken { get; set; }
        public string LinkPath { get; set; }

        public virtual Person Person { get; set; }
    }
}
