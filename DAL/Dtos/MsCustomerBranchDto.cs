using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class MsCustomerBranchDto
    {
        public int? CustBranchId { get; set; }
        public int? CustomerId { get; set; }
        public string? CustBranchCode { get; set; }
        public string? CustBranchName1 { get; set; }
        public string? CustBranchName2 { get; set; }
        public string? Remarks { get; set; }
        public string? Address { get; set; }

    }
}
