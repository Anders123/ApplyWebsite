using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ChatMessageViaMethod
    {
        public ChatMessageViaMethod()
        {
            PersonViaMethod = new HashSet<PersonViaMethod>();
        }

        public int Id { get; set; }
        public string ViaMethodName { get; set; }

        public virtual ICollection<PersonViaMethod> PersonViaMethod { get; set; }
    }
}
