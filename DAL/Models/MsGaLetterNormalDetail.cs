using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaLetterNormalDetail
    {
        public int LetNormDetailId { get; set; }
        public int? LetterNormId { get; set; }
        public string? BuyerName { get; set; }
        public string? BuyerAddress { get; set; }
        public DateTime? AddDate { get; set; }
        public string? BuyerId { get; set; }
        public bool? IsCurrentBuyer { get; set; }
        public bool? ColSalePrinted { get; set; }
        public bool? ColQutPrinted { get; set; }
        public bool? ColLetterPrinted { get; set; }
        public byte[]? Image { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public int? UserId { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public bool? TaxPrinted { get; set; }
        public string? AddField11 { get; set; }
        public string? AddField21 { get; set; }
        public string? PlateNo { get; set; }
        public string? TaxReg { get; set; }

        public virtual MsGaLetterNormal? LetterNorm { get; set; }
    }
}
