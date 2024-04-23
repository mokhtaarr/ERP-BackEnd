using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderQoutationDetail
    {
        public int TenderQoutDetailId { get; set; }
        public int? TenderQoutationId { get; set; }
        public int? TenderItemId { get; set; }
        public int? ParentTenderItemId { get; set; }
        public string? Description { get; set; }
        public int? BasUnitId { get; set; }
        public decimal? TenderQuantity { get; set; }
        public decimal? TenderCat { get; set; }
        public decimal? TenderTotal { get; set; }
        public decimal? AnalyzQuantity { get; set; }
        public decimal? AnalyzCat { get; set; }
        public decimal? AnalyzTotalUnit { get; set; }
        public decimal? AnalyzTotalQty { get; set; }
        public decimal? AnalyzTotalCost { get; set; }
        public decimal? ProfitPercent { get; set; }
        public decimal? ProfitValue { get; set; }
        public decimal? TotalProfit { get; set; }
        public decimal? Price { get; set; }
        public decimal? TotalPrice { get; set; }
        public byte? ItemStatus { get; set; }
        public string? ItemStatusDesc { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }
        public int? TenderDetailId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public decimal? TenderQtyBeforRate { get; set; }
        public decimal? AnalyzQtyBeforRate { get; set; }
        public decimal? AnalyzTotalQtyBeforRate { get; set; }
        public string? ItemCardCode { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }

        public virtual ProjTenderQoutation? TenderQoutation { get; set; }
    }
}
