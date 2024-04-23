using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdJobOrderPurchaseInvoice
    {
        public int JobPurchasInvId { get; set; }
        public int? PurInvId { get; set; }
        public int? JobOrderId { get; set; }
        public decimal? NetPrice { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual ProdJobOrder? JobOrder { get; set; }
        public virtual MsPurchasInvoice? PurInv { get; set; }
    }
}
