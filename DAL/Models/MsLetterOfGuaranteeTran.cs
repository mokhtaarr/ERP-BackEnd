using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsLetterOfGuaranteeTran
    {
        public int LetOfGrnteeTranId { get; set; }
        public int? LetOfGrnteeId { get; set; }
        public int? StoreId { get; set; }
        public int? LetOfGrnteeStatusId { get; set; }
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        public int? LetOfGrnteeTypeId { get; set; }
        public int? LetOfGrnteeCatId { get; set; }
        public int? LetOfGrnteeStatusId1 { get; set; }
        public byte? PaperDirection { get; set; }
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
        public int? BankAccountId { get; set; }
        public byte? ResourceType { get; set; }
        public int? ResourceId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? LetrOfGaccountId { get; set; }
        public int? LetrOfGexpensAccountId { get; set; }
        public int? LetrOfGcommisionAccountId { get; set; }
        public string? Description { get; set; }
        public string? ReceiverName { get; set; }
        public string? ManualTrNo { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? Rate { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? ValueBeforeRate { get; set; }
        public decimal? Commision { get; set; }
        public decimal? CashMargin { get; set; }
        public bool? IsCovered { get; set; }
        public decimal? CoverPercent { get; set; }
        public decimal? CoverValue { get; set; }
        public decimal? Expenses { get; set; }
        public DateTime? LetEndDate { get; set; }
        public string? Conditions { get; set; }
        /// <summary>
        /// 1 Uprais,2 Decreas, else none
        /// </summary>
        public byte? ValuEffect { get; set; }
        public string? Remarks { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? LimitGuarantee { get; set; }
        public decimal? CustodyGuarantee { get; set; }
        public int? ShiftId { get; set; }

        public virtual MsLetterOfGuarantee? LetOfGrntee { get; set; }
    }
}
