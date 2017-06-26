using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetSampleOfReportedTitles
    {
        public OnetSampleOfReportedTitles()
        {
            ExperienceOnetSampleTitles = new HashSet<ExperienceOnetSampleTitles>();
        }

        public int Id { get; set; }
        public string OnetsocCode { get; set; }
        public string ReportedJobTitle { get; set; }
        public string ShownInMyNextMove { get; set; }

        public virtual CntSampleTitle CntSampleTitle { get; set; }
        public virtual ICollection<ExperienceOnetSampleTitles> ExperienceOnetSampleTitles { get; set; }
        public virtual OnetOccupationData OnetsocCodeNavigation { get; set; }
    }
}
