using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Share
    {
        public Share()
        {
            ShareTaskResource = new HashSet<ShareTaskResource>();
        }

        public int Id { get; set; }
        public int? SharedById { get; set; }
        public int SharedWithId { get; set; }
        public DateTime SharedAt { get; set; }
        public DateTime? ViewedAt { get; set; }

        public virtual ICollection<ShareTaskResource> ShareTaskResource { get; set; }
        public virtual Person SharedBy { get; set; }
        public virtual Person SharedWith { get; set; }
    }
}
