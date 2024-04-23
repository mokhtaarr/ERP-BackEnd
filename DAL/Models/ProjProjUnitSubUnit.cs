using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjProjUnitSubUnit
    {
        public int SubUnitId { get; set; }
        public int ProjUnitId { get; set; }
        public int SubUnittypeId { get; set; }
        public bool? CalcByMeter { get; set; }
        public decimal? MetersCount { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Rate { get; set; }
        public decimal? MeterPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }

        public virtual ProjProjUnit ProjUnit { get; set; } = null!;
        public virtual CodeSubUnitType SubUnittype { get; set; } = null!;
    }
}
