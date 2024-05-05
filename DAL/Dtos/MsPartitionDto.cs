using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class MsPartitionDto
    {
        public int storeId { get; set; }
        public string partCode { get; set; } = string.Empty;
        public string partDescA { get; set; } = string.Empty; 
        public string partDescE { get; set; } = string.Empty;
        public string remarks { get; set; } = string.Empty;
    
    }
}
