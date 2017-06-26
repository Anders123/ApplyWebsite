using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetScalesReference
    {
        public OnetScalesReference()
        {
            OnetAbilities = new HashSet<OnetAbilities>();
            OnetKnowledge = new HashSet<OnetKnowledge>();
            OnetSkills = new HashSet<OnetSkills>();
            OnetWorkActivities = new HashSet<OnetWorkActivities>();
        }

        public string ScaleId { get; set; }
        public string ScaleName { get; set; }
        public decimal Minimum { get; set; }
        public decimal Maximum { get; set; }

        public virtual ICollection<OnetAbilities> OnetAbilities { get; set; }
        public virtual ICollection<OnetKnowledge> OnetKnowledge { get; set; }
        public virtual ICollection<OnetSkills> OnetSkills { get; set; }
        public virtual ICollection<OnetWorkActivities> OnetWorkActivities { get; set; }
    }
}
