using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetAlternateTitle
    {
        public OnetAlternateTitle()
        {
            Experience = new HashSet<Experience>();
            ExperienceOnetAltTitle = new HashSet<ExperienceOnetAltTitle>();
        }

        public int Id { get; set; }
        public string OnetsocCode { get; set; }
        public string Title { get; set; }
        public string AlternateTitle { get; set; }
        public string ShortTitle { get; set; }
        public double? Sources { get; set; }

        public virtual CntAlternateTitle CntAlternateTitle { get; set; }
        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<ExperienceOnetAltTitle> ExperienceOnetAltTitle { get; set; }
        public virtual OnetOccupationData OnetsocCodeNavigation { get; set; }
    }
}
