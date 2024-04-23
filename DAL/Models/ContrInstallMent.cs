using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ContrInstallMent
    {
        public ContrInstallMent()
        {
            ContrInstallMentDetails = new HashSet<ContrInstallMentDetail>();
        }

        public int InstallId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CustomerId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? EmpId { get; set; }
        public int? FinancialIntervalsId { get; set; }
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
        /// <summary>
        /// to attach any document in database to receiptnote
        /// </summary>
        public int? AccountId { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public byte? RectSourceType { get; set; }
        public string? OtherSource { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? TableStartDate { get; set; }
        public DateTime? TableEndDate { get; set; }
        public int? InstallmentsCount { get; set; }
        public int? PaidInstallCount { get; set; }
        public int? NotPaidInstallCount { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? NetPrice { get; set; }
        public string? Remarks { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public decimal? NotPaid { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<ContrInstallMentDetail> ContrInstallMentDetails { get; set; }
    }
}
