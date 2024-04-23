using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCashTransactionDetail
    {
        public int PaidDocId { get; set; }
        public int? RectId { get; set; }
        public int? PayId { get; set; }
        public int? AdjustId { get; set; }
        public int? JurnalId { get; set; }
        public string? TableCode { get; set; }
        public int? TableId { get; set; }
        public byte? TermType { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public string? TrNoDesc { get; set; }
        public decimal? Total { get; set; }
        public decimal? Paid { get; set; }
        public decimal? NotPaid { get; set; }
        public decimal? PaidByDoc { get; set; }
        public decimal? TotalBeforRate { get; set; }
        public decimal? PaidBeforeRate { get; set; }
        public decimal? NotPaidBeforeRate { get; set; }
        public decimal? PaidByDocBeforeRate { get; set; }
        public string? Description { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual MsAdjustMent? Adjust { get; set; }
        public virtual CalJurnalEntry? Jurnal { get; set; }
        public virtual MsPaymentNote? Pay { get; set; }
        public virtual MsReceiptNote? Rect { get; set; }
    }
}
