using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class RoleAccount
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
