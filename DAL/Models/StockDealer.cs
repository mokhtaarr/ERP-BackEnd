using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class StockDealer
    {
        public int StockDealersId { get; set; }
        public string Code { get; set; } = null!;
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public decimal? BrokerPercent { get; set; }
        public decimal? MarketFixedPercent { get; set; }
        public decimal? MarketOtherPercent { get; set; }
        public string? RemarksA { get; set; }
        public string? RemarksE { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
