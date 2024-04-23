using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CodInstallmentTemp
    {
        public CodInstallmentTemp()
        {
            CodInstallmentTempsDetails = new HashSet<CodInstallmentTempsDetail>();
            ProjProjUnitInstallTemps = new HashSet<ProjProjUnitInstallTemp>();
        }

        public int InstallTempId { get; set; }
        public int Code { get; set; }
        public string? DescA { get; set; }
        public string? DescE { get; set; }
        public int? Aid { get; set; }
        public bool? IsPercent { get; set; }
        public decimal? YearsCount { get; set; }
        public bool? CanEditInstallManual { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public bool? IsRental { get; set; }
        public bool? AutoRenew { get; set; }
        public decimal? AddValue { get; set; }
        public int? EveryPayCount { get; set; }
        public int? AfterPeriod { get; set; }

        public virtual ICollection<CodInstallmentTempsDetail> CodInstallmentTempsDetails { get; set; }
        public virtual ICollection<ProjProjUnitInstallTemp> ProjProjUnitInstallTemps { get; set; }
    }
}
