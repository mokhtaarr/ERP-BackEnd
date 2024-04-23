using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjUnitPerspectiveJoin
    {
        public int ProjUnitPerspectiveJoinId { get; set; }
        public int? ProjUnitId { get; set; }
        public Guid Fsid { get; set; }
        public int? UnitPerspectiveId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? AttachPath { get; set; }
        public byte[]? Fdata { get; set; }

        public virtual ProjProjUnit? ProjUnit { get; set; }
        public virtual CodUnitPerspective? UnitPerspective { get; set; }
    }
}
