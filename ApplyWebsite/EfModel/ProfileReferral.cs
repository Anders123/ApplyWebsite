using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileReferral
    {
        public int Id { get; set; }
        public int ReviewId { get; set; }
        public int ByPersonId { get; set; }
        public int ByAccountId { get; set; }
        public int ToPersonId { get; set; }
        public int ToAccountId { get; set; }
        public DateTime ReferredAt { get; set; }

        public virtual Account ByAccount { get; set; }
        public virtual Person ByPerson { get; set; }
        public virtual Review Review { get; set; }
        public virtual Account ToAccount { get; set; }
        public virtual Person ToPerson { get; set; }
    }
}
