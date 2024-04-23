using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PrintQoutation
    {
        public PrintQoutation()
        {
            PrintQoutationDetails = new HashSet<PrintQoutationDetail>();
        }

        public int PrinQoutId { get; set; }
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
        public int? DepartMentId { get; set; }
        public int? EmpId { get; set; }
        public int? EditTypeId { get; set; }
        public byte? SizeSource { get; set; }
        public int? StockingId { get; set; }
        public int? DistributId { get; set; }
        public int? BoxTypeId { get; set; }
        public int? SalesOfferReqId { get; set; }
        public int? GofferId { get; set; }
        public bool? IsDraw { get; set; }
        public bool? IsSample { get; set; }
        public decimal? OuterBoxesCount { get; set; }
        public decimal? PartsCount { get; set; }
        public int? CurrentEmpId { get; set; }
        public decimal? BoxCount { get; set; }
        public decimal? CutterMetricLength { get; set; }
        public decimal? GofferMetricLength { get; set; }
        public decimal? PurpuraMetricLength { get; set; }
        public decimal? TotalLength { get; set; }
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
        public int? SectorId { get; set; }

        public virtual ICollection<PrintQoutationDetail> PrintQoutationDetails { get; set; }
    }
}
