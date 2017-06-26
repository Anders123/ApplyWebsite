using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class MilitaryBasePerson
    {
        public int Id { get; set; }
        public int BaseId { get; set; }
        public int PersonId { get; set; }

        public virtual MilitaryBase Base { get; set; }
        public virtual Person Person { get; set; }
    }
}
