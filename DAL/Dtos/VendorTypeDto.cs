using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class VendorTypeDto
    {
        public int? VendorTypeId { get; set; }
        public string? VendorTypeCode { get; set; }
        public string? VendorTypeDescA { get; set; }
        public string? VendorTypeDescE { get; set; }
        public int? VendorTypeParent { get; set; }
        public string Name_VendorTypeParent { get; set; } = string.Empty;
        public string NameEn_VendorTypeParent { get; set; } = string.Empty;
        public DateTime? CreatedAt { get; set; }

        public int? VendorTypeLevel { get; set; }
        public byte? VendorTypeLevelType { get; set; }
        public string? Remarks { get; set; }

    }
}
