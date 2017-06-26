using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountTag
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int TagId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
