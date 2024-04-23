using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdProductionLine
    {
        public ProdProductionLine()
        {
            ProdProductionLineDetails = new HashSet<ProdProductionLineDetail>();
        }

        public int ProLineId { get; set; }
        public int? ProdLinCode { get; set; }
        public string? ProdLinName1 { get; set; }
        public string? ProdLinName2 { get; set; }
        public string? ProdLinDesc { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public decimal? StandardQty { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<ProdProductionLineDetail> ProdProductionLineDetails { get; set; }
    }
}
