using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Company
    {
        public Company()
        {
            Account = new HashSet<Account>();
            CompanyPerson = new HashSet<CompanyPerson>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<CompanyPerson> CompanyPerson { get; set; }
    }
}
