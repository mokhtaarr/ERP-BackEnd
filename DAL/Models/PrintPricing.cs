using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PrintPricing
    {
        public PrintPricing()
        {
            PrintPricingDetails = new HashSet<PrintPricingDetail>();
        }

        public int PrinPriceId { get; set; }
        public int? PrinQoutId { get; set; }
        public int? PrinQoutDetailId { get; set; }
        public int? Aid { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? EditPrinQoutId { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? CustomerId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? EmpId { get; set; }
        public int? CurrentEmpId { get; set; }
        public int? DepartMentId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
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
        public decimal? QtyBeforRate { get; set; }
        public decimal? SheetsQty { get; set; }
        public decimal? ProdWeight { get; set; }
        public decimal? TotalWeight { get; set; }
        public decimal? Parts { get; set; }
        public decimal? PartsBySheet { get; set; }
        public decimal? Zincs { get; set; }
        public decimal? Forms { get; set; }
        public decimal? Transportation { get; set; }
        public decimal? Palets { get; set; }
        public decimal? TotalPrepare { get; set; }
        public decimal? Commision { get; set; }
        public decimal? PaperPrice { get; set; }
        public decimal? Slofan { get; set; }
        public decimal? ScrapPercent { get; set; }
        public decimal? Scrap { get; set; }
        public decimal? ProfitPercent { get; set; }
        public decimal? Profit { get; set; }
        public decimal? ItemPrice { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? TotalSales { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalProfitPercent { get; set; }
        public decimal? TotalProfit { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public string? Remarks { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        public DateTime? PermPrintedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }

        public virtual ICollection<PrintPricingDetail> PrintPricingDetails { get; set; }
    }
}
