using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ThemeParameterType
    {
        public ThemeParameterType()
        {
            ThemeParameter = new HashSet<ThemeParameter>();
        }

        public int Id { get; set; }
        public string ParameterType { get; set; }

        public virtual ICollection<ThemeParameter> ThemeParameter { get; set; }
    }
}
