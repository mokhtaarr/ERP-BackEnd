using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPartition
    {
        public MsPartition()
        {
            MsItemPartitions = new HashSet<MsItemPartition>();
        }

        public int StorePartId { get; set; }
        public int? StoreId { get; set; }
        public string PartCode { get; set; } = null!;
        public string? PartDescA { get; set; }
        public string? PartDescE { get; set; }
        public string? Remarks { get; set; }
        public string? StoreKeeper { get; set; }
        public string? Tel { get; set; }
        public string? Address { get; set; }
        public string? Fax { get; set; }
        public string? StrCustm2 { get; set; }
        public string? StrCustm3 { get; set; }
        public string? StrCustm4 { get; set; }
        public string? StrCustm5 { get; set; }
        public string? StrCustm6 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? X { get; set; }
        public decimal? Y { get; set; }
        public decimal? Z { get; set; }
        public int? CityId { get; set; }
        public bool? SharedPartition { get; set; }
        public decimal? Space { get; set; }
        public decimal? Size { get; set; }
        public decimal? AnimalCount { get; set; }
        public bool? IsAnimalStore { get; set; }
        public int? PartAccountId { get; set; }
        public int? InBookId { get; set; }
        public int? OutBookId { get; set; }
        public int? InTermId { get; set; }
        public int? OutTermId { get; set; }

        public virtual MsStore? Store { get; set; }
        public virtual ICollection<MsItemPartition> MsItemPartitions { get; set; }
    }
}
