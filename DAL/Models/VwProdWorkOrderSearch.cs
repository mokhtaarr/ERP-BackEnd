using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwProdWorkOrderSearch
    {
        public int TrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public int? StoreId { get; set; }
        public int? TotalPieces { get; set; }
        public bool Executed { get; set; }
        public string? DocTrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public decimal? Rate { get; set; }
        public int? CurrencyId { get; set; }
        public string? CurrencyCode { get; set; }
        public string? CurrencyDescA { get; set; }
        public string? CurrencyDescE { get; set; }
        public bool? DefualtCurrency { get; set; }
        public string? TermCode { get; set; }
        public string? TermName { get; set; }
        public byte? TermType { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public bool IsPos { get; set; }
        public string? DeletedBy { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? ShiftCode { get; set; }
        public string? ShiftsName1 { get; set; }
        public string? ShiftsName2 { get; set; }
        public string? StoreCode { get; set; }
        public string? StoreDescA { get; set; }
        public string? StoreDescE { get; set; }
        public string? DocBarCode { get; set; }
        public int? PackageCount { get; set; }
        public decimal? TotalItemCost { get; set; }
        public decimal? TotalEquipCost { get; set; }
        public decimal? TotalExpensesCost { get; set; }
        public decimal? CustomerCharged { get; set; }
        public decimal? TotalServices { get; set; }
        public decimal? NetExpenses { get; set; }
        public decimal? TotalJpbOrder { get; set; }
        public decimal? TotalScrap { get; set; }
        public decimal? TotalMaterialCostEstimate { get; set; }
        public decimal? TotalGoStockCostEstimate { get; set; }
        public decimal? TotalScrapCostEstimate { get; set; }
        public decimal? TotalProductCostEstimate { get; set; }
        public decimal? TotalEquipCostEstimate { get; set; }
        public decimal? TotalExpensCostEstimate { get; set; }
        public bool? IsDeliveredProducts { get; set; }
        public bool? IsDeliveredScrap { get; set; }
        public bool? IsDeliveredMaterial { get; set; }
        public string? EmpCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
    }
}
