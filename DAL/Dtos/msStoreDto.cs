using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class msStoreDto
    {
        public int StoreId { get; set; }
        public string StoreCode { get; set; } = string.Empty;
        public string StoreDescA { get; set; } = string.Empty;
        public string StoreDescE { get; set; } = string.Empty;
        public string Tel { get; set; } = string.Empty;



    }

    public class AddmsStoreDto
    {
        public int? StoreId { get; set; }

        public string StoreCode { get; set; } = string.Empty;
        public string StoreDescA { get; set; } = string.Empty;
        public string StoreDescE { get; set; } = string.Empty;
        public string Tel { get; set; } = string.Empty;



    }
}
