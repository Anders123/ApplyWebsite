using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class MilitaryBase
    {
        public MilitaryBase()
        {
            MilitaryBaseMilitaryBranch = new HashSet<MilitaryBaseMilitaryBranch>();
            MilitaryBasePerson = new HashSet<MilitaryBasePerson>();
        }

        public int Id { get; set; }
        public string BaseName { get; set; }
        public string BaseLogo { get; set; }
        public string BaseDescription { get; set; }
        public int? BaseCountryId { get; set; }
        public int? BaseCityId { get; set; }

        public virtual ICollection<MilitaryBaseMilitaryBranch> MilitaryBaseMilitaryBranch { get; set; }
        public virtual ICollection<MilitaryBasePerson> MilitaryBasePerson { get; set; }
        public virtual GeoCity BaseCity { get; set; }
        public virtual GeoCountry BaseCountry { get; set; }
    }
}
