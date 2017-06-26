using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class GeoZip
    {
        public GeoZip()
        {
            GeoZipPop = new HashSet<GeoZipPop>();
            PostMapPoint = new HashSet<PostMapPoint>();
        }

        public int ZipId { get; set; }
        public string CityStzip { get; set; }
        public string CitySt { get; set; }
        public int CityId { get; set; }
        public string Zip { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }

        public virtual ICollection<GeoZipPop> GeoZipPop { get; set; }
        public virtual ICollection<PostMapPoint> PostMapPoint { get; set; }
        public virtual GeoCity City { get; set; }
    }
}
