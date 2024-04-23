using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsCustomerCategory
    {
        public MsCustomerCategory()
        {
            MsCustomers = new HashSet<MsCustomer>();
        }

        public int CustomerCatId { get; set; }
        public string CatCode { get; set; } = null!;
        public string? CatDescA { get; set; }
        public string? CatDescE { get; set; }
        public int? ParentCustomerCatId { get; set; }
        public int? CustomerCatParent { get; set; }
        public int? CustomerCatLevel { get; set; }
        public string? Remarks { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsTaxExempted { get; set; }
        public int? CreditPeriod { get; set; }
        /// <summary>
        /// 1 day, 2 month, 3 year
        /// </summary>
        public byte? PeriodType { get; set; }
        public decimal? CreditLimit { get; set; }
        public decimal? CreditLimitAllowed { get; set; }
        public decimal? DefaultDisc { get; set; }
        public decimal? ReportDiscValu { get; set; }
        public bool? DiscPercentOrVal { get; set; }
        public bool? IsDiscountByItem { get; set; }
        public bool? IsBlocked { get; set; }
        public bool? IsCreditEnabled { get; set; }
        public bool? IsDealer { get; set; }
        public byte? Barcode { get; set; }
        public byte? SalPrice { get; set; }

        public virtual ICollection<MsCustomer> MsCustomers { get; set; }
    }
}
