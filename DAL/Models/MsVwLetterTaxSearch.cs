using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsVwLetterTaxSearch
    {
        public int? LetterTaxTrNo { get; set; }
        public DateTime? LetterTaxTrDate { get; set; }
        public int? LetterNormalTrNo { get; set; }
        public DateTime? LetterNormalTrDate { get; set; }
        public string? BuyerName { get; set; }
        public string? BuyerId { get; set; }
        public string? MotorSn { get; set; }
        public string? BodySn { get; set; }
        public string? TempDesca { get; set; }
        public decimal? TaxValu { get; set; }
    }
}
