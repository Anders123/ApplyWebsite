using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class RoleAccountPerson
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int AccountPersonId { get; set; }

        public virtual AccountPerson AccountPerson { get; set; }
        public virtual Role Role { get; set; }
    }
}
