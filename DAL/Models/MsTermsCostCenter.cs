using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class MsTermsCostCenter
    {
        public int TermCostCenterId { get; set; }
        public int? TermId { get; set; }
        public int? CostCenterIdDebit { get; set; }
        public bool? CostCenterDebitFixed { get; set; }
        public string? ValuCostCenterDebit { get; set; }
        public int? CostCenterCredit { get; set; }
        public bool? CostCenterCreditFixed { get; set; }
        public string? ValuCostCenterCredit { get; set; }
        public int? CostCenterIdDisc { get; set; }
        public bool? CostCenterDiscIsFixed { get; set; }
        public string? ValuCostCenterDisc { get; set; }
        public int? CostCenterIdCash { get; set; }
        public bool? CostCenterCashIsFixed { get; set; }
        public string? ValuCostCenterCash { get; set; }
        public int? CostCenterIdTax { get; set; }
        public bool? CostCenterTaxIsFixed { get; set; }
        public string? ValuCostCenterTax { get; set; }
        public bool? CenterDiscDebitOrCredit { get; set; }
        public bool? CenterCashDebitOrCredit { get; set; }
        public bool? CenterTaxDebitOrCredit { get; set; }
        public int? AddCostCenterId1 { get; set; }
        public bool? AddCostCenter1IsFixed { get; set; }
        public string? ValuAddCostCenter1 { get; set; }
        public int? AddCostCenterId2 { get; set; }
        public bool? AddCostCenterIsFixed2 { get; set; }
        public string? ValuAddCostCenter2 { get; set; }
        public int? AddCostCenterId3 { get; set; }
        public bool? AddCostCenterIsFixed3 { get; set; }
        public string? ValuAddCostCenter3 { get; set; }
        public int? AddCostCenterId4 { get; set; }
        public bool? AddCostCenterIsFixed4 { get; set; }
        public string? ValuAddCostCenter4 { get; set; }
        public int? AddCostCenterId5 { get; set; }
        public bool? AddCostCenterIsFixed5 { get; set; }
        public string? ValuAddCostCenter5 { get; set; }
        public bool? AddCenter1DebitOrCredit { get; set; }
        public bool? AddCenter2DebitOrCredit { get; set; }
        public bool? AddCenter3DebitOrCredit { get; set; }
        public bool? AddCenter4DebitOrCredit { get; set; }
        public bool? AddCenter5DebitOrCredit { get; set; }

        public virtual MsTerm? Term { get; set; }
    }
}
