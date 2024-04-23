using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderPlan
    {
        public ProjTenderPlan()
        {
            ProjTenderPlanDetails = new HashSet<ProjTenderPlanDetail>();
        }

        public int TenderPlanId { get; set; }
        public int? TenderId { get; set; }
        public int? TenderQoutationId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public DateTime? EstimateDeliverDate { get; set; }
        public DateTime? FinalDeliverDate1 { get; set; }
        public decimal? Rate { get; set; }
        public int? ReviewReasonId { get; set; }
        public byte? ReviewStatus { get; set; }
        public byte? PlanStatus { get; set; }
        public bool? IsInternal { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        public DateTime? PermPrintedAt { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }
        /// <summary>
        /// 1 Customer ,2 Vendor,3 Employee, 4 Account, 5 Business partner
        /// </summary>
        public byte? OwnerType { get; set; }
        public int? OwnerId { get; set; }
        /// <summary>
        /// 1 Customer ,2 Vendor,3 Employee, 4 Account, 5 Business partner
        /// </summary>
        public byte? PmType { get; set; }
        public int? PmId { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? TotalValueAfterRate { get; set; }
        public decimal? WorkPercent { get; set; }

        public virtual ICollection<ProjTenderPlanDetail> ProjTenderPlanDetails { get; set; }
    }
}
