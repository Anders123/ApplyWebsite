using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ReferenceType
    {
        public ReferenceType()
        {
            ProfileReference = new HashSet<ProfileReference>();
        }

        public int Id { get; set; }
        public string ReferenceType1 { get; set; }

        public virtual ICollection<ProfileReference> ProfileReference { get; set; }
    }
}
