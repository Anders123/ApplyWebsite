using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommentProfile
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int ProfileId { get; set; }

        public virtual Comment Comment { get; set; }
    }
}
