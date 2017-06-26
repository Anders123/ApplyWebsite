using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Attr
    {
        public Attr()
        {
            AlertAttr = new HashSet<AlertAttr>();
            AttrIndustry = new HashSet<AttrIndustry>();
            AttrMappingMapped = new HashSet<AttrMapping>();
            AttrMappingMappedTo = new HashSet<AttrMapping>();
            AttrRankAltParent = new HashSet<AttrRankAlt>();
            AttrRankAltRankAlt = new HashSet<AttrRankAlt>();
            AttrRelatedTable = new HashSet<AttrRelatedTable>();
            CoreTitleAttr = new HashSet<CoreTitleAttr>();
            ExpDetailAttr = new HashSet<ExpDetailAttr>();
            ExperienceExperienceType = new HashSet<Experience>();
            ExperienceMilitaryBranch = new HashSet<Experience>();
            ExperienceMilitaryRank = new HashSet<Experience>();
            ExperienceMilitarySchool = new HashSet<Experience>();
            ExperienceMilitarySpecialty = new HashSet<Experience>();
            ExperienceMilitaryStatus = new HashSet<Experience>();
            ExperienceAttr = new HashSet<ExperienceAttr>();
            ImageLibraryAttr = new HashSet<ImageLibraryAttr>();
            InterviewAnswer = new HashSet<InterviewAnswer>();
            InterviewQuestionLibrary = new HashSet<InterviewQuestionLibrary>();
            InterviewQuestionRuleAttrAnswer = new HashSet<InterviewQuestionRule>();
            InterviewQuestionRuleAttrAnswerIdMaxNavigation = new HashSet<InterviewQuestionRule>();
            ListingAttr = new HashSet<ListingAttr>();
            MilitaryBaseMilitaryBranch = new HashSet<MilitaryBaseMilitaryBranch>();
            OnetCrosswalkSupplementary = new HashSet<OnetCrosswalkSupplementary>();
            PostAttr = new HashSet<PostAttr>();
            ProfileMilitaryBranch = new HashSet<Profile>();
            ProfileMilitaryRank = new HashSet<Profile>();
            ProfileMilitarySpecialty = new HashSet<Profile>();
            ProfileMilitaryStatus = new HashSet<Profile>();
            ProfileProfileType = new HashSet<Profile>();
            ProfileTransitionStatus = new HashSet<Profile>();
            ProfileLanguage = new HashSet<ProfileLanguage>();
            ProfileMilitaryHonor = new HashSet<ProfileMilitaryHonor>();
            ProfileSummaryAttr = new HashSet<ProfileSummaryAttr>();
            TaskAttr = new HashSet<TaskAttr>();
            TaskPhaseAttr = new HashSet<TaskPhaseAttr>();
            TaskResourceAttr = new HashSet<TaskResourceAttr>();
            ThemeParameterAttr = new HashSet<ThemeParameterAttr>();
            TipAttr = new HashSet<TipAttr>();
        }

        public string AttrItem { get; set; }
        public string AttrDescription { get; set; }
        public string AttrCode { get; set; }
        public string LargeIcon { get; set; }
        public string LargeMouseover { get; set; }
        public string SmallIcon { get; set; }
        public string SmallMouseover { get; set; }
        public int AttrRank { get; set; }
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public int? RelatedId { get; set; }
        public string RelatedTable { get; set; }
        public string OutsideId { get; set; }
        public bool AdminLock { get; set; }
        public int? ParentId { get; set; }
        public int? AttrIconId { get; set; }

        public virtual ICollection<AlertAttr> AlertAttr { get; set; }
        public virtual ICollection<AttrIndustry> AttrIndustry { get; set; }
        public virtual ICollection<AttrMapping> AttrMappingMapped { get; set; }
        public virtual ICollection<AttrMapping> AttrMappingMappedTo { get; set; }
        public virtual ICollection<AttrRankAlt> AttrRankAltParent { get; set; }
        public virtual ICollection<AttrRankAlt> AttrRankAltRankAlt { get; set; }
        public virtual ICollection<AttrRelatedTable> AttrRelatedTable { get; set; }
        public virtual CntAttr CntAttr { get; set; }
        public virtual ICollection<CoreTitleAttr> CoreTitleAttr { get; set; }
        public virtual ICollection<ExpDetailAttr> ExpDetailAttr { get; set; }
        public virtual ICollection<Experience> ExperienceExperienceType { get; set; }
        public virtual ICollection<Experience> ExperienceMilitaryBranch { get; set; }
        public virtual ICollection<Experience> ExperienceMilitaryRank { get; set; }
        public virtual ICollection<Experience> ExperienceMilitarySchool { get; set; }
        public virtual ICollection<Experience> ExperienceMilitarySpecialty { get; set; }
        public virtual ICollection<Experience> ExperienceMilitaryStatus { get; set; }
        public virtual ICollection<ExperienceAttr> ExperienceAttr { get; set; }
        public virtual ICollection<ImageLibraryAttr> ImageLibraryAttr { get; set; }
        public virtual ICollection<InterviewAnswer> InterviewAnswer { get; set; }
        public virtual ICollection<InterviewQuestionLibrary> InterviewQuestionLibrary { get; set; }
        public virtual ICollection<InterviewQuestionRule> InterviewQuestionRuleAttrAnswer { get; set; }
        public virtual ICollection<InterviewQuestionRule> InterviewQuestionRuleAttrAnswerIdMaxNavigation { get; set; }
        public virtual ICollection<ListingAttr> ListingAttr { get; set; }
        public virtual ICollection<MilitaryBaseMilitaryBranch> MilitaryBaseMilitaryBranch { get; set; }
        public virtual ICollection<OnetCrosswalkSupplementary> OnetCrosswalkSupplementary { get; set; }
        public virtual ICollection<PostAttr> PostAttr { get; set; }
        public virtual ICollection<Profile> ProfileMilitaryBranch { get; set; }
        public virtual ICollection<Profile> ProfileMilitaryRank { get; set; }
        public virtual ICollection<Profile> ProfileMilitarySpecialty { get; set; }
        public virtual ICollection<Profile> ProfileMilitaryStatus { get; set; }
        public virtual ICollection<Profile> ProfileProfileType { get; set; }
        public virtual ICollection<Profile> ProfileTransitionStatus { get; set; }
        public virtual ICollection<ProfileLanguage> ProfileLanguage { get; set; }
        public virtual ICollection<ProfileMilitaryHonor> ProfileMilitaryHonor { get; set; }
        public virtual ICollection<ProfileSummaryAttr> ProfileSummaryAttr { get; set; }
        public virtual ICollection<TaskAttr> TaskAttr { get; set; }
        public virtual ICollection<TaskPhaseAttr> TaskPhaseAttr { get; set; }
        public virtual ICollection<TaskResourceAttr> TaskResourceAttr { get; set; }
        public virtual ICollection<ThemeParameterAttr> ThemeParameterAttr { get; set; }
        public virtual ICollection<TipAttr> TipAttr { get; set; }
        public virtual ImageLibrary AttrIcon { get; set; }
        public virtual Attr Parent { get; set; }
        public virtual ICollection<Attr> InverseParent { get; set; }
    }
}
