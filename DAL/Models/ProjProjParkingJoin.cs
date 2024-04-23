using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjParkingJoin
    {
        public int ProjParkJoinId { get; set; }
        public int? ProjectId { get; set; }
        public int? ParkingId { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }

        public virtual CodParking? Parking { get; set; }
        public virtual ProjProject? Project { get; set; }
    }
}
