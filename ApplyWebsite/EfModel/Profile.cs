using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Profile
    {
        public Profile()
        {
            CommProfile = new HashSet<CommProfile>();
            Experience = new HashSet<Experience>();
            InterviewInstance = new HashSet<InterviewInstance>();
            ProfileAdditionalInfo = new HashSet<ProfileAdditionalInfo>();
            ProfileCity = new HashSet<ProfileCity>();
            ProfileIndustryNavigation = new HashSet<ProfileIndustry>();
            ProfileLanguage = new HashSet<ProfileLanguage>();
            ProfileMilitaryHonor = new HashSet<ProfileMilitaryHonor>();
            ProfilePercComplete = new HashSet<ProfilePercComplete>();
            ProfileReference = new HashSet<ProfileReference>();
            ProfileSearch = new HashSet<ProfileSearch>();
            Review = new HashSet<Review>();
        }

        public int Id { get; set; }
        public int PersonId { get; set; }
        public string ProfileName { get; set; }
        public bool? DefaultProfile { get; set; }
        public int? ProfileTypeId { get; set; }
        public int? MilitaryBranchId { get; set; }
        public int? MilitaryRankId { get; set; }
        public int? MilitarySpecialtyId { get; set; }
        public int? MilitaryStatusId { get; set; }
        public int? TransitionStatusId { get; set; }
        public int? SecurityClearanceId { get; set; }
        public bool ForeignLanguage { get; set; }
        public string ProfileSummary { get; set; }
        public int WillRelocate { get; set; }
        public bool PreferOnline { get; set; }
        public DateTime? MilitaryExitDate { get; set; }
        public bool GotAjob { get; set; }
        public bool UploadedResume { get; set; }
        public string UploadedResumePath { get; set; }
        public int? OutputFormatId { get; set; }
        public bool HideSkills { get; set; }
        public bool HideKnowledge { get; set; }
        public double LastPercComplete { get; set; }
        public DateTime LastPercCompleteAt { get; set; }
        public bool LastGotAjob { get; set; }
        public int? ProfileIndustryId { get; set; }
        public int? TransitionCounselorId { get; set; }

        public virtual ICollection<CommProfile> CommProfile { get; set; }
        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<InterviewInstance> InterviewInstance { get; set; }
        public virtual ICollection<ProfileAdditionalInfo> ProfileAdditionalInfo { get; set; }
        public virtual ICollection<ProfileCity> ProfileCity { get; set; }
        public virtual ICollection<ProfileIndustry> ProfileIndustryNavigation { get; set; }
        public virtual ICollection<ProfileLanguage> ProfileLanguage { get; set; }
        public virtual ICollection<ProfileMilitaryHonor> ProfileMilitaryHonor { get; set; }
        public virtual ICollection<ProfilePercComplete> ProfilePercComplete { get; set; }
        public virtual ICollection<ProfileReference> ProfileReference { get; set; }
        public virtual ICollection<ProfileSearch> ProfileSearch { get; set; }
        public virtual ICollection<Review> Review { get; set; }
        public virtual Attr MilitaryBranch { get; set; }
        public virtual Attr MilitaryRank { get; set; }
        public virtual Attr MilitarySpecialty { get; set; }
        public virtual Attr MilitaryStatus { get; set; }
        public virtual ProfileOutputFormat OutputFormat { get; set; }
        public virtual Person Person { get; set; }
        public virtual Industry ProfileIndustry { get; set; }
        public virtual Attr ProfileType { get; set; }
        public virtual Attr TransitionStatus { get; set; }
    }
}
