using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ThemeLinkParameter
    {
        public int Id { get; set; }
        public int LinkId { get; set; }
        public string ParameterUsage { get; set; }
        public int ParameterId { get; set; }
        public int? CategoryId { get; set; }
        public int? CityId { get; set; }
        public int? AccountId { get; set; }
        public int? PostId { get; set; }
        public int? CoreTitleId { get; set; }

        public virtual Account Account { get; set; }
        public virtual PostCategory Category { get; set; }
        public virtual GeoCity City { get; set; }
        public virtual CoreTitle CoreTitle { get; set; }
        public virtual ThemeLink Link { get; set; }
        public virtual ThemeParameter Parameter { get; set; }
        public virtual Post Post { get; set; }
    }
}
