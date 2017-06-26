using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetKnowledge
    {
        public OnetKnowledge()
        {
            ExpDetailKnowledge = new HashSet<ExpDetailKnowledge>();
            ExperienceOnetKnowledge = new HashSet<ExperienceOnetKnowledge>();
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

        public virtual CntKnowledge CntKnowledge { get; set; }
        public virtual ICollection<ExpDetailKnowledge> ExpDetailKnowledge { get; set; }
        public virtual ICollection<ExperienceOnetKnowledge> ExperienceOnetKnowledge { get; set; }
        public virtual OnetOccupationData OnetsocCodeNavigation { get; set; }
        public virtual OnetScalesReference Scale { get; set; }
    }
}
