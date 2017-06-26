using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceState
    {
        public int Id { get; set; }
        public int ExperienceId { get; set; }
        public int StateId { get; set; }

        public virtual Experience Experience { get; set; }
        public virtual GeoState State { get; set; }
    }
}
