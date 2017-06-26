using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class TrackAccount
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Track Track { get; set; }
    }
}
