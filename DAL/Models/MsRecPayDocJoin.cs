using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsRecPayDocJoin
    {
        public int InvRecPayId { get; set; }
        public int? PayId { get; set; }
        public int? RectId { get; set; }
        public int? DocId { get; set; }
        public byte? DocType { get; set; }
        public decimal? Paid { get; set; }
        public decimal? NotPaid { get; set; }
    }
}
