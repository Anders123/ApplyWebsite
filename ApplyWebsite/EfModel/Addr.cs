using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class Addr
    {
        public Addr()
        {
            AddrPerson = new HashSet<AddrPerson>();
        }

        public int Id { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public int? ZipId { get; set; }
        public int? CountryId { get; set; }
        public string Directions { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }

        public virtual ICollection<AddrPerson> AddrPerson { get; set; }
    }
}
