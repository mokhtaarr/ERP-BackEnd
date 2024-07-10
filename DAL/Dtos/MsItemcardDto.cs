using DAL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class MsItemcardDto
    {

        public int? ItemCardId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? ItemDescE { get; set; }
        public string? ImgDesc1 { get; set; }
        public string? ImgDesc2 { get; set; }
        public string? TaxItemCode { get; set; }
        public int? StorePartId { get; set; }
        public int? ItemCategoryId { get; set; }
        public byte? ItemType { get; set; }
        public decimal? ItemLimit { get; set; }
        public decimal? QtyInBox { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? QtyInNotebook { get; set; }
        public decimal? QtyPartiation { get; set; }
        public decimal? CoastAverage { get; set; }
        public decimal? BeforLastCost { get; set; }
        public decimal? LastCost { get; set; }
        public decimal? LastSalePrice { get; set; }
        public DateTime? LastPurchDate { get; set; }
        public int? WarantyPeriod { get; set; }
        public bool? IsCollection { get; set; }
        public bool? IsAttributeItem { get; set; }
        public bool? IsDimension { get; set; }
        public bool? IsSerialItem { get; set; }
        public string? SerialNoPrefix { get; set; }
        public bool? IsExpir { get; set; }
        public string? AddField1 { get; set; }
        public string? AddField2 { get; set; }
        public string? AddField3 { get; set; }
        public string? AddField4 { get; set; }
        public string? AddField5 { get; set; }
        public string? AddField6 { get; set; }
        public string? AddField7 { get; set; }
        public string? AddField8 { get; set; }
        public string? AddField9 { get; set; }
        public string? AddField10 { get; set; }
        public string? Remarks { get; set; }
        public int? BasUnitId { get; set; }

        public string? UnitCode { get; set; }
        public string? UnitNam { get; set; }
        public string? UnitNameE { get; set; }
        public decimal? UnittRate { get; set; }
        public string? EtaxUnitCode { get; set; }
        public bool? cannotDevide { get; set; }
        public string? Symbol { get; set; }



        public List<msitemUnitList>? list { get; set; }
        public List<msItemCollectionDto>? itemCollections { get; set; }


    }

    public class msitemUnitList
    {

        public string? UnitCode { get; set; }
        public string? UnitNam { get; set; }
        public string? UnitNameE { get; set; }
        public decimal? UnittRate { get; set; }

        public bool? CannotDevide { get; set; }
        public bool? IsDefaultSale { get; set; }
        public bool? IsDefaultPurchas { get; set; }

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
        public string? EtaxUnitCode { get; set; }

    }

    public class msItemCollectionDto
    {
        public int? ItemCardId { get; set; }
        public int? SubItemId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public byte? ItemType { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? QtyBeforRate { get; set; }
        public string? Remarks { get; set; }
        public bool? IsNotBasic { get; set; }
    }

    public class MsItemCardWithImage
    {
        public int ItemCardId { get; set; }
        public string? ImgDesc1 { get; set; }
        public string? ImgDesc2 { get; set; }
        public IFormFile Image { get; set; }
    }
}
