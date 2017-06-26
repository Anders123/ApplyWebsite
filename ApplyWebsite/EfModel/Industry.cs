using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Industry
    {
        public Industry()
        {
            AccountIndustry = new HashSet<AccountIndustry>();
            AlertIndustry = new HashSet<AlertIndustry>();
            AttrIndustry = new HashSet<AttrIndustry>();
            ImageLibraryIndustry = new HashSet<ImageLibraryIndustry>();
            PostIndustry = new HashSet<PostIndustry>();
            Profile = new HashSet<Profile>();
            ProfileIndustry = new HashSet<ProfileIndustry>();
            ThemeIndustry = new HashSet<ThemeIndustry>();
        }

        public string IndustryName { get; set; }
        public string OnetIndustryCode { get; set; }
        public int Id { get; set; }

        public virtual ICollection<AccountIndustry> AccountIndustry { get; set; }
        public virtual ICollection<AlertIndustry> AlertIndustry { get; set; }
        public virtual ICollection<AttrIndustry> AttrIndustry { get; set; }
        public virtual ICollection<ImageLibraryIndustry> ImageLibraryIndustry { get; set; }
        public virtual ICollection<PostIndustry> PostIndustry { get; set; }
        public virtual ICollection<Profile> Profile { get; set; }
        public virtual ICollection<ProfileIndustry> ProfileIndustry { get; set; }
        public virtual ICollection<ThemeIndustry> ThemeIndustry { get; set; }
    }
}
