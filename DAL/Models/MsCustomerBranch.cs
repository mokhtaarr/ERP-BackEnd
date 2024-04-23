using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCustomerBranch
    {
        public int CustBranchId { get; set; }
        public int? CustomerId { get; set; }
        public string? CustBranchCode { get; set; }
        public string? CustBranchName1 { get; set; }
        public string? CustBranchName2 { get; set; }
        public string? Remarks { get; set; }
        public int? CityId { get; set; }
        public string? Address { get; set; }

        public virtual MsCustomer? Customer { get; set; }
    }
}
