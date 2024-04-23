using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class QualityItemRecPackage
    {
        public int ItemRecPackId { get; set; }
        public int? ItemRecQualityId { get; set; }
        public string? Code { get; set; }
        public int? PackageSerial { get; set; }
        public int? WorkOrderId { get; set; }
        public long? AlterSerial { get; set; }

        public virtual QualityItemRecCheck? ItemRecQuality { get; set; }
        public virtual ProdWorkOrder? WorkOrder { get; set; }
    }
}
