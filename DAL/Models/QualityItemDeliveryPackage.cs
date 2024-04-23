using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class QualityItemDeliveryPackage
    {
        public int ItemDeliceryPackId { get; set; }
        public int? ItemDeliverId { get; set; }
        public string? Code { get; set; }
        public int? PackageSerial { get; set; }
        public long? AlterSerial { get; set; }

        public virtual QualityItemDelivery? ItemDeliver { get; set; }
    }
}
