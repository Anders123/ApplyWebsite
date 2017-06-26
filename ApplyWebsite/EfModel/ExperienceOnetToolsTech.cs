using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceOnetToolsTech
    {
        public int ExperienceId { get; set; }
        public int ToolsTechId { get; set; }
        public int DisplayRank { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual Experience Experience { get; set; }
        public virtual OnetToolsAndTechnology ToolsTech { get; set; }
    }
}
