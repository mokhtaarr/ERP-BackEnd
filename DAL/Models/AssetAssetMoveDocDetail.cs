using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AssetAssetMoveDocDetail
    {
        public int AssetMovDetailId { get; set; }
        public int? AssetMovId { get; set; }
        public int? AssetId { get; set; }
        public int? OldStoreId { get; set; }
        public int? NewStoreId { get; set; }
        public int? OldDepartMentId { get; set; }
        public int? NewDepartMentId { get; set; }
        public decimal? MoveCost { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? TotalValue { get; set; }
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

        public virtual AssetAssetMoveDoc? AssetMov { get; set; }
    }
}
