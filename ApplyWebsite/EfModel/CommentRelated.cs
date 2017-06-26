using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommentRelated
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ChildId { get; set; }

        public virtual Comment Child { get; set; }
        public virtual Comment Parent { get; set; }
    }
}
