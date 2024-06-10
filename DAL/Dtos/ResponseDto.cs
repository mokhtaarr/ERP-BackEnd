using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class ResponseDto
    {
        public bool? status { get; set; }
        public string? message { get; set; }
        public string? messageEn { get; set; }
        public int? id { get; set; }

    }
}
