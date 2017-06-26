using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AccountApprovalStatus
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime? RequestedDte { get; set; }
        public DateTime? ApprovedDte { get; set; }
        public DateTime? NotifiedDte { get; set; }

        public virtual Account Account { get; set; }
    }
}
