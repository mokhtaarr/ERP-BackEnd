using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdItemAttributsJoin
    {
        public int ProdItemAtrribId { get; set; }
        public int? ItemCardId { get; set; }
        public int? AttributId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsMandatory { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ProdItemAttribute? Attribut { get; set; }
        public virtual MsItemCard? ItemCard { get; set; }
    }
}
