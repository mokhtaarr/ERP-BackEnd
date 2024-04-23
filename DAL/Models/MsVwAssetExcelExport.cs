using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsVwAssetExcelExport
    {
        public string? AssetCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public bool? IsProduction { get; set; }
        public int? RemainInstallments { get; set; }
        public int? InstallMentCount { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Remarks { get; set; }
        public string? CatCode { get; set; }
        public string? CatDescA { get; set; }
    }
}
