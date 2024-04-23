using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwJobOrder
    {
        public int JobOrderId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? CustomerId { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public int? ItemCardId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? ItemDescE { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public string? ItemBatchCode { get; set; }
        public string? ItemBatchName1 { get; set; }
        public decimal? ProducedQty { get; set; }
        public decimal? TotalItemCost { get; set; }
        public decimal? TotalTasksCose { get; set; }
        public decimal? TotalJobsCost { get; set; }
        public decimal? TotalEquipCost { get; set; }
        public decimal? TotalExpensesCost { get; set; }
        public decimal? TotalPurchInvCost { get; set; }
        public decimal? TotalServices { get; set; }
        public decimal? TotalJpbOrder { get; set; }
        public decimal? TotalProductsPrice { get; set; }
        public decimal? TotalGoStock { get; set; }
        public decimal? TotalScrap { get; set; }
        public decimal? InstallationPrice { get; set; }
        public bool? IsDeliveredGoStock { get; set; }
        public bool? IsDeliveredProducts { get; set; }
        public bool? IsDeliveredScrap { get; set; }
        public bool? IsDeliveredMaterial { get; set; }
        public string? DocTrNo { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? BookId { get; set; }
        public int? StoreId { get; set; }
        public decimal? DiscPercent { get; set; }
        public decimal? DiscAmount { get; set; }
        public decimal? GrandTotal { get; set; }
        public string? Name1 { get; set; }
    }
}
