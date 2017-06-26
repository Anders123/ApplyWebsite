using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Role
    {
        public Role()
        {
            RoleAccount = new HashSet<RoleAccount>();
            RoleAccountPerson = new HashSet<RoleAccountPerson>();
            RolePerson = new HashSet<RolePerson>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleType { get; set; }
        public int RoleRank { get; set; }

        public virtual ICollection<RoleAccount> RoleAccount { get; set; }
        public virtual ICollection<RoleAccountPerson> RoleAccountPerson { get; set; }
        public virtual ICollection<RolePerson> RolePerson { get; set; }
    }
}
