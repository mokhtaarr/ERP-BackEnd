using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class MsLetterOfGuaranteeCategoriesDto
    {   
        public int? LetOfGrnteeCatId { get; set; }
        public string Code { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Remarks { get; set; }
    }
}
