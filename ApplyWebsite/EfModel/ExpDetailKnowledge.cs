using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExpDetailKnowledge
    {
        public int DetailId { get; set; }
        public int KnowledgeId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ExperienceDetail Detail { get; set; }
        public virtual OnetKnowledge Knowledge { get; set; }
    }
}
