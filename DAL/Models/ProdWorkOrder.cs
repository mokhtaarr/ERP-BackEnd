using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ProdWorkOrder
    {
        public ProdWorkOrder()
        {
            ProdWorkOrderEquipments = new HashSet<ProdWorkOrderEquipment>();
            ProdWorkOrderExpenses = new HashSet<ProdWorkOrderExpense>();
            ProdWorkOrderItemRecQualityDocs = new HashSet<ProdWorkOrderItemRecQualityDoc>();
            ProdWorkOrderMaterials = new HashSet<ProdWorkOrderMaterial>();
            ProdWorkOrderProdItems = new HashSet<ProdWorkOrderProdItem>();
            ProdWorkOrderServices = new HashSet<ProdWorkOrderService>();
            QualityItemRecPackages = new HashSet<QualityItemRecPackage>();
        }

        public int WorkOrderId { get; set; }
        public int? StoreEmpId { get; set; }
        public int? StoreId { get; set; }
        public int? CurrencyId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? Rate { get; set; }
        public int? TotalPieces { get; set; }
        public string? DocBarCode { get; set; }
        public bool? Executed { get; set; }
        public int? PackageCount { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
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
        public bool? IsPosted { get; set; }
        public string? Postedby { get; set; }
        public DateTime? PostedDate { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        public DateTime? PermPrintedAt { get; set; }
        public bool? IsPos { get; set; }
        public int? ShiftId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<ProdWorkOrderEquipment> ProdWorkOrderEquipments { get; set; }
        public virtual ICollection<ProdWorkOrderExpense> ProdWorkOrderExpenses { get; set; }
        public virtual ICollection<ProdWorkOrderItemRecQualityDoc> ProdWorkOrderItemRecQualityDocs { get; set; }
        public virtual ICollection<ProdWorkOrderMaterial> ProdWorkOrderMaterials { get; set; }
        public virtual ICollection<ProdWorkOrderProdItem> ProdWorkOrderProdItems { get; set; }
        public virtual ICollection<ProdWorkOrderService> ProdWorkOrderServices { get; set; }
        public virtual ICollection<QualityItemRecPackage> QualityItemRecPackages { get; set; }
    }
}
