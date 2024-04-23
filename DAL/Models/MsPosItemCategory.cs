using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsPosItemCategory
    {
        public int PosItemCategoryId { get; set; }
        public int? ItemCategoryId { get; set; }
        public bool? UseItemName { get; set; }
        public bool? UseItemImg { get; set; }
        public bool? UseItemCode { get; set; }
        public bool? UseItemBarcode { get; set; }
    }
}
