using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceOnetSampleTitles
    {
        public int ExperienceId { get; set; }
        public int SampleTitlesId { get; set; }
        public int DisplayRank { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Experience Experience { get; set; }
        public virtual OnetSampleOfReportedTitles SampleTitles { get; set; }
    }
}
