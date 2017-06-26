using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExpDetailTaskStatements
    {
        public int DetailId { get; set; }
        public int TaskStatementId { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ExperienceDetail Detail { get; set; }
        public virtual OnetTaskStatements TaskStatement { get; set; }
    }
}
