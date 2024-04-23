using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdWorkOrderItemRecQualityDoc
    {
        public int WorkOrderRecQualityId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? ItemRecQualityId { get; set; }

        public virtual ProdWorkOrder? WorkOrder { get; set; }
    }
}
