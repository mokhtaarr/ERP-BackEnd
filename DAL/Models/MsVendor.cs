using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsVendor
    {
        public MsVendor()
        {
            CalVendAccounts = new HashSet<CalVendAccount>();
            MsItemVendors = new HashSet<MsItemVendor>();
            MsVendImgs = new HashSet<MsVendImg>();
            MsVendorBranches = new HashSet<MsVendorBranch>();
            MsVendorContacts = new HashSet<MsVendorContact>();
            MsVendorUsers = new HashSet<MsVendorUser>();
            ProjProjectItemsVendors = new HashSet<ProjProjectItemsVendor>();
        }

        public int VendorId { get; set; }
        public int? VendorCatId { get; set; }
        public int? VendorTypeId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CostCenterId { get; set; }
        public string VendorCode { get; set; } = null!;
        public string? VendorDescA { get; set; }
        public string? VendorDescE { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsTaxExempted { get; set; }
        public byte? CreditPeriodType { get; set; }
        public int? CreditPeriod { get; set; }
        public decimal? CreditLimit { get; set; }
        public string? Tel { get; set; }
        public string? Tel2 { get; set; }
        public string? Tel3 { get; set; }
        public string? Tel4 { get; set; }
        public string? Tel5 { get; set; }
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
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public byte? Barcode { get; set; }
        public bool? ForAdjustOnly { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? CostCenterId1 { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CityId { get; set; }
        public int? EmpId { get; set; }
        public int? StoreId { get; set; }
        public int? TaxesId1 { get; set; }
        public int? TaxesId2 { get; set; }
        public int? TaxesId3 { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsCreditEnabled { get; set; }
        public bool? IsPricIncludTax { get; set; }
        public string? TaxExemptionNo { get; set; }
        public string? TaxRefNo { get; set; }
        public decimal? PrePaidPercent { get; set; }
        public string? PostalCode { get; set; }
        public string? HomePage { get; set; }
        public byte? InvoiceCopies { get; set; }
        public DateTime? DtReg { get; set; }
        public DateTime? DtRegRenew { get; set; }
        public string? Company { get; set; }
        public string? VendJob { get; set; }
        public string? VendId { get; set; }
        /// <summary>
        /// Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required
        /// </summary>
        public string? EtaxCustType { get; set; }
        public byte[]? LastUpdateTime { get; set; }
        public bool? IsServerEntity { get; set; }
        public int? MainServerId { get; set; }
        public decimal? Evaluation { get; set; }

        public virtual MsCurrency? Currency { get; set; }
        public virtual MsVendorCategory? VendorCat { get; set; }
        public virtual MsVendorType? VendorType { get; set; }
        public virtual ICollection<CalVendAccount> CalVendAccounts { get; set; }
        public virtual ICollection<MsItemVendor> MsItemVendors { get; set; }
        public virtual ICollection<MsVendImg> MsVendImgs { get; set; }
        public virtual ICollection<MsVendorBranch> MsVendorBranches { get; set; }
        public virtual ICollection<MsVendorContact> MsVendorContacts { get; set; }
        public virtual ICollection<MsVendorUser> MsVendorUsers { get; set; }
        public virtual ICollection<ProjProjectItemsVendor> ProjProjectItemsVendors { get; set; }
    }
}
