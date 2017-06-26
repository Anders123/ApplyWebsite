using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class GeoCity
    {
        public GeoCity()
        {
            AlertCity = new HashSet<AlertCity>();
            Experience = new HashSet<Experience>();
            GeoZip = new HashSet<GeoZip>();
            MilitaryBase = new HashSet<MilitaryBase>();
            ProfileCity = new HashSet<ProfileCity>();
            ThemeLinkParameter = new HashSet<ThemeLinkParameter>();
        }

        public int CityId { get; set; }
        public string CitySt { get; set; }
        public int StateId { get; set; }
        public string City { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }

        public virtual ICollection<AlertCity> AlertCity { get; set; }
        public virtual ICollection<Experience> Experience { get; set; }
        public virtual ICollection<GeoZip> GeoZip { get; set; }
        public virtual ICollection<MilitaryBase> MilitaryBase { get; set; }
        public virtual ICollection<ProfileCity> ProfileCity { get; set; }
        public virtual ICollection<ThemeLinkParameter> ThemeLinkParameter { get; set; }
        public virtual GeoState State { get; set; }
    }
}
