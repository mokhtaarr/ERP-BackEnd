using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsSalesInvoiceQualityDeliveryDoc
    {
        public int QualitySaleDelId { get; set; }
        public int? ItemDeliverId { get; set; }
        public int? InvId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual MsSalesInvoice? Inv { get; set; }
    }
}
