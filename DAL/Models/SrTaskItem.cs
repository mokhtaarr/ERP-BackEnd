using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrTaskItem
    {
        public int TskItemId { get; set; }
        public int? TaskId { get; set; }
        public int? ItemCardId { get; set; }
        public string? HowUse { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
        public virtual SrTask? Task { get; set; }
    }
}
