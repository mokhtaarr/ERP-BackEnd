using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsBoxTransferDetail
    {
        public int BoxTranDetailId { get; set; }
        public int? BoxTranId { get; set; }
        public int? BoxFrom { get; set; }
        public int? BoxTo { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Valu { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual MsBoxTransferNote? BoxTran { get; set; }
    }
}
