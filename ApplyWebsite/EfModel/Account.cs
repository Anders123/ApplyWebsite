using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Account
    {
        public Account()
        {
            AccountAlbum = new HashSet<AccountAlbum>();
            AccountAltName = new HashSet<AccountAltName>();
            AccountApprovalStatus = new HashSet<AccountApprovalStatus>();
            AccountExternal = new HashSet<AccountExternal>();
            AccountGroup = new HashSet<AccountGroup>();
            AccountIndustry = new HashSet<AccountIndustry>();
            AccountLink = new HashSet<AccountLink>();
            AccountLogo = new HashSet<AccountLogo>();
            AccountPerson = new HashSet<AccountPerson>();
            AccountRelationship = new HashSet<AccountRelationship>();
            AccountReleationshipIntroBy = new HashSet<AccountReleationshipIntroBy>();
            AccountTag = new HashSet<AccountTag>();
            AccountVideo = new HashSet<AccountVideo>();
            Clock = new HashSet<Clock>();
            Comm = new HashSet<Comm>();
            Comment = new HashSet<Comment>();
            EventAccount = new HashSet<EventAccount>();
            EventPerson = new HashSet<EventPerson>();
            Experience = new HashSet<Experience>();
            FeedControlAccount = new HashSet<FeedControlAccount>();
            ImageLibrary = new HashSet<ImageLibrary>();
            Interview = new HashSet<Interview>();
            InterviewQuestionFeedMapping = new HashSet<InterviewQuestionFeedMapping>();
            InterviewQuestionLibrary = new HashSet<InterviewQuestionLibrary>();
            Post = new HashSet<Post>();
            PostMap = new HashSet<PostMap>();
            PostReq = new HashSet<PostReq>();
            ProfileReference = new HashSet<ProfileReference>();
            ProfileReferralByAccount = new HashSet<ProfileReferral>();
            ProfileReferralToAccount = new HashSet<ProfileReferral>();
            RoleAccount = new HashSet<RoleAccount>();
            SearchStatement = new HashSet<SearchStatement>();
            Story = new HashSet<Story>();
            StoryTimeline = new HashSet<StoryTimeline>();
            TaskResource = new HashSet<TaskResource>();
            ThemeAccount = new HashSet<ThemeAccount>();
            ThemeLinkParameter = new HashSet<ThemeLinkParameter>();
            TrackAccount = new HashSet<TrackAccount>();
        }

        public int Id { get; set; }
        public string AccountName { get; set; }
        public string ShortName { get; set; }
        public string AccountDescription { get; set; }
        public int? CompanyId { get; set; }
        public string Logo { get; set; }
        public string Icon { get; set; }
        public string Pin { get; set; }
        public bool Ats { get; set; }
        public bool? Atsid { get; set; }
        public string Atsidentifier { get; set; }
        public int? AssetId { get; set; }
        public string WebsiteUrl { get; set; }
        public string OutsideId { get; set; }
        public int? ThumbnailId { get; set; }
        public int? BannerId { get; set; }
        public int? DefaultLogoId { get; set; }
        public string AccountSummary { get; set; }

        public virtual ICollection<AccountAlbum> AccountAlbum { get; set; }
        public virtual ICollection<AccountAltName> AccountAltName { get; set; }
        public virtual ICollection<AccountApprovalStatus> AccountApprovalStatus { get; set; }
        public virtual ICollection<AccountExternal> AccountExternal { get; set; }
        public virtual ICollection<AccountGroup> AccountGroup { get; set; }
        public virtual ICollection<AccountIndustry> AccountIndustry { get; set; }
        public virtual ICollection<AccountLink> AccountLink { get; set; }
        public virtual ICollection<AccountLogo> AccountLogo { get; set; }
        public virtual ICollection<AccountPerson> AccountPerson { get; set; }
        public virtual ICollection<AccountRelationship> AccountRelationship { get; set; }
        public virtual ICollection<AccountReleationshipIntroBy> AccountReleationshipIntroBy { get; set; }
        public virtual ICollection<AccountTag> AccountTag { get; set; }
        public virtual ICollection<AccountVideo> AccountVideo { get; set; }
        public virtual ICollection<Clock> Clock { get; set; }
        public virtual ICollection<Comm> Comm { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<EventAccount> EventAccount { get; set; }
        public virtual ICollection<EventPerson> EventPerson { get; set; }
        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<FeedControlAccount> FeedControlAccount { get; set; }
        public virtual ICollection<ImageLibrary> ImageLibrary { get; set; }
        public virtual ICollection<Interview> Interview { get; set; }
        public virtual ICollection<InterviewQuestionFeedMapping> InterviewQuestionFeedMapping { get; set; }
        public virtual ICollection<InterviewQuestionLibrary> InterviewQuestionLibrary { get; set; }
        public virtual ICollection<Post> Post { get; set; }
        public virtual ICollection<PostMap> PostMap { get; set; }
        public virtual ICollection<PostReq> PostReq { get; set; }
        public virtual ICollection<ProfileReference> ProfileReference { get; set; }
        public virtual ICollection<ProfileReferral> ProfileReferralByAccount { get; set; }
        public virtual ICollection<ProfileReferral> ProfileReferralToAccount { get; set; }
        public virtual ICollection<RoleAccount> RoleAccount { get; set; }
        public virtual ICollection<SearchStatement> SearchStatement { get; set; }
        public virtual ICollection<Story> Story { get; set; }
        public virtual ICollection<StoryTimeline> StoryTimeline { get; set; }
        public virtual ICollection<TaskResource> TaskResource { get; set; }
        public virtual ICollection<ThemeAccount> ThemeAccount { get; set; }
        public virtual ICollection<ThemeLinkParameter> ThemeLinkParameter { get; set; }
        public virtual ICollection<TrackAccount> TrackAccount { get; set; }
        public virtual AssetItem Asset { get; set; }
        public virtual ImageLibrary Banner { get; set; }
        public virtual Company Company { get; set; }
        public virtual ImageLibrary DefaultLogo { get; set; }
        public virtual ImageLibrary Thumbnail { get; set; }
    }
}
