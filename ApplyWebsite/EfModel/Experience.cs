using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Experience
    {
        public Experience()
        {
            ExperienceDetail = new HashSet<ExperienceDetail>();
            ExperienceOnetAbilities = new HashSet<ExperienceOnetAbilities>();
            ExperienceOnetActivities = new HashSet<ExperienceOnetActivities>();
            ExperienceOnetAltTitle = new HashSet<ExperienceOnetAltTitle>();
            ExperienceOnetKnowledge = new HashSet<ExperienceOnetKnowledge>();
            ExperienceOnetOccupation = new HashSet<ExperienceOnetOccupation>();
            ExperienceOnetSampleTitles = new HashSet<ExperienceOnetSampleTitles>();
            ExperienceOnetSkills = new HashSet<ExperienceOnetSkills>();
            ExperienceOnetToolsTech = new HashSet<ExperienceOnetToolsTech>();
            ExperienceReasonLeft = new HashSet<ExperienceReasonLeft>();
            ExperienceState = new HashSet<ExperienceState>();
        }

        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int? AccountId { get; set; }
        public int? AccountCityId { get; set; }
        public string OtherExperienceName { get; set; }
        public int? OnetOccupationId { get; set; }
        public int? OnetAlternateTitleId { get; set; }
        public string SchoolName { get; set; }
        public bool Graduated { get; set; }
        public int MilesPerWeek { get; set; }
        public string OtherLeftReason { get; set; }
        public bool Fmcsarules { get; set; }
        public bool SafetySensitive { get; set; }
        public DateTime? StartedOn { get; set; }
        public bool CurrentExperience { get; set; }
        public DateTime? LeftOn { get; set; }
        public string ExperienceNotes { get; set; }
        public bool HideExperience { get; set; }
        public int? OutsideId { get; set; }
        public string OutsideSource { get; set; }
        public int? ExperienceTypeId { get; set; }
        public int? MilitaryBranchId { get; set; }
        public int? MilitaryRankId { get; set; }
        public int? MilitarySchoolId { get; set; }
        public int? MilitarySpecialtyId { get; set; }
        public int? MilitaryStatusId { get; set; }
        public int? YearsId { get; set; }
        public int? MonthsId { get; set; }
        public int? CopyId { get; set; }
        public int? ExperienceRank { get; set; }

        public virtual ICollection<ExperienceDetail> ExperienceDetail { get; set; }
        public virtual ICollection<ExperienceOnetAbilities> ExperienceOnetAbilities { get; set; }
        public virtual ICollection<ExperienceOnetActivities> ExperienceOnetActivities { get; set; }
        public virtual ICollection<ExperienceOnetAltTitle> ExperienceOnetAltTitle { get; set; }
        public virtual ICollection<ExperienceOnetKnowledge> ExperienceOnetKnowledge { get; set; }
        public virtual ICollection<ExperienceOnetOccupation> ExperienceOnetOccupation { get; set; }
        public virtual ICollection<ExperienceOnetSampleTitles> ExperienceOnetSampleTitles { get; set; }
        public virtual ICollection<ExperienceOnetSkills> ExperienceOnetSkills { get; set; }
        public virtual ICollection<ExperienceOnetToolsTech> ExperienceOnetToolsTech { get; set; }
        public virtual ICollection<ExperienceReasonLeft> ExperienceReasonLeft { get; set; }
        public virtual ICollection<ExperienceState> ExperienceState { get; set; }
        public virtual GeoCity AccountCity { get; set; }
        public virtual Account Account { get; set; }
        public virtual Attr ExperienceType { get; set; }
        public virtual Attr MilitaryBranch { get; set; }
        public virtual Attr MilitaryRank { get; set; }
        public virtual Attr MilitarySchool { get; set; }
        public virtual Attr MilitarySpecialty { get; set; }
        public virtual Attr MilitaryStatus { get; set; }
        public virtual TimeMonth Months { get; set; }
        public virtual OnetAlternateTitle OnetAlternateTitle { get; set; }
        public virtual OnetOccupationData OnetOccupation { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual TimeYear Years { get; set; }
    }
}
