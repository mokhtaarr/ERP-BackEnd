using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwVendorCategory
    {
        public string VendorCode { get; set; } = null!;
        public string? VendorDescA { get; set; }
        public string? VendorDescE { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsBlocked { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? CatCode { get; set; }
        public string? CatDescA { get; set; }
        public string? CatDescE { get; set; }
    }
}
