using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AssetAssetReceiveDocDetail
    {
        public int ReceiveAssetDetailId { get; set; }
        public int? ReceiveAssetId { get; set; }
        public int? AssetId { get; set; }
        public int? EmpId { get; set; }
        public decimal? AddValue { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? TotalValue { get; set; }
        public int? StoreId { get; set; }
        public int? Aid { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public string? DbtableName { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? DbtableId { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public string? AccountTableName { get; set; }
        public byte? RectSourceType { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public int? RectSourceTypeId { get; set; }

        public virtual AssetAssetReceiveDoc? ReceiveAsset { get; set; }
    }
}
