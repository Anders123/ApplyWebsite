using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntSampleTitle
    {
        public int SampleTitleId { get; set; }
        public int Cnt { get; set; }

        public virtual OnetSampleOfReportedTitles SampleTitle { get; set; }
    }
}
