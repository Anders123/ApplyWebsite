using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Theme
    {
        public Theme()
        {
            ThemeAccount = new HashSet<ThemeAccount>();
            ThemeIndustry = new HashSet<ThemeIndustry>();
            ThemeLink = new HashSet<ThemeLink>();
            ThemeMenu = new HashSet<ThemeMenu>();
        }

        public int Id { get; set; }
        public string ThemeName { get; set; }
        public int ThemeLogoId { get; set; }
        public int? FaviconId { get; set; }
        public string ThemeColor { get; set; }
        public string HomePageUrl { get; set; }

        public virtual ICollection<ThemeAccount> ThemeAccount { get; set; }
        public virtual ICollection<ThemeIndustry> ThemeIndustry { get; set; }
        public virtual ICollection<ThemeLink> ThemeLink { get; set; }
        public virtual ICollection<ThemeMenu> ThemeMenu { get; set; }
        public virtual ImageLibrary Favicon { get; set; }
        public virtual ImageLibrary ThemeLogo { get; set; }
    }
}
