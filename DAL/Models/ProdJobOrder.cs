using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdJobOrder
    {
        public ProdJobOrder()
        {
            MsSalesInvJobOrderJoins = new HashSet<MsSalesInvJobOrderJoin>();
            ProdJobOrderEquipments = new HashSet<ProdJobOrderEquipment>();
            ProdJobOrderExpenses = new HashSet<ProdJobOrderExpense>();
            ProdJobOrderGoStocks = new HashSet<ProdJobOrderGoStock>();
            ProdJobOrderJobs = new HashSet<ProdJobOrderJob>();
            ProdJobOrderMaterials = new HashSet<ProdJobOrderMaterial>();
            ProdJobOrderProducts = new HashSet<ProdJobOrderProduct>();
            ProdJobOrderPurchaseInvoices = new HashSet<ProdJobOrderPurchaseInvoice>();
            ProdJobOrderScraps = new HashSet<ProdJobOrderScrap>();
            ProdJobOrderServices = new HashSet<ProdJobOrderService>();
            ProdJobOrderTasks = new HashSet<ProdJobOrderTask>();
            ProdJobOrderWorkFlows = new HashSet<ProdJobOrderWorkFlow>();
        }

        public int JobOrderId { get; set; }
        public int? JorderTypeId { get; set; }
        public int? TermId { get; set; }
        public int? BookId { get; set; }
        public int? StoreId { get; set; }
        public int? ItemCardId { get; set; }
        public int? ItemAtrribBatchId { get; set; }
        public int? AccountId { get; set; }
        public int? InDirectExpensesAccountId { get; set; }
        public int? CostCenterId { get; set; }
        public int? CostCenterId2 { get; set; }
        public int? PurInvId { get; set; }
        public int? Aid { get; set; }
        public int? CustomerId { get; set; }
        public int? ClientId { get; set; }
        public int? DepartMentId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public int? CurrencyId { get; set; }
        public int? TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public DateTime? TrDate { get; set; }
        public byte? OrderSource { get; set; }
        public byte? OrderType { get; set; }
        public byte? Priority { get; set; }
        public byte? OrderStatus { get; set; }
        public bool? Installation { get; set; }
        public string? RefOrder { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string? Remarks { get; set; }
        public decimal? ProducedQty { get; set; }
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
        public decimal? DiscPercent { get; set; }
        public decimal? DiscAmount { get; set; }
        public decimal? TotalMaterialCostEstimate { get; set; }
        public decimal? TotalGoStockCostEstimate { get; set; }
        public decimal? TotalScrapCostEstimate { get; set; }
        public decimal? TotalProductCostEstimate { get; set; }
        public decimal? TotalEquipCostEstimate { get; set; }
        public decimal? TotalJobsCostEstimate { get; set; }
        public decimal? TotalExpensCostEstimate { get; set; }
        public bool? IsDeliveredGoStock { get; set; }
        public bool? IsDeliveredProducts { get; set; }
        public bool? IsDeliveredScrap { get; set; }
        public bool? IsDeliveredMaterial { get; set; }
        public bool? IsPaid { get; set; }
        public int? PaidDocId { get; set; }
        public decimal? NotPaid { get; set; }
        public decimal? TotalProducedMeter { get; set; }
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? SerReqId { get; set; }
        public int? MaintainTypeId { get; set; }
        public int? ShiftId { get; set; }
        public bool? IsService { get; set; }
        /// <summary>
        /// 1 Fattening, 2 Feeding
        /// </summary>
        public byte? FatteningType { get; set; }

        public virtual ICollection<MsSalesInvJobOrderJoin> MsSalesInvJobOrderJoins { get; set; }
        public virtual ICollection<ProdJobOrderEquipment> ProdJobOrderEquipments { get; set; }
        public virtual ICollection<ProdJobOrderExpense> ProdJobOrderExpenses { get; set; }
        public virtual ICollection<ProdJobOrderGoStock> ProdJobOrderGoStocks { get; set; }
        public virtual ICollection<ProdJobOrderJob> ProdJobOrderJobs { get; set; }
        public virtual ICollection<ProdJobOrderMaterial> ProdJobOrderMaterials { get; set; }
        public virtual ICollection<ProdJobOrderProduct> ProdJobOrderProducts { get; set; }
        public virtual ICollection<ProdJobOrderPurchaseInvoice> ProdJobOrderPurchaseInvoices { get; set; }
        public virtual ICollection<ProdJobOrderScrap> ProdJobOrderScraps { get; set; }
        public virtual ICollection<ProdJobOrderService> ProdJobOrderServices { get; set; }
        public virtual ICollection<ProdJobOrderTask> ProdJobOrderTasks { get; set; }
        public virtual ICollection<ProdJobOrderWorkFlow> ProdJobOrderWorkFlows { get; set; }
    }
}
