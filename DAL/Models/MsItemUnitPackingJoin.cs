using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemUnitPackingJoin
    {
        public int ItemPackSizeId { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        public int? PackSizeId { get; set; }
        public decimal? QtyInPackage { get; set; }
        public decimal? RecomendedQty { get; set; }
        public decimal? MineQty { get; set; }
        public decimal? MaxQty { get; set; }
        public decimal? MaxWheight { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }

        public virtual CodPackingSize? PackSize { get; set; }
        public virtual MsItemUnit? Unit { get; set; }
    }
}
