using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class MsItemUnitDto
    {
        public int? UnitId { get; set; }
        public int? ItemCardId { get; set; }
        public int? BasUnitId { get; set; }
        public decimal? UnittRate { get; set; }
        public string? UnitCode { get; set; }
        public string? UnitNam { get; set; }
        public string? UnitNameE { get; set; }
        public string? Symbol { get; set; }
        public string? BarCode1 { get; set; }
        public string? BarCode2 { get; set; }
        public string? BarCode3 { get; set; }
        public string? BarCode4 { get; set; }
        public string? BarCode5 { get; set; }
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
        public byte? DefaultBarCode { get; set; }
        public decimal? ManualPurchasePrice { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? BeforLastCost { get; set; }
        public decimal? LastSalePrice { get; set; }
        public decimal? LastCostManual { get; set; }
        public bool? IsDefaultSale { get; set; }
        public bool? IsDefaultPurchas { get; set; }
        public bool? IsBasicUnit { get; set; }
        public bool? IsNotRegular { get; set; }
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
        public decimal? Price6 { get; set; }
        public decimal? Price7 { get; set; }
        public decimal? Price8 { get; set; }
        public decimal? Price9 { get; set; }
        public decimal? Price10 { get; set; }
        public decimal? LeastSalesPrice { get; set; }
        public decimal? LeastProfitMargin { get; set; }
        public decimal? Wheight { get; set; }
        public decimal? X { get; set; }
        public decimal? Y { get; set; }
        public decimal? Z { get; set; }
        public string? EtaxUnitCode { get; set; }
        public bool? IsKarat { get; set; }
        public int? MainServerId { get; set; }
        public decimal? PurchDisc { get; set; }
        public bool? CannotDevide { get; set; }

    }
}
