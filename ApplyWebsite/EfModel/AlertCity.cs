using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AlertCity
    {
        public int Id { get; set; }
        public int AlertId { get; set; }
        public int CityId { get; set; }

        public virtual Alert Alert { get; set; }
        public virtual GeoCity City { get; set; }
    }
}
