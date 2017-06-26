using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class GeoZipPop
    {
        public int GeoZipPopId { get; set; }
        public int? ZipId { get; set; }
        public string Zip { get; set; }
        public int Population { get; set; }
        public DateTime CrDt { get; set; }
        public string CrBy { get; set; }
        public DateTime MdDt { get; set; }
        public string MdBy { get; set; }

        public virtual GeoZip ZipNavigation { get; set; }
    }
}
