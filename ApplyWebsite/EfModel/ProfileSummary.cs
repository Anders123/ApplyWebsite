using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileSummary
    {
        public ProfileSummary()
        {
            ExpDetailProfileSummary = new HashSet<ExpDetailProfileSummary>();
            ProfileSummaryAttr = new HashSet<ProfileSummaryAttr>();
        }

        public int Id { get; set; }
        public string SummaryName { get; set; }
        public string Summary { get; set; }
        public int SummaryRank { get; set; }
        public bool ForExperience { get; set; }
        public bool FillInBlanks { get; set; }
        public int? OutsideId { get; set; }

        public virtual CntProfileSummary CntProfileSummary { get; set; }
        public virtual ICollection<ExpDetailProfileSummary> ExpDetailProfileSummary { get; set; }
        public virtual ICollection<ProfileSummaryAttr> ProfileSummaryAttr { get; set; }
    }
}
