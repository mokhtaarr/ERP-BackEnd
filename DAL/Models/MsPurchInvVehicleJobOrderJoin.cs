using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPurchInvVehicleJobOrderJoin
    {
        public int PurchVehiclJobOrderId { get; set; }
        public int? PurInvId { get; set; }
        public int? VjorderId { get; set; }
        public string? Remarks { get; set; }

        public virtual MsPurchasInvoice? PurInv { get; set; }
        public virtual SrVehicleJobOrder? Vjorder { get; set; }
    }
}
