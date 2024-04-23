using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsLetterOfGuarantee
    {
        public MsLetterOfGuarantee()
        {
            MsLetterOfGuaranteeTrans = new HashSet<MsLetterOfGuaranteeTran>();
        }

        public int LetOfGrnteeId { get; set; }
        public int? StoreId { get; set; }
        public int? Aid { get; set; }
        public int? CurrencyId { get; set; }
        public int? LetOfGrnteeTypeId { get; set; }
        public int? LetOfGrnteeCatId { get; set; }
        public int? LetOfGrnteeStatusId { get; set; }
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
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public string Code { get; set; } = null!;
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? ReceiverName { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? Rate { get; set; }
        public decimal? PaidPrice { get; set; }
        public decimal? ValueBeforeRate { get; set; }
        public DateTime? LetEndDate { get; set; }
        public string? Conditions { get; set; }
        public decimal? Commision { get; set; }
        public decimal? CashMargin { get; set; }
        public bool? IsCovered { get; set; }
        public decimal? CoverPercent { get; set; }
        public decimal? CoverValue { get; set; }
        public decimal? Expenses { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? LimitGuarantee { get; set; }
        public decimal? CustodyGuarantee { get; set; }
        public int? ShiftId { get; set; }

        public virtual ICollection<MsLetterOfGuaranteeTran> MsLetterOfGuaranteeTrans { get; set; }
    }
}
