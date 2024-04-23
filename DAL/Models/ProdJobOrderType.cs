using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdJobOrderType
    {
        public int JorderTypeId { get; set; }
        public string? Code { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public int? AccountId { get; set; }
        public int? InDirectExpensesAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        public bool? ItemCostInPrcent { get; set; }
        public bool? ExpensesCostInPercent { get; set; }
        public bool? JobsCostInPercent { get; set; }
        public bool? MachineCostInPercent { get; set; }
        public int? FinishedItemStorePartId { get; set; }
        public int? MaterialItemStorePartId { get; set; }
        public int? GoStockItemStorePartId { get; set; }
        public int? ScrapItemStorePartId { get; set; }
        public int? FinishedItemRecBookId { get; set; }
        public int? MaterialItemDelBookId { get; set; }
        public int? GoStockItemRecBookId { get; set; }
        public int? ScrapItemRecBookId { get; set; }
        public int? FinishedItemRecTermId { get; set; }
        public int? MaterialItemDelTermId { get; set; }
        public int? GoStockItemRecTermId { get; set; }
        public int? ScrapItemRecTermId { get; set; }
        public int? FinishedItemRecJournalBookId { get; set; }
        public int? MaterialItemDelJournalBookId { get; set; }
        public int? GoStockItemRecJournalBookId { get; set; }
        public int? ScrapItemRecJournalBookId { get; set; }
        public int? FinishedItemRecJournalTermId { get; set; }
        public int? MaterialItemDelJournalTermId { get; set; }
        public int? GoStockItemRecJournalTermId { get; set; }
        public int? ScrapItemRecJournalTermId { get; set; }
        /// <summary>
        /// 0 store, 1 customer
        /// </summary>
        public byte? JobOrderMadeFor { get; set; }
        public decimal? IndirectMaterialCostPrcent { get; set; }
        public decimal? IndirectJobsCostPrcent { get; set; }
        public decimal? IndirectMachinesCostPrcent { get; set; }
        public decimal? IndirectCostPrcent { get; set; }
        public string? Remark { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        /// <summary>
        /// 1 food,2 animal
        /// </summary>
        public byte? AnimalOrFood { get; set; }
    }
}
