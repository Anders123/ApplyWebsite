using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class ScopeConfigDss
    {
        public Guid ConfigId { get; set; }
        public string ConfigData { get; set; }
        public string ScopeStatus { get; set; }
    }
}
