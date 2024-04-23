using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSearchInstallment
    {
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public int Cc { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? ContractTrNo { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? PayStartDate { get; set; }
        public decimal? ActualSalesPrice { get; set; }
        public bool? PaidInCash { get; set; }
        public bool? IsContract { get; set; }
    }
}
