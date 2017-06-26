using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ThemeParameter
    {
        public ThemeParameter()
        {
            ThemeLinkParameter = new HashSet<ThemeLinkParameter>();
            ThemeParameterAttr = new HashSet<ThemeParameterAttr>();
        }

        public int Id { get; set; }
        public string ParameterName { get; set; }
        public int ParameterTypeId { get; set; }
        public string ParameterSyntax { get; set; }

        public virtual ICollection<ThemeLinkParameter> ThemeLinkParameter { get; set; }
        public virtual ICollection<ThemeParameterAttr> ThemeParameterAttr { get; set; }
        public virtual ThemeParameterType ParameterType { get; set; }
    }
}
