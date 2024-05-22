using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class ProdEquipmentDto
    {
        public int? EquipId { get; set; }
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
        public bool? IsScaleBoolean { get; set; }
        public decimal? MaxWeight { get; set; }
        public decimal? MinWeight { get; set; }
    }
}
