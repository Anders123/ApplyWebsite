using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetCrosswalk
    {
        public int Id { get; set; }
        public string Onetcode { get; set; }
        public string Moccode { get; set; }

        public virtual OnetOccupationData OnetcodeNavigation { get; set; }
    }
}
