using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class BnkBankNoticeDetail
    {
        public int BankNoticDetailId { get; set; }
        public int? BankNoticId { get; set; }
        public int? RectId { get; set; }
        public int? PayId { get; set; }
        public bool? IsCollected { get; set; }
        public DateTime? CollectDate { get; set; }
        public bool? IsReturned { get; set; }
        public DateTime? ReturnDate { get; set; }
        public bool? Canceled { get; set; }
        public string? Remarks { get; set; }
        public bool? IsTransferred { get; set; }
        public DateTime? TransferredAte { get; set; }

        public virtual BnkBankNotice? BankNotic { get; set; }
    }
}
