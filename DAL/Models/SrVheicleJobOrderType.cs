using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrVheicleJobOrderType
    {
        public SrVheicleJobOrderType()
        {
            SrVehicleJobOrders = new HashSet<SrVehicleJobOrder>();
        }

        public int VorderTypeId { get; set; }
        public int? AccountId { get; set; }
        public int? AddAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        public string? VorderTypeCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Remark { get; set; }
        public bool? IsAncodeMandatory { get; set; }
        public bool? GetCustomerFromAn { get; set; }
        public bool? GetVendorFromAn { get; set; }
        public bool? GetItemFromAn { get; set; }
        public bool? IsCustomerMandatory { get; set; }
        public bool? GetCostCenterIdFromAn { get; set; }
        public bool? GetAccountIdFromAn { get; set; }
        public bool? IsDriverMandatory { get; set; }
        public int? BookId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<SrVehicleJobOrder> SrVehicleJobOrders { get; set; }
    }
}
