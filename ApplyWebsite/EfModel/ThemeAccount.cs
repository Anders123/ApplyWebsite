using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ThemeAccount
    {
        public int ThemeId { get; set; }
        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Theme Theme { get; set; }
    }
}
