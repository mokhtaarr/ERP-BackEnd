using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjReInstallment
    {
        public int ReInstallId { get; set; }
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
        public decimal? TotalNotPaidInstallVal { get; set; }
        public decimal? DepositVal { get; set; }
        public int? DepositRectId { get; set; }
        public decimal? NewInstallVal { get; set; }
        public bool? IsDiscount { get; set; }
        public decimal? DiscountVal { get; set; }
        public DateTime? NewStartDate { get; set; }
        public DateTime? NewEndDate { get; set; }
        public bool? IsContract { get; set; }
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
        public int? ShiftId { get; set; }
    }
}
