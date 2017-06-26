using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class AssetItem
    {
        public AssetItem()
        {
            Account = new HashSet<Account>();
            AssetItemProperty = new HashSet<AssetItemProperty>();
        }

        public int Id { get; set; }
        public int? AssetId { get; set; }
        public int AssetTypeId { get; set; }
        public string AssetTitle { get; set; }
        public string AssetDescription { get; set; }
        public string AssetValue { get; set; }
        public int? LinktoPageId { get; set; }
        public int AssetRank { get; set; }

        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<AssetItemProperty> AssetItemProperty { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual AssetType AssetType { get; set; }
        public virtual TrackPage LinktoPage { get; set; }
    }
}
