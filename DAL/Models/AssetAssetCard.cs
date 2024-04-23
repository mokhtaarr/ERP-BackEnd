using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class AssetAssetCard
    {
        public AssetAssetCard()
        {
            AssetAssetContacts = new HashSet<AssetAssetContact>();
            CalAssetAccounts = new HashSet<CalAssetAccount>();
        }

        public int AssetId { get; set; }
        public int? AssetCatId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? CostCenterId3 { get; set; }
        public int? DepartMentId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrentEmpId { get; set; }
        public string? AssetCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public bool? NoDepreciation { get; set; }
        public byte? Status { get; set; }
        public DateTime? PurchDate { get; set; }
        public string? PurchDoc { get; set; }
        public string? VendorDesc { get; set; }
        public string? SerialNo { get; set; }
        public string? WarrantyTerms { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public string? WarrantyNo { get; set; }
        public DateTime? InsuranceExpiry { get; set; }
        public string? ResponsiblePerson { get; set; }
        public decimal? MarketPrice { get; set; }
        public byte? Barcode { get; set; }
        public decimal? PurchPrice { get; set; }
        public DateTime? LastDeprDate { get; set; }
        public DateTime? DeprStartDate { get; set; }
        public decimal? DeprInstallmentVal { get; set; }
        public int? InstallMentCount { get; set; }
        public int? RemainInstallments { get; set; }
        public byte? DeprMethod { get; set; }
        public decimal? ProductivPeriod { get; set; }
        public decimal? CurrentBookValue { get; set; }
        public decimal? JunkValue { get; set; }
        public bool? IsProduction { get; set; }
        public int? EquipId { get; set; }
        public string? CarLicenseNo { get; set; }
        public DateTime? CarLicenseIssueDate { get; set; }
        public string? CarLicenseIssuePlace { get; set; }
        public DateTime? CarLicenseExpiryDate { get; set; }
        public DateTime? DtReg { get; set; }
        public DateTime? DtRegRenew { get; set; }
        public string? Address { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Remarks { get; set; }
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
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? TaxRefNo { get; set; }
        /// <summary>
        /// Business  tax Reg Required,Person   NationalID not required,Foreigner  Name and ID  required
        /// </summary>
        public string? EtaxCustType { get; set; }

        public virtual AssetAssetCategory? AssetCat { get; set; }
        public virtual ICollection<AssetAssetContact> AssetAssetContacts { get; set; }
        public virtual ICollection<CalAssetAccount> CalAssetAccounts { get; set; }
    }
}
