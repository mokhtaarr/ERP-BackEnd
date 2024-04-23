using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchBankNotice
    {
        public string? DocTrNo { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? RefNo { get; set; }
        public string? Remarks { get; set; }
        public string? KeeperNo { get; set; }
        public decimal? TotalCheques { get; set; }
        public string? CurrencyCode { get; set; }
        public string? CurrencyDescA { get; set; }
        public string? CurrencyDescE { get; set; }
        public string? PaderDire { get; set; }
        public string? TranTypeDesc { get; set; }
        public decimal? BankExpenses { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? BankNoticDetailId { get; set; }
        public int? RectId { get; set; }
        public int? PayId { get; set; }
        public bool? IsCollected { get; set; }
        public bool? IsReturned { get; set; }
        public DateTime? CollectDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool? Canceled { get; set; }
        public bool? IsTransferred { get; set; }
        public DateTime? TransferredAte { get; set; }
        public string? RecDocTrNo { get; set; }
        public int? KeeperId { get; set; }
        public string? CheckNumber { get; set; }
        public bool? IsKembiala { get; set; }
        public string DocType { get; set; } = null!;
        public string? KeeperDocTrNo { get; set; }
        public int BankNoticId { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public string Cc { get; set; } = null!;
        public string Cc2 { get; set; } = null!;
        public decimal? ValueBeforeRate { get; set; }
        public byte? TranType { get; set; }
    }
}
