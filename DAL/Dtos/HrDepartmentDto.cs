using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class HrDepartmentDto
    {
        public int? departMentId { get; set; }
        public string? departCode { get; set; }
        public string? name { get; set; }
        public string? departName2 { get; set; }
        public string? departTask { get; set; }
        public string? remarks { get; set; }
        public int? parentId { get; set; }
    }
}
