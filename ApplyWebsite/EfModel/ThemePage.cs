using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ThemePage
    {
        public ThemePage()
        {
            ThemeLink = new HashSet<ThemeLink>();
        }

        public int Id { get; set; }
        public string PageName { get; set; }
        public string PagePath { get; set; }

        public virtual ICollection<ThemeLink> ThemeLink { get; set; }
    }
}
