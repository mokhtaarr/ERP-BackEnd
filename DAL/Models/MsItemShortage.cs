using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemShortage
    {
        public int ItemShortId { get; set; }
        public int? ItemCardId { get; set; }
        public int? UnitId { get; set; }
        public decimal? RequestedQuantity { get; set; }
        public decimal? UnitRate { get; set; }
        public decimal? RequestedQtyBeforeRate { get; set; }
        public int? InvId { get; set; }
        public DateTime? TrDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
