using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class SystemJobLog
    {
        public int Id { get; set; }
        public string JobName { get; set; }
        public DateTime JobStart { get; set; }
        public DateTime? JobComplete { get; set; }
        public string JobResult { get; set; }
        public int? ErrNo { get; set; }
        public int? ErrState { get; set; }
        public int? ErrSeverity { get; set; }
        public string ErrProc { get; set; }
        public int? ErrLine { get; set; }
        public string ErrMsg { get; set; }
        public string ErrDesc { get; set; }
    }
}
