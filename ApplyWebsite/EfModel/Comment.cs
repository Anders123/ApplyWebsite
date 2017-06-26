using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Comment
    {
        public Comment()
        {
            CommentPost = new HashSet<CommentPost>();
            CommentProfile = new HashSet<CommentProfile>();
            CommentRelatedChild = new HashSet<CommentRelated>();
            CommentRelatedParent = new HashSet<CommentRelated>();
        }

        public int Id { get; set; }
        public int CommentTypeId { get; set; }
        public string CommentText { get; set; }
        public int CommentById { get; set; }
        public DateTime CommentAt { get; set; }
        public int? CommentAccountId { get; set; }
        public bool CommentPublic { get; set; }

        public virtual ICollection<CommentPost> CommentPost { get; set; }
        public virtual ICollection<CommentProfile> CommentProfile { get; set; }
        public virtual ICollection<CommentRelated> CommentRelatedChild { get; set; }
        public virtual ICollection<CommentRelated> CommentRelatedParent { get; set; }
        public virtual Account CommentAccount { get; set; }
        public virtual Person CommentBy { get; set; }
        public virtual CommentType CommentType { get; set; }
    }
}
