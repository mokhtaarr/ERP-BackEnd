using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjOccupTypeJoin
    {
        public int ProjOccupTypeJoinId { get; set; }
        public int? ProjectId { get; set; }
        public int? BuildOccupTypeId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual CodBuildOccupType? BuildOccupType { get; set; }
        public virtual ProjProject? Project { get; set; }
    }
}
