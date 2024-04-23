using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjInsuranceUnit
    {
        public int ProjInsuranceUnitId { get; set; }
        public int? ProjUnitId { get; set; }
        public int? InsurCaseId { get; set; }
        public int? UnitInsurstatId { get; set; }
        public int? InsurCovTypeId { get; set; }
        public decimal? InsuranceValue { get; set; }

        public virtual CodInsuranceCase? InsurCase { get; set; }
        public virtual ProjProjUnit? ProjUnit { get; set; }
        public virtual CodUnitInsuranceStatus? UnitInsurstat { get; set; }
    }
}
