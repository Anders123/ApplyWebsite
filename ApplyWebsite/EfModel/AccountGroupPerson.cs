using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountGroupPerson
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int PersonId { get; set; }

        public virtual AccountGroup Group { get; set; }
        public virtual Person Person { get; set; }
    }
}
