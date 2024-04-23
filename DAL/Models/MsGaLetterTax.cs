using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaLetterTax
    {
        public int LetterTaxId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? LetterNormId { get; set; }
        public int? LetterTaxTempId { get; set; }
        public int? StoreId { get; set; }
        public string? Remarks { get; set; }
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
        public int? ShiftId { get; set; }
    }
}
