using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsSalesInvoiceCostDeliver
    {
        public int SaleNoCostDelId { get; set; }
        public int? InvId { get; set; }
        public int? DeliverId { get; set; }
        public string? Remarks { get; set; }

        public virtual MsSalesInvoice? Inv { get; set; }
    }
}
