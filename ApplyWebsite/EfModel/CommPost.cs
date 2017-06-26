using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommPost
    {
        public int Id { get; set; }
        public int CommId { get; set; }
        public int PostId { get; set; }
    }
}
