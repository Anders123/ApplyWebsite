using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntAbilities
    {
        public int AbilityId { get; set; }
        public int Cnt { get; set; }

        public virtual OnetAbilities Ability { get; set; }
    }
}
