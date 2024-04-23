using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPurchaseInvoiceCostReceived
    {
        public int PurNoCostStockId { get; set; }
        public int? PurInvId { get; set; }
        public int? StockRecId { get; set; }
        public string? Remarks { get; set; }

        public virtual MsPurchasInvoice? PurInv { get; set; }
    }
}
