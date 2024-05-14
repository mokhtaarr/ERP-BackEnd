using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class AddCustomerCategoryDto
    {
        public int? CustomerCatId { get; set; }
        public string? CatCode { get; set; }
        public string? CatDescA { get; set; }
        public string? CatDescE { get; set; }
        public string? Remarks { get; set; }
        public decimal? DefaultDisc { get; set; }
        public decimal? ReportDiscValu { get; set; }
        public bool? DiscPercentOrVal { get; set; }
        public bool? IsDiscountByItem { get; set; }
        public bool? IsTaxExempted { get; set; }
        public int? CreditPeriod { get; set; }
        public decimal? CreditLimit { get; set; }
        public bool? IsDealer { get; set; }
        public byte? SalPrice { get; set; }


    }
}
