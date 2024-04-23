using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CrmLead
    {
        public CrmLead()
        {
            CrmLeadsMembersJoins = new HashSet<CrmLeadsMembersJoin>();
        }

        public int LeadId { get; set; }
        public int? LeadTypeId { get; set; }
        public int? CityId { get; set; }
        public int? RegionId { get; set; }
        public int? StoreId { get; set; }
        public int? MarketChannelId { get; set; }
        public bool? IsOpportunity { get; set; }
        public bool? IsCustomer { get; set; }
        public int? CustomerId { get; set; }
        public string LeadCode { get; set; } = null!;
        public string? LeadName1 { get; set; }
        public string? LeadName2 { get; set; }
        public int? AssignedToEmpId { get; set; }
        public string? FormerProduct { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTaxExempted { get; set; }
        public int? CreditPeriod { get; set; }
        /// <summary>
        /// 1 day, 2 month, 3 year
        /// </summary>
        public byte? PeriodType { get; set; }
        public decimal? CreditLimit { get; set; }
        public decimal? CreditLimitAllowed { get; set; }
        public string? Nationality { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Email2 { get; set; }
        public string? Email3 { get; set; }
        public string? Email4 { get; set; }
        public string? Address { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Remarks { get; set; }
        public string? Tel2 { get; set; }
        public string? Tel3 { get; set; }
        public string? Tel4 { get; set; }
        public string? Tel5 { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PassPortNo { get; set; }
        public DateTime? PassPortIssueDate { get; set; }
        public DateTime? PassPortExpiryDate { get; set; }
        public string? PassPortIssuePlace { get; set; }
        public bool? InternationalLicense { get; set; }
        public string? CarLicenseNo { get; set; }
        public DateTime? CarLicenseIssueDate { get; set; }
        public string? CarLicenseIssuePlace { get; set; }
        public DateTime? CarLicenseExpiryDate { get; set; }
        public DateTime? DtReg { get; set; }
        public DateTime? DtRegRenew { get; set; }
        public string? Company { get; set; }
        public string? CustJob { get; set; }
        public string? CustId { get; set; }
        public byte? Barcode { get; set; }
        public byte? SalPrice { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public decimal? DefaultDisc { get; set; }
        public decimal? ReportDiscValu { get; set; }
        public bool? DiscPercentOrVal { get; set; }
        public bool? ForAdjustOnly { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? TaxesId1 { get; set; }
        public int? TaxesId2 { get; set; }
        public int? TaxesId3 { get; set; }
        public bool? IsDiscountByItem { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsCreditEnabled { get; set; }
        public bool? IsPricIncludTax { get; set; }
        public string? TaxExemptionNo { get; set; }
        public string? TaxRefNo { get; set; }
        public decimal? PrePaidPercent { get; set; }
        public string? PostalCode { get; set; }
        public string? HomePage { get; set; }
        public byte? InvoiceCopies { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual CrmLeadType? LeadType { get; set; }
        public virtual CrmMarketChannel? MarketChannel { get; set; }
        public virtual ICollection<CrmLeadsMembersJoin> CrmLeadsMembersJoins { get; set; }
    }
}
