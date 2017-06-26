using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceOnetKnowledge
    {
        public int ExperienceId { get; set; }
        public int KnowledgeId { get; set; }
        public int DisplayRank { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Experience Experience { get; set; }
        public virtual OnetKnowledge Knowledge { get; set; }
    }
}
