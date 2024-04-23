using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BnkBankNotice
    {
        public BnkBankNotice()
        {
            BnkBankNoticeDetails = new HashSet<BnkBankNoticeDetail>();
        }

        public int BankNoticId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public string? KeeperNo { get; set; }
        public int? BoxId { get; set; }
        public int? AccountId { get; set; }
        public bool? IsReceived { get; set; }
        public int? RefNo { get; set; }
        public string? Remarks { get; set; }
        public decimal? TotalCheques { get; set; }
        public bool? PaperDirection { get; set; }
        public byte? TranType { get; set; }
        public decimal? BankExpenses { get; set; }
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
        public int? ShiftId { get; set; }

        public virtual ICollection<BnkBankNoticeDetail> BnkBankNoticeDetails { get; set; }
    }
}
