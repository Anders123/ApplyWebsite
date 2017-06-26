using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CoreTitleOnet
    {
        public int TitleId { get; set; }
        public int OnetId { get; set; }

        public virtual OnetOccupationData Onet { get; set; }
        public virtual CoreTitle Title { get; set; }
    }
}
