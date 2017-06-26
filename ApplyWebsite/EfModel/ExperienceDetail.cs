using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceDetail
    {
        public ExperienceDetail()
        {
            ExpDetailAbilities = new HashSet<ExpDetailAbilities>();
            ExpDetailActivities = new HashSet<ExpDetailActivities>();
            ExpDetailAttr = new HashSet<ExpDetailAttr>();
            ExpDetailKnowledge = new HashSet<ExpDetailKnowledge>();
            ExpDetailOccupation = new HashSet<ExpDetailOccupation>();
            ExpDetailProfileSummary = new HashSet<ExpDetailProfileSummary>();
            ExpDetailSkills = new HashSet<ExpDetailSkills>();
            ExpDetailTaskStatements = new HashSet<ExpDetailTaskStatements>();
            SuggestionExperienceDetail = new HashSet<SuggestionExperienceDetail>();
        }

        public int Id { get; set; }
        public int ExperienceId { get; set; }
        public string ExperienceDetail1 { get; set; }
        public string OnetCodeType { get; set; }
        public int? OnetCodeId { get; set; }
        public string OnetCode { get; set; }
        public int DetailRank { get; set; }
        public bool HideDetail { get; set; }
        public int? OutsideParentId { get; set; }
        public int? OutsideId { get; set; }
        public string OutsideSource { get; set; }

        public virtual ICollection<ExpDetailAbilities> ExpDetailAbilities { get; set; }
        public virtual ICollection<ExpDetailActivities> ExpDetailActivities { get; set; }
        public virtual ICollection<ExpDetailAttr> ExpDetailAttr { get; set; }
        public virtual ICollection<ExpDetailKnowledge> ExpDetailKnowledge { get; set; }
        public virtual ICollection<ExpDetailOccupation> ExpDetailOccupation { get; set; }
        public virtual ICollection<ExpDetailProfileSummary> ExpDetailProfileSummary { get; set; }
        public virtual ICollection<ExpDetailSkills> ExpDetailSkills { get; set; }
        public virtual ICollection<ExpDetailTaskStatements> ExpDetailTaskStatements { get; set; }
        public virtual ICollection<SuggestionExperienceDetail> SuggestionExperienceDetail { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
