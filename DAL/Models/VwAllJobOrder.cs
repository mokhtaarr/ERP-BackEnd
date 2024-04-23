using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwAllJobOrder
    {
        public int JobOrderId { get; set; }
        public int? TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public byte? OrderSource { get; set; }
        public int? DepartMentId { get; set; }
        public byte? OrderType { get; set; }
        public byte? Priority { get; set; }
        public byte? OrderStatus { get; set; }
        public bool? Installation { get; set; }
        public string? Remarks { get; set; }
        public decimal? TotalItemCost { get; set; }
        public decimal? TotalTasksCose { get; set; }
        public decimal? TotalJobsCost { get; set; }
        public decimal? TotalEquipCost { get; set; }
        public decimal? TotalExpensesCost { get; set; }
        public decimal? CustomerCharged { get; set; }
        public decimal? NetExpenses { get; set; }
        public decimal? TotalPurchInvCost { get; set; }
        public decimal? TotalServices { get; set; }
        public decimal? TotalJpbOrder { get; set; }
        public decimal? TotalProductsPrice { get; set; }
        public decimal? TotalGoStock { get; set; }
        public decimal? TotalScrap { get; set; }
        public decimal? InstallationPrice { get; set; }
        public int? CustomerId { get; set; }
        public int? ClientId { get; set; }
        public string CustomerCode { get; set; } = null!;
        public string? CustomerDescA { get; set; }
        public string? CustomerDescE { get; set; }
        public string? Tel { get; set; }
        public string? Email { get; set; }
        public string? Fax { get; set; }
        public string? Address { get; set; }
        public string? Address1 { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public int? BookId { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? StoreId { get; set; }
    }
}
