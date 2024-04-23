using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemVendor
    {
        public int ItemVendorId { get; set; }
        public int? ItemCardId { get; set; }
        public int? VendorId { get; set; }
        public int? UnitId { get; set; }
        public decimal? UnitRate { get; set; }
        public string? Quantity1 { get; set; }
        public string? Price1 { get; set; }
        public string? Quantity2 { get; set; }
        public string? Price2 { get; set; }
        public string? Quantity3 { get; set; }
        public string? Price3 { get; set; }
        public string? Quantity4 { get; set; }
        public string? Price4 { get; set; }
        public string? Quantity5 { get; set; }
        public string? Price5 { get; set; }
        public string? Quantity6 { get; set; }
        public string? Price6 { get; set; }
        public string? Quantity7 { get; set; }
        public string? Price7 { get; set; }
        public string? Quantity8 { get; set; }
        public string? Price8 { get; set; }
        public string? Quantity9 { get; set; }
        public string? Price9 { get; set; }
        public string? Quantity10 { get; set; }
        public string? Price10 { get; set; }
        public bool? IsBasicVendor { get; set; }

        public virtual MsItemCard? ItemCard { get; set; }
        public virtual MsVendor? Vendor { get; set; }
    }
}
