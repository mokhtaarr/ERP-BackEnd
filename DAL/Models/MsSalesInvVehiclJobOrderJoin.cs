using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsSalesInvVehiclJobOrderJoin
    {
        public int SalesVehiclJobOrderId { get; set; }
        public int? InvId { get; set; }
        public int? VjorderId { get; set; }
        public string? Remarks { get; set; }

        public virtual MsSalesInvoice? Inv { get; set; }
        public virtual SrVehicleJobOrder? Vjorder { get; set; }
    }
}
