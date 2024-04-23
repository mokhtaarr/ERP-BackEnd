using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProjTenderPlanDistributionDetail
    {
        public int TenderPlanJoinId { get; set; }
        public int? TenderPlanDistId { get; set; }
        public int? TenderPlanDetailId { get; set; }
        public int? TenderDetailId { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public DateTime? EstimateDeliverDate { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public string? ItemCardCode { get; set; }
        public string? ItemCardDesc { get; set; }
        public string? ItemCardDescE { get; set; }

        public virtual ProjTenderPlanDistribution? TenderPlanDist { get; set; }
    }
}
