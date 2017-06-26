using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class CommentType
    {
        public CommentType()
        {
            Comment = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string CommentTypeName { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
    }
}
