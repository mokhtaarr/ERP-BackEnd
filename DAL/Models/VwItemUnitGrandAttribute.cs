using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class VwItemUnitGrandAttribute
    {
        public int UnitId { get; set; }
        public int? ItemCardId { get; set; }
        public int? BasUnitId { get; set; }
        public decimal? ItemUnitRate { get; set; }
        public string? BarCode1 { get; set; }
        public string? BarCode2 { get; set; }
        public string? BarCode3 { get; set; }
        public string? BarCode4 { get; set; }
        public string? BarCode5 { get; set; }
        public bool? IsDefaultSale { get; set; }
        public bool? IsDefaultPurchas { get; set; }
        public decimal? Price1 { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Price2 { get; set; }
        public decimal? Quantity2 { get; set; }
        public decimal? Price3 { get; set; }
        public decimal? Quantity3 { get; set; }
        public decimal? Price4 { get; set; }
        public decimal? Quantity4 { get; set; }
        public decimal? Price5 { get; set; }
        public decimal? Quantity5 { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? ItemDescE { get; set; }
        public decimal? CoastAverage { get; set; }
        public string? UnitCode { get; set; }
        public string? UnitNam { get; set; }
        public string? UnitNameE { get; set; }
        public decimal? BasicUnitRate { get; set; }
        public string? Symbol { get; set; }
        public int? ParentUnit { get; set; }
        public int ItemAtrribBatchId { get; set; }
        public string? ItemBatchCode { get; set; }
        public string? ItemBatchName1 { get; set; }
        public string? ItemBatchName2 { get; set; }
        public int? StoreId { get; set; }
        public int? StorePartId { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? BeforLastCost { get; set; }
        public string? BarCode6 { get; set; }
        public string? BarCode7 { get; set; }
        public string? BarCode8 { get; set; }
        public string? BarCode9 { get; set; }
        public string? BarCode10 { get; set; }
        public string? BarCode11 { get; set; }
        public string? BarCode12 { get; set; }
        public string? BarCode13 { get; set; }
        public string? BarCode14 { get; set; }
        public string? BarCode15 { get; set; }
        public int? UnitMainServerId { get; set; }
        public int? ItemMainServerId { get; set; }
        public bool? CannotDevide { get; set; }
    }
}
