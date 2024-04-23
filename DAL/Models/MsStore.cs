using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsStore
    {
        public MsStore()
        {
            CalJurnalEntries = new HashSet<CalJurnalEntry>();
            MsPartitions = new HashSet<MsPartition>();
        }

        public int StoreId { get; set; }
        public int? UserId { get; set; }
        public int? UserGroupId { get; set; }
        public string StoreCode { get; set; } = null!;
        public string? StoreDescA { get; set; }
        public string? StoreDescE { get; set; }
        /// <summary>
        /// true MainBranch , False Sub Branch
        /// </summary>
        public bool? StoreType { get; set; }
        public string? StorePosition { get; set; }
        public string? StoreKeeper { get; set; }
        public string? Tel { get; set; }
        public string? Fax { get; set; }
        public string? Remarks { get; set; }
        public byte? PrintFooterFontSize { get; set; }
        public byte? PrintHeaderFontSize { get; set; }
        public byte? PrintHeaderFontStyle { get; set; }
        public byte? PrintFooterFontStyle { get; set; }
        public int? BoxId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? CityId { get; set; }
        public byte[]? BranchLogo { get; set; }
        public string? PrintHeaderFont { get; set; }
        public string? PrintFooterFont { get; set; }
        public string? PrintHeaderFontColor { get; set; }
        public string? PrintFooterFontColor { get; set; }
        public string? PrintHeader { get; set; }
        public string? PrintFooter { get; set; }
        public string? EtaxCode { get; set; }
        public string? TaxReg { get; set; }
        public string? CommercialName { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? SalesCostAccountId1 { get; set; }
        public int? SalesCostAccountId2 { get; set; }
        public int? SalesAccountId1 { get; set; }
        public int? SalesAccountId2 { get; set; }
        public int? SalesAccountId3 { get; set; }
        public int? SalesAccountId4 { get; set; }
        public int? SalesAccountId5 { get; set; }
        public int? CashOnHandAccountId { get; set; }
        public int? BankAccountId { get; set; }
        public int? PurchAccountId1 { get; set; }
        public int? PurchAccountId2 { get; set; }
        public int? PurchAccountId3 { get; set; }
        public int? PurchAccountId4 { get; set; }
        public int? PurchAccountId5 { get; set; }
        public int? OtherAccountId1 { get; set; }
        public int? OtherAccountId2 { get; set; }
        public int? OtherAccountId3 { get; set; }
        public int? OtherAccountId4 { get; set; }
        public int? OtherAccountId5 { get; set; }
        public int? OtherAccountId6 { get; set; }
        public int? OtherAccountId7 { get; set; }
        public int? OtherAccountId8 { get; set; }
        public int? OtherAccountId9 { get; set; }
        public int? OtherAccountId10 { get; set; }
        public int? OtherAccountId11 { get; set; }
        public int? OtherAccountId12 { get; set; }
        public int? OtherAccountId13 { get; set; }
        public int? OtherAccountId14 { get; set; }

        public virtual MsBoxBank? Box { get; set; }
        public virtual ICollection<CalJurnalEntry> CalJurnalEntries { get; set; }
        public virtual ICollection<MsPartition> MsPartitions { get; set; }
    }
}
