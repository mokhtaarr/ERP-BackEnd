using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjInsurance
    {
        public int ProjInsuranceId { get; set; }
        public int? ProjectId { get; set; }
        public int? BuildInsurStatId { get; set; }
        public int? InsurCovTypeId { get; set; }
        public decimal? InsuranceValue { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual CodBuildingInsuranceStatus? BuildInsurStat { get; set; }
        public virtual ProjProject? Project { get; set; }
    }
}
