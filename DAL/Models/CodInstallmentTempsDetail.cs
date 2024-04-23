using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CodInstallmentTempsDetail
    {
        public int InstallTempDetailId { get; set; }
        public int? InstallTempId { get; set; }
        public int? PayTypeId { get; set; }
        public int? PayCount { get; set; }
        public int? PayRepeat { get; set; }
        public int? YearOrder { get; set; }
        public int? MonthOrder { get; set; }
        public decimal? PayValue { get; set; }
        public decimal? PayPercent { get; set; }
        public decimal? TotalValue { get; set; }
        public int? MonthOfInstall { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual CodInstallmentTemp? InstallTemp { get; set; }
    }
}
