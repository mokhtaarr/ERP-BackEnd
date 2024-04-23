using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsGaLetterExportDetail
    {
        public int LetExpDetailId { get; set; }
        public int? LetterExportId { get; set; }
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
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }

        public virtual MsGaLetterExport? LetterExport { get; set; }
    }
}
