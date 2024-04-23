using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdItemAttributesBatchesDetail
    {
        public int ItemAtrributBatchValuesId { get; set; }
        public int ItemAtrribBatchId { get; set; }
        public int? AttribValuId { get; set; }
        public int? AttributId { get; set; }
        public string? AttribValueDesc { get; set; }

        public virtual ProdItemAttributesBatche ItemAtrribBatch { get; set; } = null!;
    }
}
