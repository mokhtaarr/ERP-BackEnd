using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HrMobileSetting
    {
        public int HrMobSetId { get; set; }
        public int? DefPermReqBookId { get; set; }
        public int? DefVacReqBookId { get; set; }
        public int? DefLoanReqBookId { get; set; }
        public int? TermId { get; set; }
    }
}
