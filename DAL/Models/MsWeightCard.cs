using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsWeightCard
    {
        public MsWeightCard()
        {
            MsWeightcardItems = new HashSet<MsWeightcardItem>();
        }

        public int ScaleCardId { get; set; }
        public int? SourceId { get; set; }
        public byte? SourceType { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public int? EquipId { get; set; }
        public int? DriverId { get; set; }
        public int? EmpId1 { get; set; }
        public int? EmpId2 { get; set; }
        public int? VehicleId { get; set; }
        public int? CityId { get; set; }
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        public string? ManualTrNo { get; set; }
        public DateTime? TrDate { get; set; }
        public decimal? WeightQty1 { get; set; }
        public decimal? WeightQty2 { get; set; }
        public decimal? WheightDiscPercent { get; set; }
        public decimal? WeightQtyDiscount { get; set; }
        public decimal? WeightQtyDiff { get; set; }
        public DateTime? Weight1Date { get; set; }
        public DateTime? Weight1Time { get; set; }
        public DateTime? Weight2Date { get; set; }
        public DateTime? Weight2Time { get; set; }
        public bool? InOrOut { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? ClosingDoc { get; set; }
        public int? ClosingDocId { get; set; }
        public bool? IsPrinted { get; set; }
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
        public int? TermCostCenterId { get; set; }
        public decimal? TermCostCenterValue { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateAt { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? ShiftId { get; set; }

        public virtual ICollection<MsWeightcardItem> MsWeightcardItems { get; set; }
    }
}
