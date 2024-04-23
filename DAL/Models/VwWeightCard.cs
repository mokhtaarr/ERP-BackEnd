using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwWeightCard
    {
        public int ScaleCardId { get; set; }
        public int TrNo { get; set; }
        public byte? SourceType { get; set; }
        public int? SourceId { get; set; }
        public string? ManualTrNo { get; set; }
        public bool? InOrOut { get; set; }
        public decimal? WeightQty1 { get; set; }
        public decimal? WeightQty2 { get; set; }
        public decimal? WeightQtyDiff { get; set; }
        public DateTime? Weight1Date { get; set; }
        public DateTime? Weight2Date { get; set; }
        public DateTime? Weight1Time { get; set; }
        public DateTime? Weight2Time { get; set; }
        public DateTime? TrDate { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerDescA { get; set; }
        public string? EmpCode { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? DriverCode { get; set; }
        public string? DriverName1 { get; set; }
        public string? VehicleCode { get; set; }
        public string? VehicleName1 { get; set; }
        public string? Empcode2 { get; set; }
        public string? Addemp1 { get; set; }
        public string? Addemp2 { get; set; }
        public string? StoreCode { get; set; }
        public string? StoreDescA { get; set; }
        public string? PartCode { get; set; }
        public string? PartDescA { get; set; }
        public string? CityName { get; set; }
        public string? DocTrNo { get; set; }
        public string? RegNo { get; set; }
        public string? BodyNo { get; set; }
        public string? MotorNo { get; set; }
        public string? VehiclRemarks { get; set; }
        public bool? Closed { get; set; }
        public DateTime? CloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public DateTime? UncloseDate { get; set; }
        public int? UnclosedBy { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
    }
}
