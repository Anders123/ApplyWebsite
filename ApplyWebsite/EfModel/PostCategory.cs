using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostCategory
    {
        public PostCategory()
        {
            Post = new HashSet<Post>();
            ThemeLinkParameter = new HashSet<ThemeLinkParameter>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Post> Post { get; set; }
        public virtual ICollection<ThemeLinkParameter> ThemeLinkParameter { get; set; }
    }
}
