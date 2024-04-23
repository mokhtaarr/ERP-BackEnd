using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsLotNumberExpiry
    {
        public int LotNumberExpiryId { get; set; }
        public int? LotNumberConfigId { get; set; }
        public string? LotNumberExpiry { get; set; }
        public DateTime? ProdDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? Period { get; set; }
        /// <summary>
        /// 1 day, 2 month, 3 year
        /// </summary>
        public byte? PeriodType { get; set; }
        public string? Remark { get; set; }
        public bool? Disabled { get; set; }
        public string? FixedPart { get; set; }
        public string? ManualPart { get; set; }
        public string? ManualPart2 { get; set; }
        public string? ManualPart3 { get; set; }
        public string? ManualPart4 { get; set; }
        public string? ManualPart5 { get; set; }
        public string? ManualPart6 { get; set; }
        public string? Day { get; set; }
        public string? Week { get; set; }
        public string? Month { get; set; }
        public string? Year { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }
        public string? Remarks5 { get; set; }
        public string? Remarks6 { get; set; }
        public string? Remarks7 { get; set; }
    }
}
