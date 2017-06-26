using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApplyWebsite.EfModel
{
    public partial class ApplyDbContext : DbContext
    {
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccountAlbum> AccountAlbum { get; set; }
        public virtual DbSet<AccountAlbumPhoto> AccountAlbumPhoto { get; set; }
        public virtual DbSet<AccountAltName> AccountAltName { get; set; }
        public virtual DbSet<AccountApprovalStatus> AccountApprovalStatus { get; set; }
        public virtual DbSet<AccountDssTracking> AccountDssTracking { get; set; }
        public virtual DbSet<AccountExternal> AccountExternal { get; set; }
        public virtual DbSet<AccountExternalDssTracking> AccountExternalDssTracking { get; set; }
        public virtual DbSet<AccountGroup> AccountGroup { get; set; }
        public virtual DbSet<AccountGroupPerson> AccountGroupPerson { get; set; }
        public virtual DbSet<AccountIndustry> AccountIndustry { get; set; }
        public virtual DbSet<AccountLink> AccountLink { get; set; }
        public virtual DbSet<AccountLogo> AccountLogo { get; set; }
        public virtual DbSet<AccountPerson> AccountPerson { get; set; }
        public virtual DbSet<AccountRelationship> AccountRelationship { get; set; }
        public virtual DbSet<AccountRelationshipStatus> AccountRelationshipStatus { get; set; }
        public virtual DbSet<AccountRelationshipStatusHistory> AccountRelationshipStatusHistory { get; set; }
        public virtual DbSet<AccountRelationshipStatusHistoryReason> AccountRelationshipStatusHistoryReason { get; set; }
        public virtual DbSet<AccountRelationshipStatusReason> AccountRelationshipStatusReason { get; set; }
        public virtual DbSet<AccountReleationshipIntroBy> AccountReleationshipIntroBy { get; set; }
        public virtual DbSet<AccountTag> AccountTag { get; set; }
        public virtual DbSet<AccountVideo> AccountVideo { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<ActivityPerson> ActivityPerson { get; set; }
        public virtual DbSet<ActivityTask> ActivityTask { get; set; }
        public virtual DbSet<ActivityTaskResource> ActivityTaskResource { get; set; }
        public virtual DbSet<ActivityTaskStory> ActivityTaskStory { get; set; }
        public virtual DbSet<ActivityType> ActivityType { get; set; }
        public virtual DbSet<ActivtyTaskPhase> ActivtyTaskPhase { get; set; }
        public virtual DbSet<Addr> Addr { get; set; }
        public virtual DbSet<AddrPerson> AddrPerson { get; set; }
        public virtual DbSet<Alert> Alert { get; set; }
        public virtual DbSet<AlertAttr> AlertAttr { get; set; }
        public virtual DbSet<AlertCity> AlertCity { get; set; }
        public virtual DbSet<AlertIndustry> AlertIndustry { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetItem> AssetItem { get; set; }
        public virtual DbSet<AssetItemProperty> AssetItemProperty { get; set; }
        public virtual DbSet<AssetType> AssetType { get; set; }
        public virtual DbSet<Attr> Attr { get; set; }
        public virtual DbSet<AttrIndustry> AttrIndustry { get; set; }
        public virtual DbSet<AttrMapping> AttrMapping { get; set; }
        public virtual DbSet<AttrRankAlt> AttrRankAlt { get; set; }
        public virtual DbSet<AttrRelatedTable> AttrRelatedTable { get; set; }
        public virtual DbSet<Briefcase> Briefcase { get; set; }
        public virtual DbSet<BriefcasePost> BriefcasePost { get; set; }
        public virtual DbSet<BriefcasePostListing> BriefcasePostListing { get; set; }
        public virtual DbSet<BriefcaseType> BriefcaseType { get; set; }
        public virtual DbSet<ChatMessageViaMethod> ChatMessageViaMethod { get; set; }
        public virtual DbSet<Clock> Clock { get; set; }
        public virtual DbSet<ClockStatus> ClockStatus { get; set; }
        public virtual DbSet<CntAbilities> CntAbilities { get; set; }
        public virtual DbSet<CntActivities> CntActivities { get; set; }
        public virtual DbSet<CntAlternateTitle> CntAlternateTitle { get; set; }
        public virtual DbSet<CntAttr> CntAttr { get; set; }
        public virtual DbSet<CntKnowledge> CntKnowledge { get; set; }
        public virtual DbSet<CntOccupation> CntOccupation { get; set; }
        public virtual DbSet<CntProfileSummary> CntProfileSummary { get; set; }
        public virtual DbSet<CntSampleTitle> CntSampleTitle { get; set; }
        public virtual DbSet<CntSkills> CntSkills { get; set; }
        public virtual DbSet<CntTaskStatements> CntTaskStatements { get; set; }
        public virtual DbSet<CntToolsTech> CntToolsTech { get; set; }
        public virtual DbSet<Comm> Comm { get; set; }
        public virtual DbSet<CommCommMemberEvent> CommCommMemberEvent { get; set; }
        public virtual DbSet<CommConnection> CommConnection { get; set; }
        public virtual DbSet<CommMember> CommMember { get; set; }
        public virtual DbSet<CommMemberCommMethod> CommMemberCommMethod { get; set; }
        public virtual DbSet<CommMemberEvent> CommMemberEvent { get; set; }
        public virtual DbSet<CommMessage> CommMessage { get; set; }
        public virtual DbSet<CommMessageLog> CommMessageLog { get; set; }
        public virtual DbSet<CommMethod> CommMethod { get; set; }
        public virtual DbSet<CommPost> CommPost { get; set; }
        public virtual DbSet<CommProfile> CommProfile { get; set; }
        public virtual DbSet<CommPurpose> CommPurpose { get; set; }
        public virtual DbSet<CommRequest> CommRequest { get; set; }
        public virtual DbSet<CommRequestOptions> CommRequestOptions { get; set; }
        public virtual DbSet<CommReview> CommReview { get; set; }
        public virtual DbSet<CommState> CommState { get; set; }
        public virtual DbSet<CommStateLog> CommStateLog { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<CommentPost> CommentPost { get; set; }
        public virtual DbSet<CommentProfile> CommentProfile { get; set; }
        public virtual DbSet<CommentRelated> CommentRelated { get; set; }
        public virtual DbSet<CommentType> CommentType { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyPerson> CompanyPerson { get; set; }
        public virtual DbSet<CoreTitle> CoreTitle { get; set; }
        public virtual DbSet<CoreTitleAttr> CoreTitleAttr { get; set; }
        public virtual DbSet<CoreTitleOnet> CoreTitleOnet { get; set; }
        public virtual DbSet<Dashboard> Dashboard { get; set; }
        public virtual DbSet<DataType> DataType { get; set; }
        public virtual DbSet<DatabaseJob> DatabaseJob { get; set; }
        public virtual DbSet<DatabaseJobType> DatabaseJobType { get; set; }
        public virtual DbSet<DatabaseTable> DatabaseTable { get; set; }
        public virtual DbSet<DurationType> DurationType { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventAccount> EventAccount { get; set; }
        public virtual DbSet<EventAccountRelationship> EventAccountRelationship { get; set; }
        public virtual DbSet<EventPerson> EventPerson { get; set; }
        public virtual DbSet<ExpDetailAbilities> ExpDetailAbilities { get; set; }
        public virtual DbSet<ExpDetailActivities> ExpDetailActivities { get; set; }
        public virtual DbSet<ExpDetailAttr> ExpDetailAttr { get; set; }
        public virtual DbSet<ExpDetailKnowledge> ExpDetailKnowledge { get; set; }
        public virtual DbSet<ExpDetailOccupation> ExpDetailOccupation { get; set; }
        public virtual DbSet<ExpDetailProfileSummary> ExpDetailProfileSummary { get; set; }
        public virtual DbSet<ExpDetailSkills> ExpDetailSkills { get; set; }
        public virtual DbSet<ExpDetailTaskStatements> ExpDetailTaskStatements { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<ExperienceAttr> ExperienceAttr { get; set; }
        public virtual DbSet<ExperienceDetail> ExperienceDetail { get; set; }
        public virtual DbSet<ExperienceOnetAbilities> ExperienceOnetAbilities { get; set; }
        public virtual DbSet<ExperienceOnetActivities> ExperienceOnetActivities { get; set; }
        public virtual DbSet<ExperienceOnetAltTitle> ExperienceOnetAltTitle { get; set; }
        public virtual DbSet<ExperienceOnetKnowledge> ExperienceOnetKnowledge { get; set; }
        public virtual DbSet<ExperienceOnetOccupation> ExperienceOnetOccupation { get; set; }
        public virtual DbSet<ExperienceOnetSampleTitles> ExperienceOnetSampleTitles { get; set; }
        public virtual DbSet<ExperienceOnetSkills> ExperienceOnetSkills { get; set; }
        public virtual DbSet<ExperienceOnetToolsTech> ExperienceOnetToolsTech { get; set; }
        public virtual DbSet<ExperienceReasonLeft> ExperienceReasonLeft { get; set; }
        public virtual DbSet<ExperienceState> ExperienceState { get; set; }
        public virtual DbSet<ExternalSource> ExternalSource { get; set; }
        public virtual DbSet<FeedBatch> FeedBatch { get; set; }
        public virtual DbSet<FeedControl> FeedControl { get; set; }
        public virtual DbSet<FeedControlAccount> FeedControlAccount { get; set; }
        public virtual DbSet<FeedException> FeedException { get; set; }
        public virtual DbSet<FeedLog> FeedLog { get; set; }
        public virtual DbSet<FeedLogProperty> FeedLogProperty { get; set; }
        public virtual DbSet<FeedMapping> FeedMapping { get; set; }
        public virtual DbSet<FeedMappingColumn> FeedMappingColumn { get; set; }
        public virtual DbSet<FeedProperty> FeedProperty { get; set; }
        public virtual DbSet<GeoCity> GeoCity { get; set; }
        public virtual DbSet<GeoCountry> GeoCountry { get; set; }
        public virtual DbSet<GeoRegion> GeoRegion { get; set; }
        public virtual DbSet<GeoState> GeoState { get; set; }
        public virtual DbSet<GeoZip> GeoZip { get; set; }
        public virtual DbSet<GeoZipPop> GeoZipPop { get; set; }
        public virtual DbSet<ImageLibrary> ImageLibrary { get; set; }
        public virtual DbSet<ImageLibraryAttr> ImageLibraryAttr { get; set; }
        public virtual DbSet<ImageLibraryIndustry> ImageLibraryIndustry { get; set; }
        public virtual DbSet<ImageLibraryTag> ImageLibraryTag { get; set; }
        public virtual DbSet<ImageTag> ImageTag { get; set; }
        public virtual DbSet<Industry> Industry { get; set; }
        public virtual DbSet<Interview> Interview { get; set; }
        public virtual DbSet<InterviewAnswer> InterviewAnswer { get; set; }
        public virtual DbSet<InterviewInstance> InterviewInstance { get; set; }
        public virtual DbSet<InterviewInstanceBriefcase> InterviewInstanceBriefcase { get; set; }
        public virtual DbSet<InterviewQuestion> InterviewQuestion { get; set; }
        public virtual DbSet<InterviewQuestionCategory> InterviewQuestionCategory { get; set; }
        public virtual DbSet<InterviewQuestionFeedMapping> InterviewQuestionFeedMapping { get; set; }
        public virtual DbSet<InterviewQuestionLibrary> InterviewQuestionLibrary { get; set; }
        public virtual DbSet<InterviewQuestionRule> InterviewQuestionRule { get; set; }
        public virtual DbSet<InterviewQuestionRuleType> InterviewQuestionRuleType { get; set; }
        public virtual DbSet<InterviewQuestionRuleValue> InterviewQuestionRuleValue { get; set; }
        public virtual DbSet<InterviewQuestionType> InterviewQuestionType { get; set; }
        public virtual DbSet<InterviewRuleFollowUp> InterviewRuleFollowUp { get; set; }
        public virtual DbSet<Keyword> Keyword { get; set; }
        public virtual DbSet<Listing> Listing { get; set; }
        public virtual DbSet<ListingAttr> ListingAttr { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LogClock> LogClock { get; set; }
        public virtual DbSet<LogEvent> LogEvent { get; set; }
        public virtual DbSet<LogoType> LogoType { get; set; }
        public virtual DbSet<MediaLinkType> MediaLinkType { get; set; }
        public virtual DbSet<MediaVideoProvider> MediaVideoProvider { get; set; }
        public virtual DbSet<Metric> Metric { get; set; }
        public virtual DbSet<MetricCategory> MetricCategory { get; set; }
        public virtual DbSet<MilitaryBase> MilitaryBase { get; set; }
        public virtual DbSet<MilitaryBaseMilitaryBranch> MilitaryBaseMilitaryBranch { get; set; }
        public virtual DbSet<MilitaryBasePerson> MilitaryBasePerson { get; set; }
        public virtual DbSet<MilitaryHiringExperience> MilitaryHiringExperience { get; set; }
        public virtual DbSet<NationalResourceDirectory> NationalResourceDirectory { get; set; }
        public virtual DbSet<OnetAbilities> OnetAbilities { get; set; }
        public virtual DbSet<OnetAlternateTitle> OnetAlternateTitle { get; set; }
        public virtual DbSet<OnetCareerChangersMatrix> OnetCareerChangersMatrix { get; set; }
        public virtual DbSet<OnetCareerStartersMatrix> OnetCareerStartersMatrix { get; set; }
        public virtual DbSet<OnetContentModelReference> OnetContentModelReference { get; set; }
        public virtual DbSet<OnetCrosswalk> OnetCrosswalk { get; set; }
        public virtual DbSet<OnetCrosswalkSupplementary> OnetCrosswalkSupplementary { get; set; }
        public virtual DbSet<OnetKnowledge> OnetKnowledge { get; set; }
        public virtual DbSet<OnetOccupationData> OnetOccupationData { get; set; }
        public virtual DbSet<OnetSampleOfReportedTitles> OnetSampleOfReportedTitles { get; set; }
        public virtual DbSet<OnetScalesReference> OnetScalesReference { get; set; }
        public virtual DbSet<OnetSkills> OnetSkills { get; set; }
        public virtual DbSet<OnetTaskStatements> OnetTaskStatements { get; set; }
        public virtual DbSet<OnetToolsAndTechnology> OnetToolsAndTechnology { get; set; }
        public virtual DbSet<OnetUnspscReference> OnetUnspscReference { get; set; }
        public virtual DbSet<OnetWorkActivities> OnetWorkActivities { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonCommMethodPref> PersonCommMethodPref { get; set; }
        public virtual DbSet<PersonDashboard> PersonDashboard { get; set; }
        public virtual DbSet<PersonTag> PersonTag { get; set; }
        public virtual DbSet<PersonViaMethod> PersonViaMethod { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostAttr> PostAttr { get; set; }
        public virtual DbSet<PostCategory> PostCategory { get; set; }
        public virtual DbSet<PostIndustry> PostIndustry { get; set; }
        public virtual DbSet<PostKeyword> PostKeyword { get; set; }
        public virtual DbSet<PostKeywordExclude> PostKeywordExclude { get; set; }
        public virtual DbSet<PostListing> PostListing { get; set; }
        public virtual DbSet<PostMap> PostMap { get; set; }
        public virtual DbSet<PostMapFeature> PostMapFeature { get; set; }
        public virtual DbSet<PostMapFeatureType> PostMapFeatureType { get; set; }
        public virtual DbSet<PostMapGeoRegion> PostMapGeoRegion { get; set; }
        public virtual DbSet<PostMapGeoState> PostMapGeoState { get; set; }
        public virtual DbSet<PostMapPoint> PostMapPoint { get; set; }
        public virtual DbSet<PostOnet> PostOnet { get; set; }
        public virtual DbSet<PostRelated> PostRelated { get; set; }
        public virtual DbSet<PostReq> PostReq { get; set; }
        public virtual DbSet<PostReqDssTracking> PostReqDssTracking { get; set; }
        public virtual DbSet<PostType> PostType { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<ProfileAdditionalInfo> ProfileAdditionalInfo { get; set; }
        public virtual DbSet<ProfileCity> ProfileCity { get; set; }
        public virtual DbSet<ProfileIndustry> ProfileIndustry { get; set; }
        public virtual DbSet<ProfileLanguage> ProfileLanguage { get; set; }
        public virtual DbSet<ProfileLink> ProfileLink { get; set; }
        public virtual DbSet<ProfileMilitaryHonor> ProfileMilitaryHonor { get; set; }
        public virtual DbSet<ProfileOutputFormat> ProfileOutputFormat { get; set; }
        public virtual DbSet<ProfilePercComplete> ProfilePercComplete { get; set; }
        public virtual DbSet<ProfileReference> ProfileReference { get; set; }
        public virtual DbSet<ProfileReferral> ProfileReferral { get; set; }
        public virtual DbSet<ProfileSearch> ProfileSearch { get; set; }
        public virtual DbSet<ProfileSummary> ProfileSummary { get; set; }
        public virtual DbSet<ProfileSummaryAttr> ProfileSummaryAttr { get; set; }
        public virtual DbSet<ProvisionMarkerDss> ProvisionMarkerDss { get; set; }
        public virtual DbSet<QueueType> QueueType { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<RatingTaskResource> RatingTaskResource { get; set; }
        public virtual DbSet<ReasonLeft> ReasonLeft { get; set; }
        public virtual DbSet<ReferenceType> ReferenceType { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<Review> Review { get; set; }
        public virtual DbSet<ReviewSuggestion> ReviewSuggestion { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleAccount> RoleAccount { get; set; }
        public virtual DbSet<RoleAccountPerson> RoleAccountPerson { get; set; }
        public virtual DbSet<RolePerson> RolePerson { get; set; }
        public virtual DbSet<SchemaInfoDss> SchemaInfoDss { get; set; }
        public virtual DbSet<ScopeConfigDss> ScopeConfigDss { get; set; }
        public virtual DbSet<ScopeInfoDss> ScopeInfoDss { get; set; }
        public virtual DbSet<SearchStatement> SearchStatement { get; set; }
        public virtual DbSet<SearchStatementAttr> SearchStatementAttr { get; set; }
        public virtual DbSet<SearchStatementCoreTitle> SearchStatementCoreTitle { get; set; }
        public virtual DbSet<SearchStatementPost> SearchStatementPost { get; set; }
        public virtual DbSet<Share> Share { get; set; }
        public virtual DbSet<ShareTaskResource> ShareTaskResource { get; set; }
        public virtual DbSet<Story> Story { get; set; }
        public virtual DbSet<StoryImages> StoryImages { get; set; }
        public virtual DbSet<StoryTaskResource> StoryTaskResource { get; set; }
        public virtual DbSet<StoryTimeline> StoryTimeline { get; set; }
        public virtual DbSet<SuggestionAdditionalInfo> SuggestionAdditionalInfo { get; set; }
        public virtual DbSet<SuggestionExperienceDetail> SuggestionExperienceDetail { get; set; }
        public virtual DbSet<SuggestionReference> SuggestionReference { get; set; }
        public virtual DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public virtual DbSet<SystemJobLog> SystemJobLog { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskAttr> TaskAttr { get; set; }
        public virtual DbSet<TaskComplete> TaskComplete { get; set; }
        public virtual DbSet<TaskHide> TaskHide { get; set; }
        public virtual DbSet<TaskPhase> TaskPhase { get; set; }
        public virtual DbSet<TaskPhaseAttr> TaskPhaseAttr { get; set; }
        public virtual DbSet<TaskPhaseHint> TaskPhaseHint { get; set; }
        public virtual DbSet<TaskResource> TaskResource { get; set; }
        public virtual DbSet<TaskResourceAttr> TaskResourceAttr { get; set; }
        public virtual DbSet<TaskResourceFeatured> TaskResourceFeatured { get; set; }
        public virtual DbSet<TaskResourceFeaturedOn> TaskResourceFeaturedOn { get; set; }
        public virtual DbSet<TaskResourceHide> TaskResourceHide { get; set; }
        public virtual DbSet<TaskResourceImage> TaskResourceImage { get; set; }
        public virtual DbSet<TaskResourceLink> TaskResourceLink { get; set; }
        public virtual DbSet<TaskResourceRollup> TaskResourceRollup { get; set; }
        public virtual DbSet<TaskSubtask> TaskSubtask { get; set; }
        public virtual DbSet<TaskTaskResource> TaskTaskResource { get; set; }
        public virtual DbSet<Theme> Theme { get; set; }
        public virtual DbSet<ThemeAccount> ThemeAccount { get; set; }
        public virtual DbSet<ThemeIndustry> ThemeIndustry { get; set; }
        public virtual DbSet<ThemeLink> ThemeLink { get; set; }
        public virtual DbSet<ThemeLinkParameter> ThemeLinkParameter { get; set; }
        public virtual DbSet<ThemeMenu> ThemeMenu { get; set; }
        public virtual DbSet<ThemePage> ThemePage { get; set; }
        public virtual DbSet<ThemeParameter> ThemeParameter { get; set; }
        public virtual DbSet<ThemeParameterAttr> ThemeParameterAttr { get; set; }
        public virtual DbSet<ThemeParameterType> ThemeParameterType { get; set; }
        public virtual DbSet<TimeMonth> TimeMonth { get; set; }
        public virtual DbSet<TimeYear> TimeYear { get; set; }
        public virtual DbSet<Tip> Tip { get; set; }
        public virtual DbSet<TipAttr> TipAttr { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<TrackAccount> TrackAccount { get; set; }
        public virtual DbSet<TrackContentType> TrackContentType { get; set; }
        public virtual DbSet<TrackPage> TrackPage { get; set; }
        public virtual DbSet<TrackPageContent> TrackPageContent { get; set; }
        public virtual DbSet<TrackPageType> TrackPageType { get; set; }
        public virtual DbSet<TrackStory> TrackStory { get; set; }

        // Unable to generate entity type for table 'dbo.onet_task_rating'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PostReqPostMapPoint'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_nlxcompanies'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_chs'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=fastport.database.windows.net;Database=fastport-dev2;User Id=fpadmin;Password=Pony1945");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.AccountSummary).HasColumnType("varchar(1000)");

                entity.Property(e => e.Ats)
                    .HasColumnName("ATS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Atsid).HasColumnName("ATSID");

                entity.Property(e => e.Atsidentifier)
                    .HasColumnName("ATSIdentifier")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Icon).HasColumnType("varchar(255)");

                entity.Property(e => e.Logo).HasColumnType("varchar(255)");

                entity.Property(e => e.OutsideId).HasColumnType("varchar(50)");

                entity.Property(e => e.Pin).HasColumnType("varchar(255)");

                entity.Property(e => e.ShortName).HasColumnType("varchar(20)");

                entity.Property(e => e.WebsiteUrl).HasColumnType("varchar(250)");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_Account_AssetItem");

                entity.HasOne(d => d.Banner)
                    .WithMany(p => p.AccountBanner)
                    .HasForeignKey(d => d.BannerId);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Account)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Account_CompanyId");

                entity.HasOne(d => d.DefaultLogo)
                    .WithMany(p => p.AccountDefaultLogo)
                    .HasForeignKey(d => d.DefaultLogoId);

                entity.HasOne(d => d.Thumbnail)
                    .WithMany(p => p.AccountThumbnail)
                    .HasForeignKey(d => d.ThumbnailId);
            });

            modelBuilder.Entity<AccountAlbum>(entity =>
            {
                entity.Property(e => e.AlbumDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountAlbum)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountAlbum_Account");
            });

            modelBuilder.Entity<AccountAlbumPhoto>(entity =>
            {
                entity.Property(e => e.Caption).HasColumnType("varchar(max)");

                entity.Property(e => e.PhotoRank).HasDefaultValueSql("1");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.AccountAlbumPhoto)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountAlbumPhoto_AccountAlbum");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.AccountAlbumPhoto)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_AccountAlbumPhoto_ImageLibrary");
            });

            modelBuilder.Entity<AccountAltName>(entity =>
            {
                entity.Property(e => e.AlternateName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountAltName)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountAlternateNames_Account");
            });

            modelBuilder.Entity<AccountApprovalStatus>(entity =>
            {
                entity.Property(e => e.ApprovalStatus).HasColumnType("varchar(50)");

                entity.Property(e => e.ApprovedDte).HasColumnType("datetime");

                entity.Property(e => e.NotifiedDte).HasColumnType("datetime");

                entity.Property(e => e.RequestedDte).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountApprovalStatus)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountApprovalStatus_Account_ID");
            });

            modelBuilder.Entity<AccountDssTracking>(entity =>
            {
                entity.ToTable("Account_dss_tracking", "DataSync");

                entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id })
                    .HasName("local_update_peer_timestamp_index");

                entity.HasIndex(e => new { e.LastChangeDatetime, e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp })
                    .HasName("tombstone_index");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");

                entity.Property(e => e.LastChangeDatetime)
                    .HasColumnName("last_change_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");

                entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");

                entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRequired()
                    .HasColumnName("local_update_peer_timestamp")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");

                entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");

                entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");

                entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");

                entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");

                entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
            });

            modelBuilder.Entity<AccountExternal>(entity =>
            {
                entity.HasIndex(e => new { e.CompanyName, e.SourceId })
                    .HasName("UX_AccountExternal")
                    .IsUnique();

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ExternalId).HasColumnType("varchar(50)");

                entity.Property(e => e.SourceId).HasDefaultValueSql("1");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountExternal)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_AccountExternal_Account");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.AccountExternal)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountExternal_ExternalSource");
            });

            modelBuilder.Entity<AccountExternalDssTracking>(entity =>
            {
                entity.ToTable("AccountExternal_dss_tracking", "DataSync");

                entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id })
                    .HasName("local_update_peer_timestamp_index");

                entity.HasIndex(e => new { e.LastChangeDatetime, e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp })
                    .HasName("tombstone_index");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");

                entity.Property(e => e.LastChangeDatetime)
                    .HasColumnName("last_change_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");

                entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");

                entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRequired()
                    .HasColumnName("local_update_peer_timestamp")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");

                entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");

                entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");

                entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");

                entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");

                entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
            });

            modelBuilder.Entity<AccountGroup>(entity =>
            {
                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountGroup)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("AccountGroup_fk0");

                entity.HasOne(d => d.QueueType)
                    .WithMany(p => p.AccountGroup)
                    .HasForeignKey(d => d.QueueTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountGroup_QueueType");
            });

            modelBuilder.Entity<AccountGroupPerson>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AccountGroupPerson)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("AccountGroupPerson_fk0");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AccountGroupPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("AccountGroupPerson_fk1");
            });

            modelBuilder.Entity<AccountIndustry>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.IndustryId })
                    .HasName("PK_AccountIndustry");

                entity.HasIndex(e => e.AccountId)
                    .HasName("IDX_AccountIndustry_AccountId");

                entity.HasIndex(e => e.IndustryId)
                    .HasName("IDX_AccountIndustry_IndustryId");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountIndustry)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountIndustry_Account");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.AccountIndustry)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountIndustry_Industry");
            });

            modelBuilder.Entity<AccountLink>(entity =>
            {
                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasColumnName("LinkURL")
                    .HasColumnType("varchar(250)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountLink)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountLink_Account");

                entity.HasOne(d => d.LinkType)
                    .WithMany(p => p.AccountLink)
                    .HasForeignKey(d => d.LinkTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountLink_MediaLinkType");
            });

            modelBuilder.Entity<AccountLogo>(entity =>
            {
                entity.Property(e => e.AccountLogoName)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'Primary Logo'");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountLogo)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountLogo_Account");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.AccountLogo)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_AccountLogo_ImageLibrary");

                entity.HasOne(d => d.LogoType)
                    .WithMany(p => p.AccountLogo)
                    .HasForeignKey(d => d.LogoTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountLogo_LogoType");
            });

            modelBuilder.Entity<AccountPerson>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountPerson)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountPerson_Account_ID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AccountPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountPerson_Person");
            });

            modelBuilder.Entity<AccountRelationship>(entity =>
            {
                entity.Property(e => e.Archived).HasDefaultValueSql("0");

                entity.Property(e => e.ContactInfoShared).HasDefaultValueSql("0");

                entity.Property(e => e.RelationshipStatusAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountRelationship)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Relationship_Account");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AccountRelationship)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Relationship_Person");

                entity.HasOne(d => d.RelationshipStatus)
                    .WithMany(p => p.AccountRelationship)
                    .HasForeignKey(d => d.RelationshipStatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountRelationship_AccountRelationshipStatus");
            });

            modelBuilder.Entity<AccountRelationshipStatus>(entity =>
            {
                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StatusRank).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<AccountRelationshipStatusHistory>(entity =>
            {
                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.RelationshipStatusId).HasColumnName("RelationshipStatusID");

                entity.Property(e => e.StatusAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.AccountRelationshipStatusHistory)
                    .HasForeignKey(d => d.RelationshipId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountRelationshipStatusHistory_AccountRelationship");

                entity.HasOne(d => d.RelationshipStatus)
                    .WithMany(p => p.AccountRelationshipStatusHistory)
                    .HasForeignKey(d => d.RelationshipStatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountRelationshipStatusHistory_AccountRelationshipStatus");

                entity.HasOne(d => d.StatusBy)
                    .WithMany(p => p.AccountRelationshipStatusHistory)
                    .HasForeignKey(d => d.StatusById)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountRelationshipStatusHistory_Person");
            });

            modelBuilder.Entity<AccountRelationshipStatusHistoryReason>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.History)
                    .WithMany(p => p.AccountRelationshipStatusHistoryReason)
                    .HasForeignKey(d => d.HistoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountRelationshipStatusHistoryReason_AccountRelationshipStatusHistory");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.AccountRelationshipStatusHistoryReason)
                    .HasForeignKey(d => d.ReasonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountRelationshipStatusHistoryReason_AccountRelationshipStatusReason");
            });

            modelBuilder.Entity<AccountRelationshipStatusReason>(entity =>
            {
                entity.Property(e => e.ReasonName)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.ReasonRank).HasDefaultValueSql("1");

                entity.HasOne(d => d.RelationshipStatus)
                    .WithMany(p => p.AccountRelationshipStatusReason)
                    .HasForeignKey(d => d.RelationshipStatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountRelationshipStatusReason_AccountRelationshipStatus");
            });

            modelBuilder.Entity<AccountReleationshipIntroBy>(entity =>
            {
                entity.Property(e => e.AccountId).HasDefaultValueSql("1");

                entity.Property(e => e.IntroAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.IntroNotes).HasColumnType("varchar(500)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountReleationshipIntroBy)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountReleationshipIntroBy_Account");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AccountReleationshipIntroBy)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountReleationshipIntroBy_Person");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.AccountReleationshipIntroBy)
                    .HasForeignKey(d => d.RelationshipId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountReleationshipIntroBy_AccountRelationship");
            });

            modelBuilder.Entity<AccountTag>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.TagId })
                    .HasName("PK_AccountTag_1");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountTag)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountTag_Account_ID");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.AccountTag)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountTag_Tag_ID");
            });

            modelBuilder.Entity<AccountVideo>(entity =>
            {
                entity.Property(e => e.VideoCode)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.VideoDescription)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.VideoName)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountVideo)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountVideo_Account");

                entity.HasOne(d => d.VideoProvider)
                    .WithMany(p => p.AccountVideo)
                    .HasForeignKey(d => d.VideoProviderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AccountVideo_MediaVideoProvider");
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.Property(e => e.ActivityAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.HasOne(d => d.ActivityType)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.ActivityTypeId)
                    .HasConstraintName("FK_Activity_ActivityType");
            });

            modelBuilder.Entity<ActivityPerson>(entity =>
            {
                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityPerson)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_ActivityPerson_Activity");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ActivityPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityPerson_Person");
            });

            modelBuilder.Entity<ActivityTask>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityTask)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_ActivityTask_Activity");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.ActivityTask)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_ActivityTask_Task");
            });

            modelBuilder.Entity<ActivityTaskResource>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityTaskResource)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_ActivityTaskResource_Activity");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ActivityTaskResource)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_ActivityTaskResource_TaskResource");
            });

            modelBuilder.Entity<ActivityTaskStory>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityTaskStory)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_ActivityTaskStory_Activity");

                entity.HasOne(d => d.Story)
                    .WithMany(p => p.ActivityTaskStory)
                    .HasForeignKey(d => d.StoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityTaskStory_Story");
            });

            modelBuilder.Entity<ActivityType>(entity =>
            {
                entity.Property(e => e.ActivityTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ActivtyTaskPhase>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivtyTaskPhase)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_ActivtyTaskPhase_Activity");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.ActivtyTaskPhase)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivtyTaskPhase_TaskPhase");
            });

            modelBuilder.Entity<Addr>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addr1)
                    .HasColumnName("Addr")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Addr2).HasColumnType("varchar(500)");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("3");

                entity.Property(e => e.Directions).HasColumnType("varchar(4000)");

                entity.Property(e => e.ZipId).HasColumnName("ZipID");
            });

            modelBuilder.Entity<AddrPerson>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddrId).HasColumnName("AddrID");

                entity.Property(e => e.MovedIn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MovedOut).HasDefaultValueSql("0");

                entity.Property(e => e.MovedOutOn).HasColumnType("datetime");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Addr)
                    .WithMany(p => p.AddrPerson)
                    .HasForeignKey(d => d.AddrId)
                    .HasConstraintName("FK_AddrPerson_Addr");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.AddrPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AddrPerson_Person");
            });

            modelBuilder.Entity<Alert>(entity =>
            {
                entity.Property(e => e.AlertName).HasColumnType("varchar(50)");

                entity.Property(e => e.HideYesNo).HasDefaultValueSql("0");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Alert)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_Alert_Person");
            });

            modelBuilder.Entity<AlertAttr>(entity =>
            {
                entity.HasOne(d => d.Alert)
                    .WithMany(p => p.AlertAttr)
                    .HasForeignKey(d => d.AlertId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlertAttr_Alert");

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.AlertAttr)
                    .HasForeignKey(d => d.AttrId)
                    .HasConstraintName("FK_AlertAttr_Attr");
            });

            modelBuilder.Entity<AlertCity>(entity =>
            {
                entity.HasOne(d => d.Alert)
                    .WithMany(p => p.AlertCity)
                    .HasForeignKey(d => d.AlertId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlertCity_Alert");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AlertCity)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlertCity_GeoCity");
            });

            modelBuilder.Entity<AlertIndustry>(entity =>
            {
                entity.HasOne(d => d.Alert)
                    .WithMany(p => p.AlertIndustry)
                    .HasForeignKey(d => d.AlertId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AlertIndusty_Alert");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.AlertIndustry)
                    .HasForeignKey(d => d.IndustryId)
                    .HasConstraintName("FK_AlertIndustry_Industry");
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C98BE18EB57");

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__30910331AFA09DC9")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("UQ__aspnet_A__17477DE45B25572B")
                    .IsUnique();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("newid()");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D7E2A15AD");

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail })
                    .HasName("aspnet_Membership_index");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordFormat).HasDefaultValueSql("0");

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMembership)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__aspnet_Me__Appli__227D3A3E");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__aspnet_Me__UserI__23715E77");
            });

            modelBuilder.Entity<AspnetRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1BE5170967");

                entity.ToTable("aspnet_Roles");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredRoleName })
                    .HasName("aspnet_Roles_index1")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasDefaultValueSql("newid()");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__aspnet_Ro__Appli__2741EF5B");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC1ED74C532");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4DA531DB58");

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasName("aspnet_Users_Index")
                    .IsUnique();

                entity.Property(e => e.UserId).HasDefaultValueSql("newid()");

                entity.Property(e => e.IsAnonymous).HasDefaultValueSql("0");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__aspnet_Us__Appli__1DB88521");
            });

            modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_U__AF2760AD4057569C");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("aspnet_UsersInRoles_index");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__aspnet_Us__RoleI__2B12803F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__aspnet_Us__UserI__2C06A478");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<AssetItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssetDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.AssetRank).HasDefaultValueSql("1");

                entity.Property(e => e.AssetTitle).HasColumnType("varchar(150)");

                entity.Property(e => e.AssetTypeId).HasColumnName("AssetTypeID");

                entity.Property(e => e.AssetValue).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssetItem)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AssetItem_Asset");

                entity.HasOne(d => d.AssetType)
                    .WithMany(p => p.AssetItem)
                    .HasForeignKey(d => d.AssetTypeId)
                    .HasConstraintName("FK_Asset_AssetType");

                entity.HasOne(d => d.LinktoPage)
                    .WithMany(p => p.AssetItem)
                    .HasForeignKey(d => d.LinktoPageId)
                    .HasConstraintName("FK_AssetItem_TrackPage");
            });

            modelBuilder.Entity<AssetItemProperty>(entity =>
            {
                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PropertyValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.AssetItem)
                    .WithMany(p => p.AssetItemProperty)
                    .HasForeignKey(d => d.AssetItemId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AssetItemProperty_AssetItem");
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.Property(e => e.IsImage).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Attr>(entity =>
            {
                entity.Property(e => e.AdminLock).HasDefaultValueSql("0");

                entity.Property(e => e.AttrCode).HasColumnType("varchar(100)");

                entity.Property(e => e.AttrDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.AttrItem)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.Guid).HasDefaultValueSql("newid()");

                entity.Property(e => e.LargeIcon).HasColumnType("varchar(255)");

                entity.Property(e => e.LargeMouseover).HasColumnType("varchar(255)");

                entity.Property(e => e.OutsideId).HasColumnType("varchar(50)");

                entity.Property(e => e.RelatedId).HasColumnName("RelatedID");

                entity.Property(e => e.RelatedTable).HasColumnType("varchar(50)");

                entity.Property(e => e.SmallIcon).HasColumnType("varchar(255)");

                entity.Property(e => e.SmallMouseover).HasColumnType("varchar(255)");

                entity.HasOne(d => d.AttrIcon)
                    .WithMany(p => p.Attr)
                    .HasForeignKey(d => d.AttrIconId)
                    .HasConstraintName("FK_Attr_ImageLibrary");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Attr_ParentId");
            });

            modelBuilder.Entity<AttrIndustry>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttrId).HasColumnName("AttrID");

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.AttrIndustry)
                    .HasForeignKey(d => d.AttrId)
                    .HasConstraintName("FK_AttrIndustry_Attr");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.AttrIndustry)
                    .HasForeignKey(d => d.IndustryId)
                    .HasConstraintName("FK_AttrIndustry_Industry");
            });

            modelBuilder.Entity<AttrMapping>(entity =>
            {
                entity.HasOne(d => d.Mapped)
                    .WithMany(p => p.AttrMappingMapped)
                    .HasForeignKey(d => d.MappedId)
                    .HasConstraintName("FK_AttrMapping_Attr");

                entity.HasOne(d => d.MappedTo)
                    .WithMany(p => p.AttrMappingMappedTo)
                    .HasForeignKey(d => d.MappedToId)
                    .HasConstraintName("FK_AttrMapping_Attr1");
            });

            modelBuilder.Entity<AttrRankAlt>(entity =>
            {
                entity.Property(e => e.AltRank).HasDefaultValueSql("1");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.AttrRankAltParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_AttrRankAlt_Attr");

                entity.HasOne(d => d.RankAlt)
                    .WithMany(p => p.AttrRankAltRankAlt)
                    .HasForeignKey(d => d.RankAltId)
                    .HasConstraintName("FK_AttrRankAlt_Attr1");
            });

            modelBuilder.Entity<AttrRelatedTable>(entity =>
            {
                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.AttrRelatedTable)
                    .HasForeignKey(d => d.AttrId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AttrRelatedTable_Attr");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.AttrRelatedTable)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AttrRelatedTable_DatabaseTable");
            });

            modelBuilder.Entity<Briefcase>(entity =>
            {
                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.BriefcaseType)
                    .WithMany(p => p.Briefcase)
                    .HasForeignKey(d => d.BriefcaseTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Briefcase_BriefcaseType");
            });

            modelBuilder.Entity<BriefcasePost>(entity =>
            {
                entity.HasKey(e => new { e.BriefcaseId, e.PostId })
                    .HasName("PK_BriefcasePost");

                entity.Property(e => e.PrimaryApply).HasDefaultValueSql("0");

                entity.HasOne(d => d.Briefcase)
                    .WithMany(p => p.BriefcasePost)
                    .HasForeignKey(d => d.BriefcaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BriefcasePost_Briefcase");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.BriefcasePost)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BriefcasePost_Post");
            });

            modelBuilder.Entity<BriefcasePostListing>(entity =>
            {
                entity.HasKey(e => new { e.BriefcaseId, e.PostId, e.ListingId })
                    .HasName("PK_BriefcasePostListing");

                entity.Property(e => e.PrimaryApply).HasDefaultValueSql("0");

                entity.HasOne(d => d.Briefcase)
                    .WithMany(p => p.BriefcasePostListing)
                    .HasForeignKey(d => d.BriefcaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BriefcasePostListing_Briefcase");

                entity.HasOne(d => d.Listing)
                    .WithMany(p => p.BriefcasePostListing)
                    .HasForeignKey(d => d.ListingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BriefcasePostListing_Listing1");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.BriefcasePostListing)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BriefcasePostListing_Post");
            });

            modelBuilder.Entity<BriefcaseType>(entity =>
            {
                entity.Property(e => e.BriefcaseType1)
                    .IsRequired()
                    .HasColumnName("BriefcaseType")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ChatMessageViaMethod>(entity =>
            {
                entity.Property(e => e.ViaMethodName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Clock>(entity =>
            {
                entity.Property(e => e.LastStatusAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Clock)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Clock_fk1");

                entity.HasOne(d => d.AssignedTo)
                    .WithMany(p => p.ClockAssignedTo)
                    .HasForeignKey(d => d.AssignedToId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Clock_Person");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ClockPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Clock_fk0");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Clock)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Clock_fk3");
            });

            modelBuilder.Entity<ClockStatus>(entity =>
            {
                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StatusRank).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CntAbilities>(entity =>
            {
                entity.HasKey(e => e.AbilityId)
                    .HasName("PK_CntAbilities");

                entity.Property(e => e.AbilityId).ValueGeneratedNever();

                entity.Property(e => e.Cnt).HasDefaultValueSql("0");

                entity.HasOne(d => d.Ability)
                    .WithOne(p => p.CntAbilities)
                    .HasForeignKey<CntAbilities>(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntAbilities_onet_abilities");
            });

            modelBuilder.Entity<CntActivities>(entity =>
            {
                entity.HasKey(e => e.ActivitiesId)
                    .HasName("PK_CntActivities");

                entity.Property(e => e.ActivitiesId).ValueGeneratedNever();

                entity.Property(e => e.Cnt).HasDefaultValueSql("0");

                entity.HasOne(d => d.Activities)
                    .WithOne(p => p.CntActivities)
                    .HasForeignKey<CntActivities>(d => d.ActivitiesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntActivities_onet_work_activities");
            });

            modelBuilder.Entity<CntAlternateTitle>(entity =>
            {
                entity.HasKey(e => e.AltTitleId)
                    .HasName("PK_CntAlternateTitle");

                entity.Property(e => e.AltTitleId).ValueGeneratedNever();

                entity.HasOne(d => d.AltTitle)
                    .WithOne(p => p.CntAlternateTitle)
                    .HasForeignKey<CntAlternateTitle>(d => d.AltTitleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntAlternateTitle_onet_alternate_title");
            });

            modelBuilder.Entity<CntAttr>(entity =>
            {
                entity.HasKey(e => e.AttrId)
                    .HasName("PK_CntAttr");

                entity.Property(e => e.AttrId).ValueGeneratedNever();

                entity.Property(e => e.Cnt).HasDefaultValueSql("0");

                entity.HasOne(d => d.Attr)
                    .WithOne(p => p.CntAttr)
                    .HasForeignKey<CntAttr>(d => d.AttrId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntAttr_Attr");
            });

            modelBuilder.Entity<CntKnowledge>(entity =>
            {
                entity.HasKey(e => e.KnowledgeId)
                    .HasName("PK_CntKnowledge");

                entity.Property(e => e.KnowledgeId).ValueGeneratedNever();

                entity.Property(e => e.Cnt).HasDefaultValueSql("0");

                entity.HasOne(d => d.Knowledge)
                    .WithOne(p => p.CntKnowledge)
                    .HasForeignKey<CntKnowledge>(d => d.KnowledgeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntKnowledge_onet_knowledge");
            });

            modelBuilder.Entity<CntOccupation>(entity =>
            {
                entity.HasKey(e => e.OnetId)
                    .HasName("PK_CntOccupation");

                entity.Property(e => e.OnetId).ValueGeneratedNever();

                entity.Property(e => e.Cnt).HasDefaultValueSql("0");

                entity.HasOne(d => d.Onet)
                    .WithOne(p => p.CntOccupation)
                    .HasForeignKey<CntOccupation>(d => d.OnetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntOccupation_onet_occupation_data");
            });

            modelBuilder.Entity<CntProfileSummary>(entity =>
            {
                entity.HasKey(e => e.SummaryId)
                    .HasName("PK_CntProfileSummary");

                entity.Property(e => e.SummaryId).ValueGeneratedNever();

                entity.Property(e => e.Cnt).HasDefaultValueSql("0");

                entity.HasOne(d => d.Summary)
                    .WithOne(p => p.CntProfileSummary)
                    .HasForeignKey<CntProfileSummary>(d => d.SummaryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntProfileSummary_ProfileSummary");
            });

            modelBuilder.Entity<CntSampleTitle>(entity =>
            {
                entity.HasKey(e => e.SampleTitleId)
                    .HasName("PK_CntSampleTitle");

                entity.Property(e => e.SampleTitleId).ValueGeneratedNever();

                entity.HasOne(d => d.SampleTitle)
                    .WithOne(p => p.CntSampleTitle)
                    .HasForeignKey<CntSampleTitle>(d => d.SampleTitleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntSampleTitle_onet_sample_of_reported_titles");
            });

            modelBuilder.Entity<CntSkills>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK_CntSkills");

                entity.Property(e => e.SkillId).ValueGeneratedNever();

                entity.Property(e => e.Cnt).HasDefaultValueSql("0");

                entity.HasOne(d => d.Skill)
                    .WithOne(p => p.CntSkills)
                    .HasForeignKey<CntSkills>(d => d.SkillId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntSkills_onet_skills");
            });

            modelBuilder.Entity<CntTaskStatements>(entity =>
            {
                entity.HasKey(e => e.StatementId)
                    .HasName("PK_CntTaskStatements");

                entity.Property(e => e.StatementId).ValueGeneratedNever();

                entity.Property(e => e.Cnt).HasDefaultValueSql("0");

                entity.HasOne(d => d.Statement)
                    .WithOne(p => p.CntTaskStatements)
                    .HasForeignKey<CntTaskStatements>(d => d.StatementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntTaskStatements_onet_task_statements");
            });

            modelBuilder.Entity<CntToolsTech>(entity =>
            {
                entity.HasKey(e => e.ToolsTechId)
                    .HasName("PK_CntToolsTech");

                entity.Property(e => e.ToolsTechId).ValueGeneratedNever();

                entity.HasOne(d => d.ToolsTech)
                    .WithOne(p => p.CntToolsTech)
                    .HasForeignKey<CntToolsTech>(d => d.ToolsTechId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CntToolsTech_onet_tools_and_technology");
            });

            modelBuilder.Entity<Comm>(entity =>
            {
                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CommStateId)
                    .HasColumnName("CommStateID")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastMessageId).HasColumnName("LastMessageID");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Comm)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Comm_Account");

                entity.HasOne(d => d.CommState)
                    .WithMany(p => p.Comm)
                    .HasForeignKey(d => d.CommStateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Comm_CommState1");

                entity.HasOne(d => d.LastMessage)
                    .WithMany(p => p.Comm)
                    .HasForeignKey(d => d.LastMessageId)
                    .HasConstraintName("FK_Comm_CommMessage");

                entity.HasOne(d => d.Purpose)
                    .WithMany(p => p.Comm)
                    .HasForeignKey(d => d.PurposeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Comm_CommPurpose");

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.Comm)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK_Comm_Person");
            });

            modelBuilder.Entity<CommCommMemberEvent>(entity =>
            {
                entity.Property(e => e.EventAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.CommMember)
                    .WithMany(p => p.CommCommMemberEvent)
                    .HasForeignKey(d => d.CommMemberId)
                    .HasConstraintName("FK_CommCommMemberEvent_CommMember");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.CommCommMemberEvent)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommCommMemberEvent_CommMemberEvent");
            });

            modelBuilder.Entity<CommConnection>(entity =>
            {
                entity.HasKey(e => e.ConnectionId)
                    .HasName("PK_CommConnection");

                entity.Property(e => e.ConnectionId).HasColumnType("varchar(255)");

                entity.Property(e => e.ConnectedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DisconnectedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CommConnection)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommConnection_Person");
            });

            modelBuilder.Entity<CommMember>(entity =>
            {
                entity.Property(e => e.OwnerYesNo).HasDefaultValueSql("0");

                entity.Property(e => e.RemovedYesNo).HasDefaultValueSql("0");

                entity.HasOne(d => d.Comm)
                    .WithMany(p => p.CommMember)
                    .HasForeignKey(d => d.CommId)
                    .HasConstraintName("FK_CommMember_Comm");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CommMember)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommMember_Person");
            });

            modelBuilder.Entity<CommMemberCommMethod>(entity =>
            {
                entity.HasOne(d => d.CommMember)
                    .WithMany(p => p.CommMemberCommMethod)
                    .HasForeignKey(d => d.CommMemberId)
                    .HasConstraintName("FK_CommMemberCommMethod_CommMember");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.CommMemberCommMethod)
                    .HasForeignKey(d => d.MethodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommMemberCommMethod_CommMethod");
            });

            modelBuilder.Entity<CommMemberEvent>(entity =>
            {
                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.EventRank).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CommMessage>(entity =>
            {
                entity.Property(e => e.CancelRequest).HasDefaultValueSql("0");

                entity.Property(e => e.CopySender).HasDefaultValueSql("0");

                entity.Property(e => e.EmailSubject).HasColumnType("varchar(500)");

                entity.Property(e => e.MessageAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.MessageContent).HasColumnType("varchar(max)");

                entity.Property(e => e.Private).HasDefaultValueSql("0");

                entity.Property(e => e.ResponseId).HasColumnName("ResponseID");

                entity.HasOne(d => d.CommNavigation)
                    .WithMany(p => p.CommMessage)
                    .HasForeignKey(d => d.CommId)
                    .HasConstraintName("FK_CommMessage_Comm");

                entity.HasOne(d => d.CommState)
                    .WithMany(p => p.CommMessage)
                    .HasForeignKey(d => d.CommStateId)
                    .HasConstraintName("FK_CommMessage_CommState");

                entity.HasOne(d => d.RelationshipStatus)
                    .WithMany(p => p.CommMessage)
                    .HasForeignKey(d => d.RelationshipStatusId)
                    .HasConstraintName("FK_CommMessage_AccountRelationshipStatus");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.CommMessage)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_CommMessage_CommRequest");

                entity.HasOne(d => d.Response)
                    .WithMany(p => p.CommMessage)
                    .HasForeignKey(d => d.ResponseId)
                    .HasConstraintName("FK_CommMessage_CommRequestOptions");
            });

            modelBuilder.Entity<CommMessageLog>(entity =>
            {
                entity.Property(e => e.LoggedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ReadAt).HasColumnType("datetime");

                entity.Property(e => e.SentAt).HasColumnType("datetime");

                entity.HasOne(d => d.CommMember)
                    .WithMany(p => p.CommMessageLog)
                    .HasForeignKey(d => d.CommMemberId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommMessageLog_CommMember");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.CommMessageLog)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_CommMessageLog_CommMessage");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.CommMessageLog)
                    .HasForeignKey(d => d.MethodId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommMessageLog_CommMethod");
            });

            modelBuilder.Entity<CommMethod>(entity =>
            {
                entity.Property(e => e.Method)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MethodRank).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<CommProfile>(entity =>
            {
                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Comm)
                    .WithMany(p => p.CommProfile)
                    .HasForeignKey(d => d.CommId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommProfile_Comm");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.CommProfile)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommProfile_Profile");
            });

            modelBuilder.Entity<CommPurpose>(entity =>
            {
                entity.Property(e => e.PurposeName).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CommRequest>(entity =>
            {
                entity.Property(e => e.AvailableToAccount).HasDefaultValueSql("1");

                entity.Property(e => e.EmailSubject).HasColumnType("varchar(255)");

                entity.Property(e => e.FirstStateRequest).HasDefaultValueSql("0");

                entity.Property(e => e.LastStateRequest).HasDefaultValueSql("0");

                entity.Property(e => e.PendingText).HasColumnType("varchar(max)");

                entity.Property(e => e.PurposeId).HasColumnName("PurposeID");

                entity.Property(e => e.RequestName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RequestRank).HasDefaultValueSql("0");

                entity.Property(e => e.RequestText)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.Purpose)
                    .WithMany(p => p.CommRequest)
                    .HasForeignKey(d => d.PurposeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommRequest_CommPurpose");
            });

            modelBuilder.Entity<CommRequestOptions>(entity =>
            {
                entity.Property(e => e.ButtonColor)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'Standard'");

                entity.Property(e => e.ButtonRank).HasDefaultValueSql("1");

                entity.Property(e => e.ButtonText)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ButtonTooltip).HasColumnType("varchar(255)");

                entity.Property(e => e.CodeCommand).HasColumnType("varchar(50)");

                entity.Property(e => e.MessageContent).HasColumnType("varchar(500)");

                entity.HasOne(d => d.NewCommState)
                    .WithMany(p => p.CommRequestOptions)
                    .HasForeignKey(d => d.NewCommStateId)
                    .HasConstraintName("FK_CommRequestOptions_CommState1");

                entity.HasOne(d => d.NewRelationshipStatus)
                    .WithMany(p => p.CommRequestOptions)
                    .HasForeignKey(d => d.NewRelationshipStatusId)
                    .HasConstraintName("FK_CommRequestOptions_AccountRelationshipStatus");

                entity.HasOne(d => d.NewRequest)
                    .WithMany(p => p.CommRequestOptionsNewRequest)
                    .HasForeignKey(d => d.NewRequestId)
                    .HasConstraintName("FK_CommRequestOptions_CommRequest1");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.CommRequestOptionsRequest)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommRequestOptions_CommRequest");
            });

            modelBuilder.Entity<CommReview>(entity =>
            {
                entity.HasOne(d => d.Comm)
                    .WithMany(p => p.CommReview)
                    .HasForeignKey(d => d.CommId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommProfileReview_Comm");
            });

            modelBuilder.Entity<CommState>(entity =>
            {
                entity.Property(e => e.StateName).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CommStateLog>(entity =>
            {
                entity.Property(e => e.StateAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Comm)
                    .WithMany(p => p.CommStateLog)
                    .HasForeignKey(d => d.CommId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommStateLog_Comm");

                entity.HasOne(d => d.CommState)
                    .WithMany(p => p.CommStateLog)
                    .HasForeignKey(d => d.CommStateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommStateLog_CommState");

                entity.HasOne(d => d.StateBy)
                    .WithMany(p => p.CommStateLog)
                    .HasForeignKey(d => d.StateById)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommStateLog_Person");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CommentAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CommentPublic).HasDefaultValueSql("0");

                entity.Property(e => e.CommentText)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.HasOne(d => d.CommentAccount)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.CommentAccountId)
                    .HasConstraintName("FK_Comment_Account");

                entity.HasOne(d => d.CommentBy)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.CommentById)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Comment_Person");

                entity.HasOne(d => d.CommentType)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.CommentTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Comment_CommentType");
            });

            modelBuilder.Entity<CommentPost>(entity =>
            {
                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentPost)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("CommentPost_fk0");
            });

            modelBuilder.Entity<CommentProfile>(entity =>
            {
                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentProfile)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommentProfile_Comment");
            });

            modelBuilder.Entity<CommentRelated>(entity =>
            {
                entity.HasOne(d => d.Child)
                    .WithMany(p => p.CommentRelatedChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("CommentRelated_fk1");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.CommentRelatedParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("CommentRelated_fk0");
            });

            modelBuilder.Entity<CommentType>(entity =>
            {
                entity.Property(e => e.CommentTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CompanyPerson>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyPerson)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CompanyPerson_Company");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CompanyPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CompanyPerson_Person");
            });

            modelBuilder.Entity<CoreTitle>(entity =>
            {
                entity.Property(e => e.Base25Annual).HasColumnName("Base25_Annual");

                entity.Property(e => e.Base25Hourly).HasColumnName("Base25_Hourly");

                entity.Property(e => e.Base50Annual).HasColumnName("Base50_Annual");

                entity.Property(e => e.Base50Hourly).HasColumnName("Base50_Hourly");

                entity.Property(e => e.Base75Annual).HasColumnName("Base75_Annual");

                entity.Property(e => e.Base75Hourly).HasColumnName("Base75_Hourly");

                entity.Property(e => e.BaseAvgAnnual).HasColumnName("BaseAvg_Annual");

                entity.Property(e => e.BaseAvgHourly).HasColumnName("BaseAvg_Hourly");

                entity.Property(e => e.Education).HasColumnType("varchar(50)");

                entity.Property(e => e.ExperienceFrom)
                    .HasColumnName("Experience_From")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ExperienceTo)
                    .HasColumnName("Experience_To")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FlsaStatus)
                    .HasColumnName("FLSA_Status")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.JobCode)
                    .HasColumnName("Job_Code")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.JobDescription).HasColumnName("Job_Description");

                entity.Property(e => e.JobFamily)
                    .HasColumnName("Job_Family")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("Job_Title")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.JobTitleLevel)
                    .HasColumnName("Job_Title_Level")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.JobType)
                    .HasColumnName("Job_Type")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Tcc25Annual).HasColumnName("TCC25_Annual");

                entity.Property(e => e.Tcc25Hourly).HasColumnName("TCC25_Hourly");

                entity.Property(e => e.Tcc50Annual).HasColumnName("TCC50_Annual");

                entity.Property(e => e.Tcc50Hourly).HasColumnName("TCC50_Hourly");

                entity.Property(e => e.Tcc75Annual).HasColumnName("TCC75_Annual");

                entity.Property(e => e.Tcc75Hourly).HasColumnName("TCC75_Hourly");

                entity.Property(e => e.TccavgAnnual).HasColumnName("TCCAvg_Annual");

                entity.Property(e => e.TccavgHourly).HasColumnName("TCCAvg_Hourly");
            });

            modelBuilder.Entity<CoreTitleAttr>(entity =>
            {
                entity.HasKey(e => new { e.TitleId, e.AttrId })
                    .HasName("PK_CoreTitleAttr");

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.CoreTitleAttr)
                    .HasForeignKey(d => d.AttrId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CoreTitleAttr_Attr");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.CoreTitleAttr)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CoreTitleAttr_CoreTitle");
            });

            modelBuilder.Entity<CoreTitleOnet>(entity =>
            {
                entity.HasKey(e => new { e.TitleId, e.OnetId })
                    .HasName("PK_CoreTitleOnet");

                entity.HasOne(d => d.Onet)
                    .WithMany(p => p.CoreTitleOnet)
                    .HasForeignKey(d => d.OnetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CoreTitleOnet_onet_occupation_data");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.CoreTitleOnet)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CoreTitleOnet_CoreTitle");
            });

            modelBuilder.Entity<Dashboard>(entity =>
            {
                entity.Property(e => e.DashboardName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<DataType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DataType1)
                    .HasColumnName("DataType")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<DatabaseJob>(entity =>
            {
                entity.Property(e => e.CompleteAt).HasColumnType("datetime");

                entity.Property(e => e.ErroNo).HasColumnType("varchar(255)");

                entity.Property(e => e.ErrorOccured).HasDefaultValueSql("0");

                entity.Property(e => e.JobComplete).HasDefaultValueSql("0");

                entity.Property(e => e.JobDetails)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.JobResults).HasColumnType("varchar(max)");

                entity.Property(e => e.JobSql)
                    .IsRequired()
                    .HasColumnName("JobSQL")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.OrderedAtId)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.DatabaseJob)
                    .HasForeignKey(d => d.JobTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DatabaseJob_DatabaseJobType");
            });

            modelBuilder.Entity<DatabaseJobType>(entity =>
            {
                entity.Property(e => e.JobTypeDesc)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.JobTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<DatabaseTable>(entity =>
            {
                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<DurationType>(entity =>
            {
                entity.Property(e => e.DurationTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.EventEnd).HasColumnType("datetime");

                entity.Property(e => e.EventLive).HasDefaultValueSql("0");

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.EventStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<EventAccount>(entity =>
            {
                entity.Property(e => e.PositionsAvailable).HasDefaultValueSql("10");

                entity.Property(e => e.QueueTypeId).HasDefaultValueSql("1");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.EventAccount)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EventAccount_Account");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventAccount)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_EventAccount_Event");
            });

            modelBuilder.Entity<EventAccountRelationship>(entity =>
            {
                entity.Property(e => e.AlertAccount).HasDefaultValueSql("0");

                entity.Property(e => e.AlertJobSeeker).HasDefaultValueSql("0");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventAccountRelationship)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_EventAccountRelationship_Event");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.EventAccountRelationship)
                    .HasForeignKey(d => d.RelationshipId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EventAccountRelationship_AccountRelationship");
            });

            modelBuilder.Entity<EventPerson>(entity =>
            {
                entity.Property(e => e.Available).HasDefaultValueSql("1");

                entity.Property(e => e.EnteredEventAt).HasColumnType("datetime");

                entity.Property(e => e.QueueMemberRank).HasDefaultValueSql("1");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.EventPerson)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_EventPerson_Account");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventPerson)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_EventPerson_Event");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.EventPerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_EventPerson_Person");
            });

            modelBuilder.Entity<ExpDetailAbilities>(entity =>
            {
                entity.HasKey(e => new { e.DetailId, e.AbilitiesId })
                    .HasName("PK_ExpDetailAbilities");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Abilities)
                    .WithMany(p => p.ExpDetailAbilities)
                    .HasForeignKey(d => d.AbilitiesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailAbilities_onet_abilities");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.ExpDetailAbilities)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailAbilities_ExperienceDetail");
            });

            modelBuilder.Entity<ExpDetailActivities>(entity =>
            {
                entity.HasKey(e => new { e.DetailId, e.ActivitiesId })
                    .HasName("PK_ExpDetailActivities");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Activities)
                    .WithMany(p => p.ExpDetailActivities)
                    .HasForeignKey(d => d.ActivitiesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailActivities_onet_work_activities");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.ExpDetailActivities)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailActivities_ExperienceDetail");
            });

            modelBuilder.Entity<ExpDetailAttr>(entity =>
            {
                entity.HasKey(e => new { e.DetailId, e.AttrId })
                    .HasName("PK_ExpDetailAttr");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.ExpDetailAttr)
                    .HasForeignKey(d => d.AttrId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailAttr_Attr");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.ExpDetailAttr)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailAttr_ExperienceDetail");
            });

            modelBuilder.Entity<ExpDetailKnowledge>(entity =>
            {
                entity.HasKey(e => new { e.DetailId, e.KnowledgeId })
                    .HasName("PK_ExpDetailKnowledge");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.ExpDetailKnowledge)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailKnowledge_ExperienceDetail");

                entity.HasOne(d => d.Knowledge)
                    .WithMany(p => p.ExpDetailKnowledge)
                    .HasForeignKey(d => d.KnowledgeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailKnowledge_onet_knowledge");
            });

            modelBuilder.Entity<ExpDetailOccupation>(entity =>
            {
                entity.HasKey(e => new { e.DetailId, e.OnetId })
                    .HasName("PK_ExpDetailOccupation");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.ExpDetailOccupation)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailOccupation_ExperienceDetail");

                entity.HasOne(d => d.Onet)
                    .WithMany(p => p.ExpDetailOccupation)
                    .HasForeignKey(d => d.OnetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailOccupation_onet_occupation_data");
            });

            modelBuilder.Entity<ExpDetailProfileSummary>(entity =>
            {
                entity.HasKey(e => new { e.DetailId, e.SummaryId })
                    .HasName("PK_ExpDetailProfileSummary");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.ExpDetailProfileSummary)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailProfileSummary_ExperienceDetail");

                entity.HasOne(d => d.Summary)
                    .WithMany(p => p.ExpDetailProfileSummary)
                    .HasForeignKey(d => d.SummaryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailProfileSummary_ProfileSummary");
            });

            modelBuilder.Entity<ExpDetailSkills>(entity =>
            {
                entity.HasKey(e => new { e.DetailId, e.SkillsId })
                    .HasName("PK_ExpDetailSkills");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.ExpDetailSkills)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailSkills_ExperienceDetail");

                entity.HasOne(d => d.Skills)
                    .WithMany(p => p.ExpDetailSkills)
                    .HasForeignKey(d => d.SkillsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailSkills_onet_skills");
            });

            modelBuilder.Entity<ExpDetailTaskStatements>(entity =>
            {
                entity.HasKey(e => new { e.DetailId, e.TaskStatementId })
                    .HasName("PK_ExpDetailTaskStatements");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.ExpDetailTaskStatements)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailTaskStatements_ExperienceDetail");

                entity.HasOne(d => d.TaskStatement)
                    .WithMany(p => p.ExpDetailTaskStatements)
                    .HasForeignKey(d => d.TaskStatementId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExpDetailTaskStatements_onet_task_statements");
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCityId).HasColumnName("AccountCityID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CurrentExperience).HasDefaultValueSql("0");

                entity.Property(e => e.ExperienceNotes).HasColumnType("varchar(max)");

                entity.Property(e => e.ExperienceRank).HasDefaultValueSql("0");

                entity.Property(e => e.ExperienceTypeId).HasColumnName("ExperienceTypeID");

                entity.Property(e => e.Fmcsarules)
                    .HasColumnName("FMCSARules")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Graduated).HasDefaultValueSql("0");

                entity.Property(e => e.HideExperience).HasDefaultValueSql("0");

                entity.Property(e => e.LeftOn).HasColumnType("datetime");

                entity.Property(e => e.MilesPerWeek).HasDefaultValueSql("0");

                entity.Property(e => e.MilitaryBranchId).HasColumnName("MilitaryBranchID");

                entity.Property(e => e.MilitaryRankId).HasColumnName("MilitaryRankID");

                entity.Property(e => e.MilitarySchoolId).HasColumnName("MilitarySchoolID");

                entity.Property(e => e.MilitarySpecialtyId).HasColumnName("MilitarySpecialtyID");

                entity.Property(e => e.MilitaryStatusId).HasColumnName("MilitaryStatusID");

                entity.Property(e => e.OtherExperienceName).HasColumnType("varchar(150)");

                entity.Property(e => e.OtherLeftReason).HasColumnType("varchar(500)");

                entity.Property(e => e.OutsideSource).HasColumnType("varchar(50)");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.SafetySensitive).HasDefaultValueSql("0");

                entity.Property(e => e.SchoolName).HasColumnType("varchar(150)");

                entity.Property(e => e.StartedOn).HasColumnType("datetime");

                entity.HasOne(d => d.AccountCity)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.AccountCityId)
                    .HasConstraintName("FK_Experience_GeoCity");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Experience_Account_ID");

                entity.HasOne(d => d.ExperienceType)
                    .WithMany(p => p.ExperienceExperienceType)
                    .HasForeignKey(d => d.ExperienceTypeId)
                    .HasConstraintName("FK_Experience_Attr");

                entity.HasOne(d => d.MilitaryBranch)
                    .WithMany(p => p.ExperienceMilitaryBranch)
                    .HasForeignKey(d => d.MilitaryBranchId)
                    .HasConstraintName("FK_Experience_Attr1");

                entity.HasOne(d => d.MilitaryRank)
                    .WithMany(p => p.ExperienceMilitaryRank)
                    .HasForeignKey(d => d.MilitaryRankId)
                    .HasConstraintName("FK_Experience_Attr3");

                entity.HasOne(d => d.MilitarySchool)
                    .WithMany(p => p.ExperienceMilitarySchool)
                    .HasForeignKey(d => d.MilitarySchoolId)
                    .HasConstraintName("FK_Experience_Attr5");

                entity.HasOne(d => d.MilitarySpecialty)
                    .WithMany(p => p.ExperienceMilitarySpecialty)
                    .HasForeignKey(d => d.MilitarySpecialtyId)
                    .HasConstraintName("FK_Experience_Attr2");

                entity.HasOne(d => d.MilitaryStatus)
                    .WithMany(p => p.ExperienceMilitaryStatus)
                    .HasForeignKey(d => d.MilitaryStatusId)
                    .HasConstraintName("FK_Experience_Attr4");

                entity.HasOne(d => d.Months)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.MonthsId)
                    .HasConstraintName("FK_Experience_TimeMonth");

                entity.HasOne(d => d.OnetAlternateTitle)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.OnetAlternateTitleId)
                    .HasConstraintName("FK_Experience_onet_alternate_title_ID");

                entity.HasOne(d => d.OnetOccupation)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.OnetOccupationId)
                    .HasConstraintName("FK_Experience_onet_occupation_data");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Experience_Profile_ID");

                entity.HasOne(d => d.Years)
                    .WithMany(p => p.Experience)
                    .HasForeignKey(d => d.YearsId)
                    .HasConstraintName("FK_Experience_TimeYear");
            });

            modelBuilder.Entity<ExperienceAttr>(entity =>
            {
                entity.Property(e => e.AttrId).HasColumnName("AttrID");

                entity.Property(e => e.ExpCategory)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.ExperienceId).HasColumnName("ExperienceID");

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.ExperienceAttr)
                    .HasForeignKey(d => d.AttrId)
                    .HasConstraintName("FK_ExperienceAttr_Attr");
            });

            modelBuilder.Entity<ExperienceDetail>(entity =>
            {
                entity.HasIndex(e => new { e.ExperienceId, e.HideDetail })
                    .HasName("nci_wi_ExperienceDetail_69BE55CEF76CD4B25ADE2FB13A89F617");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DetailRank).HasDefaultValueSql("0");

                entity.Property(e => e.ExperienceDetail1)
                    .IsRequired()
                    .HasColumnName("ExperienceDetail")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ExperienceId).HasColumnName("ExperienceID");

                entity.Property(e => e.HideDetail).HasDefaultValueSql("0");

                entity.Property(e => e.OnetCode)
                    .HasColumnName("onetCode")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OnetCodeId).HasColumnName("onetCode_id");

                entity.Property(e => e.OnetCodeType)
                    .HasColumnName("onetCodeType")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OutsideSource).HasColumnType("varchar(50)");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceDetail)
                    .HasForeignKey(d => d.ExperienceId)
                    .HasConstraintName("FK_ExperienceDetail_Experience_ID");
            });

            modelBuilder.Entity<ExperienceOnetAbilities>(entity =>
            {
                entity.HasKey(e => new { e.ExperienceId, e.AbilitiesId })
                    .HasName("PK_ExperienceOnetAbilities");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DisplayRank).HasDefaultValueSql("0");

                entity.HasOne(d => d.Abilities)
                    .WithMany(p => p.ExperienceOnetAbilities)
                    .HasForeignKey(d => d.AbilitiesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetAbilities_onet_abilities");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceOnetAbilities)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetAbilities_Experience");
            });

            modelBuilder.Entity<ExperienceOnetActivities>(entity =>
            {
                entity.HasKey(e => new { e.ExperienceId, e.ActivitiesId })
                    .HasName("PK_ExperienceOnetActivities");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DisplayRank).HasDefaultValueSql("0");

                entity.HasOne(d => d.Activities)
                    .WithMany(p => p.ExperienceOnetActivities)
                    .HasForeignKey(d => d.ActivitiesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetActivities_onet_work_activities");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceOnetActivities)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetActivities_Experience");
            });

            modelBuilder.Entity<ExperienceOnetAltTitle>(entity =>
            {
                entity.HasKey(e => new { e.ExperienceId, e.AltTitleId })
                    .HasName("PK_ExperienceOnetAltTitle");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DisplayRank).HasDefaultValueSql("0");

                entity.HasOne(d => d.AltTitle)
                    .WithMany(p => p.ExperienceOnetAltTitle)
                    .HasForeignKey(d => d.AltTitleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetAltTitle_onet_alternate_title");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceOnetAltTitle)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetAltTitle_Experience");
            });

            modelBuilder.Entity<ExperienceOnetKnowledge>(entity =>
            {
                entity.HasKey(e => new { e.ExperienceId, e.KnowledgeId })
                    .HasName("PK_ExperienceOnetKnowledge");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DisplayRank).HasDefaultValueSql("0");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceOnetKnowledge)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetKnowledge_Experience");

                entity.HasOne(d => d.Knowledge)
                    .WithMany(p => p.ExperienceOnetKnowledge)
                    .HasForeignKey(d => d.KnowledgeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetKnowledge_onet_knowledge");
            });

            modelBuilder.Entity<ExperienceOnetOccupation>(entity =>
            {
                entity.HasKey(e => new { e.ExperienceId, e.OnetId })
                    .HasName("PK_ExperienceOnetOccupation");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DisplayRank).HasDefaultValueSql("0");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceOnetOccupation)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetOccupation_Experience");

                entity.HasOne(d => d.Onet)
                    .WithMany(p => p.ExperienceOnetOccupation)
                    .HasForeignKey(d => d.OnetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetOccupation_onet_occupation_data");
            });

            modelBuilder.Entity<ExperienceOnetSampleTitles>(entity =>
            {
                entity.HasKey(e => new { e.ExperienceId, e.SampleTitlesId })
                    .HasName("PK_ExperienceOnetSampleTitles");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DisplayRank).HasDefaultValueSql("0");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceOnetSampleTitles)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetSampleTitles_Experience");

                entity.HasOne(d => d.SampleTitles)
                    .WithMany(p => p.ExperienceOnetSampleTitles)
                    .HasForeignKey(d => d.SampleTitlesId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetSampleTitles_onet_sample_of_reported_titles");
            });

            modelBuilder.Entity<ExperienceOnetSkills>(entity =>
            {
                entity.HasKey(e => new { e.ExperienceId, e.SkillsId })
                    .HasName("PK_ExperienceOnetSkills");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DisplayRank).HasDefaultValueSql("0");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceOnetSkills)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetSkills_Experience");

                entity.HasOne(d => d.Skills)
                    .WithMany(p => p.ExperienceOnetSkills)
                    .HasForeignKey(d => d.SkillsId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetSkills_onet_skills");
            });

            modelBuilder.Entity<ExperienceOnetToolsTech>(entity =>
            {
                entity.HasKey(e => new { e.ExperienceId, e.ToolsTechId })
                    .HasName("PK_ExperienceOnetToolsTech");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DisplayRank).HasDefaultValueSql("0");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceOnetToolsTech)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetToolsTech_Experience");

                entity.HasOne(d => d.ToolsTech)
                    .WithMany(p => p.ExperienceOnetToolsTech)
                    .HasForeignKey(d => d.ToolsTechId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceOnetToolsTech_onet_tools_and_technology");
            });

            modelBuilder.Entity<ExperienceReasonLeft>(entity =>
            {
                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceReasonLeft)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceReasonLeft_Experience");

                entity.HasOne(d => d.ReasonLeft)
                    .WithMany(p => p.ExperienceReasonLeft)
                    .HasForeignKey(d => d.ReasonLeftId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceReasonLeft_ReasonLeft");
            });

            modelBuilder.Entity<ExperienceState>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExperienceId).HasColumnName("ExperienceID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceState)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExperienceState_Experience_ID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ExperienceState)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<ExternalSource>(entity =>
            {
                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<FeedBatch>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CrBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.CrDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.FeedControlId).HasColumnName("FeedControlID");

                entity.Property(e => e.MdBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.MdDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.FeedControl)
                    .WithMany(p => p.FeedBatch)
                    .HasForeignKey(d => d.FeedControlId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FEEDBATCH_FEEDCONTROL");
            });

            modelBuilder.Entity<FeedControl>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_FEEDCONTROL_NAME")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActiveFeed).HasDefaultValueSql("0");

                entity.Property(e => e.AutomaticFeed).HasDefaultValueSql("0");

                entity.Property(e => e.CrBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.CrDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ExceptionCount).HasDefaultValueSql("0");

                entity.Property(e => e.LastCommSuccessful).HasDefaultValueSql("0");

                entity.Property(e => e.LastTaskCompleted).HasDefaultValueSql("0");

                entity.Property(e => e.MdBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.MdDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.TaskCompletedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FeedControlAccount>(entity =>
            {
                entity.HasKey(e => new { e.ControlId, e.AccountId })
                    .HasName("PK_FeedControlAccount");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.FeedControlAccount)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FeedControlAccount_Account");

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.FeedControlAccount)
                    .HasForeignKey(d => d.ControlId)
                    .HasConstraintName("FK_FeedControlAccount_FeedControl");
            });

            modelBuilder.Entity<FeedException>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CrBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.CrDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Description).HasColumnType("varchar(max)");

                entity.Property(e => e.Ex)
                    .IsRequired()
                    .HasColumnType("varchar(1024)");

                entity.Property(e => e.FeedBatchId).HasColumnName("FeedBatchID");

                entity.Property(e => e.MdBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.MdDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.FeedBatch)
                    .WithMany(p => p.FeedException)
                    .HasForeignKey(d => d.FeedBatchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FeedException_FeedBatch");
            });

            modelBuilder.Entity<FeedLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CrBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.CrDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.FeedBatchId).HasColumnName("FeedBatchID");

                entity.Property(e => e.MdBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.MdDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.FeedBatch)
                    .WithMany(p => p.FeedLog)
                    .HasForeignKey(d => d.FeedBatchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FEEDLOG_FEEDBATCH");
            });

            modelBuilder.Entity<FeedLogProperty>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CrBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.CrDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.FeedLogId).HasColumnName("FeedLogID");

                entity.Property(e => e.MdBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.MdDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PropertyValue).HasColumnType("varchar(255)");

                entity.HasOne(d => d.FeedLog)
                    .WithMany(p => p.FeedLogProperty)
                    .HasForeignKey(d => d.FeedLogId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FEEDLOGPROPERTY_FEEDLOG");
            });

            modelBuilder.Entity<FeedMapping>(entity =>
            {
                entity.Property(e => e.MappingName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MappingRank).HasDefaultValueSql("1");

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.FeedMapping)
                    .HasForeignKey(d => d.ControlId)
                    .HasConstraintName("FK_FeedMapping_FeedControl");

                entity.HasOne(d => d.MappingColumn)
                    .WithMany(p => p.FeedMapping)
                    .HasForeignKey(d => d.MappingColumnId)
                    .HasConstraintName("FK_FeedMapping_FeedMappingColumn");
            });

            modelBuilder.Entity<FeedMappingColumn>(entity =>
            {
                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<FeedProperty>(entity =>
            {
                entity.HasIndex(e => new { e.FeedControlId, e.PropertyName, e.PropertyValue })
                    .HasName("AK_FEEDPROPERTY")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CrBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.CrDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.FeedControlId).HasColumnName("FeedControlID");

                entity.Property(e => e.MdBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.MdDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.PropertyValue)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.FeedControl)
                    .WithMany(p => p.FeedProperty)
                    .HasForeignKey(d => d.FeedControlId)
                    .HasConstraintName("FK_FEEDPROPERTY_FEEDCONTROL");
            });

            modelBuilder.Entity<GeoCity>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK_GeoCity");

                entity.HasIndex(e => e.StateId)
                    .HasName("Idx_GeoCity_StateID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CitySt)
                    .IsRequired()
                    .HasColumnName("CityST")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.GeoCity)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_GeoCity_GeoState");
            });

            modelBuilder.Entity<GeoCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK_GeoCountry");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryAbbr)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<GeoRegion>(entity =>
            {
                entity.Property(e => e.GeoJson).HasColumnType("varchar(max)");

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<GeoState>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK_GeoState");

                entity.HasIndex(e => e.CountryId)
                    .HasName("Idx_GeoState_CountryID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.St)
                    .IsRequired()
                    .HasColumnName("ST")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.Stname)
                    .HasColumnName("STName")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.GeoState)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_GeoState_GeoCountry");
            });

            modelBuilder.Entity<GeoZip>(entity =>
            {
                entity.HasKey(e => e.ZipId)
                    .HasName("PK_GeoZip");

                entity.HasIndex(e => e.CityId)
                    .HasName("Idx_GeoZip_CityID");

                entity.Property(e => e.ZipId).HasColumnName("ZipID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CitySt)
                    .IsRequired()
                    .HasColumnName("CityST")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.CityStzip)
                    .IsRequired()
                    .HasColumnName("CitySTZip")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnType("varchar(15)");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.GeoZip)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_GeoZip_GeoCity");
            });

            modelBuilder.Entity<GeoZipPop>(entity =>
            {
                entity.HasIndex(e => e.Zip)
                    .HasName("AK_ZIPCENSUSPOP_ZIP")
                    .IsUnique();

                entity.HasIndex(e => e.ZipId)
                    .HasName("Idx_GeoZipPop_ZipID");

                entity.Property(e => e.GeoZipPopId).HasColumnName("GeoZipPopID");

                entity.Property(e => e.CrBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.CrDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.MdBy)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("user_name()");

                entity.Property(e => e.MdDt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.ZipId).HasColumnName("ZipID");

                entity.HasOne(d => d.ZipNavigation)
                    .WithMany(p => p.GeoZipPop)
                    .HasForeignKey(d => d.ZipId)
                    .HasConstraintName("FK_GeoZipPop_GeoZip");
            });

            modelBuilder.Entity<ImageLibrary>(entity =>
            {
                entity.Property(e => e.PictureContentType).HasColumnType("varchar(250)");

                entity.Property(e => e.PictureFileName).HasColumnType("varchar(150)");

                entity.Property(e => e.PictureName)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ImageLibrary)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ImageLibrary_Account");
            });

            modelBuilder.Entity<ImageLibraryAttr>(entity =>
            {
                entity.HasKey(e => new { e.LibraryId, e.AttrId })
                    .HasName("PK_ImageLibraryAttr");

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.ImageLibraryAttr)
                    .HasForeignKey(d => d.AttrId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ImageLibraryAttr_Attr");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.ImageLibraryAttr)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ImageLibraryAttr_ImageLibrary");
            });

            modelBuilder.Entity<ImageLibraryIndustry>(entity =>
            {
                entity.HasKey(e => new { e.LibraryId, e.IndustryId })
                    .HasName("PK_ImageLibraryIndustry");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.ImageLibraryIndustry)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ImageLibraryIndustry_Industry");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.ImageLibraryIndustry)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ImageLibraryIndustry_ImageLibrary");
            });

            modelBuilder.Entity<ImageLibraryTag>(entity =>
            {
                entity.HasKey(e => new { e.ImageId, e.TagId })
                    .HasName("PK_ImageLibraryTag");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.ImageLibraryTag)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ImageLibraryTag_ImageLibrary");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.ImageLibraryTag)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ImageLibraryTag_ImageTag");
            });

            modelBuilder.Entity<ImageTag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PK_ImageTag");

                entity.Property(e => e.ImageTagName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Industry>(entity =>
            {
                entity.Property(e => e.IndustryName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.OnetIndustryCode)
                    .HasColumnName("onetIndustryCode")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Interview>(entity =>
            {
                entity.Property(e => e.InterviewName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Interview)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Interview_Account");
            });

            modelBuilder.Entity<InterviewAnswer>(entity =>
            {
                entity.HasIndex(e => new { e.InstanceId, e.QuestionId, e.AttrAnswerId })
                    .HasName("AK_InterviewAnswer");

                entity.Property(e => e.DateAnswer).HasColumnType("datetime");

                entity.Property(e => e.IntAnswer).HasDefaultValueSql("0");

                entity.Property(e => e.StringAnswer).HasColumnType("varchar(max)");

                entity.Property(e => e.YesNoAnswer).HasDefaultValueSql("0");

                entity.HasOne(d => d.AttrAnswer)
                    .WithMany(p => p.InterviewAnswer)
                    .HasForeignKey(d => d.AttrAnswerId)
                    .HasConstraintName("FK_InterviewAnswer_Attr");

                entity.HasOne(d => d.Instance)
                    .WithMany(p => p.InterviewAnswer)
                    .HasForeignKey(d => d.InstanceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewAnswer_InterviewInstance");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.InterviewAnswer)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewAnswer_InterviewQuestionLibrary");
            });

            modelBuilder.Entity<InterviewInstance>(entity =>
            {
                entity.Property(e => e.AbandonedAt).HasColumnType("datetime");

                entity.Property(e => e.InterviewAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.SubmittedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.InterviewInstance)
                    .HasForeignKey(d => d.ProfileId)
                    .HasConstraintName("FK_InterviewInstance_Profile");
            });

            modelBuilder.Entity<InterviewInstanceBriefcase>(entity =>
            {
                entity.HasKey(e => new { e.BriefcaseId, e.InstanceId })
                    .HasName("PK_InterviewInstanceBriefcase");

                entity.HasOne(d => d.Briefcase)
                    .WithMany(p => p.InterviewInstanceBriefcase)
                    .HasForeignKey(d => d.BriefcaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewInstanceBriefcase_Briefcase");

                entity.HasOne(d => d.Instance)
                    .WithMany(p => p.InterviewInstanceBriefcase)
                    .HasForeignKey(d => d.InstanceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewInstanceBriefcase_InterviewInstance");
            });

            modelBuilder.Entity<InterviewQuestion>(entity =>
            {
                entity.Property(e => e.QuestionRank).HasDefaultValueSql("1");

                entity.HasOne(d => d.Interview)
                    .WithMany(p => p.InterviewQuestion)
                    .HasForeignKey(d => d.InterviewId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewQuestion_Interview");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.InterviewQuestion)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewQuestion_InterviewQuestionLibrary");
            });

            modelBuilder.Entity<InterviewQuestionCategory>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CategoryRank).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<InterviewQuestionFeedMapping>(entity =>
            {
                entity.Property(e => e.FeedMapName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FeedNode)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.InterviewQuestionFeedMapping)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewQuestionFeedMapping_Account");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.InterviewQuestionFeedMapping)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewQuestionFeedMapping_InterviewQuestionLibrary");
            });

            modelBuilder.Entity<InterviewQuestionLibrary>(entity =>
            {
                entity.Property(e => e.AnswerRequired).HasDefaultValueSql("0");

                entity.Property(e => e.QuestionRank).HasDefaultValueSql("1");

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.QuestionTitle)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.InterviewQuestionLibrary)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewQuestionLibrary_Account");

                entity.HasOne(d => d.MultipleChoice)
                    .WithMany(p => p.InterviewQuestionLibrary)
                    .HasForeignKey(d => d.MultipleChoiceId)
                    .HasConstraintName("FK_InterviewQuestionLibrary_Attr");

                entity.HasOne(d => d.QuestionCategory)
                    .WithMany(p => p.InterviewQuestionLibrary)
                    .HasForeignKey(d => d.QuestionCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewQuestionLibrary_InterviewQuestionCategory");

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.InterviewQuestionLibrary)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewQuestionLibrary_InterviewQuestionType");
            });

            modelBuilder.Entity<InterviewQuestionRule>(entity =>
            {
                entity.Property(e => e.AttrAnswerIdMax).HasColumnName("AttrAnswerId_Max");

                entity.Property(e => e.DateAnswer).HasColumnType("datetime");

                entity.Property(e => e.DateAnswerMax)
                    .HasColumnName("DateAnswer_Max")
                    .HasColumnType("datetime");

                entity.Property(e => e.IntAnswer).HasDefaultValueSql("0");

                entity.Property(e => e.IntAnswerMax).HasColumnName("IntAnswer_Max");

                entity.Property(e => e.RuleMessage).HasColumnType("varchar(2000)");

                entity.Property(e => e.RuleName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RuleTypeId).HasDefaultValueSql("0");

                entity.Property(e => e.SetAsDefault).HasDefaultValueSql("0");

                entity.Property(e => e.YesNoAnswer).HasDefaultValueSql("0");

                entity.HasOne(d => d.AttrAnswer)
                    .WithMany(p => p.InterviewQuestionRuleAttrAnswer)
                    .HasForeignKey(d => d.AttrAnswerId)
                    .HasConstraintName("FK_InterviewQuestionRule_Attr");

                entity.HasOne(d => d.AttrAnswerIdMaxNavigation)
                    .WithMany(p => p.InterviewQuestionRuleAttrAnswerIdMaxNavigation)
                    .HasForeignKey(d => d.AttrAnswerIdMax)
                    .HasConstraintName("FK_InterviewQuestionRule_Attr1");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.InterviewQuestionRule)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewQuestionRule_InterviewQuestionLibrary");

                entity.HasOne(d => d.RuleType)
                    .WithMany(p => p.InterviewQuestionRule)
                    .HasForeignKey(d => d.RuleTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewQuestionRule_InterviewQuestionRuleType");

                entity.HasOne(d => d.RuleValue)
                    .WithMany(p => p.InterviewQuestionRule)
                    .HasForeignKey(d => d.RuleValueId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewQuestionRule_InterviewQuestionRuleValue");
            });

            modelBuilder.Entity<InterviewQuestionRuleType>(entity =>
            {
                entity.Property(e => e.RuleTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<InterviewQuestionRuleValue>(entity =>
            {
                entity.Property(e => e.RuleValueName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<InterviewQuestionType>(entity =>
            {
                entity.Property(e => e.QuestionTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<InterviewRuleFollowUp>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.Questionid })
                    .HasName("PK_InterviewRuleFollowUp");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.InterviewRuleFollowUp)
                    .HasForeignKey(d => d.Questionid)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewRuleFollowUp_InterviewQuestionLibrary");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.InterviewRuleFollowUp)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InterviewRuleFollowUp_InterviewQuestionRule");
            });

            modelBuilder.Entity<Keyword>(entity =>
            {
                entity.Property(e => e.KeywordText)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Listing>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_Listing_AccountId");

                entity.HasIndex(e => e.City)
                    .HasName("Idx_Listing_City");

                entity.HasIndex(e => e.Country)
                    .HasName("Idx_Listing_Country");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("Idx_Listing_CreatedAt");

                entity.HasIndex(e => e.IndexedAt)
                    .HasName("Idx_Listing_IndexedAt");

                entity.HasIndex(e => e.Lat)
                    .HasName("IX_Listing_Lat");

                entity.HasIndex(e => e.Long)
                    .HasName("IX_Listing_Long");

                entity.HasIndex(e => e.ReqNo)
                    .HasName("Idx_Listing_ReqNo");

                entity.HasIndex(e => e.State)
                    .HasName("Idx_Listing_State");

                entity.HasIndex(e => e.TitleId)
                    .HasName("IDX_Listing_TitleId");

                entity.HasIndex(e => e.Zip)
                    .HasName("Idx_Listing_Zip");

                entity.HasIndex(e => e.ZipId)
                    .HasName("Idx_Listing_ZipId");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City).HasColumnType("varchar(50)");

                entity.Property(e => e.Country).HasColumnType("varchar(50)");

                entity.Property(e => e.IndexedAt).HasColumnType("datetime");

                entity.Property(e => e.ReqApply).HasMaxLength(500);

                entity.Property(e => e.ReqNo)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.State).HasColumnType("varchar(50)");

                entity.Property(e => e.Title).HasColumnType("varchar(250)");

                entity.Property(e => e.Zip).HasColumnType("varchar(50)");

                entity.HasOne(d => d.TitleNavigation)
                    .WithMany(p => p.Listing)
                    .HasForeignKey(d => d.TitleId)
                    .HasConstraintName("FK_Listing_CoreTitle");
            });

            modelBuilder.Entity<ListingAttr>(entity =>
            {
                entity.HasKey(e => new { e.ListingId, e.AttrId })
                    .HasName("PK_PostReqAttr");

                entity.HasIndex(e => e.AttrId)
                    .HasName("IDX_PostReqAttr_AttrId");

                entity.HasIndex(e => e.ListingId)
                    .HasName("IDX_PostReqAttr_ReqId");

                entity.Property(e => e.MatchWeight).HasDefaultValueSql("0");

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.ListingAttr)
                    .HasForeignKey(d => d.AttrId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ListingAttr_Attr");

                entity.HasOne(d => d.Listing)
                    .WithMany(p => p.ListingAttr)
                    .HasForeignKey(d => d.ListingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ListingAttr_Listing");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.LogDetails).HasColumnType("varchar(1000)");

                entity.Property(e => e.LoggedAt).HasColumnType("datetime");

                entity.HasOne(d => d.LogEvent)
                    .WithMany(p => p.Log)
                    .HasForeignKey(d => d.LogEventId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Log_LogEvent");

                entity.HasOne(d => d.LoggedBy)
                    .WithMany(p => p.Log)
                    .HasForeignKey(d => d.LoggedById)
                    .HasConstraintName("FK_Log_Person");
            });

            modelBuilder.Entity<LogClock>(entity =>
            {
                entity.HasOne(d => d.Clock)
                    .WithMany(p => p.LogClock)
                    .HasForeignKey(d => d.ClockId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LogClock_Clock");

                entity.HasOne(d => d.Log)
                    .WithMany(p => p.LogClock)
                    .HasForeignKey(d => d.LogId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_LogClock_Log");
            });

            modelBuilder.Entity<LogEvent>(entity =>
            {
                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<LogoType>(entity =>
            {
                entity.Property(e => e.LogoTypeName).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<MediaLinkType>(entity =>
            {
                entity.Property(e => e.LinkTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<MediaVideoProvider>(entity =>
            {
                entity.Property(e => e.VideoProviderName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Metric>(entity =>
            {
                entity.Property(e => e.MetricName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MetricRank).HasDefaultValueSql("1");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Metric)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Metric_MetricCategory");

                entity.HasOne(d => d.DataType)
                    .WithMany(p => p.Metric)
                    .HasForeignKey(d => d.DataTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Metric_DataType");
            });

            modelBuilder.Entity<MetricCategory>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<MilitaryBase>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseCityId).HasColumnName("BaseCityID");

                entity.Property(e => e.BaseCountryId).HasColumnName("BaseCountryID");

                entity.Property(e => e.BaseDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.BaseLogo).HasColumnType("varchar(255)");

                entity.Property(e => e.BaseName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.BaseCity)
                    .WithMany(p => p.MilitaryBase)
                    .HasForeignKey(d => d.BaseCityId)
                    .HasConstraintName("FK_MilitaryBase_GeoCity_CityID");

                entity.HasOne(d => d.BaseCountry)
                    .WithMany(p => p.MilitaryBase)
                    .HasForeignKey(d => d.BaseCountryId)
                    .HasConstraintName("FK_MilitaryBase_GeoCountry_CountryID");
            });

            modelBuilder.Entity<MilitaryBaseMilitaryBranch>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseId).HasColumnName("BaseID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.HasOne(d => d.Base)
                    .WithMany(p => p.MilitaryBaseMilitaryBranch)
                    .HasForeignKey(d => d.BaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MilitaryBaseMilitaryBranch_MilitaryBase_ID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.MilitaryBaseMilitaryBranch)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_MilitaryBaseMilitaryBranch_Attr");
            });

            modelBuilder.Entity<MilitaryBasePerson>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseId).HasColumnName("BaseID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Base)
                    .WithMany(p => p.MilitaryBasePerson)
                    .HasForeignKey(d => d.BaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MilitaryBasePerson_MilitaryBase_ID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.MilitaryBasePerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MilitaryBasePerson_Person_ID");
            });

            modelBuilder.Entity<MilitaryHiringExperience>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HiringExperienceRank)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MilitaryHiringExperience1)
                    .IsRequired()
                    .HasColumnName("MilitaryHiringExperience")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<NationalResourceDirectory>(entity =>
            {
                entity.Property(e => e.ResourceLink).HasColumnType("varchar(255)");

                entity.Property(e => e.ResourceName).HasColumnType("varchar(255)");

                entity.Property(e => e.ResourcePhone).HasColumnType("varchar(50)");

                entity.Property(e => e.ResoureShortName).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<OnetAbilities>(entity =>
            {
                entity.ToTable("onet_abilities");

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("date_updated")
                    .HasColumnType("date");

                entity.Property(e => e.DomainSource)
                    .IsRequired()
                    .HasColumnName("domain_source")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ElementId)
                    .IsRequired()
                    .HasColumnName("element_id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LowerCiBound)
                    .HasColumnName("lower_ci_bound")
                    .HasColumnType("decimal");

                entity.Property(e => e.N)
                    .HasColumnName("n")
                    .HasColumnType("decimal");

                entity.Property(e => e.NotRelevant)
                    .HasColumnName("not_relevant")
                    .HasColumnType("char(1)");

                entity.Property(e => e.OnetsocCode)
                    .IsRequired()
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.RecommendSuppress)
                    .HasColumnName("recommend_suppress")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ScaleId)
                    .IsRequired()
                    .HasColumnName("scale_id")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.StandardError)
                    .HasColumnName("standard_error")
                    .HasColumnType("decimal");

                entity.Property(e => e.UpperCiBound)
                    .HasColumnName("upper_ci_bound")
                    .HasColumnType("decimal");

                entity.HasOne(d => d.OnetsocCodeNavigation)
                    .WithMany(p => p.OnetAbilities)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.OnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_abilities_onet_occupation_data");

                entity.HasOne(d => d.Scale)
                    .WithMany(p => p.OnetAbilities)
                    .HasForeignKey(d => d.ScaleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__onet_abil__scale__5A1103C7");
            });

            modelBuilder.Entity<OnetAlternateTitle>(entity =>
            {
                entity.ToTable("onet_alternate_title");

                entity.Property(e => e.AlternateTitle).HasColumnType("varchar(200)");

                entity.Property(e => e.OnetsocCode)
                    .IsRequired()
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.ShortTitle).HasColumnType("varchar(100)");

                entity.Property(e => e.Title).HasColumnType("varchar(100)");

                entity.HasOne(d => d.OnetsocCodeNavigation)
                    .WithMany(p => p.OnetAlternateTitle)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.OnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_alternate_titles_onet_occupation_data");
            });

            modelBuilder.Entity<OnetCareerChangersMatrix>(entity =>
            {
                entity.HasKey(e => new { e.OnetsocCode, e.RelatedOnetsocCode })
                    .HasName("PK_onet_career_changers_matrix");

                entity.ToTable("onet_career_changers_matrix");

                entity.Property(e => e.OnetsocCode)
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.RelatedOnetsocCode)
                    .HasColumnName("related_onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.RelatedIndex)
                    .HasColumnName("related_index")
                    .HasColumnType("decimal");

                entity.HasOne(d => d.OnetsocCodeNavigation)
                    .WithMany(p => p.OnetCareerChangersMatrixOnetsocCodeNavigation)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.OnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_career_changers_matrix_onet_occupation_data");

                entity.HasOne(d => d.RelatedOnetsocCodeNavigation)
                    .WithMany(p => p.OnetCareerChangersMatrixRelatedOnetsocCodeNavigation)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.RelatedOnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_career_changers_matrix_onet_occupation_data1");
            });

            modelBuilder.Entity<OnetCareerStartersMatrix>(entity =>
            {
                entity.HasKey(e => new { e.OnetsocCode, e.RelatedOnetsocCode })
                    .HasName("PK_onet_career_starters_matrix");

                entity.ToTable("onet_career_starters_matrix");

                entity.Property(e => e.OnetsocCode)
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.RelatedOnetsocCode)
                    .HasColumnName("related_onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.RelatedIndex)
                    .HasColumnName("related_index")
                    .HasColumnType("decimal");

                entity.HasOne(d => d.OnetsocCodeNavigation)
                    .WithMany(p => p.OnetCareerStartersMatrixOnetsocCodeNavigation)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.OnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_career_starters_matrix_onet_occupation_data");

                entity.HasOne(d => d.RelatedOnetsocCodeNavigation)
                    .WithMany(p => p.OnetCareerStartersMatrixRelatedOnetsocCodeNavigation)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.RelatedOnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_career_starters_matrix_onet_occupation_data1");
            });

            modelBuilder.Entity<OnetContentModelReference>(entity =>
            {
                entity.ToTable("onet_content_model_reference");

                entity.HasIndex(e => e.ElementId)
                    .HasName("IX_onet_content_model_reference")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.ElementId)
                    .IsRequired()
                    .HasColumnName("element_id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ElementName)
                    .IsRequired()
                    .HasColumnName("element_name")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<OnetCrosswalk>(entity =>
            {
                entity.ToTable("onet_crosswalk");

                entity.HasIndex(e => e.Moccode)
                    .HasName("IX_OnetOccupationalDataCrosswalk_1");

                entity.HasIndex(e => e.Onetcode)
                    .HasName("IX_OnetOccupationalDataCrosswalk");

                entity.Property(e => e.Moccode)
                    .HasColumnName("MOCCODE")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Onetcode)
                    .HasColumnName("ONETCODE")
                    .HasColumnType("char(10)");

                entity.HasOne(d => d.OnetcodeNavigation)
                    .WithMany(p => p.OnetCrosswalk)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.Onetcode)
                    .HasConstraintName("FK_onet_crosswalk_onet_occupation_data");
            });

            modelBuilder.Entity<OnetCrosswalkSupplementary>(entity =>
            {
                entity.ToTable("onet_crosswalk_supplementary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MilitarySpecialtyId).HasColumnName("MilitarySpecialtyID");

                entity.Property(e => e.OnetOccupationId).HasColumnName("OnetOccupationID");

                entity.HasOne(d => d.MilitarySpecialty)
                    .WithMany(p => p.OnetCrosswalkSupplementary)
                    .HasForeignKey(d => d.MilitarySpecialtyId)
                    .HasConstraintName("FK_MilitaryCrosswalk_Attr");

                entity.HasOne(d => d.OnetOccupation)
                    .WithMany(p => p.OnetCrosswalkSupplementary)
                    .HasForeignKey(d => d.OnetOccupationId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_crosswalk_supplementary_onet_occupation_data");
            });

            modelBuilder.Entity<OnetKnowledge>(entity =>
            {
                entity.ToTable("onet_knowledge");

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("date_updated")
                    .HasColumnType("date");

                entity.Property(e => e.DomainSource)
                    .IsRequired()
                    .HasColumnName("domain_source")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ElementId)
                    .IsRequired()
                    .HasColumnName("element_id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LowerCiBound)
                    .HasColumnName("lower_ci_bound")
                    .HasColumnType("decimal");

                entity.Property(e => e.N)
                    .HasColumnName("n")
                    .HasColumnType("decimal");

                entity.Property(e => e.NotRelevant)
                    .HasColumnName("not_relevant")
                    .HasColumnType("char(1)");

                entity.Property(e => e.OnetsocCode)
                    .IsRequired()
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.RecommendSuppress)
                    .HasColumnName("recommend_suppress")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ScaleId)
                    .IsRequired()
                    .HasColumnName("scale_id")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.StandardError)
                    .HasColumnName("standard_error")
                    .HasColumnType("decimal");

                entity.Property(e => e.UpperCiBound)
                    .HasColumnName("upper_ci_bound")
                    .HasColumnType("decimal");

                entity.HasOne(d => d.OnetsocCodeNavigation)
                    .WithMany(p => p.OnetKnowledge)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.OnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_knowledge_onet_occupation_data");

                entity.HasOne(d => d.Scale)
                    .WithMany(p => p.OnetKnowledge)
                    .HasForeignKey(d => d.ScaleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__onet_know__scale__5CED7072");
            });

            modelBuilder.Entity<OnetOccupationData>(entity =>
            {
                entity.ToTable("onet_occupation_data");

                entity.HasIndex(e => e.OnetsocCode)
                    .HasName("IX_onet_occupation_data")
                    .IsUnique();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.DescriptionPastTense)
                    .HasColumnName("description_past_tense")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.OnetsocCode)
                    .IsRequired()
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<OnetSampleOfReportedTitles>(entity =>
            {
                entity.ToTable("onet_sample_of_reported_titles");

                entity.Property(e => e.OnetsocCode)
                    .IsRequired()
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.ReportedJobTitle)
                    .IsRequired()
                    .HasColumnName("reported_job_title")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.ShownInMyNextMove)
                    .IsRequired()
                    .HasColumnName("shown_in_my_next_move")
                    .HasColumnType("char(1)");

                entity.HasOne(d => d.OnetsocCodeNavigation)
                    .WithMany(p => p.OnetSampleOfReportedTitles)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.OnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_sample_of_reported_titles_onet_occupation_data");
            });

            modelBuilder.Entity<OnetScalesReference>(entity =>
            {
                entity.HasKey(e => e.ScaleId)
                    .HasName("PK__onet_sca__853DA6AD080F20F2");

                entity.ToTable("onet_scales_reference");

                entity.Property(e => e.ScaleId)
                    .HasColumnName("scale_id")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.Maximum)
                    .HasColumnName("maximum")
                    .HasColumnType("decimal");

                entity.Property(e => e.Minimum)
                    .HasColumnName("minimum")
                    .HasColumnType("decimal");

                entity.Property(e => e.ScaleName)
                    .IsRequired()
                    .HasColumnName("scale_name")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<OnetSkills>(entity =>
            {
                entity.ToTable("onet_skills");

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("date_updated")
                    .HasColumnType("date");

                entity.Property(e => e.DomainSource)
                    .IsRequired()
                    .HasColumnName("domain_source")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ElementId)
                    .IsRequired()
                    .HasColumnName("element_id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LowerCiBound)
                    .HasColumnName("lower_ci_bound")
                    .HasColumnType("decimal");

                entity.Property(e => e.N)
                    .HasColumnName("n")
                    .HasColumnType("decimal");

                entity.Property(e => e.NotRelevant)
                    .HasColumnName("not_relevant")
                    .HasColumnType("char(1)");

                entity.Property(e => e.OnetsocCode)
                    .IsRequired()
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.RecommendSuppress)
                    .HasColumnName("recommend_suppress")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ScaleId)
                    .IsRequired()
                    .HasColumnName("scale_id")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.StandardError)
                    .HasColumnName("standard_error")
                    .HasColumnType("decimal");

                entity.Property(e => e.UpperCiBound)
                    .HasColumnName("upper_ci_bound")
                    .HasColumnType("decimal");

                entity.HasOne(d => d.OnetsocCodeNavigation)
                    .WithMany(p => p.OnetSkills)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.OnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_skills_onet_occupation_data");

                entity.HasOne(d => d.Scale)
                    .WithMany(p => p.OnetSkills)
                    .HasForeignKey(d => d.ScaleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__onet_skil__scale__5FC9DD1D");
            });

            modelBuilder.Entity<OnetTaskStatements>(entity =>
            {
                entity.ToTable("onet_task_statements");

                entity.HasIndex(e => e.TaskId)
                    .HasName("IX_onet_task_statements")
                    .IsUnique();

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("date_updated")
                    .HasColumnType("date");

                entity.Property(e => e.DomainSource)
                    .IsRequired()
                    .HasColumnName("domain_source")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.IncumbentsResponding)
                    .HasColumnName("incumbents_responding")
                    .HasColumnType("decimal");

                entity.Property(e => e.OnetsocCode)
                    .IsRequired()
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Task)
                    .IsRequired()
                    .HasColumnName("task")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.TaskId)
                    .IsRequired()
                    .HasColumnName("task_id");

                entity.Property(e => e.TaskPastTense)
                    .HasColumnName("task_past_tense")
                    .HasColumnType("varchar(1000)");

                entity.Property(e => e.TaskType)
                    .HasColumnName("task_type")
                    .HasColumnType("varchar(12)");

                entity.HasOne(d => d.OnetsocCodeNavigation)
                    .WithMany(p => p.OnetTaskStatements)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.OnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_task_statements_onet_occupation_data");
            });

            modelBuilder.Entity<OnetToolsAndTechnology>(entity =>
            {
                entity.ToTable("onet_tools_and_technology");

                entity.Property(e => e.CommodityCode)
                    .HasColumnName("commodity_code")
                    .HasColumnType("decimal");

                entity.Property(e => e.HotTechnology)
                    .IsRequired()
                    .HasColumnName("hot_technology")
                    .HasColumnType("char(1)");

                entity.Property(e => e.OnetsocCode)
                    .IsRequired()
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.T2Example)
                    .IsRequired()
                    .HasColumnName("t2_example")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.T2Type)
                    .IsRequired()
                    .HasColumnName("t2_type")
                    .HasColumnType("varchar(10)");

                entity.HasOne(d => d.CommodityCodeNavigation)
                    .WithMany(p => p.OnetToolsAndTechnology)
                    .HasForeignKey(d => d.CommodityCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_tools_and_technology_onet_unspsc_reference");

                entity.HasOne(d => d.OnetsocCodeNavigation)
                    .WithMany(p => p.OnetToolsAndTechnology)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.OnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_tools_and_technology_onet_occupation_data");
            });

            modelBuilder.Entity<OnetUnspscReference>(entity =>
            {
                entity.HasKey(e => e.CommodityCode)
                    .HasName("PK__onet_uns__6C0BFFF2409213C6");

                entity.ToTable("onet_unspsc_reference");

                entity.Property(e => e.CommodityCode)
                    .HasColumnName("commodity_code")
                    .HasColumnType("decimal");

                entity.Property(e => e.ClassCode)
                    .HasColumnName("class_code")
                    .HasColumnType("decimal");

                entity.Property(e => e.ClassTitle)
                    .IsRequired()
                    .HasColumnName("class_title")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.CommodityTitle)
                    .IsRequired()
                    .HasColumnName("commodity_title")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.FamilyCode)
                    .HasColumnName("family_code")
                    .HasColumnType("decimal");

                entity.Property(e => e.FamilyTitle)
                    .IsRequired()
                    .HasColumnName("family_title")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.SegmentCode)
                    .HasColumnName("segment_code")
                    .HasColumnType("decimal");

                entity.Property(e => e.SegmentTitle)
                    .IsRequired()
                    .HasColumnName("segment_title")
                    .HasColumnType("varchar(150)");
            });

            modelBuilder.Entity<OnetWorkActivities>(entity =>
            {
                entity.ToTable("onet_work_activities");

                entity.Property(e => e.DataValue)
                    .HasColumnName("data_value")
                    .HasColumnType("decimal");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("date_updated")
                    .HasColumnType("date");

                entity.Property(e => e.DomainSource)
                    .IsRequired()
                    .HasColumnName("domain_source")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ElementId)
                    .IsRequired()
                    .HasColumnName("element_id")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.LowerCiBound)
                    .HasColumnName("lower_ci_bound")
                    .HasColumnType("decimal");

                entity.Property(e => e.N)
                    .HasColumnName("n")
                    .HasColumnType("decimal");

                entity.Property(e => e.NotRelevant)
                    .HasColumnName("not_relevant")
                    .HasColumnType("char(1)");

                entity.Property(e => e.OnetsocCode)
                    .IsRequired()
                    .HasColumnName("onetsoc_code")
                    .HasColumnType("char(10)");

                entity.Property(e => e.RecommendSuppress)
                    .HasColumnName("recommend_suppress")
                    .HasColumnType("char(1)");

                entity.Property(e => e.ScaleId)
                    .IsRequired()
                    .HasColumnName("scale_id")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.StandardError)
                    .HasColumnName("standard_error")
                    .HasColumnType("decimal");

                entity.Property(e => e.UpperCiBound)
                    .HasColumnName("upper_ci_bound")
                    .HasColumnType("decimal");

                entity.HasOne(d => d.OnetsocCodeNavigation)
                    .WithMany(p => p.OnetWorkActivities)
                    .HasPrincipalKey(p => p.OnetsocCode)
                    .HasForeignKey(d => d.OnetsocCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_onet_work_activities_onet_occupation_data");

                entity.HasOne(d => d.Scale)
                    .WithMany(p => p.OnetWorkActivities)
                    .HasForeignKey(d => d.ScaleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK__onet_work__scale__639A6E01");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasIndex(e => e.MigrationId)
                    .HasName("idx_person_MigrationId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptPolicy).HasColumnType("datetime");

                entity.Property(e => e.AllowSms)
                    .HasColumnName("AllowSMS")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedById).HasDefaultValueSql("1");

                entity.Property(e => e.DirectPhone).HasColumnType("varchar(50)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(50)");

                entity.Property(e => e.FullName).HasColumnType("varchar(50)");

                entity.Property(e => e.Handle).HasColumnType("varchar(50)");

                entity.Property(e => e.IntroCapOverride).HasDefaultValueSql("0");

                entity.Property(e => e.IntroCapOverrideAt).HasColumnType("datetime");

                entity.Property(e => e.IntrosActive).HasDefaultValueSql("0");

                entity.Property(e => e.IntrosActiveAt).HasColumnType("datetime");

                entity.Property(e => e.LastActivityAt).HasColumnType("datetime");

                entity.Property(e => e.Lastname).HasColumnType("varchar(50)");

                entity.Property(e => e.MigrationId).HasColumnType("varchar(50)");

                entity.Property(e => e.Mobile).HasColumnType("varchar(50)");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ModifiedById).HasDefaultValueSql("1");

                entity.Property(e => e.OptOut).HasDefaultValueSql("0");

                entity.Property(e => e.Password).HasColumnType("varchar(50)");

                entity.Property(e => e.ProfileDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.ProfilePicture).HasColumnType("varchar(255)");

                entity.Property(e => e.Title).HasColumnType("varchar(50)");

                entity.Property(e => e.VerifiedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_Person_Asset");
            });

            modelBuilder.Entity<PersonCommMethodPref>(entity =>
            {
                entity.HasOne(d => d.Method)
                    .WithMany(p => p.PersonCommMethodPref)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_PersonCommMethodPref_CommMethod");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonCommMethodPref)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_PersonCommMethodPref_Person");
            });

            modelBuilder.Entity<PersonDashboard>(entity =>
            {
                entity.HasOne(d => d.Dashboard)
                    .WithMany(p => p.PersonDashboard)
                    .HasForeignKey(d => d.DashboardId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PersonDashboard_Dashboard");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonDashboard)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PersonDashboard_Person");
            });

            modelBuilder.Entity<PersonTag>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonTag)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PersonTag_Person_ID");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.PersonTag)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PersonTag_Tag_ID");
            });

            modelBuilder.Entity<PersonViaMethod>(entity =>
            {
                entity.HasOne(d => d.MethodIsdNavigation)
                    .WithMany(p => p.PersonViaMethod)
                    .HasForeignKey(d => d.MethodIsd)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PersonViaMethod_ChatMessageViaMethod");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonViaMethod)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PersonViaMethod_Person");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("IDX_RoleAccount_AccountId");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("IDX_Post_CategoryId");

                entity.Property(e => e.AllowApply).HasDefaultValueSql("0");

                entity.Property(e => e.AllowComments).HasDefaultValueSql("0");

                entity.Property(e => e.AllowContact).HasDefaultValueSql("0");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("date")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.HideDte).HasColumnType("datetime");

                entity.Property(e => e.LongDesc).HasColumnType("varchar(max)");

                entity.Property(e => e.ModifiedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.OverrideImportedText).HasDefaultValueSql("0");

                entity.Property(e => e.OverrideImportedTitle).HasDefaultValueSql("0");

                entity.Property(e => e.PostRank).HasDefaultValueSql("1");

                entity.Property(e => e.ReleaseDte)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ShortDesc).HasColumnType("varchar(1000)");

                entity.Property(e => e.ShowLinks).HasDefaultValueSql("0");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Post_fk0");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK_Post_AccountAlbum");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Post_fk3");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.PostCreatedBy)
                    .HasForeignKey(d => d.CreatedById)
                    .HasConstraintName("Post_fk7");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Post_fk4");

                entity.HasOne(d => d.Logo)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.LogoId)
                    .HasConstraintName("FK_Post_AccountLogo");

                entity.HasOne(d => d.Map)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.MapId)
                    .HasConstraintName("FK_Post_PostMap1");

                entity.HasOne(d => d.ModifiedBy)
                    .WithMany(p => p.PostModifiedBy)
                    .HasForeignKey(d => d.ModifiedById)
                    .HasConstraintName("Post_fk8");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.PostOwner)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Post_fk1");

                entity.HasOne(d => d.Thumbnail)
                    .WithMany(p => p.PostThumbnail)
                    .HasForeignKey(d => d.ThumbnailId)
                    .HasConstraintName("FK_Post_ImageLibrary");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Post_fk2");

                entity.HasOne(d => d.VideoCoverPhoto)
                    .WithMany(p => p.PostVideoCoverPhoto)
                    .HasForeignKey(d => d.VideoCoverPhotoId)
                    .HasConstraintName("FK_Post_ImageLibrary_VideoCoverPhoto");

                entity.HasOne(d => d.Video)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.VideoId)
                    .HasConstraintName("FK_Post_AccountVideo");
            });

            modelBuilder.Entity<PostAttr>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.AttrId })
                    .HasName("PK_PostAttr_1");

                entity.Property(e => e.AttrRank).HasDefaultValueSql("1");

                entity.Property(e => e.Featured).HasDefaultValueSql("0");

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.PostAttr)
                    .HasForeignKey(d => d.AttrId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PostAttr_fk1");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostAttr)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PostAttr_fk0");
            });

            modelBuilder.Entity<PostCategory>(entity =>
            {
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PostIndustry>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.IndustryId })
                    .HasName("PK_PostIndustry_1");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.PostIndustry)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PostIndustry_fk1");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostIndustry)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PostIndustry_fk0");
            });

            modelBuilder.Entity<PostKeyword>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.KeywordId })
                    .HasName("PK_PostKeyword");

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.PostKeyword)
                    .HasForeignKey(d => d.KeywordId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostKeyword_Keyword");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostKeyword)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostKeyword_Post");
            });

            modelBuilder.Entity<PostKeywordExclude>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.KeywordId })
                    .HasName("PK_PostKeywordExclude");

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.PostKeywordExclude)
                    .HasForeignKey(d => d.KeywordId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostKeywordExclude_Keyword");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostKeywordExclude)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostKeywordExclude_Post");
            });

            modelBuilder.Entity<PostListing>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.ListingId })
                    .HasName("PK_PostPostReq");

                entity.HasIndex(e => e.ListingId)
                    .HasName("IDX_PostPostReq_ReqId");

                entity.HasIndex(e => e.PostId)
                    .HasName("IDX_PostPostReq_PostId");

                entity.Property(e => e.MarriedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Unmarry).HasDefaultValueSql("0");

                entity.HasOne(d => d.Listing)
                    .WithMany(p => p.PostListing)
                    .HasForeignKey(d => d.ListingId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ListingOnet_PostListing");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostListing)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostListing_Post");
            });

            modelBuilder.Entity<PostMap>(entity =>
            {
                entity.Property(e => e.HideMap).HasDefaultValueSql("0");

                entity.Property(e => e.Imported).HasDefaultValueSql("0");

                entity.Property(e => e.MapDesc).HasColumnType("varchar(500)");

                entity.Property(e => e.MapName).HasColumnType("varchar(50)");

                entity.Property(e => e.MapRank).HasDefaultValueSql("1");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.PostMap)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostMap_Account");
            });

            modelBuilder.Entity<PostMapFeature>(entity =>
            {
                entity.Property(e => e.FeatureDesc).HasColumnType("varchar(1000)");

                entity.Property(e => e.FeatureName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.GeoJson).HasColumnType("varchar(2000)");

                entity.HasOne(d => d.FeatureType)
                    .WithMany(p => p.PostMapFeature)
                    .HasForeignKey(d => d.FeatureTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostMapFeature_PostMapFeatureType");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.PostMapFeature)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_PostMapFeature_ImageLibrary");

                entity.HasOne(d => d.Map)
                    .WithMany(p => p.PostMapFeature)
                    .HasForeignKey(d => d.MapId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostMapFeature_PostMap");
            });

            modelBuilder.Entity<PostMapFeatureType>(entity =>
            {
                entity.Property(e => e.FeatureTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PostMapGeoRegion>(entity =>
            {
                entity.HasKey(e => new { e.RegionId, e.FeatureId })
                    .HasName("PK_PostMapGeoRegion_1");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.PostMapGeoRegion)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostMapGeoRegion_PostMapFeature1");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.PostMapGeoRegion)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PostMapGeoRegion_fk1");
            });

            modelBuilder.Entity<PostMapGeoState>(entity =>
            {
                entity.HasKey(e => new { e.StateId, e.FeatureId })
                    .HasName("PK_PostMapGeoState_1");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.PostMapGeoState)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostMapGeoState_PostMapFeature1");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.PostMapGeoState)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PostMapGeoState_fk1");
            });

            modelBuilder.Entity<PostMapPoint>(entity =>
            {
                entity.Property(e => e.Addr1).HasColumnType("varchar(100)");

                entity.Property(e => e.Addr2).HasColumnType("varchar(100)");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.PostMapPoint)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostMapPoint_PostMapFeature1");

                entity.HasOne(d => d.Zip)
                    .WithMany(p => p.PostMapPoint)
                    .HasForeignKey(d => d.ZipId)
                    .HasConstraintName("FK_PostMapPoint_GeoZip");
            });

            modelBuilder.Entity<PostOnet>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.OnetId })
                    .HasName("PK_PostOnet_1");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Onet)
                    .WithMany(p => p.PostOnet)
                    .HasForeignKey(d => d.OnetId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PostOnet_fk1");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostOnet)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PostOnet_fk0");
            });

            modelBuilder.Entity<PostRelated>(entity =>
            {
                entity.HasKey(e => new { e.ParentId, e.ChildId })
                    .HasName("PK_PostRelated_1");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.PostRelatedChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PostRelated_fk1");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.PostRelatedParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PostRelated_fk0");
            });

            modelBuilder.Entity<PostReq>(entity =>
            {
                entity.HasIndex(e => e.AccountId)
                    .HasName("IX_PostReq_AccountId");

                entity.HasIndex(e => e.City)
                    .HasName("Idx_PostReq_City");

                entity.HasIndex(e => e.Country)
                    .HasName("Idx_PostReq_Country");

                entity.HasIndex(e => e.CreatedAt)
                    .HasName("Idx_PostReq_CreatedAt");

                entity.HasIndex(e => e.IndexedAt)
                    .HasName("Idx_PostReq_IndexedAt");

                entity.HasIndex(e => e.Lat)
                    .HasName("IX_PostReq_Lat");

                entity.HasIndex(e => e.Long)
                    .HasName("IX_PostReq_Long");

                entity.HasIndex(e => e.ReqNo)
                    .HasName("Idx_PostReq_ReqNo");

                entity.HasIndex(e => e.State)
                    .HasName("Idx_PostReq_State");

                entity.HasIndex(e => e.TitleId)
                    .HasName("IDX_PostReq_TitleId");

                entity.HasIndex(e => e.Zip)
                    .HasName("Idx_PostReq_Zip");

                entity.HasIndex(e => e.ZipId)
                    .HasName("Idx_PostReq_ZipId");

                entity.HasIndex(e => new { e.ReqNo, e.SourceId })
                    .HasName("UX_PostReq_ReqNo_SourceId")
                    .IsUnique();

                entity.Property(e => e.Addr1).HasColumnType("varchar(500)");

                entity.Property(e => e.Addr2).HasColumnType("varchar(500)");

                entity.Property(e => e.AltTitleMappedAt).HasColumnType("datetime");

                entity.Property(e => e.AttrMappedAt).HasColumnType("datetime");

                entity.Property(e => e.City).HasColumnType("varchar(50)");

                entity.Property(e => e.Country).HasColumnType("varchar(50)");

                entity.Property(e => e.ExperienceText).HasColumnType("varchar(250)");

                entity.Property(e => e.FactorsMappedAt).HasColumnType("datetime");

                entity.Property(e => e.IndexedAt).HasColumnType("datetime");

                entity.Property(e => e.JobTypeText).HasColumnType("varchar(250)");

                entity.Property(e => e.LongDesc).HasColumnType("varchar(max)");

                entity.Property(e => e.MappedFilters).HasColumnType("varchar(max)");

                entity.Property(e => e.OnetMappedAt).HasColumnType("datetime");

                entity.Property(e => e.ReqApply).HasMaxLength(500);

                entity.Property(e => e.ReqLink).HasMaxLength(500);

                entity.Property(e => e.ReqNo)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.SalaryText).HasColumnType("varchar(250)");

                entity.Property(e => e.SourceId).IsRequired();

                entity.Property(e => e.State).HasColumnType("varchar(50)");

                entity.Property(e => e.Title).HasColumnType("varchar(250)");

                entity.Property(e => e.Zip).HasColumnType("varchar(50)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.PostReq)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostReq_Account");
            });

            modelBuilder.Entity<PostReqDssTracking>(entity =>
            {
                entity.ToTable("PostReq_dss_tracking", "DataSync");

                entity.HasIndex(e => new { e.LocalUpdatePeerTimestamp, e.Id })
                    .HasName("local_update_peer_timestamp_index");

                entity.HasIndex(e => new { e.LastChangeDatetime, e.SyncRowIsTombstone, e.LocalUpdatePeerTimestamp })
                    .HasName("tombstone_index");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreateScopeLocalId).HasColumnName("create_scope_local_id");

                entity.Property(e => e.LastChangeDatetime)
                    .HasColumnName("last_change_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocalCreatePeerKey).HasColumnName("local_create_peer_key");

                entity.Property(e => e.LocalCreatePeerTimestamp).HasColumnName("local_create_peer_timestamp");

                entity.Property(e => e.LocalUpdatePeerKey).HasColumnName("local_update_peer_key");

                entity.Property(e => e.LocalUpdatePeerTimestamp)
                    .IsRequired()
                    .HasColumnName("local_update_peer_timestamp")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ScopeCreatePeerKey).HasColumnName("scope_create_peer_key");

                entity.Property(e => e.ScopeCreatePeerTimestamp).HasColumnName("scope_create_peer_timestamp");

                entity.Property(e => e.ScopeUpdatePeerKey).HasColumnName("scope_update_peer_key");

                entity.Property(e => e.ScopeUpdatePeerTimestamp).HasColumnName("scope_update_peer_timestamp");

                entity.Property(e => e.SyncRowIsTombstone).HasColumnName("sync_row_is_tombstone");

                entity.Property(e => e.UpdateScopeLocalId).HasColumnName("update_scope_local_id");
            });

            modelBuilder.Entity<PostType>(entity =>
            {
                entity.Property(e => e.PostTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasIndex(e => new { e.LastPercComplete, e.LastPercCompleteAt, e.MilitaryBranchId, e.MilitaryRankId, e.MilitarySpecialtyId, e.MilitaryStatusId, e.OutputFormatId, e.ProfileTypeId, e.WillRelocate, e.GotAjob, e.PersonId })
                    .HasName("nci_wi_Profile_BCADC537BA2DAD4EBB7C999DD0B8D55E");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ForeignLanguage).HasDefaultValueSql("0");

                entity.Property(e => e.GotAjob)
                    .HasColumnName("GotAJob")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.HideKnowledge).HasDefaultValueSql("0");

                entity.Property(e => e.HideSkills).HasDefaultValueSql("0");

                entity.Property(e => e.LastGotAjob)
                    .HasColumnName("LastGotAJob")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastPercComplete).HasDefaultValueSql("0");

                entity.Property(e => e.LastPercCompleteAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.MilitaryBranchId).HasColumnName("MilitaryBranchID");

                entity.Property(e => e.MilitaryExitDate).HasColumnType("datetime");

                entity.Property(e => e.MilitaryRankId).HasColumnName("MilitaryRankID");

                entity.Property(e => e.MilitarySpecialtyId).HasColumnName("MilitarySpecialtyID");

                entity.Property(e => e.MilitaryStatusId).HasColumnName("MilitaryStatusID");

                entity.Property(e => e.OutputFormatId).HasDefaultValueSql("1");

                entity.Property(e => e.PreferOnline).HasDefaultValueSql("0");

                entity.Property(e => e.ProfileName).HasColumnType("varchar(150)");

                entity.Property(e => e.ProfileSummary).HasColumnType("varchar(max)");

                entity.Property(e => e.ProfileTypeId).HasColumnName("ProfileTypeID");

                entity.Property(e => e.TransitionCounselorId).HasColumnName("TransitionCounselorID");

                entity.Property(e => e.UploadedResume).HasDefaultValueSql("0");

                entity.Property(e => e.UploadedResumePath).HasColumnType("varchar(255)");

                entity.Property(e => e.WillRelocate).HasDefaultValueSql("0");

                entity.HasOne(d => d.MilitaryBranch)
                    .WithMany(p => p.ProfileMilitaryBranch)
                    .HasForeignKey(d => d.MilitaryBranchId)
                    .HasConstraintName("FK_Profile_Attr1");

                entity.HasOne(d => d.MilitaryRank)
                    .WithMany(p => p.ProfileMilitaryRank)
                    .HasForeignKey(d => d.MilitaryRankId)
                    .HasConstraintName("FK_Profile_Attr4");

                entity.HasOne(d => d.MilitarySpecialty)
                    .WithMany(p => p.ProfileMilitarySpecialty)
                    .HasForeignKey(d => d.MilitarySpecialtyId)
                    .HasConstraintName("FK_Profile_Attr3");

                entity.HasOne(d => d.MilitaryStatus)
                    .WithMany(p => p.ProfileMilitaryStatus)
                    .HasForeignKey(d => d.MilitaryStatusId)
                    .HasConstraintName("FK_Profile_Attr2");

                entity.HasOne(d => d.OutputFormat)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.OutputFormatId)
                    .HasConstraintName("FK_Profile_ProfileOutputFormat");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Profile_Person_ID");

                entity.HasOne(d => d.ProfileIndustry)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.ProfileIndustryId)
                    .HasConstraintName("FK_Profile_Industry");

                entity.HasOne(d => d.ProfileType)
                    .WithMany(p => p.ProfileProfileType)
                    .HasForeignKey(d => d.ProfileTypeId)
                    .HasConstraintName("FK_Profile_Attr");

                entity.HasOne(d => d.TransitionStatus)
                    .WithMany(p => p.ProfileTransitionStatus)
                    .HasForeignKey(d => d.TransitionStatusId)
                    .HasConstraintName("FK_Profile_Attr5");
            });

            modelBuilder.Entity<ProfileAdditionalInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdditionalInfoRank).HasDefaultValueSql("0");

                entity.Property(e => e.HideAdditionalInfo).HasDefaultValueSql("0");

                entity.Property(e => e.InfoDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.InfoTitle)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileAdditionalInfo)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileAdditionalInfo_Profile_ID");
            });

            modelBuilder.Entity<ProfileCity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.HideCity).HasDefaultValueSql("0");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ProfileCity)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileCity)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileCity_Profile_ID");
            });

            modelBuilder.Entity<ProfileIndustry>(entity =>
            {
                entity.HasKey(e => new { e.ProfileId, e.IndustryId })
                    .HasName("PK_ProfileIndustry");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.ProfileIndustry)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileIndustry_Industry");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileIndustryNavigation)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileIndustry_Profile");
            });

            modelBuilder.Entity<ProfileLanguage>(entity =>
            {
                entity.HasKey(e => new { e.ProfileId, e.LanguageId })
                    .HasName("PK_ProfileLanguage");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.ProfileLanguage)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileLanguage_Attr");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileLanguage)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileLanguage_Profile");
            });

            modelBuilder.Entity<ProfileLink>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LinkPath).HasColumnType("varchar(255)");

                entity.Property(e => e.LinkToken).HasColumnType("varchar(255)");

                entity.Property(e => e.LinkedSite)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.ProfileLink)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK_ProfileLink_Person_ID");
            });

            modelBuilder.Entity<ProfileMilitaryHonor>(entity =>
            {
                entity.HasIndex(e => new { e.ProfileId, e.HonorId })
                    .HasName("nci_wi_ProfileMilitaryHonor_95D820FFC009C5B45BD39AB5E8DEFEDB");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HonorId).HasColumnName("HonorID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Honor)
                    .WithMany(p => p.ProfileMilitaryHonor)
                    .HasForeignKey(d => d.HonorId)
                    .HasConstraintName("FK_ProfileMilitaryHonor_Attr");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileMilitaryHonor)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileMilitaryHonor_Profile");
            });

            modelBuilder.Entity<ProfileOutputFormat>(entity =>
            {
                entity.Property(e => e.FormatDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.FormatHtml)
                    .HasColumnName("FormatHTML")
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.FormatName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FormatType)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<ProfilePercComplete>(entity =>
            {
                entity.Property(e => e.GotAjob)
                    .HasColumnName("GotAJob")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PercCompleteAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfilePercComplete)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfilePercComplete_Profile");
            });

            modelBuilder.Entity<ProfileReference>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DirectPhone).HasColumnType("varchar(50)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.FirstName).HasColumnType("varchar(50)");

                entity.Property(e => e.HideReference).HasDefaultValueSql("0");

                entity.Property(e => e.LastName).HasColumnType("varchar(50)");

                entity.Property(e => e.MobilePhone).HasColumnType("varchar(50)");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ReferenceNotes).HasColumnType("varchar(max)");

                entity.Property(e => e.ReferencePersonId).HasColumnName("ReferencePersonID");

                entity.Property(e => e.ReferenceRank).HasDefaultValueSql("0");

                entity.Property(e => e.ReferenceTypeId).HasColumnName("ReferenceTypeID");

                entity.Property(e => e.Title).HasColumnType("varchar(100)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ProfileReference)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_ProfileReference_Account");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileReference)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileReference_Profile_ID");

                entity.HasOne(d => d.ReferencePerson)
                    .WithMany(p => p.ProfileReference)
                    .HasForeignKey(d => d.ReferencePersonId)
                    .HasConstraintName("FK_ProfileReference_Person");

                entity.HasOne(d => d.ReferenceType)
                    .WithMany(p => p.ProfileReference)
                    .HasForeignKey(d => d.ReferenceTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileReference_ReferenceType");
            });

            modelBuilder.Entity<ProfileReferral>(entity =>
            {
                entity.Property(e => e.ReferredAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.ByAccount)
                    .WithMany(p => p.ProfileReferralByAccount)
                    .HasForeignKey(d => d.ByAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileReferral_Account");

                entity.HasOne(d => d.ByPerson)
                    .WithMany(p => p.ProfileReferralByPerson)
                    .HasForeignKey(d => d.ByPersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileReferral_Person");

                entity.HasOne(d => d.Review)
                    .WithMany(p => p.ProfileReferral)
                    .HasForeignKey(d => d.ReviewId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileReferral_Review");

                entity.HasOne(d => d.ToAccount)
                    .WithMany(p => p.ProfileReferralToAccount)
                    .HasForeignKey(d => d.ToAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileReferral_Account1");

                entity.HasOne(d => d.ToPerson)
                    .WithMany(p => p.ProfileReferralToPerson)
                    .HasForeignKey(d => d.ToPersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileReferral_Person1");
            });

            modelBuilder.Entity<ProfileSearch>(entity =>
            {
                entity.Property(e => e.Alert).HasDefaultValueSql("0");

                entity.Property(e => e.AlertActiveAt).HasColumnType("datetime");

                entity.Property(e => e.FJobTitleId).HasColumnName("F_JobTitleId");

                entity.Property(e => e.FLastActive)
                    .HasColumnName("F_LastActive")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FMyRecruits)
                    .HasColumnName("F_MyRecruits")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FPercentComplete).HasColumnName("F_PercentComplete");

                entity.Property(e => e.FWillRelocate)
                    .HasColumnName("F_WillRelocate")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FWishToWorkNearCityId).HasColumnName("F_WishToWorkNearCityID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.SearchNickname).HasColumnType("varchar(150)");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileSearch)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileSearch_Profile");
            });

            modelBuilder.Entity<ProfileSummary>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FillInBlanks).HasDefaultValueSql("0");

                entity.Property(e => e.ForExperience).HasDefaultValueSql("0");

                entity.Property(e => e.Summary).HasColumnType("varchar(500)");

                entity.Property(e => e.SummaryName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.SummaryRank).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<ProfileSummaryAttr>(entity =>
            {
                entity.Property(e => e.AttrId).HasColumnName("AttrID");

                entity.Property(e => e.ProfileSummaryId).HasColumnName("ProfileSummaryID");

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.ProfileSummaryAttr)
                    .HasForeignKey(d => d.AttrId)
                    .HasConstraintName("FK_ProfileSummaryAttr_Attr");

                entity.HasOne(d => d.ProfileSummary)
                    .WithMany(p => p.ProfileSummaryAttr)
                    .HasForeignKey(d => d.ProfileSummaryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProfileSummaryAttr_ProfileSummary");
            });

            modelBuilder.Entity<ProvisionMarkerDss>(entity =>
            {
                entity.HasKey(e => new { e.OwnerScopeLocalId, e.ObjectId })
                    .HasName("PK_DataSync.provision_marker_dss");

                entity.ToTable("provision_marker_dss", "DataSync");

                entity.Property(e => e.OwnerScopeLocalId).HasColumnName("owner_scope_local_id");

                entity.Property(e => e.ObjectId).HasColumnName("object_id");

                entity.Property(e => e.ProvisionDatetime)
                    .HasColumnName("provision_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProvisionLocalPeerKey).HasColumnName("provision_local_peer_key");

                entity.Property(e => e.ProvisionScopeLocalId).HasColumnName("provision_scope_local_id");

                entity.Property(e => e.ProvisionScopePeerKey).HasColumnName("provision_scope_peer_key");

                entity.Property(e => e.ProvisionScopePeerTimestamp).HasColumnName("provision_scope_peer_timestamp");

                entity.Property(e => e.ProvisionTimestamp).HasColumnName("provision_timestamp");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasColumnName("version")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<QueueType>(entity =>
            {
                entity.Property(e => e.QueueTypeName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.Property(e => e.RatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Rating1).HasColumnName("Rating");

                entity.Property(e => e.RatingDetails).HasColumnType("varchar(255)");

                entity.HasOne(d => d.RatedBy)
                    .WithMany(p => p.Rating)
                    .HasForeignKey(d => d.RatedById)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Rating_Person");
            });

            modelBuilder.Entity<RatingTaskResource>(entity =>
            {
                entity.HasOne(d => d.Rating)
                    .WithMany(p => p.RatingTaskResource)
                    .HasForeignKey(d => d.RatingId)
                    .HasConstraintName("FK_RatingTaskResource_Rating");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.RatingTaskResource)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_RatingTaskResource_TaskResource");
            });

            modelBuilder.Entity<ReasonLeft>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReasonLeft1)
                    .IsRequired()
                    .HasColumnName("ReasonLeft")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ReasonLeftNotes).HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<ReferenceType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReferenceType1)
                    .IsRequired()
                    .HasColumnName("ReferenceType")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.BudgetValue)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ResultDte).HasColumnType("datetime");

                entity.Property(e => e.ResultNotes).HasColumnType("varchar(1000)");

                entity.Property(e => e.ResultValue)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Dashboard)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.DashboardId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Result_Dashboard");

                entity.HasOne(d => d.Metric)
                    .WithMany(p => p.Result)
                    .HasForeignKey(d => d.MetricId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Result_Metric");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowAccess).HasDefaultValueSql("1");

                entity.Property(e => e.AllowSharing).HasDefaultValueSql("0");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ReviewComplete).HasColumnType("datetime");

                entity.Property(e => e.ReviewStarted)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ReviewType)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReviewerId).HasColumnName("ReviewerID");

                entity.HasOne(d => d.OutputFormat)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.OutputFormatId)
                    .HasConstraintName("FK_Review_ProfileOutputFormat");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Review_Profile");

                entity.HasOne(d => d.Reviewer)
                    .WithMany(p => p.Review)
                    .HasForeignKey(d => d.ReviewerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Review_Person1");
            });

            modelBuilder.Entity<ReviewSuggestion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptReject)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'Pending'");

                entity.Property(e => e.AcceptedRejectedAt).HasColumnType("datetime");

                entity.Property(e => e.CommentOnSuggestion).HasColumnType("varchar(max)");

                entity.Property(e => e.ReplacedText).HasColumnType("varchar(max)");

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.Suggestion)
                    .IsRequired()
                    .HasColumnType("varchar(max)");

                entity.Property(e => e.SuggestionAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.SuggestionOn).HasColumnType("varchar(50)");

                entity.Property(e => e.SuggestionWithdrawn).HasColumnType("datetime");

                entity.HasOne(d => d.Review)
                    .WithMany(p => p.ReviewSuggestion)
                    .HasForeignKey(d => d.ReviewId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReviewSuggestion_Review");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RoleType)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<RoleAccount>(entity =>
            {
                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleAccount_RoleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.RoleAccount)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RoleAccount_Account");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleAccount)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RoleAccount_Role");
            });

            modelBuilder.Entity<RoleAccountPerson>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountPersonId).HasColumnName("AccountPersonID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.AccountPerson)
                    .WithMany(p => p.RoleAccountPerson)
                    .HasForeignKey(d => d.AccountPersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RoleAccountPerson_AccountPerson");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleAccountPerson)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RoleAccountPerson_Role");
            });

            modelBuilder.Entity<RolePerson>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.RolePerson)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RolePerson_Person");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePerson)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RolePerson_Role");
            });

            modelBuilder.Entity<SchemaInfoDss>(entity =>
            {
                entity.HasKey(e => new { e.SchemaMajorVersion, e.SchemaMinorVersion })
                    .HasName("PK_DataSync.schema_info_dss");

                entity.ToTable("schema_info_dss", "DataSync");

                entity.Property(e => e.SchemaMajorVersion).HasColumnName("schema_major_version");

                entity.Property(e => e.SchemaMinorVersion).HasColumnName("schema_minor_version");

                entity.Property(e => e.SchemaExtendedInfo)
                    .IsRequired()
                    .HasColumnName("schema_extended_info")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ScopeConfigDss>(entity =>
            {
                entity.HasKey(e => e.ConfigId)
                    .HasName("PK_DataSync.scope_config_dss");

                entity.ToTable("scope_config_dss", "DataSync");

                entity.Property(e => e.ConfigId)
                    .HasColumnName("config_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigData)
                    .IsRequired()
                    .HasColumnName("config_data")
                    .HasColumnType("xml");

                entity.Property(e => e.ScopeStatus)
                    .HasColumnName("scope_status")
                    .HasColumnType("char(1)");
            });

            modelBuilder.Entity<ScopeInfoDss>(entity =>
            {
                entity.HasKey(e => e.SyncScopeName)
                    .HasName("PK_DataSync.scope_info_dss");

                entity.ToTable("scope_info_dss", "DataSync");

                entity.Property(e => e.SyncScopeName)
                    .HasColumnName("sync_scope_name")
                    .HasMaxLength(100);

                entity.Property(e => e.ScopeConfigId).HasColumnName("scope_config_id");

                entity.Property(e => e.ScopeId)
                    .HasColumnName("scope_id")
                    .HasDefaultValueSql("newid()");

                entity.Property(e => e.ScopeLocalId)
                    .HasColumnName("scope_local_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ScopeRestoreCount)
                    .HasColumnName("scope_restore_count")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ScopeSyncKnowledge).HasColumnName("scope_sync_knowledge");

                entity.Property(e => e.ScopeTimestamp)
                    .HasColumnName("scope_timestamp")
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ScopeTombstoneCleanupKnowledge).HasColumnName("scope_tombstone_cleanup_knowledge");

                entity.Property(e => e.ScopeUserComment).HasColumnName("scope_user_comment");
            });

            modelBuilder.Entity<SearchStatement>(entity =>
            {
                entity.Property(e => e.ExcludeStatement).HasColumnType("varchar(2000)");

                entity.Property(e => e.ReplaceStatement).HasColumnType("varchar(2000)");

                entity.Property(e => e.SearchStatement1)
                    .HasColumnName("SearchStatement")
                    .HasColumnType("varchar(2000)");

                entity.Property(e => e.SkipLongDesc).HasDefaultValueSql("0");

                entity.Property(e => e.StatementName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.SearchStatement)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SearchStatement_Account");
            });

            modelBuilder.Entity<SearchStatementAttr>(entity =>
            {
                entity.HasKey(e => new { e.SearchId, e.AttrId })
                    .HasName("PK_SearchStatementAttr");

                entity.HasOne(d => d.Search)
                    .WithMany(p => p.SearchStatementAttr)
                    .HasForeignKey(d => d.SearchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SearchStatementAttr_SearchStatement");
            });

            modelBuilder.Entity<SearchStatementCoreTitle>(entity =>
            {
                entity.HasKey(e => new { e.SearchId, e.TitleId })
                    .HasName("PK_SearchStatementCoreTitle");

                entity.HasOne(d => d.Search)
                    .WithMany(p => p.SearchStatementCoreTitle)
                    .HasForeignKey(d => d.SearchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SearchStatementCoreTitle_SearchStatement");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.SearchStatementCoreTitle)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SearchStatementCoreTitle_PayFactors");
            });

            modelBuilder.Entity<SearchStatementPost>(entity =>
            {
                entity.HasKey(e => new { e.SearchId, e.PostId })
                    .HasName("PK_SearchStatementPost");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.SearchStatementPost)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SearchStatementPost_Post");

                entity.HasOne(d => d.Search)
                    .WithMany(p => p.SearchStatementPost)
                    .HasForeignKey(d => d.SearchId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SearchStatementPost_SearchStatement");
            });

            modelBuilder.Entity<Share>(entity =>
            {
                entity.Property(e => e.SharedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ViewedAt).HasColumnType("datetime");

                entity.HasOne(d => d.SharedBy)
                    .WithMany(p => p.ShareSharedBy)
                    .HasForeignKey(d => d.SharedById)
                    .HasConstraintName("FK_Share_Person");

                entity.HasOne(d => d.SharedWith)
                    .WithMany(p => p.ShareSharedWith)
                    .HasForeignKey(d => d.SharedWithId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Share_Person1");
            });

            modelBuilder.Entity<ShareTaskResource>(entity =>
            {
                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ShareTaskResource)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_ShareTaskResource_TaskResource");

                entity.HasOne(d => d.Share)
                    .WithMany(p => p.ShareTaskResource)
                    .HasForeignKey(d => d.ShareId)
                    .HasConstraintName("FK_ShareTaskResource_Share");
            });

            modelBuilder.Entity<Story>(entity =>
            {
                entity.Property(e => e.Feature).HasDefaultValueSql("0");

                entity.Property(e => e.Release).HasDefaultValueSql("0");

                entity.Property(e => e.StorySummary).HasColumnType("varchar(500)");

                entity.Property(e => e.StoryText).HasColumnType("varchar(max)");

                entity.Property(e => e.StoryTitle).HasColumnType("varchar(100)");

                entity.Property(e => e.StoryVideoUrl)
                    .HasColumnName("StoryVideoURL")
                    .HasColumnType("varchar(500)");

                entity.HasOne(d => d.OwnerAccount)
                    .WithMany(p => p.Story)
                    .HasForeignKey(d => d.OwnerAccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Story_Account");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Story)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Story_Person");
            });

            modelBuilder.Entity<StoryImages>(entity =>
            {
                entity.Property(e => e.ImageCaption).HasColumnType("varchar(500)");

                entity.Property(e => e.ImageRank).HasDefaultValueSql("1");

                entity.Property(e => e.ImageSrc)
                    .IsRequired()
                    .HasColumnName("ImageSRC")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ImageTitle).HasColumnType("varchar(100)");

                entity.HasOne(d => d.Story)
                    .WithMany(p => p.StoryImages)
                    .HasForeignKey(d => d.StoryId)
                    .HasConstraintName("FK_StoryImages_Story");
            });

            modelBuilder.Entity<StoryTaskResource>(entity =>
            {
                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.StoryTaskResource)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_StoryTaskResource_TaskResource");

                entity.HasOne(d => d.Story)
                    .WithMany(p => p.StoryTaskResource)
                    .HasForeignKey(d => d.StoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StoryTaskResource_Story");
            });

            modelBuilder.Entity<StoryTimeline>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.TimelineDescription)
                    .IsRequired()
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.TimelineImage).HasColumnType("varchar(255)");

                entity.Property(e => e.TimelineTitle)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TimlineRank).HasDefaultValueSql("1");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.StoryTimeline)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_StoryTimeline_Account");

                entity.HasOne(d => d.Story)
                    .WithMany(p => p.StoryTimeline)
                    .HasForeignKey(d => d.StoryId)
                    .HasConstraintName("FK_StoryTimeline_Story");
            });

            modelBuilder.Entity<SuggestionAdditionalInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdditionalInfoId).HasColumnName("AdditionalInfoID");

                entity.Property(e => e.SuggestionId).HasColumnName("SuggestionID");

                entity.HasOne(d => d.AdditionalInfo)
                    .WithMany(p => p.SuggestionAdditionalInfo)
                    .HasForeignKey(d => d.AdditionalInfoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SuggestionAdditionalInfo_ProfileAdditionalInfo_ID");

                entity.HasOne(d => d.Suggestion)
                    .WithMany(p => p.SuggestionAdditionalInfo)
                    .HasForeignKey(d => d.SuggestionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SuggestionAdditionalInfo_ReviewSuggestion_ID");
            });

            modelBuilder.Entity<SuggestionExperienceDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.SuggestionId).HasColumnName("SuggestionID");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.SuggestionExperienceDetail)
                    .HasForeignKey(d => d.DetailId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SuggestionExperienceDetail_ExperienceDetail_ID");

                entity.HasOne(d => d.Suggestion)
                    .WithMany(p => p.SuggestionExperienceDetail)
                    .HasForeignKey(d => d.SuggestionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SuggestionExperienceDetail_ReviewSuggestion_ID");
            });

            modelBuilder.Entity<SuggestionReference>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.SuggestionId).HasColumnName("SuggestionID");

                entity.HasOne(d => d.Suggestion)
                    .WithMany(p => p.SuggestionReference)
                    .HasForeignKey(d => d.SuggestionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SuggestionReference_ReviewSuggestion_ID");
            });

            modelBuilder.Entity<Sysdiagrams>(entity =>
            {
                entity.HasKey(e => e.DiagramId)
                    .HasName("PK__sysdiagr__C2B05B618A07320C");

                entity.ToTable("sysdiagrams");

                entity.HasIndex(e => new { e.PrincipalId, e.Name })
                    .HasName("UK_principal_name")
                    .IsUnique();

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("sysname");

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<SystemJobLog>(entity =>
            {
                entity.Property(e => e.ErrDesc).HasColumnType("varchar(4000)");

                entity.Property(e => e.ErrMsg).HasColumnType("varchar(4000)");

                entity.Property(e => e.ErrProc).HasColumnType("varchar(200)");

                entity.Property(e => e.JobComplete).HasColumnType("datetime");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.JobResult).HasColumnType("varchar(max)");

                entity.Property(e => e.JobStart)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tag1)
                    .IsRequired()
                    .HasColumnName("Tag")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TagType)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("'Account'");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.CommonlySearched).HasDefaultValueSql("0");

                entity.Property(e => e.TaskDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.TaskFeatured).HasDefaultValueSql("0");

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TaskQuestion).HasColumnType("varchar(500)");

                entity.Property(e => e.TaskRank).HasDefaultValueSql("1");

                entity.Property(e => e.TaskShortDescription).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_Task_Asset");

                entity.HasOne(d => d.TaskPhase)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.TaskPhaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Task_TaskPhase");
            });

            modelBuilder.Entity<TaskAttr>(entity =>
            {
                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.TaskAttr)
                    .HasForeignKey(d => d.AttrId)
                    .HasConstraintName("FK_TaskAttr_Attr");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskAttr)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskAttr_Task");
            });

            modelBuilder.Entity<TaskComplete>(entity =>
            {
                entity.Property(e => e.RecordedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TaskComplete)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskComplete_Person");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskComplete)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskComplete_Task");
            });

            modelBuilder.Entity<TaskHide>(entity =>
            {
                entity.Property(e => e.RecordedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TaskHide)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskHide_Person");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskHide)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskHide_Task");
            });

            modelBuilder.Entity<TaskPhase>(entity =>
            {
                entity.Property(e => e.PhaseDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.PhaseName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PhaseRank).HasDefaultValueSql("1");

                entity.Property(e => e.PhaseShortDescription).HasColumnType("varchar(max)");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.TaskPhase)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_TaskPhase_Asset");
            });

            modelBuilder.Entity<TaskPhaseAttr>(entity =>
            {
                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.TaskPhaseAttr)
                    .HasForeignKey(d => d.AttrId)
                    .HasConstraintName("FK_TaskPhaseAttr_Attr");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.TaskPhaseAttr)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskPhaseAttr_TaskPhase");
            });

            modelBuilder.Entity<TaskPhaseHint>(entity =>
            {
                entity.Property(e => e.HintRank).HasDefaultValueSql("1");

                entity.Property(e => e.HintText)
                    .IsRequired()
                    .HasColumnType("varchar(500)");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.TaskPhaseHint)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskPhaseHint_TaskPhase");
            });

            modelBuilder.Entity<TaskResource>(entity =>
            {
                entity.Property(e => e.Article).HasDefaultValueSql("0");

                entity.Property(e => e.HideFromGlossary).HasDefaultValueSql("0");

                entity.Property(e => e.Hohresource)
                    .HasColumnName("HOHResource")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ResourceDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.ResourceHide).HasDefaultValueSql("0");

                entity.Property(e => e.ResourceIcon).HasColumnType("varchar(255)");

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.ResourceRank).HasDefaultValueSql("1");

                entity.Property(e => e.ResourceShortDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.ResourceUrl)
                    .HasColumnName("ResourceURL")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ResourceVideo).HasColumnType("varchar(255)");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.TaskResource)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_TaskResource_Asset");

                entity.HasOne(d => d.ResourceAccount)
                    .WithMany(p => p.TaskResource)
                    .HasForeignKey(d => d.ResourceAccountId)
                    .HasConstraintName("FK_TaskResource_Account");
            });

            modelBuilder.Entity<TaskResourceAttr>(entity =>
            {
                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.TaskResourceAttr)
                    .HasForeignKey(d => d.AttrId)
                    .HasConstraintName("FK_TaskResourceAttr_Attr");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.TaskResourceAttr)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_TaskResourceAttr_TaskResource");
            });

            modelBuilder.Entity<TaskResourceFeatured>(entity =>
            {
                entity.Property(e => e.PremiumSpot).HasDefaultValueSql("0");

                entity.HasOne(d => d.FeaturedOn)
                    .WithMany(p => p.TaskResourceFeatured)
                    .HasForeignKey(d => d.FeaturedOnId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskResourceFeatured_TaskResourceFeaturedOn");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.TaskResourceFeatured)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_TaskResourceFeatured_TaskResource");
            });

            modelBuilder.Entity<TaskResourceFeaturedOn>(entity =>
            {
                entity.Property(e => e.FeaturedOnName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TaskResourceHide>(entity =>
            {
                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Hide).HasDefaultValueSql("0");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TaskResourceHide)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskResourceHide_Person");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.TaskResourceHide)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskResourceHide_TaskResource");
            });

            modelBuilder.Entity<TaskResourceImage>(entity =>
            {
                entity.Property(e => e.ImageRank).HasDefaultValueSql("1");

                entity.Property(e => e.ImageSrc)
                    .IsRequired()
                    .HasColumnName("ImageSRC")
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.TaskResourceImage)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_TaskResourceImage_TaskResource");
            });

            modelBuilder.Entity<TaskResourceLink>(entity =>
            {
                entity.Property(e => e.LinkText)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.LinkUrl)
                    .IsRequired()
                    .HasColumnName("LinkURL")
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.TaskResourceLink)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskResourceLink_TaskResource");
            });

            modelBuilder.Entity<TaskResourceRollup>(entity =>
            {
                entity.HasOne(d => d.Child)
                    .WithMany(p => p.TaskResourceRollupChild)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskResourceRollup_TaskResource1");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.TaskResourceRollupParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TaskResourceRollup_TaskResource");
            });

            modelBuilder.Entity<TaskSubtask>(entity =>
            {
                entity.Property(e => e.SubtaskName)
                    .IsRequired()
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.SubtaskRank).HasDefaultValueSql("1");
            });

            modelBuilder.Entity<TaskTaskResource>(entity =>
            {
                entity.Property(e => e.ResourceRank).HasDefaultValueSql("1");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.TaskTaskResource)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TaskTaskResource_TaskResource");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.TaskTaskResource)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TaskTaskResource_Task");
            });

            modelBuilder.Entity<Theme>(entity =>
            {
                entity.Property(e => e.HomePageUrl)
                    .IsRequired()
                    .HasColumnName("HomePageURL")
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.ThemeColor)
                    .IsRequired()
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.ThemeName)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.HasOne(d => d.Favicon)
                    .WithMany(p => p.ThemeFavicon)
                    .HasForeignKey(d => d.FaviconId)
                    .HasConstraintName("FK_Theme_ImageLibrary1");

                entity.HasOne(d => d.ThemeLogo)
                    .WithMany(p => p.ThemeThemeLogo)
                    .HasForeignKey(d => d.ThemeLogoId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Theme_ImageLibrary");
            });

            modelBuilder.Entity<ThemeAccount>(entity =>
            {
                entity.HasKey(e => new { e.ThemeId, e.AccountId })
                    .HasName("PK_ThemeAccount");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ThemeAccount)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeAccount_Account");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.ThemeAccount)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeAccount_Theme");
            });

            modelBuilder.Entity<ThemeIndustry>(entity =>
            {
                entity.HasKey(e => new { e.ThemeId, e.IndustryId })
                    .HasName("PK_ThemeIndustry");

                entity.HasOne(d => d.Industry)
                    .WithMany(p => p.ThemeIndustry)
                    .HasForeignKey(d => d.IndustryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeIndustry_Industry");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.ThemeIndustry)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeIndustry_Theme");
            });

            modelBuilder.Entity<ThemeLink>(entity =>
            {
                entity.Property(e => e.LinkName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.ThemeLink)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeLink_ThemePage");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.ThemeLink)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeLink_Theme");
            });

            modelBuilder.Entity<ThemeLinkParameter>(entity =>
            {
                entity.Property(e => e.ParameterUsage).HasColumnType("varchar(50)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ThemeLinkParameter)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_ThemeLinkParameter_Account");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ThemeLinkParameter)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ThemeLinkParameter_PostCategory");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ThemeLinkParameter)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_ThemeLinkParameter_GeoCity");

                entity.HasOne(d => d.CoreTitle)
                    .WithMany(p => p.ThemeLinkParameter)
                    .HasForeignKey(d => d.CoreTitleId)
                    .HasConstraintName("FK_ThemeLinkParameter_CoreTitle");

                entity.HasOne(d => d.Link)
                    .WithMany(p => p.ThemeLinkParameter)
                    .HasForeignKey(d => d.LinkId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeLinkParameter_ThemeLink");

                entity.HasOne(d => d.Parameter)
                    .WithMany(p => p.ThemeLinkParameter)
                    .HasForeignKey(d => d.ParameterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeLinkParameter_ThemeParameter");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.ThemeLinkParameter)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_ThemeLinkParameter_Post");
            });

            modelBuilder.Entity<ThemeMenu>(entity =>
            {
                entity.Property(e => e.MenuRank).HasDefaultValueSql("1");

                entity.Property(e => e.MenuText)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MenuUrl)
                    .HasColumnName("MenuURL")
                    .HasColumnType("varchar(255)");

                entity.HasOne(d => d.Theme)
                    .WithMany(p => p.ThemeMenu)
                    .HasForeignKey(d => d.ThemeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeMenu_Theme");
            });

            modelBuilder.Entity<ThemePage>(entity =>
            {
                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PagePath)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<ThemeParameter>(entity =>
            {
                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ParameterSyntax).HasColumnType("varchar(500)");

                entity.HasOne(d => d.ParameterType)
                    .WithMany(p => p.ThemeParameter)
                    .HasForeignKey(d => d.ParameterTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeParameter_ThemeParameterType");
            });

            modelBuilder.Entity<ThemeParameterAttr>(entity =>
            {
                entity.HasKey(e => new { e.ParameterId, e.AttrId })
                    .HasName("PK_ThemeParameterAttr");

                entity.Property(e => e.AttrRank).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.ThemeParameterAttr)
                    .HasForeignKey(d => d.AttrId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeParameterAttr_Attr");

                entity.HasOne(d => d.Parameter)
                    .WithMany(p => p.ThemeParameterAttr)
                    .HasForeignKey(d => d.ParameterId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ThemeParameterAttr_ThemeParameter");
            });

            modelBuilder.Entity<ThemeParameterType>(entity =>
            {
                entity.Property(e => e.ParameterType).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TimeMonth>(entity =>
            {
                entity.Property(e => e.MonthText)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TimeYear>(entity =>
            {
                entity.Property(e => e.YearText)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Tip>(entity =>
            {
                entity.Property(e => e.TipContext)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TipName)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.TipRank).HasDefaultValueSql("0");

                entity.Property(e => e.TipText)
                    .IsRequired()
                    .HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<TipAttr>(entity =>
            {
                entity.HasOne(d => d.Attr)
                    .WithMany(p => p.TipAttr)
                    .HasForeignKey(d => d.AttrId)
                    .HasConstraintName("FK_TipAttr_Attr");

                entity.HasOne(d => d.Tip)
                    .WithMany(p => p.TipAttr)
                    .HasForeignKey(d => d.TipId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TipAttr_Tip");
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.Track)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_Track_Asset");
            });

            modelBuilder.Entity<TrackAccount>(entity =>
            {
                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.TrackId).HasColumnName("Track_Id");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.TrackAccount)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TrackAccount_Account");

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.TrackAccount)
                    .HasForeignKey(d => d.TrackId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TrackAccount_Track");
            });

            modelBuilder.Entity<TrackContentType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TrackPage>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.NavigationMenuLevel).HasDefaultValueSql("1");

                entity.Property(e => e.PageRank).HasDefaultValueSql("1");

                entity.Property(e => e.PageTypeId).HasColumnName("PageType_Id");

                entity.Property(e => e.TrackId).HasColumnName("Track_Id");

                entity.HasOne(d => d.PageType)
                    .WithMany(p => p.TrackPage)
                    .HasForeignKey(d => d.PageTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TrackPage_TrackPageType");

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.TrackPage)
                    .HasForeignKey(d => d.TrackId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TrackPage_Track");
            });

            modelBuilder.Entity<TrackPageContent>(entity =>
            {
                entity.Property(e => e.AssetIdOld).HasColumnName("AssetId_Old");

                entity.Property(e => e.ContentDescription).HasColumnType("varchar(max)");

                entity.Property(e => e.ContentRank).HasDefaultValueSql("0");

                entity.Property(e => e.ContentTitle).HasColumnType("varchar(150)");

                entity.Property(e => e.ContentTypeId).HasColumnName("ContentType_Id");

                entity.Property(e => e.TrackPageId).HasColumnName("TrackPage_Id");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.TrackPageContent)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_TrackPageContent_Asset");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.TrackPageContent)
                    .HasForeignKey(d => d.ContentTypeId)
                    .HasConstraintName("FK_TrackPageContent_TrackContentType");

                entity.HasOne(d => d.TrackPage)
                    .WithMany(p => p.TrackPageContent)
                    .HasForeignKey(d => d.TrackPageId)
                    .HasConstraintName("FK_TrackPageContent_TrackPage");
            });

            modelBuilder.Entity<TrackPageType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<TrackStory>(entity =>
            {
                entity.Property(e => e.StoryId).HasColumnName("Story_Id");

                entity.Property(e => e.TrackId).HasColumnName("Track_Id");

                entity.HasOne(d => d.Story)
                    .WithMany(p => p.TrackStory)
                    .HasForeignKey(d => d.StoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TrackStory_Story");

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.TrackStory)
                    .HasForeignKey(d => d.TrackId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TrackStory_Track");
            });
        }
    }
}