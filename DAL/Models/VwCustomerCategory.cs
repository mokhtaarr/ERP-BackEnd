using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwCustomerCategory
    {
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public bool? IsActive { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? CatCode { get; set; }
        public string? CatDescA { get; set; }
        public string? CatDescE { get; set; }
    }
}
