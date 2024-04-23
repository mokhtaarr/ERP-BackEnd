using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsLotNumberConfiguration
    {
        public int LotNumberConfigId { get; set; }
        public byte? PartsCount { get; set; }
        public string? Part1 { get; set; }
        /// <summary>
        /// 1 fixed,2 manual,3 date
        /// </summary>
        public byte? Part1type { get; set; }
        /// <summary>
        /// 1 day,2 week,3 month,4 year
        /// </summary>
        public byte? Part1DateType { get; set; }
        public string? Part1Label { get; set; }
        public string? Part2 { get; set; }
        public byte? Part2type { get; set; }
        public byte? Part2DateType { get; set; }
        public string? Part2Label { get; set; }
        public string? Part3 { get; set; }
        public byte? Part3type { get; set; }
        public byte? Part3DateType { get; set; }
        public string? Part3Label { get; set; }
        public string? Part4 { get; set; }
        public byte? Part4type { get; set; }
        public byte? Part4DateType { get; set; }
        public string? Part4Label { get; set; }
        public string? Part5 { get; set; }
        public byte? Part5type { get; set; }
        public byte? Part5DateType { get; set; }
        public string? Part5Label { get; set; }
        public string? Part6 { get; set; }
        public byte? Part6type { get; set; }
        public byte? Part6DateType { get; set; }
        public string? Part6Label { get; set; }
        public string? Part7 { get; set; }
        public byte? Part7type { get; set; }
        public byte? Part7DateType { get; set; }
        public string? Part7Label { get; set; }
        public string? Part8 { get; set; }
        public byte? Part8type { get; set; }
        public byte? Part8DateType { get; set; }
        public string? Part8Label { get; set; }
        public string? Part9 { get; set; }
        public byte? Part9type { get; set; }
        public byte? Part9DateType { get; set; }
        public string? Part9Label { get; set; }
        public string? Part10 { get; set; }
        public byte? Part10type { get; set; }
        public byte? Part10DateType { get; set; }
        public string? Part10Label { get; set; }
        public string? LotConfigDescription { get; set; }
        public bool? Disabled { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
