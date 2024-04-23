using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrFlateRate
    {
        public int FlatRateId { get; set; }
        public int? BrandId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemCategoryId { get; set; }
        public decimal? HourCostRate { get; set; }
        public decimal? HourPrice { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
