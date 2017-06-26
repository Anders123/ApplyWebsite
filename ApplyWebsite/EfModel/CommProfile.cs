using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommProfile
    {
        public int Id { get; set; }
        public int CommId { get; set; }
        public int ProfileId { get; set; }
        public string SectionName { get; set; }

        public virtual Comm Comm { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
