using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CodLandPosJoin
    {
        public int LandPosJoinId { get; set; }
        public int? LandId { get; set; }
        public int? LandPosId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual CodLand? Land { get; set; }
        public virtual CodLandPosition? LandPos { get; set; }
    }
}
