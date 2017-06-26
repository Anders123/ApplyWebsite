using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Tag
    {
        public Tag()
        {
            AccountTag = new HashSet<AccountTag>();
            PersonTag = new HashSet<PersonTag>();
        }

        public int Id { get; set; }
        public string Tag1 { get; set; }
        public string TagType { get; set; }

        public virtual ICollection<AccountTag> AccountTag { get; set; }
        public virtual ICollection<PersonTag> PersonTag { get; set; }
    }
}
