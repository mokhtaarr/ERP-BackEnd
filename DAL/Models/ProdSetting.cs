using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdSetting
    {
        public int ProdSettingId { get; set; }
        public int? BookId { get; set; }
        public int? FinishedProdValAccId { get; set; }
        public int? UndercostOperationAccId { get; set; }
        public int? DirectWorkersAccId { get; set; }
        public int? DirectServiceAccId { get; set; }
        public int? DirectEquipmentAccId { get; set; }
        public int? OtherCostsAccId { get; set; }
        public int? AccompanyproductsAccId { get; set; }
        public int? ScrapAccId { get; set; }
        public int? OutSourceCost { get; set; }
        public int? CostingAdjustmentId { get; set; }
        public byte? StandardCostPriority1 { get; set; }
        public byte? StandardCostPriority2 { get; set; }
        public byte? StandardCostPriority3 { get; set; }
        public decimal? DailyWorkHours { get; set; }
        /// <summary>
        /// 1 production,2 Hr
        /// </summary>
        public bool? EmpDataSource { get; set; }
        public decimal? MonthlyStandardWorkDays { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
