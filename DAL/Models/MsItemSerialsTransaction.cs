using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsItemSerialsTransaction
    {
        public int ItemSerialTranId { get; set; }
        public int? ItemSerialId { get; set; }
        public string? TableCode { get; set; }
        public int? TableEntityId { get; set; }
        public bool? IsInOrOut { get; set; }
        public int? StorePartId { get; set; }
    }
}
