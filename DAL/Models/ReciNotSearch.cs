using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ReciNotSearch
    {
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? StoreId { get; set; }
        public decimal? PaidPrice { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public string? CheckNumber { get; set; }
        public string? BankAccNumber { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public byte? CheckType { get; set; }
        public string? Remarks { get; set; }
        public bool? IsKembiala { get; set; }
        public string? ClientAccNo { get; set; }
        public int? KeeperTrNo { get; set; }
        public DateTime? KeeperTrDate { get; set; }
        public int Cc { get; set; }
        public string? BoxCode { get; set; }
        public string? Desca { get; set; }
        public byte? RectSourceType { get; set; }
        public int RectId { get; set; }
        public int? KeeperId { get; set; }
        public int? BankNoticId { get; set; }
        public int? BankNoticeTrNo { get; set; }
        public DateTime? BankNoticeTrDate { get; set; }
        public int? CurrencyId { get; set; }
        public string? CurrencyCode { get; set; }
        public string? CurrencyDescA { get; set; }
        public bool? DefualtCurrency { get; set; }
        public decimal? Commision { get; set; }
        public decimal? ValueBeforeRate { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value1BeforeRate { get; set; }
        public decimal? Value2 { get; set; }
        public decimal? Value2BeforeRate { get; set; }
        public decimal? Value3 { get; set; }
        public decimal? Value3BeforeRate { get; set; }
        public decimal? Value4 { get; set; }
        public decimal? Value4BeforeRate { get; set; }
        public decimal? Value5 { get; set; }
        public decimal? Value5BeforeRate { get; set; }
        public decimal? Value6 { get; set; }
        public decimal? Value6BeforeRate { get; set; }
        public decimal? Value7 { get; set; }
        public decimal? Value7BeforeRate { get; set; }
        public decimal? Value8 { get; set; }
        public decimal? Value8BeforeRate { get; set; }
        public decimal? Value9 { get; set; }
        public decimal? Value9BeforeRate { get; set; }
        public decimal? Value10 { get; set; }
        public decimal? Value10BeforeRate { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public decimal? Rate { get; set; }
        public string? CurrencyDescE { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? PayId { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
    }
}
