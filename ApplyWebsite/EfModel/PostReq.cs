using System;
using System.Collections.Generic;

namespace ApplyWebsite.EfModel
{
    public partial class PostReq
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string ReqNo { get; set; }
        public DateTime? ReqDte { get; set; }
        public string ReqLink { get; set; }
        public string ReqApply { get; set; }
        public DateTime? ReleaseDte { get; set; }
        public DateTime? HideDte { get; set; }
        public string Title { get; set; }
        public string LongDesc { get; set; }
        public string SalaryText { get; set; }
        public string ExperienceText { get; set; }
        public string JobTypeText { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? ZipId { get; set; }
        public string Country { get; set; }
        public double? Lat { get; set; }
        public double? Long { get; set; }
        public int? SourceId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? OnetMappedAt { get; set; }
        public DateTime? AltTitleMappedAt { get; set; }
        public DateTime? AttrMappedAt { get; set; }
        public DateTime? FactorsMappedAt { get; set; }
        public DateTime? IndexedAt { get; set; }
        public int? TitleId { get; set; }
        public string MappedFilters { get; set; }

        public virtual Account Account { get; set; }
    }
}
