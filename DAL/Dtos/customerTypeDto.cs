using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class customerTypeDto
    {
        public int? CustomerTypeId { get; set; }
        public string? CustomerTypeCode { get; set; }
        public string? CustomerTypeDescA { get; set; }
        public string? CustomerTypeDescE { get; set; }
        public int? CustomerTypeParent { get; set; }
        public int? CustomerTypeLevel { get; set; }
        public byte? CustomerTypeLevelType { get; set; }

        public string? Name_CustomerTypeParent { get; set; }
        public string? NameEn_CustomerTypeParent { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string? Remarks { get; set; }

    }
}
