using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsKeeperBankDetail
    {
        public int KeeperDetailId { get; set; }
        public int? KeeperId { get; set; }
        public int? RectId { get; set; }
        public bool? IsCollected { get; set; }
        public DateTime? CollectDate { get; set; }
        public bool? IsReturned { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string? Remarks { get; set; }
        public bool? IsTransferred { get; set; }
        public DateTime? TransferredAte { get; set; }

        public virtual MsKeeperBank? Keeper { get; set; }
    }
}
