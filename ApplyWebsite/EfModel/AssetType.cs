using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AssetType
    {
        public AssetType()
        {
            AssetItem = new HashSet<AssetItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsImage { get; set; }

        public virtual ICollection<AssetItem> AssetItem { get; set; }
    }
}
