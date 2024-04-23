using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjPerspectiveJoin
    {
        public int ProjPerspectiveJoinId { get; set; }
        public int? ProjectId { get; set; }
        public Guid Fsid { get; set; }
        public int? BuildPerspectiveId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? AttachPath { get; set; }
        public byte[]? Fdata { get; set; }

        public virtual CodBuildPerspective? BuildPerspective { get; set; }
        public virtual ProjProject? Project { get; set; }
    }
}
