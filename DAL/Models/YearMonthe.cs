using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class YearMonthe
    {
        public int YearMonthId { get; set; }
        public int? FinancialYearsId { get; set; }
        public string? MontnName { get; set; }
        public int? MonthDayes { get; set; }
        public bool? IsActual { get; set; }
        public bool? IsNonActual { get; set; }
        public string? CustomField { get; set; }
    }
}
