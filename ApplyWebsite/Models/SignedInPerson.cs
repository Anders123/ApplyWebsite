using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApplyWebsite.Models
{
    public class SignedInPerson
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public int PersonId { get; set; }

        public SignedInPerson(string name, string email, int personId)
        {
            Fullname = name;
            Email = email;
            PersonId = personId;
        }
    }
}
