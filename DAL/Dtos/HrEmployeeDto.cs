using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class HrEmployeeDto
    {
        public int? EmpId { get; set; }
        public string? EmpCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? DeviceEmpCode { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Idno { get; set; }
        public bool? IsTechnician { get; set; }
        public bool? IsSales { get; set; }
        public bool? IsMoneyCollector { get; set; }
        public DateTime? IdissueDate { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? IdexpiryDate { get; set; }
        public string? Email { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Phone3 { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public int? accountId { get; set; }
        public int? DepartMentId { get; set; }
        public int? StoreId { get; set; }
        public int? JobId { get; set; }
        public string? Remarks { get; set; }
        public bool? Gender { get; set; }
        public string? TaxRefNo { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        public string? Qualification { get; set; }
        public int? AddAccount1 { get; set; }
        public int? AddAccount2 { get; set; }
        public int? AddAccount3 { get; set; }
        public int? AddAccount4 { get; set; }
        public int? AddAccount5 { get; set; }
        public int? AddAccount6 { get; set; }
        public int? AddAccount7 { get; set; }
        public int? AddAccount8 { get; set; }
        public int? AddAccount9 { get; set; }
        public int? AddAccount10 { get; set; }

        public bool? IsPrimaryAccountChangedForm { get; set; }
        public bool? IsAddAccount1ChangedForm { get; set; }
        public bool? IsAddAccount2ChangedForm { get; set; }
        public bool? IsAddAccount3ChangedForm { get; set; }
        public bool? IsAddAccount4ChangedForm { get; set; }
        public bool? IsAddAccount5ChangedForm { get; set; }
        public bool? IsAddAccount6ChangedForm { get; set; }
        public bool? IsAddAccount7ChangedForm { get; set; }
        public bool? IsAddAccount8ChangedForm { get; set; }
        public bool? IsAddAccount9ChangedForm { get; set; }
        public bool? IsAddAccount10ChangedForm { get; set; }

    }
}
