using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrVehicleItemCard
    {
        public int VehclItemPart { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemCardIdIsVehicl { get; set; }
        public string? Description { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
    }
}
