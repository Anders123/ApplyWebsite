using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileLanguage
    {
        public int ProfileId { get; set; }
        public int LanguageId { get; set; }

        public virtual Attr Language { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
