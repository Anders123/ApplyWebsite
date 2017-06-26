using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetCareerChangersMatrix
    {
        public string OnetsocCode { get; set; }
        public string RelatedOnetsocCode { get; set; }
        public decimal RelatedIndex { get; set; }

        public virtual OnetOccupationData OnetsocCodeNavigation { get; set; }
        public virtual OnetOccupationData RelatedOnetsocCodeNavigation { get; set; }
    }
}
