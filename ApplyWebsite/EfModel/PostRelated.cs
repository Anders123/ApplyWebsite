using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostRelated
    {
        public int ParentId { get; set; }
        public int ChildId { get; set; }

        public virtual Post Child { get; set; }
        public virtual Post Parent { get; set; }
    }
}
