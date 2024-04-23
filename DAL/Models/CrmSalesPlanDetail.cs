using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class CrmSalesPlanDetail
    {
        public int SalesPlanDetailId { get; set; }
        public int? SalesPlanId { get; set; }
        public int? LeadId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? Mission { get; set; }

        public virtual CrmSalesPlan? SalesPlan { get; set; }
    }
}
