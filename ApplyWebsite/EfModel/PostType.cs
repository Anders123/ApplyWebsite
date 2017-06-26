using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostType
    {
        public PostType()
        {
            Post = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string PostTypeName { get; set; }

        public virtual ICollection<Post> Post { get; set; }
    }
}
