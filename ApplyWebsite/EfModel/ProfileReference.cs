using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ProfileReference
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int ReferenceTypeId { get; set; }
        public int? ReferencePersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int? CompanyId { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public string DirectPhone { get; set; }
        public string ReferenceNotes { get; set; }
        public bool HideReference { get; set; }
        public int ReferenceRank { get; set; }

        public virtual Account Company { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual Person ReferencePerson { get; set; }
        public virtual ReferenceType ReferenceType { get; set; }
    }
}
