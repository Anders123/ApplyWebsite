using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class OnetCrosswalkSupplementary
    {
        public int Id { get; set; }
        public int OnetOccupationId { get; set; }
        public int? MilitarySpecialtyId { get; set; }

        public virtual Attr MilitarySpecialty { get; set; }
        public virtual OnetOccupationData OnetOccupation { get; set; }
    }
}
