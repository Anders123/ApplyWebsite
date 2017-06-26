using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class MilitaryBaseMilitaryBranch
    {
        public int Id { get; set; }
        public int BaseId { get; set; }
        public int? BranchId { get; set; }

        public virtual MilitaryBase Base { get; set; }
        public virtual Attr Branch { get; set; }
    }
}
