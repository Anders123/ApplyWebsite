using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetToolsAndTechnology
    {
        public OnetToolsAndTechnology()
        {
            ExperienceOnetToolsTech = new HashSet<ExperienceOnetToolsTech>();
        }

        public int Id { get; set; }
        public string OnetsocCode { get; set; }
        public string T2Type { get; set; }
        public string T2Example { get; set; }
        public decimal CommodityCode { get; set; }
        public string HotTechnology { get; set; }

        public virtual CntToolsTech CntToolsTech { get; set; }
        public virtual ICollection<ExperienceOnetToolsTech> ExperienceOnetToolsTech { get; set; }
        public virtual OnetUnspscReference CommodityCodeNavigation { get; set; }
        public virtual OnetOccupationData OnetsocCodeNavigation { get; set; }
    }
}
