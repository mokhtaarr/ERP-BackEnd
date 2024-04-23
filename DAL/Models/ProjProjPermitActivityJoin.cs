using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjPermitActivityJoin
    {
        public int ProjPermitActivityJoinId { get; set; }
        public int? ProjectId { get; set; }
        public int? BuildPermitActivityId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual CodBuildPermitActiv? BuildPermitActivity { get; set; }
        public virtual ProjProject? Project { get; set; }
    }
}
