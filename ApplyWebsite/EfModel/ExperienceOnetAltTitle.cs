using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceOnetAltTitle
    {
        public int ExperienceId { get; set; }
        public int AltTitleId { get; set; }
        public int DisplayRank { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual OnetAlternateTitle AltTitle { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
