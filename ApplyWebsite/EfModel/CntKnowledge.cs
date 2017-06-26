using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntKnowledge
    {
        public int KnowledgeId { get; set; }
        public int Cnt { get; set; }

        public virtual OnetKnowledge Knowledge { get; set; }
    }
}
