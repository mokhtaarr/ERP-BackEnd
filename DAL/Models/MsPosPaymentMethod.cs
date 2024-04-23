using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPosPaymentMethod
    {
        public int PayMethodId { get; set; }
        public decimal? AddPercent { get; set; }
        public byte[]? MethodImage { get; set; }
        public string? Desc1 { get; set; }
        public string? Desc2 { get; set; }
        public bool? MandatoryFieldData { get; set; }
        public string? UserQuestion { get; set; }
        public int? AccountId1 { get; set; }
        public int? AccountId2 { get; set; }
        public int? AccountId3 { get; set; }
        public int? AccountId4 { get; set; }
        public int? AccountId5 { get; set; }
        public int? AccountId6 { get; set; }
        public int? AccountId7 { get; set; }
        public int? AccountId8 { get; set; }
        public int? AccountId9 { get; set; }
        public int? AccountId10 { get; set; }
    }
}
