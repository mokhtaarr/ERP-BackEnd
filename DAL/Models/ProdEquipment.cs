using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdEquipment
    {
        public ProdEquipment()
        {
            ProdEquipProfiles = new HashSet<ProdEquipProfile>();
        }

        public int EquipId { get; set; }
        public string? EquipCode { get; set; }
        public string? EquipName1 { get; set; }
        public string? EquipName2 { get; set; }
        public string? Jdesc { get; set; }
        public string? Remarks { get; set; }
        public decimal? StandardMonthlyCost { get; set; }
        public byte? StandardHolyDays { get; set; }
        public decimal? StandardDailyCost { get; set; }
        public decimal? StandardDailyWorkHours { get; set; }
        public decimal? StandardHourlyCost { get; set; }
        public int? NumberAvailable { get; set; }
        public decimal? TimeRate { get; set; }
        public int? BasUnitId { get; set; }
        public decimal? QtyPerUnit { get; set; }
        public decimal? IsScale { get; set; }
        public decimal? MaxWeight { get; set; }
        public decimal? MinWeight { get; set; }
        public string? TechnicalSpecs { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? SpeedByHour { get; set; }
        public decimal? StandByTime { get; set; }
        public decimal? MaxWidth { get; set; }
        public decimal? MaxLength { get; set; }
        public decimal? MaxHeight { get; set; }
        public int? MinLaborCount { get; set; }

        public virtual ICollection<ProdEquipProfile> ProdEquipProfiles { get; set; }
    }
}
