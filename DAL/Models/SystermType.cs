using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SystermType
    {
       
        public int TermTypId { get; set; }
        public byte? TermType { get; set; }
        public string? TermTypeNameAr { get; set; }
        public string? TermTypeNameEn { get; set; }

    }
}
