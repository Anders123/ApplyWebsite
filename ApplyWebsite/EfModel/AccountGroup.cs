using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountGroup
    {
        public AccountGroup()
        {
            AccountGroupPerson = new HashSet<AccountGroupPerson>();
            Post = new HashSet<Post>();
        }

        public int Id { get; set; }
        public int AccountId { get; set; }
        public string GroupName { get; set; }
        public int QueueTypeId { get; set; }

        public virtual ICollection<AccountGroupPerson> AccountGroupPerson { get; set; }
        public virtual ICollection<Post> Post { get; set; }
        public virtual Account Account { get; set; }
        public virtual QueueType QueueType { get; set; }
    }
}
