using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Person
    {
        public Person()
        {
            AccountGroupPerson = new HashSet<AccountGroupPerson>();
            AccountPerson = new HashSet<AccountPerson>();
            AccountRelationship = new HashSet<AccountRelationship>();
            AccountRelationshipStatusHistory = new HashSet<AccountRelationshipStatusHistory>();
            AccountReleationshipIntroBy = new HashSet<AccountReleationshipIntroBy>();
            ActivityPerson = new HashSet<ActivityPerson>();
            AddrPerson = new HashSet<AddrPerson>();
            Alert = new HashSet<Alert>();
            ClockAssignedTo = new HashSet<Clock>();
            ClockPerson = new HashSet<Clock>();
            Comm = new HashSet<Comm>();
            CommConnection = new HashSet<CommConnection>();
            Comment = new HashSet<Comment>();
            CommMember = new HashSet<CommMember>();
            CommStateLog = new HashSet<CommStateLog>();
            CompanyPerson = new HashSet<CompanyPerson>();
            EventPerson = new HashSet<EventPerson>();
            Log = new HashSet<Log>();
            MilitaryBasePerson = new HashSet<MilitaryBasePerson>();
            PersonCommMethodPref = new HashSet<PersonCommMethodPref>();
            PersonDashboard = new HashSet<PersonDashboard>();
            PersonTag = new HashSet<PersonTag>();
            PersonViaMethod = new HashSet<PersonViaMethod>();
            PostCreatedBy = new HashSet<Post>();
            PostModifiedBy = new HashSet<Post>();
            PostOwner = new HashSet<Post>();
            Profile = new HashSet<Profile>();
            ProfileLink = new HashSet<ProfileLink>();
            ProfileReference = new HashSet<ProfileReference>();
            ProfileReferralByPerson = new HashSet<ProfileReferral>();
            ProfileReferralToPerson = new HashSet<ProfileReferral>();
            Rating = new HashSet<Rating>();
            Review = new HashSet<Review>();
            RolePerson = new HashSet<RolePerson>();
            ShareSharedBy = new HashSet<Share>();
            ShareSharedWith = new HashSet<Share>();
            Story = new HashSet<Story>();
            TaskComplete = new HashSet<TaskComplete>();
            TaskHide = new HashSet<TaskHide>();
            TaskResourceHide = new HashSet<TaskResourceHide>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public bool AllowSms { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Handle { get; set; }
        public string Title { get; set; }
        public string DirectPhone { get; set; }
        public string ProfilePicture { get; set; }
        public string ProfileDescription { get; set; }
        public DateTime? VerifiedAt { get; set; }
        public string Password { get; set; }
        public int? AssetId { get; set; }
        public bool OptOut { get; set; }
        public DateTime? AcceptPolicy { get; set; }
        public string MigrationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedById { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedById { get; set; }
        public int? LastActivityId { get; set; }
        public DateTime? LastActivityAt { get; set; }
        public int IntrosActive { get; set; }
        public DateTime? IntrosActiveAt { get; set; }
        public bool IntroCapOverride { get; set; }
        public DateTime? IntroCapOverrideAt { get; set; }

        public virtual ICollection<AccountGroupPerson> AccountGroupPerson { get; set; }
        public virtual ICollection<AccountPerson> AccountPerson { get; set; }
        public virtual ICollection<AccountRelationship> AccountRelationship { get; set; }
        public virtual ICollection<AccountRelationshipStatusHistory> AccountRelationshipStatusHistory { get; set; }
        public virtual ICollection<AccountReleationshipIntroBy> AccountReleationshipIntroBy { get; set; }
        public virtual ICollection<ActivityPerson> ActivityPerson { get; set; }
        public virtual ICollection<AddrPerson> AddrPerson { get; set; }
        public virtual ICollection<Alert> Alert { get; set; }
        public virtual ICollection<Clock> ClockAssignedTo { get; set; }
        public virtual ICollection<Clock> ClockPerson { get; set; }
        public virtual ICollection<Comm> Comm { get; set; }
        public virtual ICollection<CommConnection> CommConnection { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<CommMember> CommMember { get; set; }
        public virtual ICollection<CommStateLog> CommStateLog { get; set; }
        public virtual ICollection<CompanyPerson> CompanyPerson { get; set; }
        public virtual ICollection<EventPerson> EventPerson { get; set; }
        public virtual ICollection<Log> Log { get; set; }
        public virtual ICollection<MilitaryBasePerson> MilitaryBasePerson { get; set; }
        public virtual ICollection<PersonCommMethodPref> PersonCommMethodPref { get; set; }
        public virtual ICollection<PersonDashboard> PersonDashboard { get; set; }
        public virtual ICollection<PersonTag> PersonTag { get; set; }
        public virtual ICollection<PersonViaMethod> PersonViaMethod { get; set; }
        public virtual ICollection<Post> PostCreatedBy { get; set; }
        public virtual ICollection<Post> PostModifiedBy { get; set; }
        public virtual ICollection<Post> PostOwner { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
        public virtual ICollection<ProfileLink> ProfileLink { get; set; }
        public virtual ICollection<ProfileReference> ProfileReference { get; set; }
        public virtual ICollection<ProfileReferral> ProfileReferralByPerson { get; set; }
        public virtual ICollection<ProfileReferral> ProfileReferralToPerson { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual ICollection<RolePerson> RolePerson { get; set; }
        public virtual ICollection<Share> ShareSharedBy { get; set; }
        public virtual ICollection<Share> ShareSharedWith { get; set; }
        public virtual ICollection<Story> Story { get; set; }
        public virtual ICollection<TaskComplete> TaskComplete { get; set; }
        public virtual ICollection<TaskHide> TaskHide { get; set; }
        public virtual ICollection<TaskResourceHide> TaskResourceHide { get; set; }
        public virtual Asset Asset { get; set; }
    }
}
