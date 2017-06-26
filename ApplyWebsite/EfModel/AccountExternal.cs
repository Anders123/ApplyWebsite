using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountExternal
    {
        public int Id { get; set; }
        public int? AccountId { get; set; }
        public string CompanyName { get; set; }
        public string ExternalId { get; set; }
        public int SourceId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Account Account { get; set; }
        public virtual ExternalSource Source { get; set; }
    }
}
