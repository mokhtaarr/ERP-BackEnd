using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjUnitService
    {
        public int ProjUnitServiceId { get; set; }
        public int? ReservId { get; set; }
        public int? UnitServId { get; set; }
        public int? ProjUnitId { get; set; }
        public byte? PeriodType { get; set; }
        public byte? PeriodRepeat { get; set; }
        public decimal? ServiceValue { get; set; }
        public bool? PerUnitOrMeter { get; set; }
        public decimal? MeterCount { get; set; }
        public decimal? TotalServiceValue { get; set; }
        public bool? Installed { get; set; }
        public string? Remarks { get; set; }

        public virtual ProjProjUnit? ProjUnit { get; set; }
        public virtual ProjUnitReservation? Reserv { get; set; }
        public virtual CodUnitService? UnitServ { get; set; }
    }
}
