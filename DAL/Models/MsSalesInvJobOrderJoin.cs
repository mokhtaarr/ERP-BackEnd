using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsSalesInvJobOrderJoin
    {
        public int SalesInvJobOrderId { get; set; }
        public int? InvId { get; set; }
        public int? JobOrderId { get; set; }
        public string? Remarks { get; set; }

        public virtual MsSalesInvoice? Inv { get; set; }
        public virtual ProdJobOrder? JobOrder { get; set; }
    }
}
