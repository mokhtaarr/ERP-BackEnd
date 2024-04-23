using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrEmployee
    {
        public HrEmployee()
        {
            CalEmpAccounts = new HashSet<CalEmpAccount>();
            HrEmpSalaryTypes = new HashSet<HrEmpSalaryType>();
            MsCheqBooks = new HashSet<MsCheqBook>();
            ProjProjectItemEmpJoins = new HashSet<ProjProjectItemEmpJoin>();
            SrEmpServicTypes = new HashSet<SrEmpServicType>();
            SrTaskEmps = new HashSet<SrTaskEmp>();
        }

        public int EmpId { get; set; }
        public int? StoreId { get; set; }
        public int? JobId { get; set; }
        public int? DepartMentId { get; set; }
        public int? HrempGroupId { get; set; }
        public int? PeriodTableId { get; set; }
        public int? ShiftId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public string? EmpCode { get; set; }
        public string? DeviceEmpCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Qualification { get; set; }
        public bool? Gender { get; set; }
        /// <summary>
        /// 0 single,1 married,2 married and have kids
        /// </summary>
        public byte? MaritalStatus { get; set; }
        public byte? KidsNo { get; set; }
        public byte? Religion { get; set; }
        public byte? Nationality { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Remarks { get; set; }
        public string? Idno { get; set; }
        public DateTime? IdissueDate { get; set; }
        public DateTime? IdexpiryDate { get; set; }
        public string? PassportNo { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public DateTime? PassportExpiryDate { get; set; }
        public string? Car { get; set; }
        public string? DrivingLicense { get; set; }
        public DateTime? DrivingIssueDate { get; set; }
        public DateTime? DrivingExpiryDate { get; set; }
        public DateTime? DrivingRenewalDate { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Phone3 { get; set; }
        public string? Email { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public byte? AnnualVacs { get; set; }
        public byte? ReservedVacs { get; set; }
        public DateTime? LastVacsUpdate { get; set; }
        public byte? AnnualVacsBalance { get; set; }
        public byte? ReservedVacsBalance { get; set; }
        public byte? MaxVacsBalance { get; set; }
        /// <summary>
        /// true limited, false unlimited
        /// </summary>
        public bool? ContractType { get; set; }
        /// <summary>
        /// true full Time,false Part time
        /// </summary>
        public bool? Attendance { get; set; }
        public DateTime? ContractSrtDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public DateTime? WorkStartDate { get; set; }
        public string? SocialSecurityId { get; set; }
        public string? HealthInsId { get; set; }
        public DateTime? HealthInsEndDate { get; set; }
        public string? Syndicate { get; set; }
        public string? SyndicateId { get; set; }
        public byte? MilitaryService { get; set; }
        public decimal? HourlyCostRate { get; set; }
        public bool? IsTechnician { get; set; }
        public bool? IsSales { get; set; }
        public bool? IsMoneyCollector { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public byte[]? EmpImage { get; set; }
        public bool? IssueSalary { get; set; }
        public bool? DistributeSalary { get; set; }
        public bool? AutosalaryIssue { get; set; }
        public string? BankName { get; set; }
        public string? BankAccNo { get; set; }
        public decimal? DailyCost { get; set; }
        public decimal? HourlyCost { get; set; }
        public decimal? TotalDailyCost { get; set; }
        public decimal? TotalHourlyCost { get; set; }
        public decimal? CommisionPercent { get; set; }
        public decimal? CommisionCollectionPerc { get; set; }
        public bool? IsCommissionAfterDisc { get; set; }
        public string? TaxRefNo { get; set; }
        /// <summary>
        /// Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required
        /// </summary>
        public string? EtaxCustType { get; set; }
        public decimal? Evaluation { get; set; }

        public virtual HrDepartment? DepartMent { get; set; }
        public virtual HrEmpGroup? HrempGroup { get; set; }
        public virtual HrJob? Job { get; set; }
        public virtual HrPeriodsTable? PeriodTable { get; set; }
        public virtual HrShift? Shift { get; set; }
        public virtual ICollection<CalEmpAccount> CalEmpAccounts { get; set; }
        public virtual ICollection<HrEmpSalaryType> HrEmpSalaryTypes { get; set; }
        public virtual ICollection<MsCheqBook> MsCheqBooks { get; set; }
        public virtual ICollection<ProjProjectItemEmpJoin> ProjProjectItemEmpJoins { get; set; }
        public virtual ICollection<SrEmpServicType> SrEmpServicTypes { get; set; }
        public virtual ICollection<SrTaskEmp> SrTaskEmps { get; set; }
    }
}
