using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class DatabaseJob
    {
        public int Id { get; set; }
        public int JobTypeId { get; set; }
        public string JobDetails { get; set; }
        public string JobSql { get; set; }
        public bool NotifyOnCompletion { get; set; }
        public Guid ById { get; set; }
        public DateTime OrderedAtId { get; set; }
        public bool JobComplete { get; set; }
        public DateTime? CompleteAt { get; set; }
        public string JobResults { get; set; }
        public bool ErrorOccured { get; set; }
        public string ErroNo { get; set; }

        public virtual DatabaseJobType JobType { get; set; }
    }
}
