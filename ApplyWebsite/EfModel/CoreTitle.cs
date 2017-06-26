using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CoreTitle
    {
        public CoreTitle()
        {
            CoreTitleAttr = new HashSet<CoreTitleAttr>();
            CoreTitleOnet = new HashSet<CoreTitleOnet>();
            Listing = new HashSet<Listing>();
            SearchStatementCoreTitle = new HashSet<SearchStatementCoreTitle>();
            ThemeLinkParameter = new HashSet<ThemeLinkParameter>();
        }

        public int Id { get; set; }
        public string JobCode { get; set; }
        public string JobTitle { get; set; }
        public string JobTitleLevel { get; set; }
        public string JobFamily { get; set; }
        public string JobType { get; set; }
        public string JobDescription { get; set; }
        public string ExperienceFrom { get; set; }
        public string ExperienceTo { get; set; }
        public string Education { get; set; }
        public string FlsaStatus { get; set; }
        public double? Base25Hourly { get; set; }
        public double? Base50Hourly { get; set; }
        public double? Base75Hourly { get; set; }
        public double? BaseAvgHourly { get; set; }
        public double? Tcc25Hourly { get; set; }
        public double? Tcc50Hourly { get; set; }
        public double? Tcc75Hourly { get; set; }
        public double? TccavgHourly { get; set; }
        public double? Base25Annual { get; set; }
        public double? Base50Annual { get; set; }
        public double? Base75Annual { get; set; }
        public double? BaseAvgAnnual { get; set; }
        public double? Tcc25Annual { get; set; }
        public double? Tcc50Annual { get; set; }
        public double? Tcc75Annual { get; set; }
        public double? TccavgAnnual { get; set; }

        public virtual ICollection<CoreTitleAttr> CoreTitleAttr { get; set; }
        public virtual ICollection<CoreTitleOnet> CoreTitleOnet { get; set; }
        public virtual ICollection<Listing> Listing { get; set; }
        public virtual ICollection<SearchStatementCoreTitle> SearchStatementCoreTitle { get; set; }
        public virtual ICollection<ThemeLinkParameter> ThemeLinkParameter { get; set; }
    }
}
