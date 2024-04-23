using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjUnitPermitActivityJoin
    {
        public int ProjUnitPermitActivityJoinId { get; set; }
        public int? ProjUnitId { get; set; }
        public int? UnitPermitActivId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual ProjProjUnit? ProjUnit { get; set; }
        public virtual CodUnitPermittedActivity? UnitPermitActiv { get; set; }
    }
}
