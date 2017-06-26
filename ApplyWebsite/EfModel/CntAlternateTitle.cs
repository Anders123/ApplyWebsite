using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntAlternateTitle
    {
        public int AltTitleId { get; set; }
        public int Cnt { get; set; }

        public virtual OnetAlternateTitle AltTitle { get; set; }
    }
}
