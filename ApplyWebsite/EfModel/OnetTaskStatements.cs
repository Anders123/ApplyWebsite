using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetTaskStatements
    {
        public OnetTaskStatements()
        {
            ExpDetailTaskStatements = new HashSet<ExpDetailTaskStatements>();
        }

        public int Id { get; set; }
        public string OnetsocCode { get; set; }
        public int? TaskId { get; set; }
        public string Task { get; set; }
        public string TaskType { get; set; }
        public decimal? IncumbentsResponding { get; set; }
        public DateTime DateUpdated { get; set; }
        public string DomainSource { get; set; }
        public string TaskPastTense { get; set; }

        public virtual CntTaskStatements CntTaskStatements { get; set; }
        public virtual ICollection<ExpDetailTaskStatements> ExpDetailTaskStatements { get; set; }
        public virtual OnetOccupationData OnetsocCodeNavigation { get; set; }
    }
}
