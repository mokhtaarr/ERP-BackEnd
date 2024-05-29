using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class SysBookDto
    {
        public int? BookId { get; set; }
        public string? PrefixCode { get; set; }
        public string? BookNameAr { get; set; }
        public string? BookNameEn { get; set; }
        public byte? TermType { get; set; }
        public int? UserId { get; set; }
        public int? StoreId { get; set; }
        public bool? AutoSerial { get; set; }
        public bool? SystemIssuedOnly { get; set; }
        public bool? IsDefault { get; set; }
        public int? StartNum { get; set; }
        public int? EndNum { get; set; }

    }
}
