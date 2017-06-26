using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class MediaVideoProvider
    {
        public MediaVideoProvider()
        {
            AccountVideo = new HashSet<AccountVideo>();
        }

        public int Id { get; set; }
        public string VideoProviderName { get; set; }

        public virtual ICollection<AccountVideo> AccountVideo { get; set; }
    }
}
