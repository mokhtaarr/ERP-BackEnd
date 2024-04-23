using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderExecutionExitractDetail
    {
        public int ExecutExitractDetailId { get; set; }
        public int? ExecutExitractId { get; set; }
        public int? TenderPlanDetailId { get; set; }
        public int? TenderDetailId { get; set; }
        public int? TenderItemId { get; set; }
        public int? ParentTenderItemId { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? PrevQuantity { get; set; }
        public decimal? TotalQuantity { get; set; }
        public decimal? TenderCat { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? TotalSubItem { get; set; }
        public decimal? CurrentQty { get; set; }
        public decimal? WorkPercent { get; set; }
        public decimal? ProfitPercent { get; set; }
        public decimal? ProfitValue { get; set; }
        public decimal? TenderItemPrice { get; set; }
        public decimal? TotalProfit { get; set; }
        public decimal? TenderTotalPrice { get; set; }
        public decimal? DistQty { get; set; }
        public decimal? TotalSubDist { get; set; }
        public decimal? TotalPriceDist { get; set; }
        public DateTime? EstimateDeliverDate { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public decimal? Price { get; set; }
        public decimal? PrevQtyBeforRate { get; set; }
        public decimal? TotalQtyBeforRate { get; set; }
        public decimal? CurrentQtyBeforRate { get; set; }
        public decimal? DistQtyBeforRate { get; set; }
        public decimal? RaisQty { get; set; }
        public decimal? RaisQtyBeforRate { get; set; }
        public decimal? PrevReturn { get; set; }
        public decimal? RaisBeforPrevReturn { get; set; }
        public decimal? RaisValue { get; set; }
        public decimal? RaisPercent { get; set; }
        public decimal? PreviousRais { get; set; }
        public decimal? RemainQtyBeforRate { get; set; }
        public decimal? RemainQty { get; set; }
        public string? ItemCardCode { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }

        public virtual ProjTenderExecutionExitract? ExecutExitract { get; set; }
    }
}
