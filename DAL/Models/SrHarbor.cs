using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrHarbor
    {
        public int HarborId { get; set; }
        public int? CityId { get; set; }
        public string? HarborCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
