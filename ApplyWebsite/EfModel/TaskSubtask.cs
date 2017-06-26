using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TaskSubtask
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string SubtaskName { get; set; }
        public int SubtaskRank { get; set; }
    }
}
