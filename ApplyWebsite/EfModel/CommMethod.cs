using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommMethod
    {
        public CommMethod()
        {
            CommMemberCommMethod = new HashSet<CommMemberCommMethod>();
            CommMessageLog = new HashSet<CommMessageLog>();
            PersonCommMethodPref = new HashSet<PersonCommMethodPref>();
        }

        public int Id { get; set; }
        public string Method { get; set; }
        public int MethodRank { get; set; }

        public virtual ICollection<CommMemberCommMethod> CommMemberCommMethod { get; set; }
        public virtual ICollection<CommMessageLog> CommMessageLog { get; set; }
        public virtual ICollection<PersonCommMethodPref> PersonCommMethodPref { get; set; }
    }
}
