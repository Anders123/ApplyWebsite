using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommentPost
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int PostId { get; set; }

        public virtual Comment Comment { get; set; }
    }
}
