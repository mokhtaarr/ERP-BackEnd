using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjRealItem
    {
        public int ProjectRealItemId { get; set; }
        public int? ProjectId { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        public string? AttributeCode { get; set; }
        public string? AttributeName { get; set; }
        public decimal? SuggestPrice { get; set; }
        public decimal? RealCost { get; set; }

        public virtual ProjProject? Project { get; set; }
    }
}
