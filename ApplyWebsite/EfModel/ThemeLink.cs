using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ThemeLink
    {
        public ThemeLink()
        {
            ThemeLinkParameter = new HashSet<ThemeLinkParameter>();
        }

        public int Id { get; set; }
        public int ThemeId { get; set; }
        public string LinkName { get; set; }
        public int PageId { get; set; }

        public virtual ICollection<ThemeLinkParameter> ThemeLinkParameter { get; set; }
        public virtual ThemePage Page { get; set; }
        public virtual Theme Theme { get; set; }
    }
}
