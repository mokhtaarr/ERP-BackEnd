using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SysAnalyticalCodeProccess
    {
        public int AnprocessId { get; set; }
        public int? Aid { get; set; }
        public DateTime? TrDate { get; set; }
        public string? Remarks { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }
        public string? Remarks5 { get; set; }
        public string? Remarks6 { get; set; }
        public string? Remarks7 { get; set; }
        public string? Remarks8 { get; set; }
        public string? Remarks9 { get; set; }
        public string? Remarks10 { get; set; }

        public virtual SysAnalyticalCode? AidNavigation { get; set; }
    }
}
