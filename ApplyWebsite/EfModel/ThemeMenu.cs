using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ThemeMenu
    {
        public int Id { get; set; }
        public int ThemeId { get; set; }
        public string MenuText { get; set; }
        public string MenuUrl { get; set; }
        public int MenuRank { get; set; }

        public virtual Theme Theme { get; set; }
    }
}
