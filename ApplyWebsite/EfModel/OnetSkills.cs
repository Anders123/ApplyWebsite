using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetSkills
    {
        public OnetSkills()
        {
            ExpDetailSkills = new HashSet<ExpDetailSkills>();
            ExperienceOnetSkills = new HashSet<ExperienceOnetSkills>();
        }

        public int Id { get; set; }
        public string OnetsocCode { get; set; }
        public string ElementId { get; set; }
        public string ScaleId { get; set; }
        public decimal DataValue { get; set; }
        public decimal? N { get; set; }
        public decimal? StandardError { get; set; }
        public decimal? LowerCiBound { get; set; }
        public decimal? UpperCiBound { get; set; }
        public string RecommendSuppress { get; set; }
        public string NotRelevant { get; set; }
        public DateTime DateUpdated { get; set; }
        public string DomainSource { get; set; }

        public virtual CntSkills CntSkills { get; set; }
        public virtual ICollection<ExpDetailSkills> ExpDetailSkills { get; set; }
        public virtual ICollection<ExperienceOnetSkills> ExperienceOnetSkills { get; set; }
        public virtual OnetOccupationData OnetsocCodeNavigation { get; set; }
        public virtual OnetScalesReference Scale { get; set; }
    }
}
