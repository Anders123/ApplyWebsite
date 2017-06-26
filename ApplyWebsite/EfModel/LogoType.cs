using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class LogoType
    {
        public LogoType()
        {
            AccountLogo = new HashSet<AccountLogo>();
        }

        public int Id { get; set; }
        public string LogoTypeName { get; set; }

        public virtual ICollection<AccountLogo> AccountLogo { get; set; }
    }
}
