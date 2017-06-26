using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class RolePerson
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PersonId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Role Role { get; set; }
    }
}
