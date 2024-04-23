using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchPrintPricing
    {
        public int? StoreId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int? PrinQoutId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public decimal? OuterBoxesCount { get; set; }
        public decimal? PartsCount { get; set; }
        public int? Layers { get; set; }
        public decimal? OutOrderLength { get; set; }
        public decimal? OutOrderWidth { get; set; }
        public decimal? OutOrderHeight { get; set; }
        public decimal? InOrderLength { get; set; }
        public decimal? InOrderWidth { get; set; }
        public decimal? InOrderHeight { get; set; }
        public decimal? CutterLength { get; set; }
        public decimal? CutterWidth { get; set; }
        public decimal? CutterHeight { get; set; }
        public decimal? CutterMetricLength { get; set; }
        public decimal? GofferMetricLength { get; set; }
        public decimal? PurpuraMetricLength { get; set; }
        public decimal? TotalLength { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? ItemDescE { get; set; }
        public string? ItemBatchCode { get; set; }
        public string? ItemBatchName1 { get; set; }
        public string? ItemBatchName2 { get; set; }
        public decimal? PartsBySheet { get; set; }
        public decimal? Zincs { get; set; }
        public decimal? Forms { get; set; }
        public decimal? Transportation { get; set; }
        public decimal? Palets { get; set; }
        public decimal? TotalPrepare { get; set; }
        public decimal? Commision { get; set; }
        public decimal? TotalSales { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalProfit { get; set; }
        public decimal? ItemPrice { get; set; }
        public int PrinPriceId { get; set; }
    }
}
