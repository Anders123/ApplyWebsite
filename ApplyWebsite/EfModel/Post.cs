using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Post
    {
        public Post()
        {
            BriefcasePost = new HashSet<BriefcasePost>();
            BriefcasePostListing = new HashSet<BriefcasePostListing>();
            PostAttr = new HashSet<PostAttr>();
            PostIndustry = new HashSet<PostIndustry>();
            PostKeyword = new HashSet<PostKeyword>();
            PostKeywordExclude = new HashSet<PostKeywordExclude>();
            PostListing = new HashSet<PostListing>();
            PostOnet = new HashSet<PostOnet>();
            PostRelatedChild = new HashSet<PostRelated>();
            PostRelatedParent = new HashSet<PostRelated>();
            SearchStatementPost = new HashSet<SearchStatementPost>();
            ThemeLinkParameter = new HashSet<ThemeLinkParameter>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public bool OverrideImportedTitle { get; set; }
        public int AccountId { get; set; }
        public int OwnerId { get; set; }
        public int CategoryId { get; set; }
        public int GroupId { get; set; }
        public int InterviewId { get; set; }
        public int? ThumbnailId { get; set; }
        public int? LogoId { get; set; }
        public int TypeId { get; set; }
        public int? MapId { get; set; }
        public int? AlbumId { get; set; }
        public int? VideoId { get; set; }
        public bool ShowLinks { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public bool OverrideImportedText { get; set; }
        public bool AllowContact { get; set; }
        public bool AllowApply { get; set; }
        public bool AllowComments { get; set; }
        public DateTime ReleaseDte { get; set; }
        public DateTime? HideDte { get; set; }
        public int? CreatedById { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? ModifiedById { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public int PostRank { get; set; }
        public int? VideoCoverPhotoId { get; set; }

        public virtual ICollection<BriefcasePost> BriefcasePost { get; set; }
        public virtual ICollection<BriefcasePostListing> BriefcasePostListing { get; set; }
        public virtual ICollection<PostAttr> PostAttr { get; set; }
        public virtual ICollection<PostIndustry> PostIndustry { get; set; }
        public virtual ICollection<PostKeyword> PostKeyword { get; set; }
        public virtual ICollection<PostKeywordExclude> PostKeywordExclude { get; set; }
        public virtual ICollection<PostListing> PostListing { get; set; }
        public virtual ICollection<PostOnet> PostOnet { get; set; }
        public virtual ICollection<PostRelated> PostRelatedChild { get; set; }
        public virtual ICollection<PostRelated> PostRelatedParent { get; set; }
        public virtual ICollection<SearchStatementPost> SearchStatementPost { get; set; }
        public virtual ICollection<ThemeLinkParameter> ThemeLinkParameter { get; set; }
        public virtual Account Account { get; set; }
        public virtual AccountAlbum Album { get; set; }
        public virtual PostCategory Category { get; set; }
        public virtual Person CreatedBy { get; set; }
        public virtual AccountGroup Group { get; set; }
        public virtual AccountLogo Logo { get; set; }
        public virtual PostMap Map { get; set; }
        public virtual Person ModifiedBy { get; set; }
        public virtual Person Owner { get; set; }
        public virtual ImageLibrary Thumbnail { get; set; }
        public virtual PostType Type { get; set; }
        public virtual ImageLibrary VideoCoverPhoto { get; set; }
        public virtual AccountVideo Video { get; set; }
    }
}
