using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class NationalResourceDirectory
    {
        public int Id { get; set; }
        public string ResourceName { get; set; }
        public string ResoureShortName { get; set; }
        public string ResourceLink { get; set; }
        public string ResourcePhone { get; set; }
    }
}
