using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaLetterTempTax
    {
        public int LetterTaxTempId { get; set; }
        public string? TempCode { get; set; }
        public string? TempDesca { get; set; }
        public string? TempDesce { get; set; }
        public decimal? Price { get; set; }
        public decimal? TaxPercent { get; set; }
        public decimal? TaxValu { get; set; }
        public int? Quantity { get; set; }
        public int? QuantityUsed { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
    }
}
