using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CntTaskStatements
    {
        public int StatementId { get; set; }
        public int Cnt { get; set; }

        public virtual OnetTaskStatements Statement { get; set; }
    }
}
