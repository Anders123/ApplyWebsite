using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Alert
    {
        public Alert()
        {
            AlertAttr = new HashSet<AlertAttr>();
            AlertCity = new HashSet<AlertCity>();
            AlertIndustry = new HashSet<AlertIndustry>();
        }

        public int Id { get; set; }
        public int? PersonId { get; set; }
        public string AlertName { get; set; }
        public bool HideYesNo { get; set; }

        public virtual ICollection<AlertAttr> AlertAttr { get; set; }
        public virtual ICollection<AlertCity> AlertCity { get; set; }
        public virtual ICollection<AlertIndustry> AlertIndustry { get; set; }
        public virtual Person Person { get; set; }
    }
}
