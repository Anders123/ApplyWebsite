using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommMemberCommMethod
    {
        public int Id { get; set; }
        public int CommMemberId { get; set; }
        public int MethodId { get; set; }

        public virtual CommMember CommMember { get; set; }
        public virtual CommMethod Method { get; set; }
    }
}
