using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetUnspscReference
    {
        public OnetUnspscReference()
        {
            OnetToolsAndTechnology = new HashSet<OnetToolsAndTechnology>();
        }

        public decimal CommodityCode { get; set; }
        public string CommodityTitle { get; set; }
        public decimal ClassCode { get; set; }
        public string ClassTitle { get; set; }
        public decimal FamilyCode { get; set; }
        public string FamilyTitle { get; set; }
        public decimal SegmentCode { get; set; }
        public string SegmentTitle { get; set; }

        public virtual ICollection<OnetToolsAndTechnology> OnetToolsAndTechnology { get; set; }
    }
}
