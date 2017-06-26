using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AssetItemProperty
    {
        public int Id { get; set; }
        public int AssetItemId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyValue { get; set; }

        public virtual AssetItem AssetItem { get; set; }
    }
}
