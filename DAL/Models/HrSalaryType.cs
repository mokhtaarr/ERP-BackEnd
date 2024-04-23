using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrSalaryType
    {
        public HrSalaryType()
        {
            HrEmpSalaryTypes = new HashSet<HrEmpSalaryType>();
            HrEmpsSalaryTemps = new HashSet<HrEmpsSalaryTemp>();
            HrSegments = new HashSet<HrSegment>();
        }

        public int SalaryTypId { get; set; }
        public int? AttendElementId { get; set; }
        public byte? SalaryCalcMethod { get; set; }
        public string? SalaryCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public decimal? SalaryValu { get; set; }
        public byte? UseType { get; set; }
        public byte? AffectType { get; set; }
        public byte? ImplementScale { get; set; }
        public int? ParentRelation { get; set; }
        public decimal? Multiply { get; set; }
        public decimal? Devide { get; set; }
        public byte? Approximation { get; set; }
        public decimal? MaximumVal { get; set; }
        public decimal? MinimumVal { get; set; }
        public byte? DebitAccFilter { get; set; }
        public int? DebitAccId { get; set; }
        public byte? CreditAccFilter { get; set; }
        public int? CreditAccId { get; set; }
        public byte? DebitCostCenterFilter { get; set; }
        public int? DebitCostCenterId { get; set; }
        public byte? CreditCostCenterFilter { get; set; }
        public int? CreditCostCenterId { get; set; }
        public bool? LargerThanZero { get; set; }
        public bool? CanDelet { get; set; }
        public bool? AutoIssue { get; set; }
        public bool? CanEdit { get; set; }
        public bool? Distributable { get; set; }
        public bool? IsBasicsalary { get; set; }
        public byte? Indmnity { get; set; }
        public byte? Taxation { get; set; }
        public byte? SocialSecurity { get; set; }
        public decimal? ElementCount { get; set; }
        public string? ElementCountDesc { get; set; }
        public bool? UseElementOrUnit { get; set; }
        public string? Equation { get; set; }
        public bool? IsAnnualSegment { get; set; }
        public int? AnnualPeriods { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public decimal? Approx { get; set; }
        public bool? ApproxUp { get; set; }
        public bool? IsZeroIfLargerThan { get; set; }
        public decimal? ZeroIfLargerThan { get; set; }
        public decimal? AddField1 { get; set; }
        public decimal? AddField2 { get; set; }

        public virtual ICollection<HrEmpSalaryType> HrEmpSalaryTypes { get; set; }
        public virtual ICollection<HrEmpsSalaryTemp> HrEmpsSalaryTemps { get; set; }
        public virtual ICollection<HrSegment> HrSegments { get; set; }
    }
}
