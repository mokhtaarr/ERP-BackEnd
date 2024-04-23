using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CodLandPermitActivJoin
    {
        public int LandPermitActivJoinId { get; set; }
        public int? LandId { get; set; }
        public int? LandPermitActivId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual CodLand? Land { get; set; }
        public virtual CodLandPermtActiv? LandPermitActiv { get; set; }
    }
}
