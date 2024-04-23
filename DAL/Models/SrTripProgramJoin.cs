using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrTripProgramJoin
    {
        public int TripProgramJoinId { get; set; }
        public int? TripId { get; set; }
        public int? ProgramId { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Days { get; set; }
        public string? Mtscruze { get; set; }
        /// <summary>
        /// single, double, Trible
        /// </summary>
        public byte? Number { get; set; }

        public virtual SrProgram? Program { get; set; }
        public virtual SrTrip? Trip { get; set; }
    }
}
