using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Ou
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Adderss { get; set; }
        public string? Phone { get; set; }
        public string? Emaia { get; set; }
        public long? Taxnumber { get; set; }
        public byte[]? Img { get; set; }
    }
}
