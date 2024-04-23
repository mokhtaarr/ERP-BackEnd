using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdProductionOrderDetail
    {
        public int ProdOrderDetailId { get; set; }
        public int? ProductionOrderId { get; set; }
        public int? RecipeId { get; set; }
        public int? RecipeDetaiId { get; set; }
        public int? BillOfMaterialId { get; set; }
        public int? ProLineId { get; set; }

        public virtual ProdProductionOrder? ProductionOrder { get; set; }
    }
}
