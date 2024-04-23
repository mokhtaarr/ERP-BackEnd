using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SrReciptionDetail
    {
        public int RecipDetlId { get; set; }
        public int? ReciptionId { get; set; }
        public string? CustRequest { get; set; }
        public string? Remarks { get; set; }
        public int? ComId { get; set; }
        public byte? Serial { get; set; }

        public virtual SrComplaint? Com { get; set; }
        public virtual SrReciption? Reciption { get; set; }
    }
}
