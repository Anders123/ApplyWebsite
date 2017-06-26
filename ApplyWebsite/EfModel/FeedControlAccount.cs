using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class FeedControlAccount
    {
        public int ControlId { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual FeedControl Control { get; set; }
    }
}
