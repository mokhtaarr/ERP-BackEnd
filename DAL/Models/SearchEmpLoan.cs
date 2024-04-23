using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SearchEmpLoan
    {
        public string LoanCode { get; set; } = null!;
        public DateTime? TrDate { get; set; }
        public string? ManualTrNo { get; set; }
        public string? Remarks1 { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpName1 { get; set; }
        public string? EmpName2 { get; set; }
        public decimal? LoanValue { get; set; }
        public int? Installments { get; set; }
        public decimal? InstallmentValue { get; set; }
        public decimal? LastInstallmentValue { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Jcode { get; set; }
        public string? Jname1 { get; set; }
        public string? Jname2 { get; set; }
        public string? DepartCode { get; set; }
        public string? DepartName1 { get; set; }
        public string? DepartName2 { get; set; }
        public string? StoreCode { get; set; }
        public string? StoreDescA { get; set; }
        public string? StoreDescE { get; set; }
        public int? StoreId { get; set; }
    }
}
