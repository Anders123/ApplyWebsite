using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ExperienceAttr
    {
        public int Id { get; set; }
        public int ExperienceId { get; set; }
        public string ExpCategory { get; set; }
        public int? AttrId { get; set; }

        public virtual Attr Attr { get; set; }
    }
}
