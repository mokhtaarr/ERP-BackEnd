using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class ProdBasicUnitDto
    {
        public int? BasUnitId { get; set; }
        public string? UnitCode { get; set; }
        public string? UnitNam { get; set; }
        public string? UnitNameE { get; set; }
        public decimal? UnittRate { get; set; }
        public string? Remarks { get; set; }
        public string? AutoDesc { get; set; }
        public string? EtaxUnitCode { get; set; }

    }
}
