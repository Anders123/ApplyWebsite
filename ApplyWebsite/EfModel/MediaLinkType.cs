using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class MediaLinkType
    {
        public MediaLinkType()
        {
            AccountLink = new HashSet<AccountLink>();
        }

        public int Id { get; set; }
        public string LinkTypeName { get; set; }

        public virtual ICollection<AccountLink> AccountLink { get; set; }
    }
}
