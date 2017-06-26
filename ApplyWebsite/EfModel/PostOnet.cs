using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostOnet
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int OnetId { get; set; }

        public virtual OnetOccupationData Onet { get; set; }
        public virtual Post Post { get; set; }
    }
}
