using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjUnitConcession
    {
        public int UnitConcessionId { get; set; }
        public int? ReservId { get; set; }
        public int? InstallTempDetailId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? ProjUnitId { get; set; }
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Commission { get; set; }
        public decimal? ConcessionFee { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? ActualSalesPrice { get; set; }
        public decimal? PaidBeforeConcession { get; set; }
        public decimal? NotPaidInstallments { get; set; }
        public string? Remarks { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public decimal? NotPaid { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public string? AddField8 { get; set; }
        public string? AddField9 { get; set; }
        public string? AddField10 { get; set; }
        public int? ShiftId { get; set; }
    }
}
