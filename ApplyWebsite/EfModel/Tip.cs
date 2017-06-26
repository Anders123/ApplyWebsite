using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Tip
    {
        public Tip()
        {
            TipAttr = new HashSet<TipAttr>();
        }

        public int Id { get; set; }
        public string TipName { get; set; }
        public string TipText { get; set; }
        public string TipContext { get; set; }
        public int TipRank { get; set; }

        public virtual ICollection<TipAttr> TipAttr { get; set; }
    }
}
