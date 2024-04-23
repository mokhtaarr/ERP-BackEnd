using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPettycash
    {
        public MsPettycash()
        {
            MsPettyCashDetails = new HashSet<MsPettyCashDetail>();
            MsPettyPaymentJoins = new HashSet<MsPettyPaymentJoin>();
        }

        public int PettycashId { get; set; }
        public int? StorId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? EmpId { get; set; }
        public int? CurrencyId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int? VjorderId { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? TotalPaidPrice { get; set; }
        public decimal? TotalFilteredPrice { get; set; }
        public decimal? Rate { get; set; }
        /// <summary>
        ///  1  Customer ; 2 vendor ; 3  Other
        /// </summary>
        public byte? RectSourceType { get; set; }
        public string? Remarks { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
        public decimal? NotPaid { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
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
        public byte? RectSourceType1 { get; set; }
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public int? ShiftId { get; set; }

        public virtual ICollection<MsPettyCashDetail> MsPettyCashDetails { get; set; }
        public virtual ICollection<MsPettyPaymentJoin> MsPettyPaymentJoins { get; set; }
    }
}
