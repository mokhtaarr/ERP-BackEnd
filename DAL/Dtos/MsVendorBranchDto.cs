using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class MsVendorBranchDto
    {
        public int? VendBranchId { get; set; }
        public int? VendorId { get; set; }
        public string? VendBranchCode { get; set; }
        public string? VendBranchName1 { get; set; }
        public string? VendBranchName2 { get; set; }
        public string? Remarks { get; set; }
        public string? Address { get; set; }
    }
}
