using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountLink
    {
        public int Id { get; set; }
        public int LinkTypeId { get; set; }
        public string LinkUrl { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual MediaLinkType LinkType { get; set; }
    }
}
