using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountLogo
    {
        public AccountLogo()
        {
            Post = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string AccountLogoName { get; set; }
        public int LogoTypeId { get; set; }
        public int AccountId { get; set; }
        public int? ImageId { get; set; }

        public virtual ICollection<Post> Post { get; set; }
        public virtual Account Account { get; set; }
        public virtual ImageLibrary Image { get; set; }
        public virtual LogoType LogoType { get; set; }
    }
}
