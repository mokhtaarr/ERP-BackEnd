using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AssetDepreciationDocDetail
    {
        public int DeprDocDetailId { get; set; }
        public int? DeprDocId { get; set; }
        public int? AssetId { get; set; }
        public decimal? Value { get; set; }
        public int? DebitAccountId { get; set; }
        public int? CreditAccountId { get; set; }
        public int? DebitCostcenterId { get; set; }
        public int? CreditCostCenterId { get; set; }
        public int? DebitAssetAccountId { get; set; }
        public int? CreditAssetAccountId { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }

        public virtual AssetDepreciationDoc? DeprDoc { get; set; }
    }
}
