using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CodAccountClassification
    {
        public int AccountClassId { get; set; }
        public int? ParentAccountClassId { get; set; }
        public long? Code { get; set; }
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public int? Aid { get; set; }
        public byte? AccountClassType { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public int? AccountCatId { get; set; }

        public virtual CodAccountCategory? AccountCat { get; set; }
    }
}
