using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class QueueType
    {
        public QueueType()
        {
            AccountGroup = new HashSet<AccountGroup>();
        }

        public int Id { get; set; }
        public string QueueTypeName { get; set; }

        public virtual ICollection<AccountGroup> AccountGroup { get; set; }
    }
}
