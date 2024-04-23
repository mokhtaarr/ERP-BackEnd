using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class MsItemcardDto
    {

        public int ItemCardId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemDescA { get; set; }
        public string? ItemDescE { get; set; }
        public string? ImgDesc1 { get; set; }
        public string? ImgDesc2 { get; set; }
        public IFormFile Image { get; set; }

    }
}
