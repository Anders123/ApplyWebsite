using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountAltName
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string AlternateName { get; set; }

        public virtual Account Account { get; set; }
    }
}
