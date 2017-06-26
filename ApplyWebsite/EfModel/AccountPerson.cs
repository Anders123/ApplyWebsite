using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountPerson
    {
        public AccountPerson()
        {
            RoleAccountPerson = new HashSet<RoleAccountPerson>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public int PersonId { get; set; }

        public virtual ICollection<RoleAccountPerson> RoleAccountPerson { get; set; }
        public virtual Account Account { get; set; }
        public virtual Person Person { get; set; }
    }
}
