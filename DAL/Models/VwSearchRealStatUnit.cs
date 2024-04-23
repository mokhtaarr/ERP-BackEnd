using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwSearchRealStatUnit
    {
        public string? Code { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public int? FloorNumber { get; set; }
        public int? RoomCount { get; set; }
        public decimal? UnitArea { get; set; }
        public decimal? UnitMeterPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public bool? Sold { get; set; }
        public bool? Reserved { get; set; }
        public string? ContractDocNo { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? ReserveDate { get; set; }
        public bool? Rented { get; set; }
        public string? RentDocNo { get; set; }
        public int? ResourceId { get; set; }
        public byte? ResourceType { get; set; }
        public int? ResourceAccountId { get; set; }
        public int? HelpAccId { get; set; }
        public string? HelpAccType { get; set; }
        public string? AccountDescription { get; set; }
        public decimal? ShareValue { get; set; }
        public decimal? SharePercent { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public int Cc { get; set; }
    }
}
