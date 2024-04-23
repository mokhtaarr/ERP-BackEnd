using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAccountClassification
    {
        public long? Code { get; set; }
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public string? ClassLevel { get; set; }
        public long? AccountCatCode { get; set; }
        public string? AccountCatDescA { get; set; }
        public string? AccountCatDescE { get; set; }
        public byte? AccountClassType { get; set; }
    }
}
