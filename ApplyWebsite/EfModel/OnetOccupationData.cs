using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetOccupationData
    {
        public OnetOccupationData()
        {
            CoreTitleOnet = new HashSet<CoreTitleOnet>();
            ExpDetailOccupation = new HashSet<ExpDetailOccupation>();
            Experience = new HashSet<Experience>();
            ExperienceOnetOccupation = new HashSet<ExperienceOnetOccupation>();
            OnetAbilities = new HashSet<OnetAbilities>();
            OnetAlternateTitle = new HashSet<OnetAlternateTitle>();
            OnetCareerChangersMatrixOnetsocCodeNavigation = new HashSet<OnetCareerChangersMatrix>();
            OnetCareerChangersMatrixRelatedOnetsocCodeNavigation = new HashSet<OnetCareerChangersMatrix>();
            OnetCareerStartersMatrixOnetsocCodeNavigation = new HashSet<OnetCareerStartersMatrix>();
            OnetCareerStartersMatrixRelatedOnetsocCodeNavigation = new HashSet<OnetCareerStartersMatrix>();
            OnetCrosswalk = new HashSet<OnetCrosswalk>();
            OnetCrosswalkSupplementary = new HashSet<OnetCrosswalkSupplementary>();
            OnetKnowledge = new HashSet<OnetKnowledge>();
            OnetSampleOfReportedTitles = new HashSet<OnetSampleOfReportedTitles>();
            OnetSkills = new HashSet<OnetSkills>();
            OnetTaskStatements = new HashSet<OnetTaskStatements>();
            OnetToolsAndTechnology = new HashSet<OnetToolsAndTechnology>();
            OnetWorkActivities = new HashSet<OnetWorkActivities>();
            PostOnet = new HashSet<PostOnet>();
        }

        public int Id { get; set; }
        public string OnetsocCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DescriptionPastTense { get; set; }

        public virtual CntOccupation CntOccupation { get; set; }
        public virtual ICollection<CoreTitleOnet> CoreTitleOnet { get; set; }
        public virtual ICollection<ExpDetailOccupation> ExpDetailOccupation { get; set; }
        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<ExperienceOnetOccupation> ExperienceOnetOccupation { get; set; }
        public virtual ICollection<OnetAbilities> OnetAbilities { get; set; }
        public virtual ICollection<OnetAlternateTitle> OnetAlternateTitle { get; set; }
        public virtual ICollection<OnetCareerChangersMatrix> OnetCareerChangersMatrixOnetsocCodeNavigation { get; set; }
        public virtual ICollection<OnetCareerChangersMatrix> OnetCareerChangersMatrixRelatedOnetsocCodeNavigation { get; set; }
        public virtual ICollection<OnetCareerStartersMatrix> OnetCareerStartersMatrixOnetsocCodeNavigation { get; set; }
        public virtual ICollection<OnetCareerStartersMatrix> OnetCareerStartersMatrixRelatedOnetsocCodeNavigation { get; set; }
        public virtual ICollection<OnetCrosswalk> OnetCrosswalk { get; set; }
        public virtual ICollection<OnetCrosswalkSupplementary> OnetCrosswalkSupplementary { get; set; }
        public virtual ICollection<OnetKnowledge> OnetKnowledge { get; set; }
        public virtual ICollection<OnetSampleOfReportedTitles> OnetSampleOfReportedTitles { get; set; }
        public virtual ICollection<OnetSkills> OnetSkills { get; set; }
        public virtual ICollection<OnetTaskStatements> OnetTaskStatements { get; set; }
        public virtual ICollection<OnetToolsAndTechnology> OnetToolsAndTechnology { get; set; }
        public virtual ICollection<OnetWorkActivities> OnetWorkActivities { get; set; }
        public virtual ICollection<PostOnet> PostOnet { get; set; }
    }
}
